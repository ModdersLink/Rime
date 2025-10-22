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

using fb.Entity;
using fb.Core;
using fb.Physics;

namespace fb.GameShared;

[ContainerType(16, 128)]
public class GamePhysicsComponentData
	: fb.Physics.PhysicsComponentData
{
	[ContainerField(0x70), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public Realm Realm { get; set; } = fb.Core.Realm.Realm_ClientAndServer;
	
	[ContainerField(0x78), JsonProperty(Order = 120)]
	public RefArray<EffectParameter> EffectParameters { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) Realm);
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_EffectParameters = p_EbxWriter.GetArrayWriter(EffectParameters.GetType(), EffectParameters.Count);
		p_Writer.Write(s_EffectParameters.ArrayIndex);
		foreach (var s_Entry in EffectParameters)
		{
			s_EffectParameters.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
	}
}

