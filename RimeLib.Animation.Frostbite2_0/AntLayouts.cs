using System.Collections.Generic;
using System.Linq;
using RimeLib.Animation.EA.Reflection;

namespace RimeLib.Animation.Frostbite2_0;

/// <summary>
/// The ANT layouts of Frostbite 2's AnimationSet banks, as BF3's banks carry them: every layout
/// those banks use, each with the hash its own reflection gives it. A bank written for Frostbite 2
/// takes its layouts from here.
/// </summary>
public static class AntLayouts
{
    private sealed record FieldDefinition(string Name, string? Type, uint ElementSize, uint Offset, ushort Count, ushort Flags, ushort Alignment, short Rle);

    private sealed record LayoutDefinition(string Name, uint Hash, uint Size, uint Alignment, bool Recorded, bool Native, int MinSlot, FieldDefinition[] Fields);

    /// <summary>The layouts by name, new for each call, their fields pointing at each other's.</summary>
    public static Dictionary<string, LayoutHeader> Create()
    {
        var s_Layouts = s_Definitions.ToDictionary(p_D => p_D.Name, p_D => new LayoutHeader
        {
            Name = p_D.Name,
            Hash = p_D.Hash,
            DataSize = p_D.Size,
            Alignment = p_D.Alignment,
            Recorded = p_D.Recorded,
            Native = p_D.Native,
            MinSlot = p_D.MinSlot,
            MaxSlot = p_D.MinSlot + p_D.Fields.Length - 1,
        });

        foreach (var s_Definition in s_Definitions)
        {
            var s_Layout = s_Layouts[s_Definition.Name];
            s_Layout.Fields = s_Definition.Fields.Select((p_F, p_Index) => new EntryHeader
            {
                Id = s_Definition.MinSlot + p_Index,
                Name = p_F.Name,
                Layout = p_F.Type == null ? null : s_Layouts[p_F.Type],
                LayoutHash = p_F.Type == null ? 0 : s_Layouts[p_F.Type].Hash,
                ElementSize = p_F.ElementSize,
                Offset = p_F.Offset,
                Count = p_F.Count,
                Flags = (EntryHeader.FieldFlags)p_F.Flags,
                ElementAlign = p_F.Alignment,
                RLE = p_F.Rle,
            }).ToArray();

            NameStrings(s_Layout);
        }

        return s_Layouts;
    }

    /// <summary>Places the field names as Frostbite 2 does: after the layout's name, those of the name, guid and base fields, then the others in slot order.</summary>
    private static void NameStrings(LayoutHeader p_Layout)
    {
        var s_Offset = (uint)p_Layout.Name.Length + 2;
        foreach (var s_Field in p_Layout.Fields.Where(p_F => p_F.Name.Length > 0).OrderBy(p_F => p_F.Id switch { -2 => 0, -3 => 1, -1 => 2, _ => 3 }))
        {
            s_Field.NameOffset = s_Offset;
            s_Offset += (uint)s_Field.Name.Length + 1;
        }
    }

    private static readonly LayoutDefinition[] s_Definitions =
    [
        new("Bool", 0x00000001, 1, 1, false, true, 0, []),
        new("UInt8", 0x00000003, 1, 1, false, true, 0, []),
        new("Int16", 0x00000004, 2, 2, false, true, 0, []),
        new("UInt16", 0x00000005, 2, 2, false, true, 0, []),
        new("Int32", 0x00000006, 4, 4, false, true, 0, []),
        new("UInt32", 0x00000007, 4, 4, false, true, 0, []),
        new("Float", 0x0000000A, 4, 4, false, true, 0, []),
        new("Vector3", 0x0000000C, 16, 16, false, true, 0,
        [
            new("x", "Float", 4, 0, 1, 0, 4, 3),
            new("y", "Float", 4, 4, 1, 0, 4, 2),
            new("z", "Float", 4, 8, 1, 0, 4, 1),
        ]),
        new("Vector4", 0x0000000D, 16, 16, false, true, 0,
        [
            new("x", "Float", 4, 0, 1, 0, 4, 4),
            new("y", "Float", 4, 4, 1, 0, 4, 3),
            new("z", "Float", 4, 8, 1, 0, 4, 2),
            new("w", "Float", 4, 12, 1, 0, 4, 1),
        ]),
        new("Quaternion", 0x0000000E, 16, 16, false, true, 0,
        [
            new("x", "Float", 4, 0, 1, 0, 4, 4),
            new("y", "Float", 4, 4, 1, 0, 4, 3),
            new("z", "Float", 4, 8, 1, 0, 4, 2),
            new("w", "Float", 4, 12, 1, 0, 4, 1),
        ]),
        new("Guid", 0x00000010, 16, 4, false, true, 0, []),
        new("String", 0x00000011, 16, 8, false, true, 0, []),
        new("DataRef", 0x00000012, 8, 8, false, true, 0, []),
        new("Traj2RefFeatureAsset", 0x025058D1, 80, 8, true, false, -3,
        [
            new("__guid", "Guid", 16, 24, 1, 0, 4, 1),
            new("__name", "String", 16, 0, 1, 0, 8, 1),
            new("__base", "DataRef", 8, 16, 1, 0, 8, 1),
            new("ReferenceTemplate", "Guid", 16, 40, 1, 0, 4, 2),
            new("TrajectoryTemplate", "Guid", 16, 56, 1, 0, 4, 1),
            new("ReferenceJoint", "Int32", 4, 72, 1, 0, 4, 2),
            new("TrajectoryJoint", "Int32", 4, 76, 1, 0, 4, 1),
        ]),
        new("LayoutHierarchyAsset", 0x08DD313B, 72, 8, true, false, -3,
        [
            new("__guid", "Guid", 16, 56, 1, 0, 4, 1),
            new("__name", "String", 16, 32, 1, 0, 8, 1),
            new("__base", "DataRef", 8, 48, 1, 0, 8, 1),
            new("LayoutAssets", "Guid", 16, 0, 1, 1, 8, 2),
            new("Children", "Guid", 16, 16, 1, 1, 8, 1),
        ]),
        new("LayoutAsset", 0x0FE4702A, 61, 8, true, false, -3,
        [
            new("__guid", "Guid", 16, 40, 1, 0, 4, 1),
            new("__name", "String", 16, 0, 1, 0, 8, 1),
            new("__base", "DataRef", 8, 32, 1, 0, 8, 1),
            new("NoReorder", "Bool", 1, 60, 1, 0, 1, 1),
            new("MinAlignment", "UInt32", 4, 56, 1, 0, 4, 1),
            new("Slots", "LayoutEntry", 16, 16, 1, 1, 8, 1),
        ]),
        new("FloatAsset", 0x14D6960B, 44, 8, true, false, -3,
        [
            new("__guid", "Guid", 16, 24, 1, 0, 4, 1),
            new("__name", "String", 16, 0, 1, 0, 8, 1),
            new("__base", "DataRef", 8, 16, 1, 0, 8, 1),
            new("Default", "Float", 4, 40, 1, 0, 4, 1),
        ]),
        new("ControllerUpdate", 0x1FF9092C, 56, 8, true, false, -3,
        [
            new("__guid", "Guid", 16, 24, 1, 0, 4, 1),
            new("__name", "String", 16, 0, 1, 0, 8, 1),
            new("__base", "DataRef", 8, 16, 1, 0, 8, 1),
            new("InitParams", "Guid", 16, 40, 1, 0, 4, 1),
        ]),
        new("AnimatableConfigAsset", 0x2CD72428, 156, 16, true, false, -3,
        [
            new("__guid", "Guid", 16, 88, 1, 0, 4, 1),
            new("__name", "String", 16, 64, 1, 0, 8, 1),
            new("__base", "DataRef", 8, 80, 1, 0, 8, 1),
            new("Parent", "Guid", 16, 104, 1, 0, 4, 2),
            new("DefaultPose", "Guid", 16, 120, 1, 0, 4, 1),
            new("StartPosition", "Vector3", 16, 0, 1, 0, 16, 1),
            new("StartRotation", "Quaternion", 16, 16, 1, 0, 16, 1),
            new("PlayerScale", "Float", 4, 152, 1, 0, 4, 1),
            new("FeatureCollection", "Guid", 16, 136, 1, 0, 4, 1),
            new("OverrideGameStateTarget", "Guid", 16, 32, 1, 1, 8, 2),
            new("OverrideGameStateData", "Guid", 16, 48, 1, 1, 8, 1),
        ]),
        new("DeltaTrajectory", 0x36DD7D3E, 60, 8, true, false, -3,
        [
            new("__guid", "Guid", 16, 24, 1, 0, 4, 1),
            new("__name", "String", 16, 0, 1, 0, 8, 1),
            new("__base", "DataRef", 8, 16, 1, 0, 8, 1),
            new("DeltaTicks", "Guid", 16, 40, 1, 0, 4, 1),
            new("VelocityMode", "UInt32", 4, 56, 1, 0, 4, 1),
        ]),
        new("JointInfo", 0x4E369EAC, 24, 8, true, false, 0,
        [
            new("JointName", "String", 16, 0, 1, 0, 8, 1),
            new("ParentIndex", "Int32", 4, 16, 1, 0, 4, 2),
            new("JointType", "Int32", 4, 20, 1, 0, 4, 1),
        ]),
        new("JointMappingFeature", 0x59244A1A, 56, 8, true, false, -3,
        [
            new("__guid", "Guid", 16, 40, 1, 0, 4, 1),
            new("__name", "String", 16, 0, 1, 0, 8, 1),
            new("__base", "DataRef", 8, 32, 1, 0, 8, 1),
            new("JointMappings", "JointMappingData", 16, 16, 1, 1, 8, 1),
        ]),
        new("CurveAnimationAsset::ChannelGroup", 0x5BFA3A4D, 4, 2, true, false, 0,
        [
            new("NumKeys", "UInt16", 2, 0, 1, 0, 2, 2),
            new("NumChannels", "UInt16", 2, 2, 1, 0, 2, 1),
        ]),
        new("DefaultDofVector3", 0x63207A9D, 32, 16, true, false, 0,
        [
            new("DofName", "String", 16, 16, 1, 0, 8, 1),
            new("Value", "Vector3", 16, 0, 1, 0, 16, 1),
        ]),
        new("RigOpListUpdate", 0x6663DD97, 69, 8, true, false, -3,
        [
            new("__guid", "Guid", 16, 24, 1, 0, 4, 1),
            new("__name", "String", 16, 0, 1, 0, 8, 1),
            new("__base", "DataRef", 8, 16, 1, 0, 8, 1),
            new("RigOpListKey", "Guid", 16, 40, 1, 0, 4, 1),
            new("RunOnSpuKey", "Bool", 1, 68, 1, 0, 1, 1),
            new("NumJobs", "UInt32", 4, 56, 1, 0, 4, 3),
            new("MaxAnimatablesPerJob", "UInt32", 4, 60, 1, 0, 4, 2),
            new("QueueBatchSize", "UInt32", 4, 64, 1, 0, 4, 1),
        ]),
        new("DefaultDofFloat", 0x66ABA23E, 20, 8, true, false, 0,
        [
            new("DofName", "String", 16, 0, 1, 0, 8, 1),
            new("Value", "Float", 4, 16, 1, 0, 4, 1),
        ]),
        new("AnimatableAsset", 0x6B09D07B, 88, 8, true, false, -3,
        [
            new("__guid", "Guid", 16, 24, 1, 0, 4, 1),
            new("__name", "String", 16, 0, 1, 0, 8, 1),
            new("__base", "DataRef", 8, 16, 1, 0, 8, 1),
            new("FeatureCollection", "Guid", 16, 40, 1, 0, 4, 3),
            new("DisablePoseUpdate", "Guid", 16, 56, 1, 0, 4, 2),
            new("DisableControllerUpdate", "Guid", 16, 72, 1, 0, 4, 1),
        ]),
        new("LayoutEntry", 0x6EC49814, 20, 8, true, false, 0,
        [
            new("Name", "String", 16, 0, 1, 0, 8, 1),
            new("Type", "UInt32", 4, 16, 1, 0, 4, 1),
        ]),
        new("CurveAnimationAsset::KeysBlock", 0x702D35FC, 4, 2, true, false, 0,
        [
            new("NumChannelGroups", "UInt16", 2, 0, 1, 0, 2, 2),
            new("KeysCount", "UInt16", 2, 2, 1, 0, 2, 1),
        ]),
        new("ClipInitParam", 0x73587F6F, 44, 8, true, false, -3,
        [
            new("__guid", "Guid", 16, 24, 1, 0, 4, 1),
            new("__name", "String", 16, 0, 1, 0, 8, 1),
            new("__base", "DataRef", 8, 16, 1, 0, 8, 1),
            new("StartTick", "Float", 4, 40, 1, 0, 4, 1),
        ]),
        new("DefaultDofVector4", 0x7979B6C6, 32, 16, true, false, 0,
        [
            new("DofName", "String", 16, 16, 1, 0, 8, 1),
            new("Value", "Vector4", 16, 0, 1, 0, 16, 1),
        ]),
        new("ActorGroupAsset", 0x7C3D2BA2, 40, 8, true, false, -3,
        [
            new("__guid", "Guid", 16, 24, 1, 0, 4, 1),
            new("__name", "String", 16, 0, 1, 0, 8, 1),
            new("__base", "DataRef", 8, 16, 1, 0, 8, 1),
        ]),
        new("ControllerUpdateInitParamsAsset", 0x83A9A138, 72, 8, true, false, -3,
        [
            new("__guid", "Guid", 16, 24, 1, 0, 4, 1),
            new("__name", "String", 16, 0, 1, 0, 8, 1),
            new("__base", "DataRef", 8, 16, 1, 0, 8, 1),
            new("ControllerAsset", "Guid", 16, 40, 1, 0, 4, 2),
            new("InitParams", "Guid", 16, 56, 1, 0, 4, 1),
        ]),
        new("PrimaryRigFeatureAsset", 0x8CD9E9C2, 56, 8, true, false, -3,
        [
            new("__guid", "Guid", 16, 24, 1, 0, 4, 1),
            new("__name", "String", 16, 0, 1, 0, 8, 1),
            new("__base", "DataRef", 8, 16, 1, 0, 8, 1),
            new("Rig", "Guid", 16, 40, 1, 0, 4, 1),
        ]),
        new("SkeletonAsset", 0x931FE7FB, 60, 8, true, false, -3,
        [
            new("__guid", "Guid", 16, 40, 1, 0, 4, 1),
            new("__name", "String", 16, 0, 1, 0, 8, 1),
            new("__base", "DataRef", 8, 32, 1, 0, 8, 1),
            new("Joints", "JointInfo", 16, 16, 1, 1, 8, 1),
            new("TrajJointIndex", "Int32", 4, 56, 1, 0, 4, 1),
        ]),
        new("RigAsset", 0x95C07894, 168, 8, true, false, -3,
        [
            new("__guid", "Guid", 16, 104, 1, 0, 4, 1),
            new("__name", "String", 16, 16, 1, 0, 8, 1),
            new("__base", "DataRef", 8, 96, 1, 0, 8, 1),
            new("FeatureCollection", "Guid", 16, 120, 1, 0, 4, 2),
            new("Skeleton", "Guid", 16, 136, 1, 0, 4, 1),
            new("DofSetLists", "Guid", 16, 0, 1, 1, 8, 1),
            new("DefaultFloatValues", "DefaultDofFloat", 16, 48, 1, 1, 8, 1),
            new("DefaultIntValues", "DefaultDofInt", 16, 80, 1, 1, 8, 1),
            new("DefaultVector3Values", "DefaultDofVector3", 16, 32, 1, 1, 8, 1),
            new("DefaultVector4Values", "DefaultDofVector4", 16, 64, 1, 1, 8, 1),
            new("DeltaTrajDofSet", "Guid", 16, 152, 1, 0, 4, 1),
        ]),
        new("CurveAnimationAsset", 0x96D93A9F, 162, 8, true, false, -3,
        [
            new("__guid", "Guid", 16, 136, 1, 0, 4, 1),
            new("__name", "String", 16, 80, 1, 0, 8, 1),
            new("__base", "DataRef", 8, 128, 1, 0, 8, 1),
            new("FPS", "Float", 4, 152, 1, 0, 4, 1),
            new("NumRotations", "UInt16", 2, 156, 1, 0, 2, 3),
            new("NumVectors", "UInt16", 2, 158, 1, 0, 2, 2),
            new("NumFloats", "UInt16", 2, 160, 1, 0, 2, 1),
            new("Values", "Float", 16, 48, 1, 1, 8, 1),
            new("Keys", "UInt16", 16, 0, 1, 1, 8, 1),
            new("Consts", "Float", 16, 64, 1, 1, 8, 1),
            new("ConstOffsets", "UInt16", 16, 16, 1, 1, 8, 1),
            new("KeysBlocks", "CurveAnimationAsset::KeysBlock", 16, 112, 1, 1, 8, 1),
            new("ChannelGroups", "CurveAnimationAsset::ChannelGroup", 16, 96, 1, 1, 8, 1),
            new("ChannelOffsets", "UInt16", 16, 32, 1, 1, 8, 1),
        ]),
        new("ControllerAsset", 0x9792444B, 56, 8, true, false, -3,
        [
            new("__guid", "Guid", 16, 24, 1, 0, 4, 1),
            new("__name", "String", 16, 0, 1, 0, 8, 1),
            new("__base", "DataRef", 8, 16, 1, 0, 8, 1),
            new("TagCollectionSet", "Guid", 16, 40, 1, 0, 4, 1),
        ]),
        new("JointMappingData", 0x9905895B, 32, 8, true, false, 0,
        [
            new("JointTemplate", "Guid", 16, 16, 1, 0, 4, 1),
            new("JointIndices", "Int32", 16, 0, 1, 1, 8, 1),
        ]),
        new("RigOpListBinding", 0x9E0F8443, 64, 8, true, false, 0,
        [
            new("DataRigOpType", "String", 16, 0, 1, 0, 8, 1),
            new("DataRigOpKey", "Guid", 16, 32, 1, 0, 4, 1),
            new("DataParam", "RigOpListBindingParam", 16, 16, 1, 1, 8, 1),
            new("DataEnableKey", "Guid", 16, 48, 1, 0, 4, 1),
        ]),
        new("FeatureCollectionAsset", 0xA8465B62, 56, 8, true, false, -3,
        [
            new("__guid", "Guid", 16, 40, 1, 0, 4, 1),
            new("__name", "String", 16, 16, 1, 0, 8, 1),
            new("__base", "DataRef", 8, 32, 1, 0, 8, 1),
            new("FeatureAssets", "Guid", 16, 0, 1, 1, 8, 1),
        ]),
        new("RigOpListBindingParam", 0xA99F6406, 80, 8, true, false, 0,
        [
            new("DataDSLKey", "Guid", 16, 32, 1, 0, 4, 2),
            new("DataDSKey", "Guid", 16, 48, 1, 0, 4, 1),
            new("DataName", "String", 16, 0, 1, 0, 8, 1),
            new("DataValueKey", "Guid", 16, 64, 1, 0, 4, 1),
            new("DataParameterName", "String", 16, 16, 1, 0, 8, 1),
        ]),
        new("JointMapTemplateIDAsset", 0xAA2961E6, 60, 8, true, false, -3,
        [
            new("__guid", "Guid", 16, 24, 1, 0, 4, 1),
            new("__name", "String", 16, 0, 1, 0, 8, 1),
            new("__base", "DataRef", 8, 16, 1, 0, 8, 1),
            new("TemplateAsset", "Guid", 16, 40, 1, 0, 4, 1),
            new("EnumValue", "Int32", 4, 56, 1, 0, 4, 1),
        ]),
        new("DeltaTrajLayoutAsset", 0xB2932A71, 40, 8, true, false, -3,
        [
            new("__guid", "Guid", 16, 24, 1, 0, 4, 1),
            new("__name", "String", 16, 0, 1, 0, 8, 1),
            new("__base", "DataRef", 8, 16, 1, 0, 8, 1),
        ]),
        new("DctAnimationAsset", 0xB5A06C02, 187, 8, true, false, -3,
        [
            new("__guid", "Guid", 16, 152, 1, 0, 4, 1),
            new("__name", "String", 16, 128, 1, 0, 8, 1),
            new("__base", "DataRef", 8, 144, 1, 0, 8, 1),
            new("NumKeys", "UInt16", 2, 172, 1, 0, 2, 5),
            new("NumQuats", "UInt16", 2, 174, 1, 0, 2, 4),
            new("NumVec3", "UInt16", 2, 176, 1, 0, 2, 3),
            new("NumFloat", "UInt16", 2, 178, 1, 0, 2, 2),
            new("NumFloatVec", "UInt16", 2, 180, 1, 0, 2, 1),
            new("Cycle", "Bool", 1, 184, 1, 0, 1, 1),
            new("QuantizeMultBlock", "UInt16", 2, 182, 1, 0, 2, 1),
            new("KeyTimes", "UInt16", 16, 96, 1, 1, 8, 1),
            new("QuantizeMultSubblock", "UInt8", 1, 185, 1, 0, 1, 2),
            new("CatchAllBitCount", "UInt8", 1, 186, 1, 0, 1, 1),
            new("DofTableDescBytes", "UInt8", 16, 0, 1, 1, 8, 1),
            new("DeltaBaseX", "Int16", 16, 32, 1, 1, 8, 4),
            new("DeltaBaseY", "Int16", 16, 48, 1, 1, 8, 3),
            new("DeltaBaseZ", "Int16", 16, 64, 1, 1, 8, 2),
            new("DeltaBaseW", "Int16", 16, 80, 1, 1, 8, 1),
            new("BitsPerSubblock", "UInt16", 16, 112, 1, 1, 8, 1),
            new("DataSize", "UInt32", 4, 168, 1, 0, 4, 1),
            new("Data", "UInt8", 16, 16, 1, 1, 8, 1),
        ]),
        new("LoopingControllerAsset", 0xB7C81789, 85, 8, true, false, -3,
        [
            new("__guid", "Guid", 16, 24, 1, 0, 4, 1),
            new("__name", "String", 16, 0, 1, 0, 8, 1),
            new("__base", "DataRef", 8, 16, 1, 0, 8, 1),
            new("SubjectControllerAsset", "Guid", 16, 40, 1, 0, 4, 2),
            new("SubjectInitParams", "Guid", 16, 56, 1, 0, 4, 1),
            new("IsLoopControl", "Bool", 1, 84, 1, 0, 1, 1),
            new("StartTime", "Float", 4, 72, 1, 0, 4, 3),
            new("LoopStartTime", "Float", 4, 76, 1, 0, 4, 2),
            new("LoopEndTime", "Float", 4, 80, 1, 0, 4, 1),
        ]),
        new("SceneOpMatrixAsset", 0xBA6CB211, 104, 8, true, false, -3,
        [
            new("__guid", "Guid", 16, 72, 1, 0, 4, 1),
            new("__name", "String", 16, 48, 1, 0, 8, 1),
            new("__base", "DataRef", 8, 64, 1, 0, 8, 1),
            new("SceneOpAssets", "Guid", 16, 16, 1, 1, 8, 2),
            new("AnimatableAssets", "Guid", 16, 32, 1, 1, 8, 1),
            new("CellInfo", "Bool", 16, 0, 1, 1, 8, 1),
            new("DeltaTicks", "Guid", 16, 88, 1, 0, 4, 1),
        ]),
        new("BaseJointMapTemplateAsset", 0xC9BE6E25, 56, 8, true, false, -3,
        [
            new("__guid", "Guid", 16, 40, 1, 0, 4, 1),
            new("__name", "String", 16, 16, 1, 0, 8, 1),
            new("__base", "DataRef", 8, 32, 1, 0, 8, 1),
            new("IDList", "Guid", 16, 0, 1, 1, 8, 1),
        ]),
        new("ChannelToDofAsset", 0xC9DEDB8F, 60, 8, true, false, -3,
        [
            new("__guid", "Guid", 16, 40, 1, 0, 4, 1),
            new("__name", "String", 16, 16, 1, 0, 8, 1),
            new("__base", "DataRef", 8, 32, 1, 0, 8, 1),
            new("StorageType", "UInt32", 4, 56, 1, 0, 4, 1),
            new("IndexData", "UInt8", 16, 0, 1, 1, 8, 1),
        ]),
        new("RigFeatureAsset", 0xCD8D7EF2, 44, 8, true, false, -3,
        [
            new("__guid", "Guid", 16, 24, 1, 0, 4, 1),
            new("__name", "String", 16, 0, 1, 0, 8, 1),
            new("__base", "DataRef", 8, 16, 1, 0, 8, 1),
            new("Checksum", "Int32", 4, 40, 1, 0, 4, 1),
        ]),
        new("AnimationAsset", 0xCEAFE7C0, 71, 8, true, false, -3,
        [
            new("__guid", "Guid", 16, 24, 1, 0, 4, 1),
            new("__name", "String", 16, 0, 1, 0, 8, 1),
            new("__base", "DataRef", 8, 16, 1, 0, 8, 1),
            new("CodecType", "UInt32", 4, 56, 1, 0, 4, 2),
            new("AnimId", "UInt32", 4, 60, 1, 0, 4, 1),
            new("TrimOffset", "Float", 4, 64, 1, 0, 4, 1),
            new("EndFrame", "UInt16", 2, 68, 1, 0, 2, 1),
            new("Additive", "Bool", 1, 70, 1, 0, 1, 1),
            new("ChannelToDofAsset", "Guid", 16, 40, 1, 0, 4, 1),
        ]),
        new("RigOpListAsset", 0xE0E7B866, 56, 8, true, false, -3,
        [
            new("__guid", "Guid", 16, 40, 1, 0, 4, 1),
            new("__name", "String", 16, 0, 1, 0, 8, 1),
            new("__base", "DataRef", 8, 32, 1, 0, 8, 1),
            new("DataRigOps", "RigOpListBinding", 16, 16, 1, 1, 8, 1),
        ]),
        new("Traj2RefRigOpAsset", 0xE0FFD596, 40, 8, true, false, -3,
        [
            new("__guid", "Guid", 16, 24, 1, 0, 4, 1),
            new("__name", "String", 16, 0, 1, 0, 8, 1),
            new("__base", "DataRef", 8, 16, 1, 0, 8, 1),
        ]),
        new("DefaultDofInt", 0xE3DD398F, 20, 8, true, false, 0,
        [
            new("DofName", "String", 16, 0, 1, 0, 8, 1),
            new("Value", "Int32", 4, 16, 1, 0, 4, 1),
        ]),
        new("ActorAsset", 0xEA86D88E, 72, 8, true, false, -3,
        [
            new("__guid", "Guid", 16, 24, 1, 0, 4, 1),
            new("__name", "String", 16, 0, 1, 0, 8, 1),
            new("__base", "DataRef", 8, 16, 1, 0, 8, 1),
            new("AnimatableAsset", "Guid", 16, 40, 1, 0, 4, 2),
            new("ConfigAsset", "Guid", 16, 56, 1, 0, 4, 1),
        ]),
        new("ControllerFeatureAsset", 0xF267A05D, 72, 8, true, false, -3,
        [
            new("__guid", "Guid", 16, 24, 1, 0, 4, 1),
            new("__name", "String", 16, 0, 1, 0, 8, 1),
            new("__base", "DataRef", 8, 16, 1, 0, 8, 1),
            new("ControllerAsset", "Guid", 16, 40, 1, 0, 4, 2),
            new("ControllerInitParams", "Guid", 16, 56, 1, 0, 4, 1),
        ]),
        new("ModelFeatureAsset", 0xFBA3BBB0, 56, 8, true, false, -3,
        [
            new("__guid", "Guid", 16, 40, 1, 0, 4, 1),
            new("__name", "String", 16, 0, 1, 0, 8, 1),
            new("__base", "DataRef", 8, 32, 1, 0, 8, 1),
            new("Model", "String", 16, 16, 1, 0, 8, 1),
        ]),
        new("ClipControllerAsset", 0xFC431BE4, 89, 8, true, false, -3,
        [
            new("__guid", "Guid", 16, 24, 1, 0, 4, 1),
            new("__name", "String", 16, 0, 1, 0, 8, 1),
            new("__base", "DataRef", 8, 16, 1, 0, 8, 1),
            new("Target", "Guid", 16, 40, 1, 0, 4, 2),
            new("Anim", "Guid", 16, 56, 1, 0, 4, 1),
            new("", null, 0, 0, 0, 0, 0, 0),
            new("NumTicks", "Float", 4, 72, 1, 0, 4, 3),
            new("FPS", "Float", 4, 76, 1, 0, 4, 2),
            new("FPSScale", "Float", 4, 80, 1, 0, 4, 1),
            new("DeltaTrajectory", "UInt8", 1, 88, 1, 0, 1, 1),
            new("Distance", "Float", 4, 84, 1, 0, 4, 1),
        ]),
    ];
}
