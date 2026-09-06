using System.IO;
using System.Linq;
using Newtonsoft.Json;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib;
using RimeLib.Havok;

namespace RimeLib.Cmd.Commands.Game
{
    /// <summary>
    /// Writes the collision shapes in a HavokPhysicsData resource as JSON.
    ///
    /// The counterpart to building collision: without this the game's own collision can be shipped
    /// but not edited, because nothing can say what is already there.
    /// </summary>
    [CommandDescription("Dumps the collision shapes in a HavokPhysicsData resource as JSON.")]
    public class DumpCollisionShapesCommand : Command
    {
        [CommandArgument(Description = "The physics resource, e.g. levels/mp_001/mp_001_physics")]
        public string? Name { get; set; }

        [CommandArgument(Description = "The output .json file")]
        public FileInfo? Destination { get; set; }

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            if (string.IsNullOrWhiteSpace(Name) || Destination is null)
            {
                p_Writer.WriteLine("Usage: dump_collision_shapes <resource> <destination.json>");
                return false;
            }

            var s_Mounter = ((GameContext)p_Context).GetMounter();

            if (!s_Mounter.TryGetResource(Name!, out var s_Resource) || s_Resource.FirstVariant == null)
            {
                p_Writer.WriteLine($"Could not find resource ({Name}).");
                return false;
            }

            var s_Converter = EngineInterfaceRegistry.Create<IHavokConverter>(s_Mounter.GetEngineType());
            var s_Shapes = s_Converter.GetShapes(s_Resource.FirstVariant, s_Mounter).ToList();
            var s_Wrapper = s_Converter.GetWrapper(s_Resource.FirstVariant, s_Mounter);

            File.WriteAllText(Destination.FullName, JsonConvert.SerializeObject(new
            {
                Resource = Name,
                Wrapper = new
                {
                    s_Wrapper.PartCount,
                    s_Wrapper.Scale,
                    s_Wrapper.MaterialCountUsed,
                    s_Wrapper.HighestMaterialIndex,
                    PartTranslations = s_Wrapper.PartTranslations.Select(t => new[] { t.X, t.Y, t.Z }),
                    s_Wrapper.LocalAabbs,
                    s_Wrapper.MaterialIndices,
                    s_Wrapper.MaterialFlagsAndIndices
                },
                Shapes = s_Shapes.Select(s => new
                {
                    s.Kind,
                    s.Offset,
                    s.PlacementOffset,
                    s.Radius,
                    s.CylinderRadius,
                    Centre = new[] { s.Centre.X, s.Centre.Y, s.Centre.Z },
                    // Three COLUMNS, the way Havok stores a rotation. Identity for an unrotated
                    // placement, which is what 46,941 of BF3's 68,436 placements are.
                    Rotation = new[]
                    {
                        new[] { s.Placement.Column0.X, s.Placement.Column0.Y, s.Placement.Column0.Z },
                        new[] { s.Placement.Column1.X, s.Placement.Column1.Y, s.Placement.Column1.Z },
                        new[] { s.Placement.Column2.X, s.Placement.Column2.Y, s.Placement.Column2.Z }
                    },
                    HalfExtents = new[] { s.HalfExtents.X, s.HalfExtents.Y, s.HalfExtents.Z },
                    VertexA = new[] { s.VertexA.X, s.VertexA.Y, s.VertexA.Z },
                    VertexB = new[] { s.VertexB.X, s.VertexB.Y, s.VertexB.Z },
                    Vertices = s.Vertices.Select(v => new[] { v.X, v.Y, v.Z }),
                    s.Indices,
                    Planes = s.Planes.Select(v => new[] { v.X, v.Y, v.Z, v.W })
                })
            }));

            // Placements, not distinct shapes: BF3 instances a shape behind several wrappers --
            // BigRadioTower places 26 boxes 69 times -- and reporting the shapes would undercount
            // the geometry by two thirds on exactly the resources that need editing most.
            p_Writer.WriteLine($"{s_Shapes.Count} placement(s) of " +
                               $"{s_Shapes.Select(s => s.Offset).Distinct().Count()} distinct shape(s) (" +
                               string.Join(", ", s_Shapes.GroupBy(s => s.Kind)
                                                         .OrderByDescending(g => g.Count())
                                                         .Select(g => $"{g.Count()} {g.Key}")) +
                               $") written to {Destination.FullName}.");

            return true;
        }
    }
}
