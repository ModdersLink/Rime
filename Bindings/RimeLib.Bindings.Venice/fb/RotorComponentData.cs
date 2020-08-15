///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using RimeLib.IO;
using RimeLib.Frostbite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Reflection;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(16)]
	public class RotorComponentData : 
		ComponentData
	{
		protected RotorModelData m_LowRpmModel = new RotorModelData();
		[ContainerField(96), ContainerFieldNameHash(3693202929)]
		public RotorModelData LowRpmModel { get { return m_LowRpmModel; } set { if (OnPropertyChanging("RotorComponentData." + nameof(LowRpmModel), this, m_LowRpmModel, value)) m_LowRpmModel = value; } } // 0x60 (96)
		
		protected RotorModelData m_HighRpmModel = new RotorModelData();
		[ContainerField(104), ContainerFieldNameHash(4157411755)]
		public RotorModelData HighRpmModel { get { return m_HighRpmModel; } set { if (OnPropertyChanging("RotorComponentData." + nameof(HighRpmModel), this, m_HighRpmModel, value)) m_HighRpmModel = value; } } // 0x68 (104)
		
		protected RotationAxis m_RotationAxis = new RotationAxis();
		[ContainerField(112), ContainerFieldNameHash(3148542130)]
		public RotationAxis RotationAxis { get { return m_RotationAxis; } set { if (OnPropertyChanging("RotorComponentData." + nameof(RotationAxis), this, m_RotationAxis, value)) m_RotationAxis = value; } } // 0x70 (112)
		
		protected float m_RotationMultiplier = new float();
		[ContainerField(116), LayoutImmutable, Blittable, ContainerFieldNameHash(1226236954)]
		public float RotationMultiplier { get { return m_RotationMultiplier; } set { if (OnPropertyChanging("RotorComponentData." + nameof(RotationMultiplier), this, m_RotationMultiplier, value)) m_RotationMultiplier = value; } } // 0x74 (116)
		
		protected float m_ChangeModelRpm = new float();
		[ContainerField(120), LayoutImmutable, Blittable, ContainerFieldNameHash(935487395)]
		public float ChangeModelRpm { get { return m_ChangeModelRpm; } set { if (OnPropertyChanging("RotorComponentData." + nameof(ChangeModelRpm), this, m_ChangeModelRpm, value)) m_ChangeModelRpm = value; } } // 0x78 (120)
		
		protected CtrRef<EffectBlueprint> m_BlowEffect = new CtrRef<EffectBlueprint>();
		[ContainerField(124), ContainerFieldNameHash(3040391844)]
		public CtrRef<EffectBlueprint> BlowEffect { get { return m_BlowEffect; } set { if (OnPropertyChanging("RotorComponentData." + nameof(BlowEffect), this, m_BlowEffect, value)) m_BlowEffect = value; } } // 0x7C (124)
		
		protected float m_TriggerGroundEffectHeight = new float();
		[ContainerField(128), LayoutImmutable, Blittable, ContainerFieldNameHash(1753938672)]
		public float TriggerGroundEffectHeight { get { return m_TriggerGroundEffectHeight; } set { if (OnPropertyChanging("RotorComponentData." + nameof(TriggerGroundEffectHeight), this, m_TriggerGroundEffectHeight, value)) m_TriggerGroundEffectHeight = value; } } // 0x80 (128)
		
		protected float m_CriticallyDamagedRotationForce = new float();
		[ContainerField(132), LayoutImmutable, Blittable, ContainerFieldNameHash(482271037)]
		public float CriticallyDamagedRotationForce { get { return m_CriticallyDamagedRotationForce; } set { if (OnPropertyChanging("RotorComponentData." + nameof(CriticallyDamagedRotationForce), this, m_CriticallyDamagedRotationForce, value)) m_CriticallyDamagedRotationForce = value; } } // 0x84 (132)
		
		protected bool m_OnlyTriggerBlowEffectInWater = new bool();
		[ContainerField(136), LayoutImmutable, Blittable, ContainerFieldNameHash(2216323514)]
		public bool OnlyTriggerBlowEffectInWater { get { return m_OnlyTriggerBlowEffectInWater; } set { if (OnPropertyChanging("RotorComponentData." + nameof(OnlyTriggerBlowEffectInWater), this, m_OnlyTriggerBlowEffectInWater, value)) m_OnlyTriggerBlowEffectInWater = value; } } // 0x88 (136)
		
		protected bool m_GroundEffectOnTerrainOnly = new bool();
		[ContainerField(137), LayoutImmutable, Blittable, ContainerFieldNameHash(1990027221)]
		public bool GroundEffectOnTerrainOnly { get { return m_GroundEffectOnTerrainOnly; } set { if (OnPropertyChanging("RotorComponentData." + nameof(GroundEffectOnTerrainOnly), this, m_GroundEffectOnTerrainOnly, value)) m_GroundEffectOnTerrainOnly = value; } } // 0x89 (137)
		
		protected bool m_CriticalDamage = new bool();
		[ContainerField(138), LayoutImmutable, Blittable, ContainerFieldNameHash(3377319365)]
		public bool CriticalDamage { get { return m_CriticalDamage; } set { if (OnPropertyChanging("RotorComponentData." + nameof(CriticalDamage), this, m_CriticalDamage, value)) m_CriticalDamage = value; } } // 0x8A (138)
		
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
