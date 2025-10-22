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

using fb.GameShared;
using fb.Core;
using fb.Render;
using fb.Entity;
using fb.Physics;

namespace fb.SoldierShared;

[ContainerType(16, 416)]
public class MedicBagHealingSphereEntityData
	: fb.SoldierShared.ExplosionPackEntityData
{
	[ContainerField(0x190), JsonProperty(Order = 400)]
	public HealingSphereData Healer { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		Healer.Serialize(p_Writer, p_EbxWriter);
		p_Writer.WriteNullBytes(8);
	}
}

