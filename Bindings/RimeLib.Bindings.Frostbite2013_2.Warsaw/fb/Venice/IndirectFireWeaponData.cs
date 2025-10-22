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

namespace fb.Venice;

[ContainerType(8, 64)]
public class IndirectFireWeaponData
	: fb.GameShared.WeaponData
{
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public IndirectFireDispersionData Dispersion { get; set; } = new();
	
	[ContainerField(0x3c), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
	public float DelayBeforeAimingCamera { get; set; } = 1.000f;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		Dispersion.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(DelayBeforeAimingCamera);
	}
}

