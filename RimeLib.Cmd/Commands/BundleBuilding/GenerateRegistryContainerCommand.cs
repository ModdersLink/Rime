using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization;
using System;
using System.IO;
using System.Linq;

namespace RimeLib.Cmd.Commands.BundleBuilding
{
    [CommandDescription("Generates a new RegistryContainer by looping through all partitions in the bundle and collecting networked entities, assets, blueprints, and reference objects.")]
    public class GenerateRegistryContainerCommand : Command
    {
        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            var s_BundleContext = (BundleBuildingContext)p_Context;
            var s_SbContext = (SbBuildingContext)s_BundleContext.Parent!;
            var s_Partitions = s_BundleContext.GetPartitions();

            if (s_Partitions.Count == 0)
            {
                p_Writer.WriteLine("No partitions found in the bundle.");
                return true;
            }

            var s_Builder = Require<IRegistryContainerBuilder>(s_SbContext.EngineType, p_Writer);
            if (s_Builder == null)
                return false;

            var s_Converter = EngineInterfaceRegistry.Create<IPartitionConverter>(s_SbContext.EngineType);
            var s_Registry = s_Builder.Create();

            foreach (var s_PartitionEntry in s_Partitions)
            {
                var s_Name = s_PartitionEntry.Key;
                var s_Object = s_PartitionEntry.Value;

                try
                {
                    s_Builder.Add(s_Registry, s_Converter.FromPartitionObject(s_Name, (IObjectVariant)s_Object));
                }
                catch (Exception s_Exception)
                {
                    p_Writer.WriteLine($"Warning: Failed to parse partition '{s_Name}': {s_Exception.Message}");
                }
            }

            s_BundleContext.SetGeneratedRegistry(s_Registry);

            // NOTE: AssetRegistry and EntityRegistry seem to be perfect now.
            // The BlueprintRegistry and ReferenceObjectRegistry are not always matching the original ones, but they probably don't have to.
            // It is very close if you ignore all the WorldPartReferenceObjectDatas and WorldPartDatas.

            p_Writer.WriteLine($"RegistryContainer successfully generated and stored in context.");
            var s_Lists = s_Builder.Read(s_Registry)!;
            p_Writer.WriteLine($"- Entities: {s_Lists.Entities.Count}");
            p_Writer.WriteLine($"- Assets: {s_Lists.Assets.Count}");
            p_Writer.WriteLine($"- Blueprints: {s_Lists.Blueprints.Count}");
            p_Writer.WriteLine($"- ReferenceObjects: {s_Lists.ReferenceObjects.Count}");

            return true;
        }
    }
}
