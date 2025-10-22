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
using fb.SoldierShared;
using fb.GameShared;
using fb.Entity;

namespace fb.VeniceShared;

[ContainerType(16, 144)]
public class LaunchTomahawkActionData
	: fb.VeniceShared.CommanderActionBaseData
{
	public LaunchTomahawkActionData()
	{
		//CommanderActionBaseData
		ActionType = CommanderActionType.CommanderActionType_LaunchTomahawk;
	}
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public CtrRef<ProjectileBlueprint> Projectile { get; set; } = new();
	
	[ContainerField(0x38), JsonProperty(Order = 56)]
	public CtrRef<SoldierWeaponUnlockAsset> Weapon { get; set; } = new();
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public float InitialSpeed { get; set; } = 20.000f;
	
	[ContainerField(0x50), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public LinearTransform LaunchTransform { get; set; } = new()
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
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(Projectile));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(Weapon));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(InitialSpeed);
		p_Writer.WriteNullBytes(12);
		LaunchTransform.Serialize(p_Writer, p_EbxWriter);
	}
}

