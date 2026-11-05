using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using RimeLib.Animation.EA.GenericData;
using RimeLib.Animation.EA.Reflection;
using RimeLib.Animation.Frostbite;
using RimeLib.Animation.Frostbite2_0;
using RimeLib.Frostbite;
using RimeLib.IO.Conversion;
using Frostbite2Packaging = fb.AntPackagingType;

namespace RimeLib.Animation.Frostbite2013_2;

/// <summary>
/// This engine's AnimationSet banks as Frostbite 2's. A bank becomes a little-endian stream of
/// Frostbite 2's layouts; an object whose layout Frostbite 2 has field for field is copied, its
/// bools and empty strings as Frostbite 2 stores them. The controllers are Frostbite 2's: a clip's data becomes a
/// clip controller, a looping one a looping controller over the whole clip from its first tick,
/// the root controller update and feature the controller update and feature, the feature named
/// without its root prefix. The clip and update
/// init params Frostbite 2 refers to follow the bank's own objects, with the next free ids.
/// </summary>
public class AnimationBankConverter : IAnimationBankConverter
{
    /// <summary>This engine's AntPackagingType_AnimationSet.</summary>
    private const uint c_AnimationSet = 2;

    /// <summary>What this engine's root controller feature adds to the name of the feature it is.</summary>
    private const string c_RootPrefix = "Root_";

    /// <summary>How Frostbite 2's banks store a true bool.</summary>
    private const byte c_True = 0xFF;

    public EngineType[] GetSupportedEngines() => [EngineType.Frostbite2013_2];

    public byte[] Convert(byte[] p_Bank, EngineType p_Target, TextWriter p_Log)
    {
        if (p_Target != EngineType.Frostbite2_0)
            throw new NotSupportedException($"animation banks are converted to Frostbite 2 only, not {p_Target}");

        var s_Source = new AnimationSetBank();
        s_Source.Deserialize(p_Bank);

        if (s_Source.PackagingType != c_AnimationSet)
            throw new NotSupportedException($"a bank of packaging type {s_Source.PackagingType} is not an AnimationSet bank");

        var s_Conversion = new Conversion(s_Source.Archive.Objects, AntLayouts.Create(), p_Log);
        var s_Objects = s_Conversion.Run();

        var s_Target = new AnimationSetBank
        {
            PackagingType = (uint)Frostbite2Packaging.AntPackagingType_AnimationSet,
            Archive = new Archive
            {
                BigEndian = false,
                Reflection = Reflection.Gather(s_Objects.SelectMany(LayoutsOf)),
                Objects = s_Objects,
            },
        };

        if (!s_Target.Serialize(out var s_Data))
            throw new InvalidDataException("the bank writer refused");

        return s_Data;
    }

    /// <summary>The layouts of an instance and of everything in it.</summary>
    private static IEnumerable<LayoutHeader> LayoutsOf(Instance p_Instance)
    {
        yield return p_Instance.Layout;

        foreach (var s_Value in p_Instance.Values)
        {
            foreach (var s_Item in s_Value is List<object?> s_List ? s_List : [s_Value])
            {
                if (s_Item is not Instance s_Inner)
                    continue;

                foreach (var s_Layout in LayoutsOf(s_Inner))
                    yield return s_Layout;
            }
        }
    }

    private sealed class Conversion
    {
        private readonly List<Instance> m_Source;
        private readonly Dictionary<string, LayoutHeader> m_Layouts;
        private readonly TextWriter m_Log;
        private readonly Dictionary<Guid, Instance> m_ById;
        private readonly List<Instance> m_Added = new();
        private int m_NextId;

        public Conversion(List<Instance> p_Source, Dictionary<string, LayoutHeader> p_Layouts, TextWriter p_Log)
        {
            m_Source = p_Source;
            m_Layouts = p_Layouts;
            m_Log = p_Log;
            m_ById = p_Source.Where(p_O => p_O.Has("__guid")).ToDictionary(p_O => (Guid)p_O["__guid"]!);
            m_NextId = m_ById.Keys.Select(LocalId).DefaultIfEmpty().Max() + 1;
        }

        /// <summary>The local id an AnimationSet bank gives an object, the first field of its guid.</summary>
        private static int LocalId(Guid p_Guid) => EndianBitConverter.Little.ToInt32(p_Guid.ToByteArray(), 0);

        private Guid NewId() => new(m_NextId++, 0, 0, new byte[8]);

        public List<Instance> Run()
        {
            var s_Objects = m_Source.Select(Object).ToList();
            s_Objects.AddRange(m_Added);
            return s_Objects;
        }

        private Instance Object(Instance p_Source) => p_Source.Layout.Name switch
        {
            "ClipControllerData" => ClipController(p_Source),
            "LoopingData" => LoopingController(p_Source),
            "RootControllerUpdateAsset" => ControllerUpdate(p_Source),
            "RootControllerFeatureAsset" => ControllerFeature(p_Source),
            _ => Copy(p_Source, Layout(p_Source.Layout.Name), true),
        };

        private LayoutHeader Layout(string p_Name) => m_Layouts.TryGetValue(p_Name, out var s_Layout)
            ? s_Layout
            : throw new NotSupportedException($"Frostbite 2 has no layout {p_Name}");

        private Instance New(string p_Layout, Instance? p_Source)
        {
            var s_Instance = Instance.Create(Layout(p_Layout));
            if (p_Source != null)
            {
                s_Instance["__guid"] = p_Source["__guid"];
                s_Instance["__name"] = p_Source["__name"];
            }

            return s_Instance;
        }

        /// <summary>A controller's base, which keeps no tag collection.</summary>
        private Instance ControllerBase() => Instance.Create(Layout("ControllerAsset"));

        private Instance ClipController(Instance p_Source)
        {
            var s_Clip = New("ClipControllerAsset", p_Source);
            s_Clip["__base"] = ControllerBase();
            s_Clip["Target"] = p_Source["Target"];
            s_Clip["Anim"] = p_Source["Anim"];
            s_Clip["NumTicks"] = p_Source["NumTicks"];
            s_Clip["FPS"] = p_Source["FPS"];
            s_Clip["FPSScale"] = p_Source["FPSScale"];
            s_Clip["DeltaTrajectory"] = p_Source["Modes"];
            s_Clip["Distance"] = p_Source["Distance"];

            if ((float)p_Source["TickOffset"]! != 0 || (float)p_Source["TrimOffset"]! != 0)
                m_Log.WriteLine($"  {p_Source["__name"]}: a clip controller has no tick offset ({p_Source["TickOffset"]}) or trim ({p_Source["TrimOffset"]}); left out");

            return s_Clip;
        }

        private Instance LoopingController(Instance p_Source)
        {
            var s_Subject = (Guid)p_Source["Subject"]!;
            if (!m_ById.TryGetValue(s_Subject, out var s_Clip) || s_Clip.Layout.Name != "ClipControllerData")
                throw new NotSupportedException($"{p_Source["__name"]} loops {s_Subject}, which is not a clip in the bank");

            var s_InitParams = Instance.Create(Layout("ClipInitParam"));
            s_InitParams["__guid"] = NewId();
            m_Added.Add(s_InitParams);

            var s_Looping = New("LoopingControllerAsset", p_Source);
            s_Looping["__base"] = ControllerBase();
            s_Looping["SubjectControllerAsset"] = s_Subject;
            s_Looping["SubjectInitParams"] = s_InitParams["__guid"];
            s_Looping["LoopEndTime"] = s_Clip["NumTicks"];
            return s_Looping;
        }

        private Instance ControllerUpdate(Instance p_Source)
        {
            var s_InitParams = Instance.Create(Layout("ControllerUpdateInitParamsAsset"));
            s_InitParams["__guid"] = NewId();
            s_InitParams["__name"] = "ControllerUpdateInitParams";
            m_Added.Add(s_InitParams);

            var s_Update = New("ControllerUpdate", p_Source);
            s_Update["InitParams"] = s_InitParams["__guid"];
            return s_Update;
        }

        private Instance ControllerFeature(Instance p_Source)
        {
            var s_Base = (Instance?)p_Source["__base"];
            var s_Root = (Guid)p_Source["RootControllerAsset"]!;

            var s_Feature = New("ControllerFeatureAsset", p_Source);
            if (s_Feature["__name"] is string s_Name && s_Name.StartsWith(c_RootPrefix, StringComparison.Ordinal))
                s_Feature["__name"] = s_Name[c_RootPrefix.Length..];
            s_Feature["ControllerAsset"] = s_Root != Guid.Empty ? s_Root : s_Base?["ControllerAsset"] ?? Guid.Empty;
            s_Feature["ControllerInitParams"] = s_Base?["ControllerInitParams"] ?? Guid.Empty;
            return s_Feature;
        }

        /// <summary>An instance in a layout of the same fields, value for value.</summary>
        private Instance Copy(Instance p_Source, LayoutHeader p_Layout, bool p_Object)
        {
            var s_Target = new Instance(p_Layout, p_Object ? new Data { LayoutHash = p_Layout.Hash } : null);

            if (p_Source.Layout.Fields.Length != p_Layout.Fields.Length || p_Source.Layout.DataSize != p_Layout.DataSize)
                throw new NotSupportedException($"{p_Layout.Name} is laid out differently in Frostbite 2");

            for (var i = 0; i < p_Layout.Fields.Length; i++)
            {
                var s_Field = p_Layout.Fields[i];
                var s_From = p_Source.Layout.Fields[i];

                if (s_From.Name != s_Field.Name || s_From.Offset != s_Field.Offset || s_From.Count != s_Field.Count
                    || s_From.Flags != s_Field.Flags || s_From.Layout?.Name != s_Field.Layout?.Name)
                    throw new NotSupportedException($"{p_Layout.Name}.{s_Field.Name} is laid out differently in Frostbite 2");

                s_Target.Values[i] = Value(s_Field, p_Source.Values[i]);
            }

            return s_Target;
        }

        private object? Value(EntryHeader p_Field, object? p_Value) => p_Value switch
        {
            List<object?> s_List => s_List.Select(p_Item => Element(p_Field, p_Item)).ToList(),
            _ => Element(p_Field, p_Value),
        };

        private object? Element(EntryHeader p_Field, object? p_Value) => p_Value switch
        {
            Instance { Header: not null } s_Object => Copy(s_Object, Layout(s_Object.Layout.Name), true),
            Instance s_Struct => Copy(s_Struct, p_Field.Layout!, false),
            byte s_Bool when (LayoutType)p_Field.LayoutHash == LayoutType.Bool => s_Bool != 0 ? c_True : (byte)0,
            string { Length: 0 } => null,
            _ => p_Value,
        };
    }
}
