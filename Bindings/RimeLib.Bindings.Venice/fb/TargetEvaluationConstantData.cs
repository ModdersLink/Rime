///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class TargetEvaluationConstantData : 
		Asset
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public float MaxBattleStrength { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float DefaultHumanTargetPreference { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float OtherSquadAttackerFactorUsage { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public float TargetFlipFactorUsage { get; set; } // 0x18 (24)
		
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
