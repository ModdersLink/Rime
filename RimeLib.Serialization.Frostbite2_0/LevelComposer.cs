using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using fb;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Conversion;

namespace RimeLib.Serialization.Frostbite2_0;

/// <summary>
/// Frostbite 2 levels: a level is a PrefabBlueprint whose SubWorldReferenceObjectData include its
/// sub-worlds, and a game mode is a SubWorldData whose setups are linked to the map's objects.
/// </summary>
public class LevelComposer : ILevelComposer
{
    public EngineType[] GetSupportedEngines() => new[] { EngineType.Frostbite2_0 };

    public DatabasePartitionBase AddSubWorld(DatabasePartitionBase p_Level, DatabasePartitionBase p_Template, string p_TemplateBundle, string p_Bundle, out string p_Summary)
    {
        if (p_Level.PrimaryInstance is not PrefabBlueprint s_World)
            throw new InvalidDataException($"'{p_Level.Name}' is not a level.");

        var s_Instances = p_Template.Instances.ToDictionary(p_I => PartitionConversion.InstanceGuid(p_Template.PartitionGuid, p_I.InstanceId));
        if (p_Template.Instances.OfType<SubWorldReferenceObjectData>().FirstOrDefault(p_R => p_R.BundleName.Equals(p_TemplateBundle, StringComparison.OrdinalIgnoreCase)) is not { } s_Reference
            || s_Instances.GetValueOrDefault(PartitionConversion.InstanceGuid(p_Template.PartitionGuid, s_Reference.InclusionSettings.InstanceId)) is not SubWorldInclusionSettings s_Inclusion)
        {
            throw new InvalidDataException($"'{p_Template.Name}' includes no sub-world '{p_TemplateBundle}'.");
        }

        GUID NewGuid(string p_Key) => PartitionConversion.Derived(p_Level.PartitionGuid, $"{p_Bundle}/{p_Key}");
        CtrRef<T> Local<T>(DataContainerBase p_Instance) where T : DataContainer => new(p_Level.PartitionGuid, p_Instance.InstanceId);

        var s_Settings = s_Inclusion.Settings.Select(p_S => (SubWorldInclusionSetting)s_Instances[PartitionConversion.InstanceGuid(p_Template.PartitionGuid, p_S.InstanceId)]).ToList();
        for (var i = 0; i < s_Settings.Count; ++i)
            s_Settings[i].InstanceId = new DataContainerId.Guid(NewGuid($"setting/{i}"));
        s_Inclusion.InstanceId = new DataContainerId.Guid(NewGuid("settings"));
        s_Inclusion.Settings = new RefArray<SubWorldInclusionSetting>();
        s_Inclusion.Settings.AddRange(s_Settings.Select(Local<SubWorldInclusionSetting>));

        s_Reference.InstanceId = new DataContainerId.Guid(NewGuid("reference"));
        s_Reference.BundleName = p_Bundle;
        s_Reference.InclusionSettings = Local<SubWorldInclusionSettings>(s_Inclusion);
        s_Reference.IndexInBlueprint = (ushort)s_World.Objects.Count;
        s_World.Objects.Add(Local<GameObjectData>(s_Reference));

        var s_Built = new EbxTypeLibrary().CreatePartition(p_Level.Name, p_Level.PartitionGuid,
            PartitionConversion.InstanceGuid(p_Level.PartitionGuid, s_World.InstanceId),
            p_Level.Instances.Append(s_Reference).Append(s_Inclusion).Concat(s_Settings).ToList());

        p_Summary = string.Join("; ", s_Settings.Select(p_S => string.Join(",", p_S.EnabledOptions)));
        return s_Built;
    }

    public DatabasePartitionBase BuildGameMode(string p_Name, IEngineMounter p_TemplateGame, DatabasePartitionBase p_Template,
        IEngineMounter p_SourceGame, DatabasePartitionBase p_Source, string p_Mode, IReadOnlyList<DatabasePartitionBase> p_Parts,
        IReadOnlyDictionary<int, int> p_Fields, TextWriter p_Log)
    {
        if (p_Template.PrimaryInstance is not SubWorldData s_TemplateWorld)
            throw new InvalidDataException($"'{p_Template.Name}' is not a sub-world.");

        if (SourceLinks(p_Source, p_Mode) is not { } s_SourceLinks)
            throw new InvalidDataException($"'{p_Source.Name}' references no sub-world in bundle '{p_Mode}'.");

        var s_ModePartition = Parse(p_SourceGame, p_Mode.ToLowerInvariant());
        var s_ModeValues = s_ModePartition != null ? InterfaceValues(s_ModePartition) : new Dictionary<int, string>();
        var s_ModeFrames = s_ModePartition != null ? InterfaceFrames(p_SourceGame, s_ModePartition) : new Dictionary<int, LinearTransform>();

        return Build(p_Name, p_TemplateGame, p_Template, s_TemplateWorld, s_SourceLinks, s_ModeValues, s_ModeFrames, p_Parts, p_Fields, p_Log);
    }

    /// <summary>
    /// The template's sub-world holding its setups, each output link of theirs to the linked
    /// objects the source gives that field, and the template interface's values from the source
    /// mode's interface, a transform moved from the frame of the object the source feeds it to
    /// into that of the setup the template feeds it to.
    /// </summary>
    private static DatabasePartitionBase Build(string p_Name, IEngineMounter p_TemplateGame, DatabasePartitionBase p_TemplatePartition, SubWorldData p_Template,
        Dictionary<int, List<CtrRefBase>> p_SourceLinks, Dictionary<int, string> p_ModeValues, Dictionary<int, LinearTransform> p_ModeFrames, IReadOnlyList<DatabasePartitionBase> p_Parts,
        IReadOnlyDictionary<int, int> p_Fields, TextWriter p_Writer)
    {
        var s_PartitionGuid = PartitionConversion.Derived(p_TemplatePartition.PartitionGuid, p_Name);
        GUID NewGuid(string p_Key) => PartitionConversion.Derived(s_PartitionGuid, p_Key);
        CtrRef<T> Local<T>(DataContainerBase p_Instance) where T : DataContainer => new(s_PartitionGuid, p_Instance.InstanceId);
        int SourceField(int p_Field) => p_Fields.GetValueOrDefault(p_Field, p_Field);

        // The setups: what the template's sub-world links from and feeds, other than its interface.
        var s_Descriptor = (CtrRefBase)p_Template.Descriptor;
        var s_SetupRefs = p_Template.LinkConnections.Select(p_L => (CtrRefBase)p_L.Source)
            .Concat(p_Template.PropertyConnections.Select(p_C => (CtrRefBase)p_C.Target))
            .Where(p_R => !SameRef(p_R, s_Descriptor))
            .DistinctBy(Key)
            .ToList();

        var s_Setups = new Dictionary<string, ReferenceObjectData>();
        foreach (var s_Ref in s_SetupRefs)
        {
            if (Find(p_TemplateGame, p_TemplatePartition, s_Ref) is not ReferenceObjectData s_Setup)
                continue;
            s_Setup.InstanceId = new DataContainerId.Guid(NewGuid($"setup/{Key(s_Ref)}"));
            s_Setups[Key(s_Ref)] = s_Setup;
        }

        // Every converted object the source links, by its converted reference.
        var s_PartObjects = p_Parts.SelectMany(p_P => p_P.Instances.Select(p_I => (Key: Key(p_P.PartitionGuid, p_I.InstanceId), Instance: p_I)))
            .ToDictionary(p_O => p_O.Key, p_O => p_O.Instance);

        var s_Links = new List<LinkConnection>();
        var s_Linked = new List<DataContainerBase>();
        foreach (var s_Group in p_Template.LinkConnections.GroupBy(p_L => (Source: Key(p_L.Source), p_L.SourceFieldId, p_L.TargetFieldId)))
        {
            if (!s_Setups.TryGetValue(s_Group.Key.Source, out var s_Setup))
                continue;

            var s_Targets = p_SourceLinks.GetValueOrDefault(SourceField(s_Group.Key.SourceFieldId)) ?? [];
            var s_Found = s_Targets.Select(p_T => s_PartObjects.GetValueOrDefault(Key(p_T.PartitionGuid, new DataContainerId.Guid(PartitionConversion.InstanceGuid(p_T.PartitionGuid, p_T.InstanceId)))))
                .OfType<DataContainerBase>().ToList();
            p_Writer.WriteLine($"LINK {s_Group.Key.SourceFieldId}: {s_Found.Count} of the source's {s_Targets.Count} objects (the template links {s_Group.Count()})");

            foreach (var s_Target in s_Found)
            {
                s_Links.Add(new LinkConnection
                {
                    Source = Local<DataContainer>(s_Setup),
                    Target = new CtrRef<DataContainer>(Part(p_Parts, s_Target).PartitionGuid, s_Target.InstanceId),
                    SourceFieldId = s_Group.Key.SourceFieldId,
                    TargetFieldId = s_Group.Key.TargetFieldId,
                });
                s_Linked.Add(s_Target);
            }
        }

        // The interface: the source mode's value for each field, or a spawn spread from the
        // others for a transform it has none for (a team's fallback spawn).
        var s_TemplateDescriptor = (InterfaceDescriptorData)Find(p_TemplateGame, p_TemplatePartition, s_Descriptor)!;
        s_TemplateDescriptor.InstanceId = new DataContainerId.Guid(NewGuid("interface"));
        var s_Spawns = new Queue<LinearTransform>(Spread(s_Linked.OfType<AlternateSpawnEntityData>().Select(p_S => p_S.Transform).ToList()));
        LinearTransform TemplateFrame(int p_Field) => p_Template.PropertyConnections
            .Where(p_C => SameRef(p_C.Source, s_Descriptor) && p_C.SourceFieldId == p_Field)
            .Select(p_C => s_Setups.GetValueOrDefault(Key(p_C.Target))?.BlueprintTransform)
            .FirstOrDefault(p_T => p_T != null) ?? Identity();
        // A field pair may name the interface field or the setup field it feeds.
        int InterfaceSource(int p_Field) => p_Fields.TryGetValue(p_Field, out var s_Mapped) ? s_Mapped
            : p_Template.PropertyConnections
                .Where(p_C => SameRef(p_C.Source, s_Descriptor) && p_C.SourceFieldId == p_Field && p_Fields.ContainsKey(p_C.TargetFieldId))
                .Select(p_C => (int?)p_Fields[p_C.TargetFieldId]).FirstOrDefault() ?? p_Field;
        foreach (var s_Field in s_TemplateDescriptor.Fields)
        {
            var s_Source = InterfaceSource(s_Field.Id);
            if (p_ModeValues.TryGetValue(s_Source, out var s_Value))
                s_Field.Value = TryParseTransform(s_Value, out var s_Transform)
                    ? Format(ToLocal(ToWorld(s_Transform, p_ModeFrames.GetValueOrDefault(s_Source) ?? Identity()), TemplateFrame(s_Field.Id)))
                    : s_Value;
            else if (s_Field.Value.StartsWith("LinearTransform", StringComparison.Ordinal) && s_Spawns.TryDequeue(out var s_Spawn))
                s_Field.Value = Format(ToLocal(s_Spawn, TemplateFrame(s_Field.Id)));
            else
            {
                p_Writer.WriteLine($"FIELD {s_Field.Id} keeps the template's value '{s_Field.Value}'");
                continue;
            }
            p_Writer.WriteLine($"FIELD {s_Field.Id}: '{s_Field.Value}'");
        }

        CtrRef<DataContainer>? Retarget(CtrRefBase p_Ref) =>
            SameRef(p_Ref, s_Descriptor) ? Local<DataContainer>(s_TemplateDescriptor)
            : s_Setups.TryGetValue(Key(p_Ref), out var s_Setup) ? Local<DataContainer>(s_Setup)
            : null;

        var s_Properties = p_Template.PropertyConnections
            .Select(p_C => (Source: Retarget(p_C.Source), Target: Retarget(p_C.Target), p_C.SourceFieldId, p_C.TargetFieldId))
            .Where(p_C => p_C.Source != null && p_C.Target != null)
            .Select(p_C => new PropertyConnection { Source = p_C.Source!, Target = p_C.Target!, SourceFieldId = p_C.SourceFieldId, TargetFieldId = p_C.TargetFieldId })
            .ToList();
        var s_Events = p_Template.EventConnections
            .Select(p_C => (Connection: p_C, Source: Retarget(p_C.Source), Target: Retarget(p_C.Target)))
            .Where(p_C => p_C.Source != null && p_C.Target != null)
            .Select(p_C => { p_C.Connection.Source = p_C.Source!; p_C.Connection.Target = p_C.Target!; return p_C.Connection; })
            .ToList();

        // A world part reference per partition of linked objects, so the sub-world creates them.
        var s_PartReference = p_Template.Objects.First(p_O => Find(p_TemplateGame, p_TemplatePartition, p_O) is WorldPartReferenceObjectData);
        var s_PartReferences = s_Linked.Select(p_O => Part(p_Parts, p_O)).Distinct().Select(p_P =>
        {
            var s_Reference = (WorldPartReferenceObjectData)Find(p_TemplateGame, Parse(p_TemplateGame, p_TemplatePartition.Name)!, s_PartReference)!;
            s_Reference.InstanceId = new DataContainerId.Guid(NewGuid($"part/{p_P.Name}"));
            s_Reference.Blueprint = new CtrRef<Blueprint>(p_P.PartitionGuid, p_P.PrimaryInstance.InstanceId);
            return s_Reference;
        }).ToList();

        var s_Objects = s_PartReferences.Cast<ReferenceObjectData>().Concat(s_Setups.Values).ToList();
        for (var i = 0; i < s_Objects.Count; ++i)
            s_Objects[i].IndexInBlueprint = (ushort)i;

        p_Template.Name = p_Name;
        p_Template.InstanceId = new DataContainerId.Guid(NewGuid("world"));
        p_Template.Descriptor = Local<InterfaceDescriptorData>(s_TemplateDescriptor);
        p_Template.Objects = new RefArray<GameObjectData>();
        p_Template.Objects.AddRange(s_Objects.Select(Local<GameObjectData>));
        p_Template.LinkConnections = s_Links;
        p_Template.PropertyConnections = s_Properties;
        p_Template.EventConnections = s_Events;
        p_Template.RegistryContainer = new CtrRef<RegistryContainer>();

        var s_Instances = new List<DataContainerBase> { p_Template, s_TemplateDescriptor };
        s_Instances.AddRange(s_Objects);
        return new EbxTypeLibrary()
            .CreatePartition(p_Name.ToLowerInvariant(), s_PartitionGuid, NewGuid("world"), s_Instances);
    }

    /// <summary>By field id, the objects the source sub-world links its reference to the mode's sub-world to.</summary>
    private static Dictionary<int, List<CtrRefBase>>? SourceLinks(DatabasePartitionBase p_Source, string p_Mode)
    {
        var s_Mode = p_Source.Instances.FirstOrDefault(p_I => Field(p_I, "BundleName") is string s_Bundle && s_Bundle.Equals(p_Mode, StringComparison.OrdinalIgnoreCase));
        if (s_Mode == null)
            return null;

        var s_ModeKey = Key(p_Source.PartitionGuid, s_Mode.InstanceId);
        return (Field(p_Source.PrimaryInstance, "LinkConnections") as IEnumerable ?? Array.Empty<object>()).Cast<object>()
            .Where(p_L => Field(p_L, "Source") is CtrRefBase s_Ref && Key(Normalized(s_Ref)) == s_ModeKey)
            .GroupBy(p_L => (int)Field(p_L, "SourceFieldId")!)
            .ToDictionary(p_G => p_G.Key, p_G => p_G.Select(p_L => (CtrRefBase)Field(p_L, "Target")!).ToList());
    }

    /// <summary>A sub-world's interface: its descriptor, or what newer engines call its interface.</summary>
    private static CtrRefBase? InterfaceRef(DataContainerBase p_SubWorld) =>
        (Field(p_SubWorld, "Descriptor") ?? Field(p_SubWorld, "Interface")) as CtrRefBase;

    /// <summary>The values of a sub-world's interface fields, by id.</summary>
    private static Dictionary<int, string> InterfaceValues(DatabasePartitionBase p_SubWorld)
    {
        var s_Values = new Dictionary<int, string>();
        if (InterfaceRef(p_SubWorld.PrimaryInstance) is not { } s_Ref
            || p_SubWorld.Instances.FirstOrDefault(p_I => Key(p_SubWorld.PartitionGuid, p_I.InstanceId) == Key(Normalized(s_Ref))) is not { } s_Descriptor)
            return s_Values;

        foreach (var s_Field in (Field(s_Descriptor, "Fields") as IEnumerable ?? Array.Empty<object>()).Cast<object>())
            if (Field(s_Field, "Value") is string { Length: > 0 } s_Value)
                s_Values[(int)Field(s_Field, "Id")!] = s_Value;
        return s_Values;
    }

    /// <summary>
    /// By interface field id, the transform of the object a sub-world feeds the field to: an
    /// object's transform field is relative to it.
    /// </summary>
    private static Dictionary<int, LinearTransform> InterfaceFrames(IEngineMounter p_Game, DatabasePartitionBase p_SubWorld)
    {
        var s_Frames = new Dictionary<int, LinearTransform>();
        if (InterfaceRef(p_SubWorld.PrimaryInstance) is not { } s_Interface)
            return s_Frames;

        foreach (var s_Connection in (Field(p_SubWorld.PrimaryInstance, "PropertyConnections") as IEnumerable ?? Array.Empty<object>()).Cast<object>())
        {
            if (Field(s_Connection, "Source") is CtrRefBase s_Source && SameRef(s_Source, s_Interface)
                && Field(s_Connection, "Target") is CtrRefBase s_Target
                && Find(p_Game, p_SubWorld, s_Target) is { } s_Object && Field(s_Object, "BlueprintTransform") is { } s_Transform)
                s_Frames[(int)Field(s_Connection, "SourceFieldId")!] = Transform(s_Transform);
        }
        return s_Frames;
    }

    /// <summary>Any engine's transform as this engine's.</summary>
    private static LinearTransform Transform(object p_Transform)
    {
        Vec3 Vector(string p_Name) => Field(p_Transform, p_Name) is { } s_V
            ? new Vec3 { x = (float)Field(s_V, "x")!, y = (float)Field(s_V, "y")!, z = (float)Field(s_V, "z")! }
            : new Vec3();
        return new LinearTransform { right = Vector("right"), up = Vector("up"), forward = Vector("forward"), trans = Vector("trans") };
    }

    private static LinearTransform Identity() => new() { right = new Vec3 { x = 1 }, up = new Vec3 { y = 1 }, forward = new Vec3 { z = 1 }, trans = new Vec3() };

    /// <summary>A transform relative to a frame, in the frame's parent.</summary>
    private static LinearTransform ToWorld(LinearTransform p_Local, LinearTransform p_Frame)
    {
        Vec3 Rotate(Vec3 p_V) => new()
        {
            x = p_V.x * p_Frame.right.x + p_V.y * p_Frame.up.x + p_V.z * p_Frame.forward.x,
            y = p_V.x * p_Frame.right.y + p_V.y * p_Frame.up.y + p_V.z * p_Frame.forward.y,
            z = p_V.x * p_Frame.right.z + p_V.y * p_Frame.up.z + p_V.z * p_Frame.forward.z,
        };
        var s_Trans = Rotate(p_Local.trans);
        return new LinearTransform
        {
            right = Rotate(p_Local.right),
            up = Rotate(p_Local.up),
            forward = Rotate(p_Local.forward),
            trans = new Vec3 { x = s_Trans.x + p_Frame.trans.x, y = s_Trans.y + p_Frame.trans.y, z = s_Trans.z + p_Frame.trans.z },
        };
    }

    /// <summary>A transform in a frame's parent, relative to the frame (a rotation without scale).</summary>
    private static LinearTransform ToLocal(LinearTransform p_World, LinearTransform p_Frame)
    {
        static float Dot(Vec3 p_A, Vec3 p_B) => p_A.x * p_B.x + p_A.y * p_B.y + p_A.z * p_B.z;
        Vec3 Unrotate(Vec3 p_V) => new() { x = Dot(p_V, p_Frame.right), y = Dot(p_V, p_Frame.up), z = Dot(p_V, p_Frame.forward) };
        return new LinearTransform
        {
            right = Unrotate(p_World.right),
            up = Unrotate(p_World.up),
            forward = Unrotate(p_World.forward),
            trans = Unrotate(new Vec3 { x = p_World.trans.x - p_Frame.trans.x, y = p_World.trans.y - p_Frame.trans.y, z = p_World.trans.z - p_Frame.trans.z }),
        };
    }

    /// <summary>An interface field's transform value, as <see cref="Format"/> writes it.</summary>
    private static bool TryParseTransform(string p_Value, out LinearTransform p_Transform)
    {
        p_Transform = new LinearTransform();
        if (!p_Value.StartsWith("LinearTransform", StringComparison.Ordinal))
            return false;

        var s_Numbers = Regex.Matches(p_Value, @"[-+]?(?:\d+\.?\d*|\.\d+)(?:[eE][-+]?\d+)?")
            .Select(p_M => float.Parse(p_M.Value, NumberStyles.Float, CultureInfo.InvariantCulture)).ToArray();
        if (s_Numbers.Length != 12)
            return false;

        Vec3 Vector(int p_At) => new() { x = s_Numbers[p_At], y = s_Numbers[p_At + 1], z = s_Numbers[p_At + 2] };
        p_Transform = new LinearTransform { right = Vector(0), up = Vector(3), forward = Vector(6), trans = Vector(9) };
        return true;
    }

    /// <summary>The transforms ordered so each is the farthest from those before it.</summary>
    private static IEnumerable<LinearTransform> Spread(List<LinearTransform> p_Transforms)
    {
        var s_Left = p_Transforms.ToList();
        var s_Chosen = new List<LinearTransform>();
        while (s_Left.Count > 0)
        {
            var s_Next = s_Chosen.Count == 0 ? s_Left[0] : s_Left.MaxBy(p_T => s_Chosen.Min(p_C => Distance(p_T, p_C)))!;
            s_Left.Remove(s_Next);
            s_Chosen.Add(s_Next);
            yield return s_Next;
        }
    }

    private static float Distance(LinearTransform p_A, LinearTransform p_B) =>
        MathF.Sqrt(MathF.Pow(p_A.trans.x - p_B.trans.x, 2) + MathF.Pow(p_A.trans.y - p_B.trans.y, 2) + MathF.Pow(p_A.trans.z - p_B.trans.z, 2));

    /// <summary>A transform as an interface field's value.</summary>
    private static string Format(LinearTransform p_Transform)
    {
        static string Vector(Vec3 p_V) => string.Create(CultureInfo.InvariantCulture, $"({p_V.x},{p_V.y},{p_V.z})");
        return $"LinearTransform ({Vector(p_Transform.right)},{Vector(p_Transform.up)},{Vector(p_Transform.forward)},{Vector(p_Transform.trans)})";
    }

    private static DatabasePartitionBase? Parse(IEngineMounter p_Game, string p_Name) =>
        p_Game.TryGetPartition(p_Name, out var s_Mounted) && s_Mounted.FirstVariant is { } s_Variant
            ? EngineInterfaceRegistry.Create<IPartitionConverter>(p_Game.GetEngineType()).FromPartitionObject(p_Name, s_Variant)
            : null;

    /// <summary>The instance a reference points at, in the partition or another of the game, parsed afresh.</summary>
    private static DataContainerBase? Find(IEngineMounter p_Game, DatabasePartitionBase p_Partition, CtrRefBase p_Ref)
    {
        var s_Partition = p_Ref.PartitionGuid == p_Partition.PartitionGuid
            ? p_Partition
            : p_Game.TryGetPartitionByGuid(p_Ref.PartitionGuid, out var s_Name, out _) ? Parse(p_Game, s_Name) : null;
        return s_Partition?.Instances.FirstOrDefault(p_I => Key(s_Partition.PartitionGuid, p_I.InstanceId) == Key(Normalized(p_Ref)));
    }

    private static DatabasePartitionBase Part(IReadOnlyList<DatabasePartitionBase> p_Parts, DataContainerBase p_Instance) =>
        p_Parts.First(p_P => p_P.Instances.Contains(p_Instance));

    /// <summary>A reference by GUID, as the converted partitions refer to the instance.</summary>
    private static CtrRefBase Normalized(CtrRefBase p_Ref) =>
        new CtrRef<DataContainer>(p_Ref.PartitionGuid, PartitionConversion.InstanceGuid(p_Ref.PartitionGuid, p_Ref.InstanceId));

    private static bool SameRef(CtrRefBase p_A, CtrRefBase p_B) => Key(Normalized(p_A)) == Key(Normalized(p_B));

    private static string Key(CtrRefBase p_Ref) => Key(p_Ref.PartitionGuid, p_Ref.InstanceId);

    private static string Key(GUID p_Partition, DataContainerId p_Id) => $"{p_Partition}/{PartitionConversion.InstanceGuid(p_Partition, p_Id)}";

    private static object? Field(object p_Object, string p_Name) => p_Object.GetType().GetProperty(p_Name)?.GetValue(p_Object);
}
