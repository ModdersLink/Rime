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
using fb.Entity;

namespace fb.GameShared;

[ContainerType(16, 144)]
public class PartComponentData
	: fb.Entity.GameComponentData
{
	[ContainerField(0x70), JsonProperty(Order = 112)]
	public RefArray<HealthStateData> HealthStates { get; set; } = new();
	
	[ContainerField(0x78), JsonProperty(Order = 120)]
	public RefArray<PartLinkData> PartLinks { get; set; } = new();
	
	[ContainerField(0x80), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public bool IsSupported { get; set; } = false;
	
	[ContainerField(0x81), LayoutImmutable, Blittable, JsonProperty(Order = 129)]
	public bool IsFragile { get; set; } = false;
	
	[ContainerField(0x82), LayoutImmutable, Blittable, JsonProperty(Order = 130)]
	public bool IsNetworkable { get; set; } = false;
	
	[ContainerField(0x83), LayoutImmutable, Blittable, JsonProperty(Order = 131)]
	public bool IsWindow { get; set; } = false;
	
	[ContainerField(0x84), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
	public bool AnimatePhysics { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_HealthStates = p_EbxWriter.GetArrayWriter(HealthStates.GetType(), HealthStates.Count);
		p_Writer.Write(s_HealthStates.ArrayIndex);
		foreach (var s_Entry in HealthStates)
		{
			s_HealthStates.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_PartLinks = p_EbxWriter.GetArrayWriter(PartLinks.GetType(), PartLinks.Count);
		p_Writer.Write(s_PartLinks.ArrayIndex);
		foreach (var s_Entry in PartLinks)
		{
			s_PartLinks.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(IsSupported);
		p_Writer.Write(IsFragile);
		p_Writer.Write(IsNetworkable);
		p_Writer.Write(IsWindow);
		p_Writer.Write(AnimatePhysics);
		p_Writer.WriteNullBytes(11);
	}
}

