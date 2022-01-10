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
	[ContainerType(16, 144)]
	public class RotorComponentData : 
		ComponentData
	{
		[ContainerField(96)]
		public RotorModelData LowRpmModel { get; set; } = new();

		[ContainerField(104)]
		public RotorModelData HighRpmModel { get; set; } = new();

		[ContainerField(112)]
		public RotationAxis RotationAxis { get; set; } = new();

		[ContainerField(116), LayoutImmutable, Blittable]
		public float RotationMultiplier { get; set; }

		[ContainerField(120), LayoutImmutable, Blittable]
		public float ChangeModelRpm { get; set; }

		[ContainerField(124)]
		public CtrRef<EffectBlueprint> BlowEffect { get; set; } = new();

		[ContainerField(128), LayoutImmutable, Blittable]
		public float TriggerGroundEffectHeight { get; set; }

		[ContainerField(132), LayoutImmutable, Blittable]
		public float CriticallyDamagedRotationForce { get; set; }

		[ContainerField(136), LayoutImmutable, Blittable]
		public bool OnlyTriggerBlowEffectInWater { get; set; }

		[ContainerField(137), LayoutImmutable, Blittable]
		public bool GroundEffectOnTerrainOnly { get; set; }

		[ContainerField(138), LayoutImmutable, Blittable]
		public bool CriticalDamage { get; set; }

		public static void Deserialize(RotorComponentData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.RotorModelData.Deserialize(p_Instance.LowRpmModel, p_Reader, p_Parser);
			fb.RotorModelData.Deserialize(p_Instance.HighRpmModel, p_Reader, p_Parser);
			p_Instance.RotationAxis = (RotationAxis) p_Reader.ReadInt32();
			p_Instance.RotationMultiplier = p_Reader.ReadSingle();
			p_Instance.ChangeModelRpm = p_Reader.ReadSingle();
			p_Instance.BlowEffect.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.TriggerGroundEffectHeight = p_Reader.ReadSingle();
			p_Instance.CriticallyDamagedRotationForce = p_Reader.ReadSingle();
			p_Instance.OnlyTriggerBlowEffectInWater = p_Reader.ReadBool();
			p_Instance.GroundEffectOnTerrainOnly = p_Reader.ReadBool();
			p_Instance.CriticalDamage = p_Reader.ReadBool();
			p_Reader.Seek(5, SeekOrigin.Current);
		}

	}
}
