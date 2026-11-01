using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;

namespace RimeLib.Cmd.Commands.Game
{
    /// <summary>
    /// Every mounted resource of a type, written to a FILE.
    ///
    /// list_resources_of_type prints to the console, and whatever drives the REPL consumes that, so
    /// a tool cannot read the answer back. This is the same enumeration, written where it can be
    /// used -- which is what turns "guess which shaderdb holds this shader" into "look at all of
    /// them".
    /// </summary>
    [CommandDescription("Lists all mounted resources of a given type to a JSON file.")]
    public class ListResourcesOfTypeJsonCommand : Command
    {
        [CommandArgument(Description = "The resource type to list, e.g. ShaderDatabase")]
        public string? Type { get; set; }

        [CommandArgument(Description = "The output .json file")]
        public FileInfo? Destination { get; set; }

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            if (string.IsNullOrWhiteSpace(Type) || Destination == null)
            {
                p_Writer.WriteLine("Usage: list_resources_of_type_json <type> <destination.json>");
                return false;
            }

            var s_Resources = ((GameContext)p_Context).GetMountedResourceVariations();
            var s_Names = new List<string>();

            // A resource's 16-byte meta says things its payload does not -- a MeshSet keeps its
            // relocation-table length there -- so rebuilding one needs to know what the shipped
            // equivalent carries.
            var s_Meta = new Dictionary<string, string>();

            foreach (var s_Resource in s_Resources)
            {
                var s_Variant = s_Resource.Value.FirstVariant;

                if (s_Variant == null || s_Variant.GetResourceType().ToString() != Type)
                    continue;

                s_Names.Add(s_Resource.Key);

                if (s_Variant.TryGetMeta(out var s_Bytes) && s_Bytes.Length > 0)
                    s_Meta[s_Resource.Key] = Convert.ToHexString(s_Bytes);
            }

            File.WriteAllText(Destination.FullName,
                JsonConvert.SerializeObject(new { type = Type, resources = s_Names, meta = s_Meta }));
            p_Writer.WriteLine($"{s_Names.Count} resource(s) of type {Type} written to {Destination.FullName}.");

            return true;
        }
    }
}
