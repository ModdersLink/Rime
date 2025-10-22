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

namespace fb.VeniceShared;

[ContainerType(8, 56)]
public class CommanderMapInfoEntityData
	: fb.Entity.EntityData
{
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public Realm Realm { get; set; } = fb.Core.Realm.Realm_Server;
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public string Tag { get; set; } = string.Empty;
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public List<string> ExclusiveToGameModes { get; set; } = new();
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public bool IsLevolution { get; set; } = false;
	
	[ContainerField(0x31), LayoutImmutable, Blittable, JsonProperty(Order = 49)]
	public bool IsMinimapPatch { get; set; } = false;
	
	[ContainerField(0x32), LayoutImmutable, Blittable, JsonProperty(Order = 50)]
	public bool IsActiveByDefault { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) Realm);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteString(Tag));
		(RimeWriter Writer, uint ArrayIndex) s_ExclusiveToGameModes = p_EbxWriter.GetArrayWriter(ExclusiveToGameModes.GetType(), ExclusiveToGameModes.Count);
		p_Writer.Write(s_ExclusiveToGameModes.ArrayIndex);
		foreach (var s_Entry in ExclusiveToGameModes)
		{
			s_ExclusiveToGameModes.Writer.Write(p_EbxWriter.WriteString(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(IsLevolution);
		p_Writer.Write(IsMinimapPatch);
		p_Writer.Write(IsActiveByDefault);
		p_Writer.WriteNullBytes(5);
	}
}

