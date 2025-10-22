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

[ContainerType(8, 56)]
public class UnlockEntityData
	: fb.Entity.EntityData
{
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public Realm Realm { get; set; } = fb.Core.Realm.Realm_Server;
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public List<GUID> UnlockGuids { get; set; } = new();
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public UnlockEntityLogic Logic { get; set; } = UnlockEntityLogic.UnlockEntityLogic_AND;
	
	[ContainerField(0x2c), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
	public UnlockEntityPlayerQueryType ContextPlayerQueryType { get; set; } = UnlockEntityPlayerQueryType.UnlockEntityPlayerQueryType_ActiveWeaponUnlocks;
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public bool ServerUsePrevIfNoCurrChar { get; set; } = false;
	
	[ContainerField(0x31), LayoutImmutable, Blittable, JsonProperty(Order = 49)]
	public bool InvertTest { get; set; } = false;
	
	[ContainerField(0x32), LayoutImmutable, Blittable, JsonProperty(Order = 50)]
	public bool ContextPlayer { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) Realm);
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_UnlockGuids = p_EbxWriter.GetArrayWriter(UnlockGuids.GetType(), UnlockGuids.Count);
		p_Writer.Write(s_UnlockGuids.ArrayIndex);
		foreach (var s_Entry in UnlockGuids)
		{
			s_Entry.Serialize(s_UnlockGuids.Writer);
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write((int) Logic);
		p_Writer.Write((int) ContextPlayerQueryType);
		p_Writer.Write(ServerUsePrevIfNoCurrChar);
		p_Writer.Write(InvertTest);
		p_Writer.Write(ContextPlayer);
		p_Writer.WriteNullBytes(5);
	}
}

