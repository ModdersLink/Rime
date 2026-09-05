using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.Content.Frostbite;
using RimeLib.IO;
using RimeLib.Terrain.Resources;
using RimeLib;

namespace RimeLib.Cmd.Commands.BundleBuilding
{
    /// <summary>
    /// Ships an EDITED terrain: replaces heightfield node samples in a streaming tree and adds the
    /// rebuilt resource to the bundle.
    ///
    /// Until now a terrain could be read and never shipped, so a level authored from a stage could
    /// move every object in it and not raise the ground by a metre. The four raster trees and the
    /// streaming tree that contains them all re-serialise to their shipped bytes exactly (measured
    /// over all 33 of BF3's terrains), which is what makes an edit safe: everything the edit does
    /// not touch comes back identical, so a diff against the original is exactly the edit.
    ///
    /// Samples are UInt16 height values, 133x133 per node including the two-sample border, base64
    /// in the JSON -- the same shape dump_terrain_nodes emits, so a caller edits what it dumped.
    /// </summary>
    [CommandDescription("Replaces heightfield node samples in a terrain streaming tree from JSON ({\"nodes\":[{\"level\":n,\"indexX\":n,\"indexY\":n,\"data\":\"<base64>\"}]}) and adds the rebuilt resource to the bundle.")]
    internal class ReplaceTerrainHeightsCommand : Command
    {
        [CommandArgument(Description = "The streamingtree resource to rebuild, e.g. levels/mp_001/terrain/mp001_terrain/mp001_terrain.streamingtree")]
        public string? Name { get; set; }

        [CommandArgument(Description = "JSON file holding the edited nodes.")]
        public FileInfo? Edits { get; set; }

        [CommandArgument(Description = "Id returned by mount_game.", Optional = true)]
        public int Id { get; set; } = 1;

        [CommandArgument(Optional = true, Description = "Also write the rebuilt resource here, so it can be diffed against the shipped one.")]
        public FileInfo? Save { get; set; }

        private class NodeEdit
        {
            public ushort Level { get; set; }
            public ushort IndexX { get; set; }
            public ushort IndexY { get; set; }
            public string? Data { get; set; }
        }

        private class EditFile
        {
            public List<NodeEdit>? Nodes { get; set; }
        }

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            if (string.IsNullOrWhiteSpace(Name) || Edits is null)
            {
                p_Writer.WriteLine("Usage: replace_terrain_heights <streamingtree-resource> <edits.json> [id]");
                return false;
            }

            // The mounter lives on the BaseContext, two parents up -- same walk every other
            // bundle-building command that needs the game does.
            var s_Building = (BundleBuildingContext)p_Context;
            var s_Sb = (SbBuildingContext?)s_Building.Parent;

            if (s_Sb?.Parent is not BaseContext s_Base)
            {
                p_Writer.WriteLine("Parent context is invalid.");
                return false;
            }

            if (!s_Base.GetMounters().TryGetValue(Id, out var s_Mounter))
            {
                p_Writer.WriteLine($"Id ({Id}) is not valid, ensure you mounted a game first.");
                return false;
            }

            if (!s_Mounter.TryGetResource(Name!, out var s_Resource) || s_Resource.FirstVariant == null)
            {
                p_Writer.WriteLine($"Could not find terrain resource ({Name}).");
                return false;
            }

            EditFile? s_Edits;

            try
            {
                s_Edits = JsonConvert.DeserializeObject<EditFile>(File.ReadAllText(Edits.FullName));
            }
            catch (Exception s_Ex)
            {
                p_Writer.WriteLine("Could not read the edits: " + s_Ex.Message);
                return false;
            }

            if (s_Edits?.Nodes == null || s_Edits.Nodes.Count == 0)
            {
                p_Writer.WriteLine("The edit file names no nodes.");
                return false;
            }

            // Through the interface, resolved for whichever engine is mounted -- RimeLib.Cmd does
            // not reference the Frostbite2_0 assembly, it is found at runtime.
            var s_Terrain = EngineInterfaceRegistry.Create<ITerrainHeightfield>(
                s_Mounter.GetEngineType());

            var s_NodeEdits = new List<TerrainNodeEdit>();

            foreach (var s_Edit in s_Edits.Nodes)
            {
                s_NodeEdits.Add(new TerrainNodeEdit
                {
                    Level = s_Edit.Level,
                    IndexX = s_Edit.IndexX,
                    IndexY = s_Edit.IndexY,
                    Samples = Convert.FromBase64String(s_Edit.Data ?? string.Empty),
                });
            }

            if (!s_Terrain.WriteHeightfield(s_Resource.FirstVariant, s_NodeEdits,
                    out var s_Payload, out var s_Error) || s_Payload == null)
            {
                p_Writer.WriteLine("replace_terrain_heights: " + (s_Error ?? "failed"));
                return false;
            }

            if (Save != null)
                File.WriteAllBytes(Save.FullName, s_Payload);

            s_Resource.FirstVariant.TryGetMeta(out var s_Meta);
            s_Building.AddGeneratedResource(Name!, s_Payload, ResourceType.TerrainStreamingTree,
                s_Meta);

            p_Writer.WriteLine(
                $"replace_terrain_heights: {s_NodeEdits.Count} node(s) replaced, " +
                $"{s_Payload.Length} bytes -> {Name}");

            return true;
        }
    }
}
