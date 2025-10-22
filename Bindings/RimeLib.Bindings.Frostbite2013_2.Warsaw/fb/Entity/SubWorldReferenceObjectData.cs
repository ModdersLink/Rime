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

namespace fb.Entity;

[ContainerType(16, 176)]
public class SubWorldReferenceObjectData
	: fb.Entity.ReferenceObjectData
{
	public SubWorldReferenceObjectData()
	{
		//ReferenceObjectData
		CastSunShadowEnable = false;
	}
	
	[ContainerField(0x80), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public string BundleName { get; set; } = string.Empty;
	
	[ContainerField(0x88), JsonProperty(Order = 136)]
	public List<string> PreloadedBundleNames { get; set; } = new();
	
	[ContainerField(0x90), JsonProperty(Order = 144)]
	public BundleHeapInfo BundleHeap { get; set; } = new();
	
	[ContainerField(0xa0), JsonProperty(Order = 160)]
	public CtrRef<SubWorldInclusionSettings> InclusionSettings { get; set; } = new();
	
	[ContainerField(0xa8), LayoutImmutable, Blittable, JsonProperty(Order = 168)]
	public bool AutoLoad { get; set; } = false;
	
	[ContainerField(0xa9), LayoutImmutable, Blittable, JsonProperty(Order = 169)]
	public bool IsWin32SubLevel { get; set; } = true;
	
	[ContainerField(0xaa), LayoutImmutable, Blittable, JsonProperty(Order = 170)]
	public bool IsXenonSubLevel { get; set; } = true;
	
	[ContainerField(0xab), LayoutImmutable, Blittable, JsonProperty(Order = 171)]
	public bool IsPs3SubLevel { get; set; } = true;
	
	[ContainerField(0xac), LayoutImmutable, Blittable, JsonProperty(Order = 172)]
	public bool IsGen4aSubLevel { get; set; } = true;
	
	[ContainerField(0xad), LayoutImmutable, Blittable, JsonProperty(Order = 173)]
	public bool IsGen4bSubLevel { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteString(BundleName));
		(RimeWriter Writer, uint ArrayIndex) s_PreloadedBundleNames = p_EbxWriter.GetArrayWriter(PreloadedBundleNames.GetType(), PreloadedBundleNames.Count);
		p_Writer.Write(s_PreloadedBundleNames.ArrayIndex);
		foreach (var s_Entry in PreloadedBundleNames)
		{
			s_PreloadedBundleNames.Writer.Write(p_EbxWriter.WriteString(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		BundleHeap.Serialize(p_Writer, p_EbxWriter);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(InclusionSettings));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(AutoLoad);
		p_Writer.Write(IsWin32SubLevel);
		p_Writer.Write(IsXenonSubLevel);
		p_Writer.Write(IsPs3SubLevel);
		p_Writer.Write(IsGen4aSubLevel);
		p_Writer.Write(IsGen4bSubLevel);
		p_Writer.WriteNullBytes(2);
	}
}

