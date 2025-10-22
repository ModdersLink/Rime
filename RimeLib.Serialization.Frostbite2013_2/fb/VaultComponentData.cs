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

namespace fb.Venice;

[ContainerType(16, 304)]
public class VaultComponentData
	: fb.Entity.GameComponentData
{
	[ContainerField(0x70), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public float StartHeightMax { get; set; } = 1.550f;
	
	[ContainerField(0x74), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
	public float StartHeightMin { get; set; } = 0.800f;
	
	[ContainerField(0x78), JsonProperty(Order = 120)]
	public VaultBinding Binding { get; set; } = new();
	
	[ContainerField(0x104), JsonProperty(Order = 260)]
	public Vault1pOnlyBinding Binding1pOnly { get; set; } = new();
	
	[ContainerField(0x118), JsonProperty(Order = 280)]
	public Vault3pOnlyBinding Binding3pOnly { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(StartHeightMax);
		p_Writer.Write(StartHeightMin);
		Binding.Serialize(p_Writer, p_EbxWriter);
		Binding1pOnly.Serialize(p_Writer, p_EbxWriter);
		Binding3pOnly.Serialize(p_Writer, p_EbxWriter);
		p_Writer.WriteNullBytes(4);
	}
}

