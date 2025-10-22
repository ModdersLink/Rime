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
using fb.UI;

namespace fb.VeniceShared;

[ContainerType(8, 64)]
public class UIWeaponCompData
	: fb.UI.UIComponentData
{
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public float MinHitIndicatorLimit { get; set; } = 0.000f;
	
	[ContainerField(0x34), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
	public float NormalHitIndicatorLimit { get; set; } = 25.000f;
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public float MaxHitIndicatorLimit { get; set; } = 50.000f;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(MinHitIndicatorLimit);
		p_Writer.Write(NormalHitIndicatorLimit);
		p_Writer.Write(MaxHitIndicatorLimit);
		p_Writer.WriteNullBytes(4);
	}
}

