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
using RimeLib.Serialization.Ebx;
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(16, 192)]
	public class VehicleProjectileEntityData :
		ProjectileEntityData
	{
		[ContainerField(160), JsonProperty(Order = 160)]
		public CtrRef<VehicleBlueprint> Vehicle { get; set; } = new();

		[ContainerField(164), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
		public float EnterDelay { get; set; }

		[ContainerField(168), LayoutImmutable, Blittable, JsonProperty(Order = 168)]
		public float NoVehicleCollisionTime { get; set; }

		[ContainerField(172), LayoutImmutable, Blittable, JsonProperty(Order = 172)]
		public float AlignWithGroundRayLength { get; set; }

		[ContainerField(176), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
		public bool AutoEnter { get; set; }

		[ContainerField(177), LayoutImmutable, Blittable, JsonProperty(Order = 177)]
		public bool AlignWithGround { get; set; }

		[ContainerField(178), LayoutImmutable, Blittable, JsonProperty(Order = 178)]
		public bool CheckGroundWhenSpawned { get; set; }

		[ContainerField(179), LayoutImmutable, Blittable, JsonProperty(Order = 179)]
		public bool DeployInsideNeutralCombatAreaOnly { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(Vehicle));
			p_Writer.Write(EnterDelay);
			p_Writer.Write(NoVehicleCollisionTime);
			p_Writer.Write(AlignWithGroundRayLength);
			p_Writer.Write(AutoEnter);
			p_Writer.Write(AlignWithGround);
			p_Writer.Write(CheckGroundWhenSpawned);
			p_Writer.Write(DeployInsideNeutralCombatAreaOnly);
			p_Writer.WriteNullBytes(12);
		}
	}
}
