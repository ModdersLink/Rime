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

[ContainerType(8, 56)]
public class TextSequenceEntityData
	: fb.Entity.EntityData
{
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public Realm Realm { get; set; } = fb.Core.Realm.Realm_Client;
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public List<string> Events { get; set; } = new();
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public RefArray<TextSequenceItem> Items { get; set; } = new();
	
	[ContainerField(0x30), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public Vec2 ScreenPosition { get; set; } = new()
	{
		y = 0.000f,
		x = 0.000f,
	};
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) Realm);
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_Events = p_EbxWriter.GetArrayWriter(Events.GetType(), Events.Count);
		p_Writer.Write(s_Events.ArrayIndex);
		foreach (var s_Entry in Events)
		{
			s_Events.Writer.Write(p_EbxWriter.WriteString(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_Items = p_EbxWriter.GetArrayWriter(Items.GetType(), Items.Count);
		p_Writer.Write(s_Items.ArrayIndex);
		foreach (var s_Entry in Items)
		{
			s_Items.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		ScreenPosition.Serialize(p_Writer, p_EbxWriter);
	}
}

