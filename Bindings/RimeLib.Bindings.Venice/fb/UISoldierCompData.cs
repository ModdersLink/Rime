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
	[ContainerType(4, 76)]
	public class UISoldierCompData : 
		UIComponentData
	{
		[ContainerField(28), LayoutImmutable, Blittable]
		public float CriticalHealthThreshold { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable]
		public float HitShaderDamageMultiplier { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable]
		public float HitShaderMinDamage { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable]
		public float EKGLineThickness { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable]
		public int ShockTraumaAbilityIndex { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable]
		public int RangerPTProgramAbilityIndex { get; set; }

		[ContainerField(52), LayoutImmutable, Blittable]
		public int FocusAbilityIndex { get; set; }

		[ContainerField(56), LayoutImmutable, Blittable]
		public float EKGLineAlpha { get; set; }

		[ContainerField(60), LayoutImmutable, Blittable]
		public float HitShaderGradientDurationMultiplier { get; set; }

		[ContainerField(64), LayoutImmutable, Blittable]
		public float HitShaderMaxDamage { get; set; }

		[ContainerField(68), LayoutImmutable, Blittable]
		public float HitShaderIndicatorDurationMultiplier { get; set; }

		[ContainerField(72), LayoutImmutable, Blittable]
		public bool UseVehicleTeamSpawn { get; set; }

		[ContainerField(73), LayoutImmutable, Blittable]
		public bool UseSquadSpawn { get; set; }

		[ContainerField(74), LayoutImmutable, Blittable]
		public bool SpawnOnSquadLeaders { get; set; }

		public static void Deserialize(UISoldierCompData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.CriticalHealthThreshold = p_Reader.ReadSingle();
			p_Instance.HitShaderDamageMultiplier = p_Reader.ReadSingle();
			p_Instance.HitShaderMinDamage = p_Reader.ReadSingle();
			p_Instance.EKGLineThickness = p_Reader.ReadSingle();
			p_Instance.ShockTraumaAbilityIndex = p_Reader.ReadInt32();
			p_Instance.RangerPTProgramAbilityIndex = p_Reader.ReadInt32();
			p_Instance.FocusAbilityIndex = p_Reader.ReadInt32();
			p_Instance.EKGLineAlpha = p_Reader.ReadSingle();
			p_Instance.HitShaderGradientDurationMultiplier = p_Reader.ReadSingle();
			p_Instance.HitShaderMaxDamage = p_Reader.ReadSingle();
			p_Instance.HitShaderIndicatorDurationMultiplier = p_Reader.ReadSingle();
			p_Instance.UseVehicleTeamSpawn = p_Reader.ReadBool();
			p_Instance.UseSquadSpawn = p_Reader.ReadBool();
			p_Instance.SpawnOnSquadLeaders = p_Reader.ReadBool();
			p_Reader.Seek(1, SeekOrigin.Current);
		}

	}
}
