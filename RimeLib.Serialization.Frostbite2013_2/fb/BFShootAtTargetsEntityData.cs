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

using fb.VeniceShared;
using fb.Core;
using fb.Entity;

namespace fb.BFAI2Data;

[ContainerType(8, 48)]
public class BFShootAtTargetsEntityData
	: fb.BFAI2Data.BFParameterEntityData
{
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public AI2ShootType ShootType { get; set; } = AI2ShootType.AI2ShootType_Continuous;
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public AICombatIntensity CombatIntensity { get; set; } = AICombatIntensity.AICombatIntensity_None;
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public bool CycleTargets { get; set; } = false;
	
	[ContainerField(0x29), LayoutImmutable, Blittable, JsonProperty(Order = 41)]
	public bool RandomTargetOrder { get; set; } = false;
	
	[ContainerField(0x2a), LayoutImmutable, Blittable, JsonProperty(Order = 42)]
	public bool DisableOnSoldierEngaged { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) ShootType);
		p_Writer.Write((int) CombatIntensity);
		p_Writer.Write(CycleTargets);
		p_Writer.Write(RandomTargetOrder);
		p_Writer.Write(DisableOnSoldierEngaged);
		p_Writer.WriteNullBytes(5);
	}
}

