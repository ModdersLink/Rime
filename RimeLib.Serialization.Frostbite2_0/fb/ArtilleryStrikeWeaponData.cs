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
	[ContainerType(4, 92)]
	public partial class ArtilleryStrikeWeaponData :
		WeaponData
	{
		[ObservableProperty]
		[property: ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private float _MaxStrikeDistance;

		[ObservableProperty]
		[property: ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		private float _StrikeRadius;

		[ObservableProperty]
		[property: ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		private float _SpawnHeight;

		[ObservableProperty]
		[property: ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		private float _MaxRandomSpawnHeight;

		[ObservableProperty]
		[property: ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		private float _StrikeCameraOffset;

		[ObservableProperty]
		[property: ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		private float _SpawnHeightMultiplier;

		[ObservableProperty]
		[property: ContainerField(40), JsonProperty(Order = 40)]
		private CtrRef<TargetCameraData> _Camera = new();

		[ObservableProperty]
		[property: ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		private float _AimingCameraHeight;

		[ObservableProperty]
		[property: ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		private float _StrikeCameraHeight;

		[ObservableProperty]
		[property: ContainerField(52), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
		private float _AimingCameraOffset;

		[ObservableProperty]
		[property: ContainerField(56), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
		private float _StrikeCameraFov;

		[ObservableProperty]
		[property: ContainerField(60), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
		private float _AimingCameraFov;

		[ObservableProperty]
		[property: ContainerField(64), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		private float _DelayBeforeAimingCamera;

		[ObservableProperty]
		[property: ContainerField(68), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
		private float _ValidMinDistance;

		[ObservableProperty]
		[property: ContainerField(72), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
		private float _FireCameraTime;

		[ObservableProperty]
		[property: ContainerField(76), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
		private float _StrikeCameraTime;

		[ObservableProperty]
		[property: ContainerField(80), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
		private float _ValidMaxDistance;

		[ObservableProperty]
		[property: ContainerField(84), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
		private float _ValidMaxAngle;

		[ObservableProperty]
		[property: ContainerField(88), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
		private bool _IncreaseSpawnHeightWithDistance;

		[ObservableProperty]
		[property: ContainerField(89), LayoutImmutable, Blittable, JsonProperty(Order = 89)]
		private bool _EnableProjectileTrails;

		[ObservableProperty]
		[property: ContainerField(90), LayoutImmutable, Blittable, JsonProperty(Order = 90)]
		private bool _EnableCameraRotation;

		[ObservableProperty]
		[property: ContainerField(91), LayoutImmutable, Blittable, JsonProperty(Order = 91)]
		private bool _FireProjectileFromWeapon;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(MaxStrikeDistance);
			p_Writer.Write(StrikeRadius);
			p_Writer.Write(SpawnHeight);
			p_Writer.Write(MaxRandomSpawnHeight);
			p_Writer.Write(StrikeCameraOffset);
			p_Writer.Write(SpawnHeightMultiplier);
			p_Writer.Write(p_EbxWriter.WriteImport(Camera));
			p_Writer.Write(AimingCameraHeight);
			p_Writer.Write(StrikeCameraHeight);
			p_Writer.Write(AimingCameraOffset);
			p_Writer.Write(StrikeCameraFov);
			p_Writer.Write(AimingCameraFov);
			p_Writer.Write(DelayBeforeAimingCamera);
			p_Writer.Write(ValidMinDistance);
			p_Writer.Write(FireCameraTime);
			p_Writer.Write(StrikeCameraTime);
			p_Writer.Write(ValidMaxDistance);
			p_Writer.Write(ValidMaxAngle);
			p_Writer.Write(IncreaseSpawnHeightWithDistance);
			p_Writer.Write(EnableProjectileTrails);
			p_Writer.Write(EnableCameraRotation);
			p_Writer.Write(FireProjectileFromWeapon);
		}
	}
}
