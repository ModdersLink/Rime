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

namespace fb.Venice;

[ContainerType(8, 56)]
public class MultipleTargetPainterWeaponData
	: fb.GameShared.WeaponData
{
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public float TimeObjectIsPainted { get; set; } = 15.000f;
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public SpottingType SpottingBehavior { get; set; } = SpottingType.STDefault;
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public float TimeObjectIsSpotted { get; set; } = 30.000f;
	
	[ContainerField(0x2c), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
	public float Range { get; set; } = 1000.000f;
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public float Angle { get; set; } = 15.000f;
	
	[ContainerField(0x34), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
	public bool UseLaserPainting { get; set; } = false;
	
	[ContainerField(0x35), LayoutImmutable, Blittable, JsonProperty(Order = 53)]
	public bool UseSpotting { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(TimeObjectIsPainted);
		p_Writer.Write((int) SpottingBehavior);
		p_Writer.Write(TimeObjectIsSpotted);
		p_Writer.Write(Range);
		p_Writer.Write(Angle);
		p_Writer.Write(UseLaserPainting);
		p_Writer.Write(UseSpotting);
		p_Writer.WriteNullBytes(2);
	}
}

