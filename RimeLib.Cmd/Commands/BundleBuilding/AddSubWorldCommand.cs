using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.Frostbite;
using RimeLib.Frostbite.Core;
using RimeLib.IO;
using RimeLib.Serialization;
using RimeLib.Serialization.Conversion;

namespace RimeLib.Cmd.Commands.BundleBuilding
{
    /// <summary>
    /// Adds a reference to a sub-world's bundle to a level of this bundle, loaded as a template
    /// level loads one of its own: with that reference's inclusion settings (the game modes it
    /// loads in) and autoload.
    /// </summary>
    [CommandDescription("Adds a sub-world bundle to a level of this bundle, included as a template level includes one of its sub-worlds.")]
    public class AddSubWorldCommand : Command
    {
        [CommandArgument(Description = "The level partition of this bundle, e.g. levels/mp_prison/mp_prison.")]
        public string? Level { get; set; }

        [CommandArgument(Description = "The sub-world's bundle, e.g. Levels/MP_Prison/TeamDeathmatch.")]
        public string? Bundle { get; set; }

        [CommandArgument(Description = "Id returned by mount_game, of the game the template level comes from (this bundle's engine).")]
        public int TemplateId { get; set; }

        [CommandArgument(Description = "The template level, e.g. levels/mp_subway/mp_subway.")]
        public string? TemplateLevel { get; set; }

        [CommandArgument(Description = "The template level's sub-world bundle to include it like, e.g. Levels/MP_Subway/TeamDeathmatch.")]
        public string? TemplateBundle { get; set; }

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            //if (string.IsNullOrWhiteSpace(Level) || string.IsNullOrWhiteSpace(Bundle) || string.IsNullOrWhiteSpace(TemplateLevel) || string.IsNullOrWhiteSpace(TemplateBundle))
            //{
            //    p_Writer.WriteLine("usage: add_sub_world <level> <bundle> <template_id> <template_level> <template_bundle>");
            //    return false;
            //}

            //var s_Bundle = (BundleBuildingContext)p_Context;
            //var s_Sb = (SbBuildingContext)s_Bundle.Parent!;
            //var s_Converter = EngineInterfaceRegistry.Create<IPartitionConverter>(s_Sb.EngineType);
            //var s_LevelName = Level!.ToLowerInvariant();
            //if (!BundlePartitionVariant.All(s_Bundle).TryGetValue(s_LevelName, out var s_LevelVariant)
            //    || s_Converter.FromPartitionObject(s_LevelName, s_LevelVariant) is not { PrimaryInstance: PrefabBlueprint s_World } s_Level)
            //{
            //    p_Writer.WriteLine($"The bundle has no level '{Level}'.");
            //    return false;
            //}

            //if (!((BaseContext)s_Sb.Parent!).GetMounters().TryGetValue(TemplateId, out var s_Game)
            //    || !s_Game.TryGetPartition(TemplateLevel!, out var s_Mounted) || s_Mounted.FirstVariant is not { } s_TemplateVariant)
            //{
            //    p_Writer.WriteLine($"No mounted level '{TemplateLevel}' in game {TemplateId}.");
            //    return false;
            //}

            //var s_Template = s_Converter.FromPartitionObject(TemplateLevel!, s_TemplateVariant);
            //var s_Instances = s_Template.Instances.ToDictionary(p_I => PartitionConversion.InstanceGuid(s_Template.PartitionGuid, p_I.InstanceId));
            //if (s_Template.Instances.OfType<SubWorldReferenceObjectData>().FirstOrDefault(p_R => p_R.BundleName.Equals(TemplateBundle, StringComparison.OrdinalIgnoreCase)) is not { } s_Reference
            //    || s_Instances.GetValueOrDefault(PartitionConversion.InstanceGuid(s_Template.PartitionGuid, s_Reference.InclusionSettings.InstanceId)) is not SubWorldInclusionSettings s_Inclusion)
            //{
            //    p_Writer.WriteLine($"'{TemplateLevel}' includes no sub-world '{TemplateBundle}'.");
            //    return false;
            //}

            //GUID NewGuid(string p_Key) => PartitionConversion.Derived(s_Level.PartitionGuid, $"{Bundle}/{p_Key}");
            //CtrRef<T> Local<T>(DataContainerBase p_Instance) where T : DataContainer => new(s_Level.PartitionGuid, p_Instance.InstanceId);

            //var s_Settings = s_Inclusion.Settings.Select(p_S => (SubWorldInclusionSetting)s_Instances[PartitionConversion.InstanceGuid(s_Template.PartitionGuid, p_S.InstanceId)]).ToList();
            //for (var i = 0; i < s_Settings.Count; ++i)
            //    s_Settings[i].InstanceId = new DataContainerId.Guid(NewGuid($"setting/{i}"));
            //s_Inclusion.InstanceId = new DataContainerId.Guid(NewGuid("settings"));
            //s_Inclusion.Settings = new RefArray<SubWorldInclusionSetting>();
            //s_Inclusion.Settings.AddRange(s_Settings.Select(Local<SubWorldInclusionSetting>));

            //s_Reference.InstanceId = new DataContainerId.Guid(NewGuid("reference"));
            //s_Reference.BundleName = Bundle!;
            //s_Reference.InclusionSettings = Local<SubWorldInclusionSettings>(s_Inclusion);
            //s_Reference.IndexInBlueprint = (ushort)s_World.Objects.Count;
            //s_World.Objects.Add(Local<GameObjectData>(s_Reference));

            //var s_Built = EngineInterfaceRegistry.Create<IEbxTypeLibrary>(s_Sb.EngineType).CreatePartition(s_LevelName, s_Level.PartitionGuid,
            //    PartitionConversion.InstanceGuid(s_Level.PartitionGuid, s_World.InstanceId),
            //    s_Level.Instances.Append(s_Reference).Append(s_Inclusion).Concat(s_Settings).ToList());

            //var s_Stream = new MemoryStream();
            //using (var s_Writer = new RimeWriter(s_Stream))
            //    EngineInterfaceRegistry.Create<IPartitionGenerator>(s_Sb.EngineType).Generate(s_Built, s_Writer);
            //s_Bundle.RemovePartition(s_LevelName);
            //s_Bundle.AddRawPartitionBytes(s_LevelName, s_Stream.ToArray());
            //p_Writer.WriteLine($"'{s_LevelName}' includes '{Bundle}' as '{TemplateLevel}' includes '{TemplateBundle}': {string.Join("; ", s_Settings.Select(p_S => string.Join(",", p_S.EnabledOptions)))}.");
            return true;
        }
    }
}
