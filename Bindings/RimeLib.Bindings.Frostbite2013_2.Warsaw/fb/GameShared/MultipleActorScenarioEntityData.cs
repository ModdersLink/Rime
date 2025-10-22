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
using fb.Ant;
using fb.Entity;

namespace fb.GameShared;

[ContainerType(16, 288)]
public class MultipleActorScenarioEntityData
	: fb.Entity.SpatialEntityData
{
	[ContainerField(0x60), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 96)]
	public LinearTransform WorldSpaceConnectTransform { get; set; } = new()
	{
		trans = new()
		{
			z = 0.000f,
			y = 0.000f,
			x = 0.000f,
		},
		up = new()
		{
			z = 0.000f,
			y = 1.000f,
			x = 0.000f,
		},
		forward = new()
		{
			z = 1.000f,
			y = 0.000f,
			x = 0.000f,
		},
		right = new()
		{
			z = 0.000f,
			y = 0.000f,
			x = 1.000f,
		},
	};
	
	[ContainerField(0xa0), JsonProperty(Order = 160)]
	public AntRef ScenarioAntRef { get; set; } = new();
	
	[ContainerField(0xb4), LayoutImmutable, Blittable, JsonProperty(Order = 180)]
	public int LevelChoice { get; set; } = -1;
	
	[ContainerField(0xb8), LayoutImmutable, Blittable, JsonProperty(Order = 184)]
	public int ScenarioChoice { get; set; } = -1;
	
	[ContainerField(0xbc), LayoutImmutable, Blittable, JsonProperty(Order = 188)]
	public int Actor1 { get; set; } = -1;
	
	[ContainerField(0xc0), LayoutImmutable, Blittable, JsonProperty(Order = 192)]
	public int Actor1Part { get; set; } = -1;
	
	[ContainerField(0xc4), LayoutImmutable, Blittable, JsonProperty(Order = 196)]
	public int Actor1SecondPart { get; set; } = -1;
	
	[ContainerField(0xc8), LayoutImmutable, Blittable, JsonProperty(Order = 200)]
	public int Actor2 { get; set; } = -1;
	
	[ContainerField(0xcc), LayoutImmutable, Blittable, JsonProperty(Order = 204)]
	public int Actor2Part { get; set; } = -1;
	
	[ContainerField(0xd0), LayoutImmutable, Blittable, JsonProperty(Order = 208)]
	public int Actor2SecondPart { get; set; } = -1;
	
	[ContainerField(0xd4), LayoutImmutable, Blittable, JsonProperty(Order = 212)]
	public int Actor3 { get; set; } = -1;
	
	[ContainerField(0xd8), LayoutImmutable, Blittable, JsonProperty(Order = 216)]
	public int Actor3Part { get; set; } = -1;
	
	[ContainerField(0xdc), LayoutImmutable, Blittable, JsonProperty(Order = 220)]
	public int Actor3SecondPart { get; set; } = -1;
	
	[ContainerField(0xe0), LayoutImmutable, Blittable, JsonProperty(Order = 224)]
	public int Actor4 { get; set; } = -1;
	
	[ContainerField(0xe4), LayoutImmutable, Blittable, JsonProperty(Order = 228)]
	public int Actor4Part { get; set; } = -1;
	
	[ContainerField(0xe8), LayoutImmutable, Blittable, JsonProperty(Order = 232)]
	public int Actor4SecondPart { get; set; } = -1;
	
	[ContainerField(0xec), LayoutImmutable, Blittable, JsonProperty(Order = 236)]
	public int Actor5 { get; set; } = -1;
	
	[ContainerField(0xf0), LayoutImmutable, Blittable, JsonProperty(Order = 240)]
	public int Actor5Part { get; set; } = -1;
	
	[ContainerField(0xf4), LayoutImmutable, Blittable, JsonProperty(Order = 244)]
	public int Actor5SecondPart { get; set; } = -1;
	
	[ContainerField(0xf8), LayoutImmutable, Blittable, JsonProperty(Order = 248)]
	public int Actor6 { get; set; } = -1;
	
	[ContainerField(0xfc), LayoutImmutable, Blittable, JsonProperty(Order = 252)]
	public int Actor6Part { get; set; } = -1;
	
	[ContainerField(0x100), LayoutImmutable, Blittable, JsonProperty(Order = 256)]
	public int Actor6SecondPart { get; set; } = -1;
	
	[ContainerField(0x104), LayoutImmutable, Blittable, JsonProperty(Order = 260)]
	public float ExternalTime { get; set; } = -1.000f;
	
	[ContainerField(0x108), LayoutImmutable, Blittable, JsonProperty(Order = 264)]
	public Realm Realm { get; set; } = fb.Core.Realm.Realm_Client;
	
	[ContainerField(0x10c), LayoutImmutable, Blittable, JsonProperty(Order = 268)]
	public bool WorldSpace { get; set; } = false;
	
	[ContainerField(0x10d), LayoutImmutable, Blittable, JsonProperty(Order = 269)]
	public bool AligningEnabled { get; set; } = true;
	
	[ContainerField(0x10e), LayoutImmutable, Blittable, JsonProperty(Order = 270)]
	public bool UseInputEventPlayerAsPlayer1 { get; set; } = false;
	
	[ContainerField(0x10f), LayoutImmutable, Blittable, JsonProperty(Order = 271)]
	public bool ScenarioActive { get; set; } = false;
	
	[ContainerField(0x110), LayoutImmutable, Blittable, JsonProperty(Order = 272)]
	public bool Actor1Prepared { get; set; } = true;
	
	[ContainerField(0x111), LayoutImmutable, Blittable, JsonProperty(Order = 273)]
	public bool Actor2Prepared { get; set; } = true;
	
	[ContainerField(0x112), LayoutImmutable, Blittable, JsonProperty(Order = 274)]
	public bool Actor3Prepared { get; set; } = true;
	
	[ContainerField(0x113), LayoutImmutable, Blittable, JsonProperty(Order = 275)]
	public bool Actor4Prepared { get; set; } = true;
	
	[ContainerField(0x114), LayoutImmutable, Blittable, JsonProperty(Order = 276)]
	public bool Actor5Prepared { get; set; } = true;
	
	[ContainerField(0x115), LayoutImmutable, Blittable, JsonProperty(Order = 277)]
	public bool Actor6Prepared { get; set; } = true;
	
	[ContainerField(0x116), LayoutImmutable, Blittable, JsonProperty(Order = 278)]
	public bool CheckActor1Finished { get; set; } = true;
	
	[ContainerField(0x117), LayoutImmutable, Blittable, JsonProperty(Order = 279)]
	public bool CheckActor2Finished { get; set; } = true;
	
	[ContainerField(0x118), LayoutImmutable, Blittable, JsonProperty(Order = 280)]
	public bool CheckActor3Finished { get; set; } = true;
	
	[ContainerField(0x119), LayoutImmutable, Blittable, JsonProperty(Order = 281)]
	public bool CheckActor4Finished { get; set; } = true;
	
	[ContainerField(0x11a), LayoutImmutable, Blittable, JsonProperty(Order = 282)]
	public bool CheckActor5Finished { get; set; } = true;
	
	[ContainerField(0x11b), LayoutImmutable, Blittable, JsonProperty(Order = 283)]
	public bool CheckActor6Finished { get; set; } = true;
	
	[ContainerField(0x11c), LayoutImmutable, Blittable, JsonProperty(Order = 284)]
	public bool UseExternalTime { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		WorldSpaceConnectTransform.Serialize(p_Writer, p_EbxWriter);
		ScenarioAntRef.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(LevelChoice);
		p_Writer.Write(ScenarioChoice);
		p_Writer.Write(Actor1);
		p_Writer.Write(Actor1Part);
		p_Writer.Write(Actor1SecondPart);
		p_Writer.Write(Actor2);
		p_Writer.Write(Actor2Part);
		p_Writer.Write(Actor2SecondPart);
		p_Writer.Write(Actor3);
		p_Writer.Write(Actor3Part);
		p_Writer.Write(Actor3SecondPart);
		p_Writer.Write(Actor4);
		p_Writer.Write(Actor4Part);
		p_Writer.Write(Actor4SecondPart);
		p_Writer.Write(Actor5);
		p_Writer.Write(Actor5Part);
		p_Writer.Write(Actor5SecondPart);
		p_Writer.Write(Actor6);
		p_Writer.Write(Actor6Part);
		p_Writer.Write(Actor6SecondPart);
		p_Writer.Write(ExternalTime);
		p_Writer.Write((int) Realm);
		p_Writer.Write(WorldSpace);
		p_Writer.Write(AligningEnabled);
		p_Writer.Write(UseInputEventPlayerAsPlayer1);
		p_Writer.Write(ScenarioActive);
		p_Writer.Write(Actor1Prepared);
		p_Writer.Write(Actor2Prepared);
		p_Writer.Write(Actor3Prepared);
		p_Writer.Write(Actor4Prepared);
		p_Writer.Write(Actor5Prepared);
		p_Writer.Write(Actor6Prepared);
		p_Writer.Write(CheckActor1Finished);
		p_Writer.Write(CheckActor2Finished);
		p_Writer.Write(CheckActor3Finished);
		p_Writer.Write(CheckActor4Finished);
		p_Writer.Write(CheckActor5Finished);
		p_Writer.Write(CheckActor6Finished);
		p_Writer.Write(UseExternalTime);
		p_Writer.WriteNullBytes(3);
	}
}

