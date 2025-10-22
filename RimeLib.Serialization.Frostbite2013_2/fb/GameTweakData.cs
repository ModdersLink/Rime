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

namespace fb.BFAI2Data;

[ContainerType(8, 360)]
public class GameTweakData
	: fb.GameShared.GameAIDifficultyData
{
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public GameTweakCommon Common { get; set; } = new();
	
	[ContainerField(0x98), JsonProperty(Order = 152)]
	public GameTweakAITargeting AITargeting { get; set; } = new();
	
	[ContainerField(0xfc), JsonProperty(Order = 252)]
	public GameTweakAIDamage AIDamage { get; set; } = new();
	
	[ContainerField(0x108), JsonProperty(Order = 264)]
	public GameTweakBucketDamage BucketDamage { get; set; } = new();
	
	[ContainerField(0x140), JsonProperty(Order = 320)]
	public GameTweakSniper Sniper { get; set; } = new();
	
	[ContainerField(0x150), JsonProperty(Order = 336)]
	public GameTweakPanicBehavior Panic { get; set; } = new();
	
	[ContainerField(0x15c), JsonProperty(Order = 348)]
	public GameTweakBlindedBehavior Blinded { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		Common.Serialize(p_Writer, p_EbxWriter);
		AITargeting.Serialize(p_Writer, p_EbxWriter);
		AIDamage.Serialize(p_Writer, p_EbxWriter);
		BucketDamage.Serialize(p_Writer, p_EbxWriter);
		Sniper.Serialize(p_Writer, p_EbxWriter);
		Panic.Serialize(p_Writer, p_EbxWriter);
		Blinded.Serialize(p_Writer, p_EbxWriter);
		p_Writer.WriteNullBytes(4);
	}
}

