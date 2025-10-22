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

namespace fb.VeniceShared;

[ContainerType(16, 112)]
public class VeniceGameplayLevelDescriptionComponent
	: fb.GameShared.LevelDescriptionComponent
{
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public int DefaultTeam1Faction { get; set; } = 0;
	
	[ContainerField(0x14), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
	public int DefaultTeam2Faction { get; set; } = 1;
	
	[ContainerField(0x20), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public Vec4 AdaptiveCamoColor1 { get; set; } = new()
	{
		w = 0.000f,
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x30), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public Vec4 AdaptiveCamoColor2 { get; set; } = new()
	{
		w = 0.000f,
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x40), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public Vec4 AdaptiveCamoColor3 { get; set; } = new()
	{
		w = 0.000f,
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x50), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public Vec4 AdaptiveCamoColor4 { get; set; } = new()
	{
		w = 0.000f,
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x60), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
	public int DefaultTeam3Faction { get; set; } = 0;
	
	[ContainerField(0x64), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
	public int DefaultTeam4Faction { get; set; } = 1;
	
	[ContainerField(0x68), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
	public bool AllowParachuteFromMobileSpawnpoint { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(DefaultTeam1Faction);
		p_Writer.Write(DefaultTeam2Faction);
		p_Writer.WriteNullBytes(8);
		AdaptiveCamoColor1.Serialize(p_Writer, p_EbxWriter);
		AdaptiveCamoColor2.Serialize(p_Writer, p_EbxWriter);
		AdaptiveCamoColor3.Serialize(p_Writer, p_EbxWriter);
		AdaptiveCamoColor4.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(DefaultTeam3Faction);
		p_Writer.Write(DefaultTeam4Faction);
		p_Writer.Write(AllowParachuteFromMobileSpawnpoint);
		p_Writer.WriteNullBytes(7);
	}
}

