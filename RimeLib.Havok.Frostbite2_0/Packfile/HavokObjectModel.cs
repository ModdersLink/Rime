using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using RimeLib.Havok.Frostbite2_0.Mopp;
using RimeLib.Frostbite;
using RimeLib.Havok.Frostbite2_0.Frostbite;
using RimeLib.IO;

namespace RimeLib.Havok.Frostbite2_0.Packfile;

public class HavokObjectModel : IHavokObjectModel
{
    public EngineType[] GetSupportedEngines() => [EngineType.Frostbite2_0];

    public byte[] Rewrite(byte[] p_Resource)
    {
        var s_Physics = new HavokPhysicsData(new RimeReader(new MemoryStream(p_Resource)));
        s_Physics.HavokInstance32 = HkPackfile.Write(HkPackfile.Read(s_Physics.HavokInstance32), 4);
        s_Physics.HavokInstance64 = HkPackfile.Write(HkPackfile.Read(s_Physics.HavokInstance64), 8);

        if (!s_Physics.Serialize(out var s_Data))
            throw new InvalidDataException("The physics resource could not be written.");
        return s_Data;
    }

    public byte[] Rewrite(byte[] p_Resource, IReadOnlyList<hkpCollisionShape> p_Shapes) => HkPackfile.Rewrite(p_Resource, HkPhysicsBuilder.Build(p_Shapes));

    public byte[] Meta(byte[] p_Resource) => HavokResourceCookie.Of(p_Resource).ToArray();

    public IReadOnlyList<string> CheckMopps(byte[] p_Resource, out int p_Trees)
    {
        var s_Physics = new HavokPhysicsData(new RimeReader(new MemoryStream(p_Resource)));
        var s_Root = HkPackfile.Read(s_Physics.HavokInstance32);
        var s_Misses = new List<string>();
        p_Trees = 0;

        foreach (var s_Tree in Trees(s_Root))
        {
            if (s_Tree.Code is not { } s_Code || Primitives(s_Tree.Child) is not { } s_Primitives)
                continue;

            ++p_Trees;
            Check("BF3's", s_Code.Offset, s_Code.Instructions, s_Primitives, s_Misses);
            if (s_Primitives.Count > 0)
            {
                var (s_Offset, s_Built) = MoppBuilder.Build(s_Primitives);
                Check("Rime's", s_Offset, s_Built, s_Primitives, s_Misses);
            }
        }

        return s_Misses;
    }

    /// <summary>
    /// The keys and bounds a MOPP is over that can be bounded: a list's children, a compressed
    /// mesh's big triangles, whose keys are their indices, or an extended mesh's shape subparts' children.
    /// </summary>
    private static List<MoppPrimitive>? Primitives(HkpShape? p_Child)
    {
        switch (p_Child)
        {
            case HkpListShape s_List:
                return s_List.Children
                    .Select((p_Child, p_Index) => (p_Index, Bounds: p_Child.Shape is { } s_Shape ? HkShapeBounds.Of(s_Shape) : null))
                    .Where(p_C => p_C.Bounds != null)
                    .Select(p_C => new MoppPrimitive((uint)p_C.p_Index, p_C.Bounds!.Value.Min, p_C.Bounds.Value.Max))
                    .ToList();

            case HkpCompressedMeshShape s_Mesh:
                return HkShapeBounds.OfBigTriangles(s_Mesh);

            case HkpExtendedMeshShape s_Mesh:
                return HkShapeBounds.OfShapesSubparts(s_Mesh);

            default:
                return null;
        }
    }

    private static void Check(string p_Whose, Vector4 p_Offset, IReadOnlyList<MoppInstruction> p_Code, List<MoppPrimitive> p_Primitives, List<string> p_Misses)
    {
        var s_Query = new MoppQuery(p_Code);
        foreach (var s_Primitive in p_Primitives)
        {
            var s_Box = MoppBuilder.ToBox(s_Primitive, new Vector3(p_Offset.X, p_Offset.Y, p_Offset.Z), p_Offset.W);
            if (!s_Query.Query(s_Box).Contains(s_Primitive.Key))
                p_Misses.Add($"{p_Whose} MOPP does not find key 0x{s_Primitive.Key:X} of {p_Primitives.Count}");
        }
    }

    /// <summary>Every MOPP tree the root's shapes reach.</summary>
    private static IEnumerable<HkpMoppBvTreeShape> Trees(HkObject p_Object, HashSet<HkObject>? p_Seen = null)
    {
        p_Seen ??= new HashSet<HkObject>(ReferenceEqualityComparer.Instance);
        if (!p_Seen.Add(p_Object))
            yield break;

        IEnumerable<HkObject?> s_Children = p_Object switch
        {
            HkRootLevelContainer s_Root => s_Root.NamedVariants.Select(p_V => p_V.Variant),
            HavokPhysicsContainer s_Container => s_Container.Shapes,
            HkpMoppBvTreeShape s_Tree => [s_Tree.Child],
            HkpListShape s_List => s_List.Children.Select(p_C => p_C.Shape),
            HkpConvexWrapperShape s_Wrapper => [s_Wrapper.Child],
            _ => [],
        };

        if (p_Object is HkpMoppBvTreeShape s_Found)
            yield return s_Found;

        foreach (var s_Child in s_Children)
            if (s_Child != null)
                foreach (var s_Tree in Trees(s_Child, p_Seen))
                    yield return s_Tree;
    }
}
