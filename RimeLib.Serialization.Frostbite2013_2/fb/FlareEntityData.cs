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
using fb.GameShared;
using fb.Render;
using fb.Entity;
using fb.Physics;

namespace fb.SoldierShared;

[ContainerType(16, 368)]
public class FlareEntityData
	: fb.SoldierShared.GrenadeEntityData
{
	[ContainerField(0x160), LayoutImmutable, Blittable, JsonProperty(Order = 352)]
	public float FlareRange { get; set; } = 5.000f;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(FlareRange);
		p_Writer.WriteNullBytes(12);
	}
}

