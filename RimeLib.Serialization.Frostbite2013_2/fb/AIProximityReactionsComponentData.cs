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
using fb.VeniceShared;
using fb.Entity;

namespace fb.Venice;

[ContainerType(16, 688)]
public class AIProximityReactionsComponentData
	: fb.Entity.GameComponentData
{
	[ContainerField(0x70), JsonProperty(Order = 112)]
	public AIProximityReactionsBinding Binding { get; set; } = new();
	
	[ContainerField(0x28c), LayoutImmutable, Blittable, JsonProperty(Order = 652)]
	public float MinExplosionImpulseForce { get; set; } = 10.000f;
	
	[ContainerField(0x290), LayoutImmutable, Blittable, JsonProperty(Order = 656)]
	public float MaxExplosionLookDistance { get; set; } = 100.000f;
	
	[ContainerField(0x294), LayoutImmutable, Blittable, JsonProperty(Order = 660)]
	public float FireReactionDistance { get; set; } = 5.000f;
	
	[ContainerField(0x298), LayoutImmutable, Blittable, JsonProperty(Order = 664)]
	public float DrasticAimYawAmount { get; set; } = 50.000f;
	
	[ContainerField(0x2a0), JsonProperty(Order = 672)]
	public List<LookAtHuman> LookAtHumanTiming { get; set; } = new();
	
	[ContainerField(0x2a8), LayoutImmutable, Blittable, JsonProperty(Order = 680)]
	public bool UseLocalPlayer { get; set; } = false;
	
	[ContainerField(0x2a9), LayoutImmutable, Blittable, JsonProperty(Order = 681)]
	public bool Enabled { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		Binding.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(MinExplosionImpulseForce);
		p_Writer.Write(MaxExplosionLookDistance);
		p_Writer.Write(FireReactionDistance);
		p_Writer.Write(DrasticAimYawAmount);
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_LookAtHumanTiming = p_EbxWriter.GetArrayWriter(LookAtHumanTiming.GetType(), LookAtHumanTiming.Count);
		p_Writer.Write(s_LookAtHumanTiming.ArrayIndex);
		foreach (var s_Entry in LookAtHumanTiming)
		{
			s_Entry.Serialize(s_LookAtHumanTiming.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(UseLocalPlayer);
		p_Writer.Write(Enabled);
		p_Writer.WriteNullBytes(6);
	}
}

