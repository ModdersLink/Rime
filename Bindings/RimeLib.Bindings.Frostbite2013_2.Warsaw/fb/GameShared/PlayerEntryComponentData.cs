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

[ContainerType(16, 288)]
public class PlayerEntryComponentData
	: fb.GameShared.EntryComponentData
{
	[ContainerField(0xf0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 240)]
	public Vec3 AnimationAccelerationMultiplier { get; set; } = new()
	{
		z = 0.100f,
		y = 0.100f,
		x = 0.100f,
	};
	
	[ContainerField(0x100), LayoutImmutable, Blittable, JsonProperty(Order = 256)]
	public string AntEntryID { get; set; } = string.Empty;
	
	[ContainerField(0x108), LayoutImmutable, Blittable, JsonProperty(Order = 264)]
	public AntEntryIdEnum AntEntryId { get; set; } = AntEntryIdEnum.AntEntryIdEnum_Humvee_Driver;
	
	[ContainerField(0x110), JsonProperty(Order = 272)]
	public CtrRef<AntEnumeration> AntEntryEnumeration { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		AnimationAccelerationMultiplier.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteString(AntEntryID));
		p_Writer.Write((int) AntEntryId);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(AntEntryEnumeration));
		p_Writer.WriteNullBytes(12);
	}
}

