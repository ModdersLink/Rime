using System;
using System.Collections.Generic;
using System.IO;
using RimeLib.IO;
using RimeLib.IO.Conversion;

namespace RimeLib.Havok.Frostbite2_0.Mopp;

/// <summary>The MOPP byte code's commands, by the names and values of Havok's own hkpMoppCommands.</summary>
public enum MoppOpcode : byte
{
    Return = 0x00,
    Scale1 = 0x01, Scale2 = 0x02, Scale3 = 0x03, Scale4 = 0x04,
    Jump8 = 0x05, Jump16 = 0x06, Jump24 = 0x07, Jump32 = 0x08,
    TermReoffset8 = 0x09, TermReoffset16 = 0x0A, TermReoffset32 = 0x0B,
    JumpChunk = 0x0C, DataOffset = 0x0D,
    SplitX = 0x10, SplitY = 0x11, SplitZ = 0x12, SplitYZ = 0x13, SplitYMZ = 0x14, SplitXZ = 0x15, SplitXMZ = 0x16,
    SplitXY = 0x17, SplitXMY = 0x18, SplitXYZ = 0x19, SplitXYMZ = 0x1A, SplitXMYZ = 0x1B, SplitXMYMZ = 0x1C,
    SingleSplitX = 0x20, SingleSplitY = 0x21, SingleSplitZ = 0x22,
    SplitJumpX = 0x23, SplitJumpY = 0x24, SplitJumpZ = 0x25,
    DoubleCutX = 0x26, DoubleCutY = 0x27, DoubleCutZ = 0x28,
    DoubleCut24X = 0x29, DoubleCut24Y = 0x2A, DoubleCut24Z = 0x2B,
    Term4 = 0x30, Term4Last = 0x4F,
    Term8 = 0x50, Term16 = 0x51, Term24 = 0x52, Term32 = 0x53,
    Property8 = 0x60, Property8Last = 0x63, Property16 = 0x64, Property16Last = 0x67, Property32 = 0x68, Property32Last = 0x6B,
    JumpChunk32 = 0x70,

    /// <summary>
    /// Not a command: the builder's uninitialised fill between a chunked MOPP's chunks and after its
    /// code, which no jump reaches. Its one operand is how many bytes of it there are.
    /// </summary>
    Fill = 0xCD,
}

/// <summary>
/// One command of a MOPP and its operands, each of the width the command gives it (1 to 4
/// bytes, big-endian): a split's low and high plane and the jump to its second child, a cut's
/// bounds, a rescale's offsets, a terminal's index.
/// </summary>
public sealed record MoppInstruction(byte Opcode, IReadOnlyList<uint> Operands)
{
    /// <summary>The width of each operand of a command, or none for a command BF3's MOPPs do not use.</summary>
    public static int[]? OperandWidths(byte p_Opcode) => p_Opcode switch
    {
        (byte)MoppOpcode.Return => [],
        >= (byte)MoppOpcode.Scale1 and <= (byte)MoppOpcode.Scale4 => [1, 1, 1],
        (byte)MoppOpcode.Jump8 => [1],
        (byte)MoppOpcode.Jump16 => [2],
        (byte)MoppOpcode.Jump24 => [3],
        (byte)MoppOpcode.TermReoffset8 => [1],
        (byte)MoppOpcode.TermReoffset16 => [2],
        (byte)MoppOpcode.TermReoffset32 => [4],
        >= (byte)MoppOpcode.SplitX and <= (byte)MoppOpcode.SplitXMYMZ => [1, 1, 1],
        >= (byte)MoppOpcode.SingleSplitX and <= (byte)MoppOpcode.SingleSplitZ => [1, 1],
        >= (byte)MoppOpcode.SplitJumpX and <= (byte)MoppOpcode.SplitJumpZ => [1, 1, 2, 2],
        >= (byte)MoppOpcode.DoubleCutX and <= (byte)MoppOpcode.DoubleCutZ => [1, 1],
        >= (byte)MoppOpcode.DoubleCut24X and <= (byte)MoppOpcode.DoubleCut24Z => [3, 3],
        >= (byte)MoppOpcode.Term4 and <= (byte)MoppOpcode.Term4Last => [],
        >= (byte)MoppOpcode.Term8 and <= (byte)MoppOpcode.Term32 => [p_Opcode - (byte)MoppOpcode.Term8 + 1],
        >= (byte)MoppOpcode.Property8 and <= (byte)MoppOpcode.Property8Last => [1],
        >= (byte)MoppOpcode.Property16 and <= (byte)MoppOpcode.Property16Last => [2],
        >= (byte)MoppOpcode.Property32 and <= (byte)MoppOpcode.Property32Last => [4],
        (byte)MoppOpcode.JumpChunk32 => [4],
        _ => null,
    };

    /// <summary>The commands of a MOPP's byte code, in order, with each run of the builder's fill as one <see cref="MoppOpcode.Fill"/>.</summary>
    public static List<MoppInstruction> Decode(IReadOnlyList<byte> p_Code)
    {
        var s_Bytes = new byte[p_Code.Count];
        for (var i = 0; i < s_Bytes.Length; ++i)
            s_Bytes[i] = p_Code[i];

        using var s_Reader = new RimeReader(new MemoryStream(s_Bytes), Endianness.BigEndian);
        var s_Instructions = new List<MoppInstruction>();
        while (s_Reader.Position < s_Reader.Length)
        {
            var s_At = (int)s_Reader.Position;
            if (s_Bytes[s_At] == (byte)MoppOpcode.Fill)
            {
                var s_End = s_At;
                while (s_End < s_Bytes.Length && s_Bytes[s_End] == (byte)MoppOpcode.Fill)
                    ++s_End;
                s_Instructions.Add(new MoppInstruction((byte)MoppOpcode.Fill, [(uint)(s_End - s_At)]));
                s_Reader.Seek(s_End, SeekOrigin.Begin);
                continue;
            }

            var s_Opcode = s_Reader.ReadUByte();
            var s_Widths = OperandWidths(s_Opcode)
                ?? throw new NotSupportedException($"MOPP command 0x{s_Opcode:X2} is not modelled.");
            var s_Operands = new uint[s_Widths.Length];
            for (var i = 0; i < s_Widths.Length; ++i)
                s_Operands[i] = ReadOperand(s_Reader, s_Widths[i]);
            s_Instructions.Add(new MoppInstruction(s_Opcode, s_Operands));
        }

        return s_Instructions;
    }

    /// <summary>The byte code of the commands.</summary>
    public static List<byte> Encode(IEnumerable<MoppInstruction> p_Instructions)
    {
        var s_Stream = new MemoryStream();
        using (var s_Writer = new RimeWriter(s_Stream, Endianness.BigEndian))
        {
            foreach (var s_Instruction in p_Instructions)
            {
                if (s_Instruction.Opcode == (byte)MoppOpcode.Fill)
                {
                    for (var i = 0; i < s_Instruction.Operands[0]; ++i)
                        s_Writer.Write((byte)MoppOpcode.Fill);
                    continue;
                }

                var s_Widths = OperandWidths(s_Instruction.Opcode)
                    ?? throw new NotSupportedException($"MOPP command 0x{s_Instruction.Opcode:X2} is not modelled.");
                if (s_Widths.Length != s_Instruction.Operands.Count)
                    throw new ArgumentException($"MOPP command 0x{s_Instruction.Opcode:X2} takes {s_Widths.Length} operand(s), not {s_Instruction.Operands.Count}.");

                s_Writer.Write(s_Instruction.Opcode);
                for (var i = 0; i < s_Widths.Length; ++i)
                    WriteOperand(s_Writer, s_Widths[i], s_Instruction.Operands[i]);
            }
        }

        return [.. s_Stream.ToArray()];
    }

    /// <summary>The instruction's size in bytes: the command and its operands.</summary>
    public int Size => Opcode == (byte)MoppOpcode.Fill ? (int)Operands[0] : 1 + (OperandWidths(Opcode) is { } s_Widths ? Sum(s_Widths) : 0);

    private static int Sum(int[] p_Values)
    {
        var s_Sum = 0;
        foreach (var s_Value in p_Values)
            s_Sum += s_Value;
        return s_Sum;
    }

    private static uint ReadOperand(RimeReader p_Reader, int p_Width)
    {
        uint s_Value = 0;
        for (var i = 0; i < p_Width; ++i)
            s_Value = (s_Value << 8) | p_Reader.ReadUByte();
        return s_Value;
    }

    private static void WriteOperand(RimeWriter p_Writer, int p_Width, uint p_Value)
    {
        if (p_Width < 4 && p_Value >> (8 * p_Width) != 0)
            throw new ArgumentOutOfRangeException(nameof(p_Value), $"0x{p_Value:X} does not fit {p_Width} byte(s).");

        for (var i = p_Width - 1; i >= 0; --i)
            p_Writer.Write((byte)(p_Value >> (8 * i)));
    }
}
