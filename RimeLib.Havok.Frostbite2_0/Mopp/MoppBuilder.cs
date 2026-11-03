using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace RimeLib.Havok.Frostbite2_0.Mopp;

/// <summary>A primitive a MOPP finds: its shape key and its bounds.</summary>
public readonly record struct MoppPrimitive(uint Key, Vector3 Min, Vector3 Max);

/// <summary>
/// Builds a MOPP over primitives: a tree of splits, halving each set along its widest axis, with
/// a rescale into a smaller cell where a set fits one, and each primitive's terminal behind cuts
/// to its bounds. What it builds is what <see cref="MoppQuery"/> runs, so a query finds every
/// primitive it overlaps; it is not the cost-optimised tree Havok's compiler builds.
/// </summary>
public static class MoppBuilder
{
    private const int c_Bits = 24;
    private const int c_TopShift = 16;
    private const int c_MaxShift = 16;

    /// <summary>The offset and scale into the 24-bit space, as hkpMoppCode stores them, and the code.</summary>
    public static (Vector4 Offset, List<MoppInstruction> Code) Build(IReadOnlyList<MoppPrimitive> p_Primitives)
    {
        if (p_Primitives.Count == 0)
            throw new ArgumentException("A MOPP over no primitives.", nameof(p_Primitives));

        var s_Min = p_Primitives.Select(p_P => p_P.Min).Aggregate(Vector3.Min);
        var s_Max = p_Primitives.Select(p_P => p_P.Max).Aggregate(Vector3.Max);
        var s_Extent = MathF.Max(MathF.Max(s_Max.X - s_Min.X, s_Max.Y - s_Min.Y), MathF.Max(s_Max.Z - s_Min.Z, 1e-3f));
        // A margin of a hundredth on each side keeps every primitive inside the space after rounding.
        var s_Margin = s_Extent * 0.01f;
        var s_Origin = s_Min - new Vector3(s_Margin);
        var s_Scale = ((1 << c_Bits) - 1) / (s_Extent + 2 * s_Margin);

        var s_Boxes = p_Primitives.Select(p_P => (p_P.Key, Box: ToBox(p_P, s_Origin, s_Scale))).ToList();
        var s_Code = new List<MoppInstruction>();
        Emit(s_Boxes, [0, 0, 0], 0, s_Code);
        return (new Vector4(s_Origin, s_Scale), s_Code);
    }

    /// <summary>The integer box a query or a primitive of these bounds is in the space.</summary>
    public static MoppBox ToBox(MoppPrimitive p_Primitive, Vector3 p_Origin, float p_Scale)
    {
        int Quantize(float p_Value, float p_Origin, bool p_Up)
        {
            var s_Value = (p_Value - p_Origin) * p_Scale;
            return System.Math.Clamp((int)(p_Up ? MathF.Ceiling(s_Value) : MathF.Floor(s_Value)), 0, (1 << c_Bits) - 1);
        }

        return new MoppBox(
            Quantize(p_Primitive.Min.X, p_Origin.X, false), Quantize(p_Primitive.Min.Y, p_Origin.Y, false), Quantize(p_Primitive.Min.Z, p_Origin.Z, false),
            Quantize(p_Primitive.Max.X, p_Origin.X, true), Quantize(p_Primitive.Max.Y, p_Origin.Y, true), Quantize(p_Primitive.Max.Z, p_Origin.Z, true));
    }

    private static void Emit(List<(uint Key, MoppBox Box)> p_Set, int[] p_Offset, int p_Shift, List<MoppInstruction> p_Code)
    {
        (p_Offset, p_Shift) = Rescale(p_Set, p_Offset, p_Shift, p_Code);

        if (p_Set.Count == 1)
        {
            var (s_Key, s_Box) = p_Set[0];
            for (var s_Axis = 0; s_Axis < 3; ++s_Axis)
                p_Code.Add(new MoppInstruction((byte)((byte)MoppOpcode.DoubleCutX + s_Axis),
                    [(uint)Plane(s_Box.Min(s_Axis), s_Axis, p_Offset, p_Shift), (uint)Plane(s_Box.Max(s_Axis), s_Axis, p_Offset, p_Shift)]));
            p_Code.Add(Terminal(s_Key));
            return;
        }

        // Split the widest axis at the median of the centres.
        var s_Widest = Enumerable.Range(0, 3).OrderByDescending(p_A => p_Set.Max(p_P => p_P.Box.Max(p_A)) - p_Set.Min(p_P => p_P.Box.Min(p_A))).First();
        var s_Sorted = p_Set.OrderBy(p_P => (long)p_P.Box.Min(s_Widest) + p_P.Box.Max(s_Widest)).ToList();
        var s_Left = s_Sorted.Take(s_Sorted.Count / 2).ToList();
        var s_Right = s_Sorted.Skip(s_Sorted.Count / 2).ToList();

        var s_First = (uint)s_Left.Max(p_P => Plane(p_P.Box.Max(s_Widest), s_Widest, p_Offset, p_Shift));
        var s_Second = (uint)s_Right.Min(p_P => Plane(p_P.Box.Min(s_Widest), s_Widest, p_Offset, p_Shift));

        var s_LeftCode = new List<MoppInstruction>();
        Emit(s_Left, p_Offset, p_Shift, s_LeftCode);
        var s_LeftSize = s_LeftCode.Sum(p_I => p_I.Size);

        p_Code.Add(s_LeftSize <= byte.MaxValue
            ? new MoppInstruction((byte)((byte)MoppOpcode.SplitX + s_Widest), [s_First, s_Second, (uint)s_LeftSize])
            : new MoppInstruction((byte)((byte)MoppOpcode.SplitJumpX + s_Widest), [s_First, s_Second, 0, (uint)s_LeftSize]));
        p_Code.AddRange(s_LeftCode);
        Emit(s_Right, p_Offset, p_Shift, p_Code);
    }

    /// <summary>
    /// Moves into the largest sub-cell, up to four halvings at once, that still holds the whole set,
    /// so planes deeper down keep their resolution.
    /// </summary>
    private static (int[] Offset, int Shift) Rescale(List<(uint Key, MoppBox Box)> p_Set, int[] p_Offset, int p_Shift, List<MoppInstruction> p_Code)
    {
        var s_Low = new int[3];
        var s_Extent = 0;
        for (var s_Axis = 0; s_Axis < 3; ++s_Axis)
        {
            s_Low[s_Axis] = p_Set.Min(p_P => Plane(p_P.Box.Min(s_Axis), s_Axis, p_Offset, p_Shift));
            s_Extent = System.Math.Max(s_Extent, p_Set.Max(p_P => Plane(p_P.Box.Max(s_Axis), s_Axis, p_Offset, p_Shift)) - s_Low[s_Axis] + 1);
        }

        var s_Steps = 0;
        while (s_Steps < 4 && p_Shift + s_Steps < c_MaxShift && s_Extent << (s_Steps + 1) <= 256)
            ++s_Steps;

        if (s_Steps == 0)
            return (p_Offset, p_Shift);

        p_Code.Add(new MoppInstruction((byte)s_Steps, [(uint)s_Low[0], (uint)s_Low[1], (uint)s_Low[2]]));
        return ([(p_Offset[0] + s_Low[0]) << s_Steps, (p_Offset[1] + s_Low[1]) << s_Steps, (p_Offset[2] + s_Low[2]) << s_Steps], p_Shift + s_Steps);
    }

    private static int Cell(int p_Value, int p_Axis, int[] p_Offset, int p_Shift) => (p_Value >> (c_TopShift - p_Shift)) - p_Offset[p_Axis];

    /// <summary>
    /// A coordinate in the current cell, rounded down as a query's is, so a query that overlaps a
    /// primitive passes every plane and cut set from the primitive's own bounds.
    /// </summary>
    private static int Plane(int p_Value, int p_Axis, int[] p_Offset, int p_Shift) => System.Math.Clamp(Cell(p_Value, p_Axis, p_Offset, p_Shift), 0, 255);

    private static MoppInstruction Terminal(uint p_Key) => p_Key switch
    {
        < 32 => new MoppInstruction((byte)((byte)MoppOpcode.Term4 + p_Key), []),
        <= 0xFF => new MoppInstruction((byte)MoppOpcode.Term8, [p_Key]),
        <= 0xFFFF => new MoppInstruction((byte)MoppOpcode.Term16, [p_Key]),
        <= 0xFFFFFF => new MoppInstruction((byte)MoppOpcode.Term24, [p_Key]),
        _ => new MoppInstruction((byte)MoppOpcode.Term32, [p_Key]),
    };
}
