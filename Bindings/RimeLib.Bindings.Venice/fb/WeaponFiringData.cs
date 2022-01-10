///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4, 64)]
	public class WeaponFiringData : 
		GameDataContainer
	{
		[ContainerField(8)]
		public CtrRef<FiringFunctionData> PrimaryFire { get; set; } = new();

		[ContainerField(12), LayoutImmutable, Blittable]
		public float DeployTime { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable]
		public float ReactivateCooldownTime { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public float DisableZoomOnDeployTime { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public float AltDeployTime { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable]
		public int AltDeployId { get; set; }

		[ContainerField(32)]
		public CtrRef<WeaponSwayData> WeaponSway { get; set; } = new();

		[ContainerField(36), LayoutImmutable, Blittable]
		public float SupportDelayProne { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable]
		public float SupportDelayStand { get; set; }

		[ContainerField(44)]
		public RumbleFiringData Rumble { get; set; } = new();

		[ContainerField(56), LayoutImmutable, Blittable]
		public bool InflictSelfDamage { get; set; }

		[ContainerField(57), LayoutImmutable, Blittable]
		public bool UseAutoAiming { get; set; }

		[ContainerField(58), LayoutImmutable, Blittable]
		public bool ShowEnemyNametagOnAim { get; set; }

		[ContainerField(59), LayoutImmutable, Blittable]
		public bool ReloadWholeMags { get; set; }

		[ContainerField(60), LayoutImmutable, Blittable]
		public bool DisableReloadWhileSprinting { get; set; }

		[ContainerField(61), LayoutImmutable, Blittable]
		public bool AbortReloadOnSprint { get; set; }

		public static void Deserialize(WeaponFiringData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.PrimaryFire.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.DeployTime = p_Reader.ReadSingle();
			p_Instance.ReactivateCooldownTime = p_Reader.ReadSingle();
			p_Instance.DisableZoomOnDeployTime = p_Reader.ReadSingle();
			p_Instance.AltDeployTime = p_Reader.ReadSingle();
			p_Instance.AltDeployId = p_Reader.ReadInt32();
			p_Instance.WeaponSway.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.SupportDelayProne = p_Reader.ReadSingle();
			p_Instance.SupportDelayStand = p_Reader.ReadSingle();
			fb.RumbleFiringData.Deserialize(p_Instance.Rumble, p_Reader, p_Parser);
			p_Instance.InflictSelfDamage = p_Reader.ReadBool();
			p_Instance.UseAutoAiming = p_Reader.ReadBool();
			p_Instance.ShowEnemyNametagOnAim = p_Reader.ReadBool();
			p_Instance.ReloadWholeMags = p_Reader.ReadBool();
			p_Instance.DisableReloadWhileSprinting = p_Reader.ReadBool();
			p_Instance.AbortReloadOnSprint = p_Reader.ReadBool();
			p_Reader.Seek(2, SeekOrigin.Current);
		}

	}
}
