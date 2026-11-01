using System;
﻿using System.IO;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.Content.Frostbite;

namespace RimeLib.Cmd.Commands.BundleBuilding
{
    [CommandDescription("Adds a new resource to this bundle or replaces an existing one.")]
    public class AddResourceCommand : Command
    {
        [CommandArgument(Description = "The name of the resource.")]
        public string? Name { get; set; }

        [CommandArgument(Description = "The resource type.")]
        public ResourceType Type { get; set; }

        [CommandArgument(Description = "The path to the file containing the resource data.")]
        public FileInfo? FilePath { get; set; }

        // A MeshSet keeps its relocation-table length here; without it the engine relocates nothing.
        [CommandArgument(Description = "Optional 16-byte resource metadata as 32 hex characters.", Optional = true)]
        public string? Meta { get; set; }

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            if (!FilePath!.Exists)
            {
                p_Writer.WriteLine("The specified file could not be found.");
                return false;
            }

            byte[]? s_Meta = null;

            if (!string.IsNullOrWhiteSpace(Meta))
            {
                var s_Hex = Meta.Trim();

                if (s_Hex.Length != 32)
                {
                    p_Writer.WriteLine($"meta must be 32 hex characters (16 bytes), got {s_Hex.Length}.");
                    return false;
                }

                try
                {
                    s_Meta = Convert.FromHexString(s_Hex);
                }
                catch (FormatException)
                {
                    p_Writer.WriteLine("meta is not valid hex.");
                    return false;
                }
            }

            ((BundleBuildingContext) p_Context).AddResource(Name!, Type, FilePath, s_Meta);

            return true;
        }
    }
}
