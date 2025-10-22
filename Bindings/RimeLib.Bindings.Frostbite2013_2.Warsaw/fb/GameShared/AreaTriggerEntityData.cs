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

namespace fb.GameShared;

[ContainerType(16, 208)]
public class AreaTriggerEntityData
	: fb.GameShared.TriggerEntityData
{
	[ContainerField(0x70), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public LinearTransform GeometryTransform { get; set; } = new()
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
	
	[ContainerField(0xb0), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
	public AreaTriggerInclude Include { get; set; } = AreaTriggerInclude.ATPlayers;
	
	[ContainerField(0xb4), LayoutImmutable, Blittable, JsonProperty(Order = 180)]
	public float Radius { get; set; } = 0.000f;
	
	[ContainerField(0xb8), LayoutImmutable, Blittable, JsonProperty(Order = 184)]
	public float InsideAreaEventRepeatTime { get; set; } = 0.000f;
	
	[ContainerField(0xbc), LayoutImmutable, Blittable, JsonProperty(Order = 188)]
	public TeamId TeamOfAllies { get; set; } = TeamId.Team1;
	
	[ContainerField(0xc0), LayoutImmutable, Blittable, JsonProperty(Order = 192)]
	public bool UseCharacterEntity { get; set; } = false;
	
	[ContainerField(0xc1), LayoutImmutable, Blittable, JsonProperty(Order = 193)]
	public bool UseRadiusWithGeometryTransform { get; set; } = false;
	
	[ContainerField(0xc2), LayoutImmutable, Blittable, JsonProperty(Order = 194)]
	public bool OneInsideAreaEventPerSoldier { get; set; } = false;
	
	[ContainerField(0xc3), LayoutImmutable, Blittable, JsonProperty(Order = 195)]
	public bool TriggerOnlyOnLeave { get; set; } = false;
	
	[ContainerField(0xc4), LayoutImmutable, Blittable, JsonProperty(Order = 196)]
	public bool ResetOnEnable { get; set; } = false;
	
	[ContainerField(0xc5), LayoutImmutable, Blittable, JsonProperty(Order = 197)]
	public bool TriggerOnLeaveOnDeath { get; set; } = true;
	
	[ContainerField(0xc6), LayoutImmutable, Blittable, JsonProperty(Order = 198)]
	public bool TriggerOnLeaveOnDisable { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		GeometryTransform.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) Include);
		p_Writer.Write(Radius);
		p_Writer.Write(InsideAreaEventRepeatTime);
		p_Writer.Write((int) TeamOfAllies);
		p_Writer.Write(UseCharacterEntity);
		p_Writer.Write(UseRadiusWithGeometryTransform);
		p_Writer.Write(OneInsideAreaEventPerSoldier);
		p_Writer.Write(TriggerOnlyOnLeave);
		p_Writer.Write(ResetOnEnable);
		p_Writer.Write(TriggerOnLeaveOnDeath);
		p_Writer.Write(TriggerOnLeaveOnDisable);
		p_Writer.WriteNullBytes(9);
	}
}

