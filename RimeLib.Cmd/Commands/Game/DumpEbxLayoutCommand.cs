using System;
using System.IO;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;

namespace RimeLib.Cmd.Commands.Game
{
    /// <summary>
    /// Writes the TYPE AND FIELD LAYOUT an EBX partition declares, as JSON.
    ///
    /// Some Frostbite2_0 classes are generated as field-less stubs -- TerrainData is one -- and the
    /// reader matches properties by NAME, so every field it does not declare is skipped and the
    /// instance decodes to its base class and nothing more. That is why a level's terrain layers,
    /// and the material table its splat indexes into, read back empty.
    ///
    /// The names, offsets and types are in the file's own descriptor tables. This dumps them, so
    /// the missing properties can be declared from the data rather than guessed at.
    /// </summary>
    [CommandDescription("Dumps an EBX partition's declared type/field layout as JSON.")]
    public class DumpEbxLayoutCommand : Command
    {
        [CommandArgument(Description = "Partition name, e.g. levels/mp_001/terrain/mp001_terrain/mp001_terrain")]
        public string? Name { get; set; }

        [CommandArgument(Description = "The output .json file")]
        public FileInfo? Destination { get; set; }

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            if (string.IsNullOrWhiteSpace(Name) || Destination is null)
            {
                p_Writer.WriteLine("Usage: dump_ebx_layout <partition> <destination.json>");
                return false;
            }

            var s_Mounter = ((GameContext)p_Context).GetMounter();

            if (!s_Mounter.TryGetPartition(Name!, out var s_Partition) || s_Partition.FirstVariant == null)
            {
                p_Writer.WriteLine($"Could not find partition ({Name}).");
                return false;
            }

            // Reflection: this project does not reference the version-specific serialization
            // assembly, the same reason DumpShaderTexturesCommand reaches its shaderdb this way.
            var s_ReaderType = Type.GetType(
                "RimeLib.Serialization.Frostbite2_0.Ebx.EbxReader, RimeLib.Serialization.Frostbite2_0");

            if (s_ReaderType == null)
            {
                p_Writer.WriteLine("Could not resolve the Frostbite2_0 EbxReader.");
                return false;
            }

            using var s_Reader = (IDisposable)Activator.CreateInstance(s_ReaderType)!;
            var s_Parse = s_ReaderType.GetMethod("ParsePartition");
            var s_Dump = s_ReaderType.GetMethod("DumpLayout");

            if (s_Parse == null || s_Dump == null)
            {
                p_Writer.WriteLine("EbxReader is missing ParsePartition or DumpLayout.");
                return false;
            }

            s_Parse.Invoke(s_Reader, new object?[] { Name, s_Partition.FirstVariant });

            var s_Json = (string)s_Dump.Invoke(s_Reader, Array.Empty<object>())!;

            File.WriteAllText(Destination.FullName, s_Json);
            p_Writer.WriteLine($"Layout for {Name} written to {Destination.FullName}");
            return true;
        }
    }
}
