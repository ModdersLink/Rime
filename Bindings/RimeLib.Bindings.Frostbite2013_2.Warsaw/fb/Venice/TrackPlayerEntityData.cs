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

namespace fb.Venice;

[ContainerType(16, 128)]
public class TrackPlayerEntityData
	: fb.Entity.SpatialEntityData
{
	[ContainerField(0x60), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
	public float SnapHeightOffsetY { get; set; } = 1.300f;
	
	[ContainerField(0x64), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
	public TrackPlayerEntityType TrackPlayerType { get; set; } = TrackPlayerEntityType.TrackPlayerEntityType_None;
	
	[ContainerField(0x68), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
	public bool RandomizeTracker { get; set; } = false;
	
	[ContainerField(0x69), LayoutImmutable, Blittable, JsonProperty(Order = 105)]
	public bool Enabled { get; set; } = true;
	
	[ContainerField(0x6a), LayoutImmutable, Blittable, JsonProperty(Order = 106)]
	public bool SnapHeightOnKilledDestroyed { get; set; } = false;
	
	[ContainerField(0x6b), LayoutImmutable, Blittable, JsonProperty(Order = 107)]
	public bool SnapToExitPointOnVehicleDeath { get; set; } = false;
	
	[ContainerField(0x6c), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
	public bool CheckPlayerAlive { get; set; } = false;
	
	[ContainerField(0x6d), LayoutImmutable, Blittable, JsonProperty(Order = 109)]
	public bool EnforceSharedCombatArea { get; set; } = false;
	
	[ContainerField(0x6e), LayoutImmutable, Blittable, JsonProperty(Order = 110)]
	public bool UpdateFlagComponent { get; set; } = false;
	
	[ContainerField(0x6f), LayoutImmutable, Blittable, JsonProperty(Order = 111)]
	public bool TrackMultiplePlayers { get; set; } = false;
	
	[ContainerField(0x70), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public bool Reset { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(SnapHeightOffsetY);
		p_Writer.Write((int) TrackPlayerType);
		p_Writer.Write(RandomizeTracker);
		p_Writer.Write(Enabled);
		p_Writer.Write(SnapHeightOnKilledDestroyed);
		p_Writer.Write(SnapToExitPointOnVehicleDeath);
		p_Writer.Write(CheckPlayerAlive);
		p_Writer.Write(EnforceSharedCombatArea);
		p_Writer.Write(UpdateFlagComponent);
		p_Writer.Write(TrackMultiplePlayers);
		p_Writer.Write(Reset);
		p_Writer.WriteNullBytes(15);
	}
}

