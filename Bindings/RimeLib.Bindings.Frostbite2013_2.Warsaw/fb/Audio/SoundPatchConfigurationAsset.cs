///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;

using fb.Core;

namespace fb.Audio;

[ContainerType(8, 104)]
public class SoundPatchConfigurationAsset
	: fb.Audio.SoundAsset
{
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public CtrRef<SoundPatchAsset> Sound { get; set; } = new();
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public float Loudness { get; set; } = 0.000f;
	
	[ContainerField(0x34), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
	public float Radius { get; set; } = 0.500f;
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public float RadiusFalloffScalar { get; set; } = 1.000f;
	
	[ContainerField(0x3c), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
	public float MinObstructionValue { get; set; } = 0.000f;
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public float MaxObstructionValue { get; set; } = 1.000f;
	
	[ContainerField(0x48), JsonProperty(Order = 72)]
	public CtrRef<MixerAsset> Mixer { get; set; } = new();
	
	[ContainerField(0x50), JsonProperty(Order = 80)]
	public RefArray<AudioGraphNodeConfigData> NodeConfigs { get; set; } = new();
	
	[ContainerField(0x58), JsonProperty(Order = 88)]
	public RefArray<AudioGraphParameterConfigData> ParameterConfigs { get; set; } = new();
	
	[ContainerField(0x60), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
	public bool EnableObstructionOverrides { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(Sound));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(Loudness);
		p_Writer.Write(Radius);
		p_Writer.Write(RadiusFalloffScalar);
		p_Writer.Write(MinObstructionValue);
		p_Writer.Write(MaxObstructionValue);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(Mixer));
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_NodeConfigs = p_EbxWriter.GetArrayWriter(NodeConfigs.GetType(), NodeConfigs.Count);
		p_Writer.Write(s_NodeConfigs.ArrayIndex);
		foreach (var s_Entry in NodeConfigs)
		{
			s_NodeConfigs.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_ParameterConfigs = p_EbxWriter.GetArrayWriter(ParameterConfigs.GetType(), ParameterConfigs.Count);
		p_Writer.Write(s_ParameterConfigs.ArrayIndex);
		foreach (var s_Entry in ParameterConfigs)
		{
			s_ParameterConfigs.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(EnableObstructionOverrides);
		p_Writer.WriteNullBytes(7);
	}
}

