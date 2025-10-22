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

namespace fb.BFAI2Data;

[ContainerType(8, 48)]
public class BFCombatBehaviorEntityData
	: fb.BFAI2Data.BFParameterEntityData
{
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public CombatEnvironment CombatEnvironment { get; set; } = fb.BFAI2Data.CombatEnvironment.CombatEnvironment_Default;
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public bool AllowFire { get; set; } = true;
	
	[ContainerField(0x25), LayoutImmutable, Blittable, JsonProperty(Order = 37)]
	public bool AllowFireDuringScriptedAnimations { get; set; } = false;
	
	[ContainerField(0x26), LayoutImmutable, Blittable, JsonProperty(Order = 38)]
	public bool AllowDetectHuman { get; set; } = true;
	
	[ContainerField(0x27), LayoutImmutable, Blittable, JsonProperty(Order = 39)]
	public bool LessAggressiveToHuman { get; set; } = false;
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public bool IsOnHumanSquad { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) CombatEnvironment);
		p_Writer.Write(AllowFire);
		p_Writer.Write(AllowFireDuringScriptedAnimations);
		p_Writer.Write(AllowDetectHuman);
		p_Writer.Write(LessAggressiveToHuman);
		p_Writer.Write(IsOnHumanSquad);
		p_Writer.WriteNullBytes(7);
	}
}

