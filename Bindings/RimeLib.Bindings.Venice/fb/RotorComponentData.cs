///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class RotorComponentData : 
		ComponentData
	{
		[ContainerField(96)]
		public RotorModelData LowRpmModel { get; set; } = new RotorModelData(); // 0x60 (96)
		
		[ContainerField(104)]
		public RotorModelData HighRpmModel { get; set; } = new RotorModelData(); // 0x68 (104)
		
		[ContainerField(112)]
		public RotationAxis RotationAxis { get; set; } = new RotationAxis(); // 0x70 (112)
		
		[ContainerField(116), LayoutImmutable, Blittable]
		public float RotationMultiplier { get; set; } // 0x74 (116)
		
		[ContainerField(120), LayoutImmutable, Blittable]
		public float ChangeModelRpm { get; set; } // 0x78 (120)
		
		[ContainerField(124)]
		public CtrRef<EffectBlueprint> BlowEffect { get; set; } = new CtrRef<EffectBlueprint>(); // 0x7C (124)
		
		[ContainerField(128), LayoutImmutable, Blittable]
		public float TriggerGroundEffectHeight { get; set; } // 0x80 (128)
		
		[ContainerField(132), LayoutImmutable, Blittable]
		public float CriticallyDamagedRotationForce { get; set; } // 0x84 (132)
		
		[ContainerField(136), LayoutImmutable, Blittable]
		public bool OnlyTriggerBlowEffectInWater { get; set; } // 0x88 (136)
		
		[ContainerField(137), LayoutImmutable, Blittable]
		public bool GroundEffectOnTerrainOnly { get; set; } // 0x89 (137)
		
		[ContainerField(138), LayoutImmutable, Blittable]
		public bool CriticalDamage { get; set; } // 0x8A (138)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3693202929:
					LowRpmModel = (RotorModelData) p_Value;
					break;

				case 4157411755:
					HighRpmModel = (RotorModelData) p_Value;
					break;

				case 3148542130:
					RotationAxis = (RotationAxis) Enum.ToObject(typeof(RotationAxis), p_Value);
					break;

				case 1226236954:
					RotationMultiplier = (float) p_Value;
					break;

				case 935487395:
					ChangeModelRpm = (float) p_Value;
					break;

				case 3040391844:
					BlowEffect = (CtrRef<EffectBlueprint>) p_Value;
					break;

				case 1753938672:
					TriggerGroundEffectHeight = (float) p_Value;
					break;

				case 482271037:
					CriticallyDamagedRotationForce = (float) p_Value;
					break;

				case 2216323514:
					OnlyTriggerBlowEffectInWater = (bool) p_Value;
					break;

				case 1990027221:
					GroundEffectOnTerrainOnly = (bool) p_Value;
					break;

				case 3377319365:
					CriticalDamage = (bool) p_Value;
					break;

				default:
					base.Bind(p_Descriptor, p_Value);
					break;
			}
		}

		public override object GetFieldValueByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3693202929:
					return LowRpmModel;

				case 4157411755:
					return HighRpmModel;

				case 3148542130:
					return RotationAxis;

				case 1226236954:
					return RotationMultiplier;

				case 935487395:
					return ChangeModelRpm;

				case 3040391844:
					return BlowEffect;

				case 1753938672:
					return TriggerGroundEffectHeight;

				case 482271037:
					return CriticallyDamagedRotationForce;

				case 2216323514:
					return OnlyTriggerBlowEffectInWater;

				case 1990027221:
					return GroundEffectOnTerrainOnly;

				case 3377319365:
					return CriticalDamage;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3693202929:
					return typeof(RotorComponentData).GetProperty(nameof(LowRpmModel));

				case 4157411755:
					return typeof(RotorComponentData).GetProperty(nameof(HighRpmModel));

				case 3148542130:
					return typeof(RotorComponentData).GetProperty(nameof(RotationAxis));

				case 1226236954:
					return typeof(RotorComponentData).GetProperty(nameof(RotationMultiplier));

				case 935487395:
					return typeof(RotorComponentData).GetProperty(nameof(ChangeModelRpm));

				case 3040391844:
					return typeof(RotorComponentData).GetProperty(nameof(BlowEffect));

				case 1753938672:
					return typeof(RotorComponentData).GetProperty(nameof(TriggerGroundEffectHeight));

				case 482271037:
					return typeof(RotorComponentData).GetProperty(nameof(CriticallyDamagedRotationForce));

				case 2216323514:
					return typeof(RotorComponentData).GetProperty(nameof(OnlyTriggerBlowEffectInWater));

				case 1990027221:
					return typeof(RotorComponentData).GetProperty(nameof(GroundEffectOnTerrainOnly));

				case 3377319365:
					return typeof(RotorComponentData).GetProperty(nameof(CriticalDamage));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
