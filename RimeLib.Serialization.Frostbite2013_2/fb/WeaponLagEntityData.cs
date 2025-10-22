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

namespace fb.SoldierShared;

[ContainerType(8, 128)]
public class WeaponLagEntityData
	: fb.Entity.EntityData
{
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public WeaponLagBinding Binding { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		Binding.Serialize(p_Writer, p_EbxWriter);
		p_Writer.WriteNullBytes(4);
	}
}

