using System;
using System.Collections.Generic;

namespace RimeLib.Havok.Frostbite2_0.Mopp;

/// <summary>A box in a MOPP's integer space: 24 bits per axis, inclusive.</summary>
public readonly record struct MoppBox(int MinX, int MinY, int MinZ, int MaxX, int MaxY, int MaxZ)
{
    public int Min(int p_Axis) => p_Axis switch { 0 => MinX, 1 => MinY, _ => MinZ };
    public int Max(int p_Axis) => p_Axis switch { 0 => MaxX, 1 => MaxY, _ => MaxZ };
}

/// <summary>
/// Runs a MOPP over a query box and gives the terminals it reaches, as Havok's box query does.
/// The tree works in cells of 256 per axis: a box's coordinate in the current cell is its 24-bit
/// coordinate shifted down to the cell's size, less the cell's offset. A split's first plane
/// bounds what its first child holds from above and its second plane what its second child holds
/// from below; diagonal splits compare sums of coordinates, against the plane times the number of
/// axes less 255 per negated one. A cut bounds what follows it, a rescale moves into a sub-cell
/// of the current one, at twice the resolution per step.
/// </summary>
public sealed class MoppQuery
{
    private const int c_TopShift = 16;

    /// <summary>The axes a split of each direction adds up, with their signs.</summary>
    private static readonly (int X, int Y, int Z)[] s_Directions =
    [
        (1, 0, 0), (0, 1, 0), (0, 0, 1), (0, 1, 1), (0, 1, -1), (1, 0, 1), (1, 0, -1),
        (1, 1, 0), (1, -1, 0), (1, 1, 1), (1, 1, -1), (1, -1, 1), (1, -1, -1),
    ];

    private sealed record State(int[] Offset, int Shift, uint TermOffset);

    private readonly IReadOnlyList<MoppInstruction> m_Code;

    /// <summary>Which instruction starts at each byte of the code, which jumps land on.</summary>
    private readonly Dictionary<int, int> m_Starts = new();

    public MoppQuery(IReadOnlyList<MoppInstruction> p_Code)
    {
        m_Code = p_Code;
        var s_At = 0;
        for (var i = 0; i < p_Code.Count; ++i)
        {
            m_Starts[s_At] = i;
            s_At += p_Code[i].Size;
        }
    }

    public HashSet<uint> Query(MoppBox p_Box)
    {
        var s_Hits = new HashSet<uint>();
        Walk(m_Code, m_Starts, 0, new State([0, 0, 0], 0, 0), p_Box, s_Hits);
        return s_Hits;
    }

    private static void Walk(IReadOnlyList<MoppInstruction> p_Code, Dictionary<int, int> p_Starts, int p_Byte, State p_State, MoppBox p_Box, HashSet<uint> p_Hits)
    {
        var (s_Offset, s_Shift, s_TermOffset) = (p_State.Offset, p_State.Shift, p_State.TermOffset);
        while (true)
        {
            var s_Instruction = p_Code[p_Starts[p_Byte]];
            var s_Next = p_Byte + s_Instruction.Size;
            var s_Op = s_Instruction.Opcode;
            var s_Args = s_Instruction.Operands;

            switch (s_Op)
            {
                case (byte)MoppOpcode.Return:
                    return;

                case >= (byte)MoppOpcode.Scale1 and <= (byte)MoppOpcode.Scale4:
                    s_Offset = [(s_Offset[0] + (int)s_Args[0]) << s_Op, (s_Offset[1] + (int)s_Args[1]) << s_Op, (s_Offset[2] + (int)s_Args[2]) << s_Op];
                    s_Shift += s_Op;
                    p_Byte = s_Next;
                    break;

                case (byte)MoppOpcode.Jump8 or (byte)MoppOpcode.Jump16 or (byte)MoppOpcode.Jump24:
                    p_Byte = s_Next + (int)s_Args[0];
                    break;

                // A chunked MOPP's jump to the chunk at an offset in the code.
                case (byte)MoppOpcode.JumpChunk32:
                    p_Byte = (int)s_Args[0];
                    break;

                case (byte)MoppOpcode.TermReoffset8 or (byte)MoppOpcode.TermReoffset16:
                    s_TermOffset += s_Args[0];
                    p_Byte = s_Next;
                    break;

                case (byte)MoppOpcode.TermReoffset32:
                    s_TermOffset = s_Args[0];
                    p_Byte = s_Next;
                    break;

                case >= (byte)MoppOpcode.SplitX and <= (byte)MoppOpcode.SplitXMYMZ:
                case >= (byte)MoppOpcode.SingleSplitX and <= (byte)MoppOpcode.SplitJumpZ:
                {
                    var (s_Direction, s_First, s_Second, s_Left, s_Right) = s_Op switch
                    {
                        <= (byte)MoppOpcode.SplitXMYMZ => (s_Op - (byte)MoppOpcode.SplitX, s_Args[0], s_Args[1], s_Next, s_Next + (int)s_Args[2]),
                        <= (byte)MoppOpcode.SingleSplitZ => (s_Op - (byte)MoppOpcode.SingleSplitX, s_Args[0], s_Args[0], s_Next, s_Next + (int)s_Args[1]),
                        _ => (s_Op - (byte)MoppOpcode.SplitJumpX, s_Args[0], s_Args[1], s_Next + (int)s_Args[2], s_Next + (int)s_Args[3]),
                    };
                    var (s_Low, s_High, s_Axes, s_Negated) = Project(s_Directions[s_Direction], p_Box, s_Offset, s_Shift);
                    var s_State = new State(s_Offset, s_Shift, s_TermOffset);
                    var s_GoLeft = s_Low <= s_Axes * (int)s_First - 255 * s_Negated;
                    var s_GoRight = s_High >= s_Axes * (int)s_Second - 255 * s_Negated;
                    if (s_GoLeft && s_GoRight)
                        Walk(p_Code, p_Starts, s_Left, s_State, p_Box, p_Hits);
                    if (!s_GoLeft && !s_GoRight)
                        return;
                    p_Byte = s_GoRight ? s_Right : s_Left;
                    break;
                }

                case >= (byte)MoppOpcode.DoubleCutX and <= (byte)MoppOpcode.DoubleCutZ:
                {
                    var s_Axis = s_Op - (byte)MoppOpcode.DoubleCutX;
                    if (Cell(p_Box.Max(s_Axis), s_Axis, s_Offset, s_Shift) < s_Args[0] || Cell(p_Box.Min(s_Axis), s_Axis, s_Offset, s_Shift) > s_Args[1])
                        return;
                    p_Byte = s_Next;
                    break;
                }

                case >= (byte)MoppOpcode.DoubleCut24X and <= (byte)MoppOpcode.DoubleCut24Z:
                {
                    var s_Axis = s_Op - (byte)MoppOpcode.DoubleCut24X;
                    if (p_Box.Max(s_Axis) < s_Args[0] || p_Box.Min(s_Axis) > s_Args[1])
                        return;
                    p_Byte = s_Next;
                    break;
                }

                case >= (byte)MoppOpcode.Term4 and <= (byte)MoppOpcode.Term4Last:
                    p_Hits.Add(s_Op - (uint)MoppOpcode.Term4 + s_TermOffset);
                    return;

                case >= (byte)MoppOpcode.Term8 and <= (byte)MoppOpcode.Term32:
                    p_Hits.Add(s_Args[0] + s_TermOffset);
                    return;

                default:
                    throw new NotSupportedException($"MOPP command 0x{s_Op:X2} is not queried.");
            }
        }
    }

    /// <summary>A 24-bit coordinate in the current cell.</summary>
    private static int Cell(int p_Value, int p_Axis, int[] p_Offset, int p_Shift) => (p_Value >> (c_TopShift - p_Shift)) - p_Offset[p_Axis];

    /// <summary>The box's extent along a split direction, in the current cell, with the direction's axis counts.</summary>
    private static (int Low, int High, int Axes, int Negated) Project((int X, int Y, int Z) p_Direction, MoppBox p_Box, int[] p_Offset, int p_Shift)
    {
        int s_Low = 0, s_High = 0, s_Axes = 0, s_Negated = 0;
        int[] s_Signs = [p_Direction.X, p_Direction.Y, p_Direction.Z];
        for (var s_Axis = 0; s_Axis < 3; ++s_Axis)
        {
            if (s_Signs[s_Axis] == 0)
                continue;

            var s_Min = Cell(p_Box.Min(s_Axis), s_Axis, p_Offset, p_Shift);
            var s_Max = Cell(p_Box.Max(s_Axis), s_Axis, p_Offset, p_Shift);
            ++s_Axes;
            if (s_Signs[s_Axis] > 0)
            {
                s_Low += s_Min;
                s_High += s_Max;
            }
            else
            {
                ++s_Negated;
                s_Low -= s_Max;
                s_High -= s_Min;
            }
        }

        return (s_Low, s_High, s_Axes, s_Negated);
    }
}
