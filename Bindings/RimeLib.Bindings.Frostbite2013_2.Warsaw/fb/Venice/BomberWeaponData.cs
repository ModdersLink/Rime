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
using fb.GameShared;

namespace fb.Venice;

[ContainerType(8, 80)]
public class BomberWeaponData
	: fb.GameShared.LockingWeaponData
{
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public float MaxPitchAngle { get; set; } = 0.000f;
	
	[ContainerField(0x44), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
	public float MinPitchAngle { get; set; } = 0.000f;
	
	[ContainerField(0x48), JsonProperty(Order = 72)]
	public CtrRef<PrefabBlueprint> MapMarkerPrefabBlueprint { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(MaxPitchAngle);
		p_Writer.Write(MinPitchAngle);
		p_Writer.Write(p_EbxWriter.WriteImport(MapMarkerPrefabBlueprint));
		p_Writer.WriteNullBytes(4);
	}
}

