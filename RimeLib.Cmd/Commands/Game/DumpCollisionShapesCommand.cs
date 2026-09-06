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

            File.WriteAllText(Destination.FullName, JsonConvert.SerializeObject(new
            {
                Resource = Name,
                Shapes = s_Shapes.Select(s => new
                {
                    s.Kind,
                    s.Offset,
                    s.Radius,
                    Centre = new[] { s.Centre.X, s.Centre.Y, s.Centre.Z },
                    HalfExtents = new[] { s.HalfExtents.X, s.HalfExtents.Y, s.HalfExtents.Z },
                    Vertices = s.Vertices.Select(v => new[] { v.X, v.Y, v.Z }),
                    Planes = s.Planes.Select(v => new[] { v.X, v.Y, v.Z, v.W })
                })
            }));

            p_Writer.WriteLine($"{s_Shapes.Count} shape(s) " +
                               $"({s_Shapes.Count(s => s.Kind == "box")} box, " +
                               $"{s_Shapes.Count(s => s.Kind == "convex")} convex) " +
                               $"written to {Destination.FullName}.");

            return true;
        }
    }
}
