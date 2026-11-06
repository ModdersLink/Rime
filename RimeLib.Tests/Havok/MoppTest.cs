using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using RimeLib.Havok.Frostbite2_0.Mopp;
using Xunit;

namespace RimeLib.Tests.Havok;

public class MoppTest
{
    private static List<MoppPrimitive> Primitives(int p_Count, int p_Seed, float p_Size)
    {
        var s_Random = new Random(p_Seed);
        return Enumerable.Range(0, p_Count).Select(p_I =>
        {
            var s_Min = new Vector3(s_Random.NextSingle(), s_Random.NextSingle(), s_Random.NextSingle()) * 100f - new Vector3(50f);
            var s_Size = new Vector3(s_Random.NextSingle(), s_Random.NextSingle(), s_Random.NextSingle()) * p_Size;
            return new MoppPrimitive((uint)(p_I * 7 + 3), s_Min, s_Min + s_Size);
        }).ToList();
    }

    private static bool Overlap(MoppPrimitive p_A, Vector3 p_Min, Vector3 p_Max) =>
        p_A.Min.X <= p_Max.X && p_A.Max.X >= p_Min.X && p_A.Min.Y <= p_Max.Y && p_A.Max.Y >= p_Min.Y && p_A.Min.Z <= p_Max.Z && p_A.Max.Z >= p_Min.Z;

    [Theory]
    [InlineData(1, 1, 5f)]
    [InlineData(40, 2, 5f)]
    [InlineData(500, 3, 2f)]
    [InlineData(3000, 4, 0.5f)]
    [InlineData(20000, 5, 0.2f)]
    public void FindsEveryPrimitiveAQueryOverlaps(int p_Count, int p_Seed, float p_Size)
    {
        var s_Primitives = Primitives(p_Count, p_Seed, p_Size);
        var (s_Offset, s_Code) = MoppBuilder.Build(s_Primitives);
        var s_Origin = new Vector3(s_Offset.X, s_Offset.Y, s_Offset.Z);
        var s_Random = new Random(p_Seed + 100);

        for (var i = 0; i < 200; ++i)
        {
            var s_Min = new Vector3(s_Random.NextSingle(), s_Random.NextSingle(), s_Random.NextSingle()) * 110f - new Vector3(55f);
            var s_Max = s_Min + new Vector3(s_Random.NextSingle(), s_Random.NextSingle(), s_Random.NextSingle()) * 10f;
            var s_Hits = new MoppQuery(s_Code).Query(MoppBuilder.ToBox(new MoppPrimitive(0, s_Min, s_Max), s_Origin, s_Offset.W));

            foreach (var s_Primitive in s_Primitives.Where(p_P => Overlap(p_P, s_Min, s_Max)))
                Assert.Contains(s_Primitive.Key, s_Hits);
        }
    }

    [Fact]
    public void FindsLittleFarFromThePrimitives()
    {
        var s_Primitives = Primitives(500, 5, 1f);
        var (s_Offset, s_Code) = MoppBuilder.Build(s_Primitives);
        var s_Box = MoppBuilder.ToBox(new MoppPrimitive(0, new Vector3(10f), new Vector3(11f)), new Vector3(s_Offset.X, s_Offset.Y, s_Offset.Z), s_Offset.W);

        var s_Overlapping = s_Primitives.Count(p_P => Overlap(p_P, new Vector3(10f), new Vector3(11f)));
        Assert.True(new MoppQuery(s_Code).Query(s_Box).Count <= s_Overlapping + 2);
    }

    [Fact]
    public void EncodesWhatItDecodes()
    {
        var (_, s_Code) = MoppBuilder.Build(Primitives(300, 6, 2f));
        var s_Bytes = MoppInstruction.Encode(s_Code);

        Assert.Equal(s_Bytes, MoppInstruction.Encode(MoppInstruction.Decode(s_Bytes)));
    }
}
