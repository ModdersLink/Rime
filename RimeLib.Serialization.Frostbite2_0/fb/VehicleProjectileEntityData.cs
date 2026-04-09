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
using RimeLib.Serialization.Frostbite2_0.Ebx;
using CommunityToolkit.Mvvm.ComponentModel;

namespace fb
{
	[ContainerType(16, 192)]
	public partial class VehicleProjectileEntityData :
		ProjectileEntityData
	{
		[ObservableProperty]
		[property: ContainerField(160), JsonProperty(Order = 160)]
		private CtrRef<VehicleBlueprint> _Vehicle = new();

		[ObservableProperty]
		[property: ContainerField(164), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
		private float _EnterDelay;

		[ObservableProperty]
		[property: ContainerField(168), LayoutImmutable, Blittable, JsonProperty(Order = 168)]
		private float _NoVehicleCollisionTime;

		[ObservableProperty]
		[property: ContainerField(172), LayoutImmutable, Blittable, JsonProperty(Order = 172)]
		private float _AlignWithGroundRayLength;

		[ObservableProperty]
		[property: ContainerField(176), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
		private bool _AutoEnter;

		[ObservableProperty]
		[property: ContainerField(177), LayoutImmutable, Blittable, JsonProperty(Order = 177)]
		private bool _AlignWithGround;

		[ObservableProperty]
		[property: ContainerField(178), LayoutImmutable, Blittable, JsonProperty(Order = 178)]
		private bool _CheckGroundWhenSpawned;

		[ObservableProperty]
		[property: ContainerField(179), LayoutImmutable, Blittable, JsonProperty(Order = 179)]
		private bool _DeployInsideNeutralCombatAreaOnly;

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
