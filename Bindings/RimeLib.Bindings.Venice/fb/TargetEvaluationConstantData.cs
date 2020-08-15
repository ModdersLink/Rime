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
	[ContainerType(4)]
	public class TargetEvaluationConstantData : 
		Asset
	{
		protected float m_MaxBattleStrength = new float();
		[ContainerField(12), LayoutImmutable, Blittable, ContainerFieldNameHash(1522242046)]
		public float MaxBattleStrength { get { return m_MaxBattleStrength; } set { if (OnPropertyChanging("TargetEvaluationConstantData." + nameof(MaxBattleStrength), this, m_MaxBattleStrength, value)) m_MaxBattleStrength = value; } } // 0xC (12)
		
		protected float m_DefaultHumanTargetPreference = new float();
		[ContainerField(16), LayoutImmutable, Blittable, ContainerFieldNameHash(170113627)]
		public float DefaultHumanTargetPreference { get { return m_DefaultHumanTargetPreference; } set { if (OnPropertyChanging("TargetEvaluationConstantData." + nameof(DefaultHumanTargetPreference), this, m_DefaultHumanTargetPreference, value)) m_DefaultHumanTargetPreference = value; } } // 0x10 (16)
		
		protected float m_OtherSquadAttackerFactorUsage = new float();
		[ContainerField(20), LayoutImmutable, Blittable, ContainerFieldNameHash(1113892580)]
		public float OtherSquadAttackerFactorUsage { get { return m_OtherSquadAttackerFactorUsage; } set { if (OnPropertyChanging("TargetEvaluationConstantData." + nameof(OtherSquadAttackerFactorUsage), this, m_OtherSquadAttackerFactorUsage, value)) m_OtherSquadAttackerFactorUsage = value; } } // 0x14 (20)
		
		protected float m_TargetFlipFactorUsage = new float();
		[ContainerField(24), LayoutImmutable, Blittable, ContainerFieldNameHash(3580919279)]
		public float TargetFlipFactorUsage { get { return m_TargetFlipFactorUsage; } set { if (OnPropertyChanging("TargetEvaluationConstantData." + nameof(TargetFlipFactorUsage), this, m_TargetFlipFactorUsage, value)) m_TargetFlipFactorUsage = value; } } // 0x18 (24)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1522242046:
					MaxBattleStrength = (float) p_Value;
					break;

				case 170113627:
					DefaultHumanTargetPreference = (float) p_Value;
					break;

				case 1113892580:
					OtherSquadAttackerFactorUsage = (float) p_Value;
					break;

				case 3580919279:
					TargetFlipFactorUsage = (float) p_Value;
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
				case 1522242046:
					return MaxBattleStrength;

				case 170113627:
					return DefaultHumanTargetPreference;

				case 1113892580:
					return OtherSquadAttackerFactorUsage;

				case 3580919279:
					return TargetFlipFactorUsage;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1522242046:
					return typeof(TargetEvaluationConstantData).GetProperty(nameof(MaxBattleStrength));

				case 170113627:
					return typeof(TargetEvaluationConstantData).GetProperty(nameof(DefaultHumanTargetPreference));

				case 1113892580:
					return typeof(TargetEvaluationConstantData).GetProperty(nameof(OtherSquadAttackerFactorUsage));

				case 3580919279:
					return typeof(TargetEvaluationConstantData).GetProperty(nameof(TargetFlipFactorUsage));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
