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
	public class ParachuteStateData : 
		CharacterStateData
	{
		protected float m_DeployTime = new float();
		[ContainerField(12), LayoutImmutable, Blittable, ContainerFieldNameHash(2275884507)]
		public float DeployTime { get { return m_DeployTime; } set { if (OnPropertyChanging("ParachuteStateData." + nameof(DeployTime), this, m_DeployTime, value)) m_DeployTime = value; } } // 0xC (12)
		
		protected float m_TerminalVelocity = new float();
		[ContainerField(16), LayoutImmutable, Blittable, ContainerFieldNameHash(1459893878)]
		public float TerminalVelocity { get { return m_TerminalVelocity; } set { if (OnPropertyChanging("ParachuteStateData." + nameof(TerminalVelocity), this, m_TerminalVelocity, value)) m_TerminalVelocity = value; } } // 0x10 (16)
		
		protected float m_ForwardDragCoefficient = new float();
		[ContainerField(20), LayoutImmutable, Blittable, ContainerFieldNameHash(2142952731)]
		public float ForwardDragCoefficient { get { return m_ForwardDragCoefficient; } set { if (OnPropertyChanging("ParachuteStateData." + nameof(ForwardDragCoefficient), this, m_ForwardDragCoefficient, value)) m_ForwardDragCoefficient = value; } } // 0x14 (20)
		
		protected float m_AngleOfAttack = new float();
		[ContainerField(24), LayoutImmutable, Blittable, ContainerFieldNameHash(2971529797)]
		public float AngleOfAttack { get { return m_AngleOfAttack; } set { if (OnPropertyChanging("ParachuteStateData." + nameof(AngleOfAttack), this, m_AngleOfAttack, value)) m_AngleOfAttack = value; } } // 0x18 (24)
		
		protected float m_BankOffset = new float();
		[ContainerField(28), LayoutImmutable, Blittable, ContainerFieldNameHash(1603265742)]
		public float BankOffset { get { return m_BankOffset; } set { if (OnPropertyChanging("ParachuteStateData." + nameof(BankOffset), this, m_BankOffset, value)) m_BankOffset = value; } } // 0x1C (28)
		
		protected float m_ThrottleOffset = new float();
		[ContainerField(32), LayoutImmutable, Blittable, ContainerFieldNameHash(1429396608)]
		public float ThrottleOffset { get { return m_ThrottleOffset; } set { if (OnPropertyChanging("ParachuteStateData." + nameof(ThrottleOffset), this, m_ThrottleOffset, value)) m_ThrottleOffset = value; } } // 0x20 (32)
		
		protected float m_BrakeOffset = new float();
		[ContainerField(36), LayoutImmutable, Blittable, ContainerFieldNameHash(1350216631)]
		public float BrakeOffset { get { return m_BrakeOffset; } set { if (OnPropertyChanging("ParachuteStateData." + nameof(BrakeOffset), this, m_BrakeOffset, value)) m_BrakeOffset = value; } } // 0x24 (36)
		
		protected float m_MaxRollVelocity = new float();
		[ContainerField(40), LayoutImmutable, Blittable, ContainerFieldNameHash(1947747259)]
		public float MaxRollVelocity { get { return m_MaxRollVelocity; } set { if (OnPropertyChanging("ParachuteStateData." + nameof(MaxRollVelocity), this, m_MaxRollVelocity, value)) m_MaxRollVelocity = value; } } // 0x28 (40)
		
		protected float m_MaxPitchVelocity = new float();
		[ContainerField(44), LayoutImmutable, Blittable, ContainerFieldNameHash(2587272352)]
		public float MaxPitchVelocity { get { return m_MaxPitchVelocity; } set { if (OnPropertyChanging("ParachuteStateData." + nameof(MaxPitchVelocity), this, m_MaxPitchVelocity, value)) m_MaxPitchVelocity = value; } } // 0x2C (44)
		
		protected float m_MaxYawVelocity = new float();
		[ContainerField(48), LayoutImmutable, Blittable, ContainerFieldNameHash(3921711241)]
		public float MaxYawVelocity { get { return m_MaxYawVelocity; } set { if (OnPropertyChanging("ParachuteStateData." + nameof(MaxYawVelocity), this, m_MaxYawVelocity, value)) m_MaxYawVelocity = value; } } // 0x30 (48)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2275884507:
					DeployTime = (float) p_Value;
					break;

				case 1459893878:
					TerminalVelocity = (float) p_Value;
					break;

				case 2142952731:
					ForwardDragCoefficient = (float) p_Value;
					break;

				case 2971529797:
					AngleOfAttack = (float) p_Value;
					break;

				case 1603265742:
					BankOffset = (float) p_Value;
					break;

				case 1429396608:
					ThrottleOffset = (float) p_Value;
					break;

				case 1350216631:
					BrakeOffset = (float) p_Value;
					break;

				case 1947747259:
					MaxRollVelocity = (float) p_Value;
					break;

				case 2587272352:
					MaxPitchVelocity = (float) p_Value;
					break;

				case 3921711241:
					MaxYawVelocity = (float) p_Value;
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
				case 2275884507:
					return DeployTime;

				case 1459893878:
					return TerminalVelocity;

				case 2142952731:
					return ForwardDragCoefficient;

				case 2971529797:
					return AngleOfAttack;

				case 1603265742:
					return BankOffset;

				case 1429396608:
					return ThrottleOffset;

				case 1350216631:
					return BrakeOffset;

				case 1947747259:
					return MaxRollVelocity;

				case 2587272352:
					return MaxPitchVelocity;

				case 3921711241:
					return MaxYawVelocity;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2275884507:
					return typeof(ParachuteStateData).GetProperty(nameof(DeployTime));

				case 1459893878:
					return typeof(ParachuteStateData).GetProperty(nameof(TerminalVelocity));

				case 2142952731:
					return typeof(ParachuteStateData).GetProperty(nameof(ForwardDragCoefficient));

				case 2971529797:
					return typeof(ParachuteStateData).GetProperty(nameof(AngleOfAttack));

				case 1603265742:
					return typeof(ParachuteStateData).GetProperty(nameof(BankOffset));

				case 1429396608:
					return typeof(ParachuteStateData).GetProperty(nameof(ThrottleOffset));

				case 1350216631:
					return typeof(ParachuteStateData).GetProperty(nameof(BrakeOffset));

				case 1947747259:
					return typeof(ParachuteStateData).GetProperty(nameof(MaxRollVelocity));

				case 2587272352:
					return typeof(ParachuteStateData).GetProperty(nameof(MaxPitchVelocity));

				case 3921711241:
					return typeof(ParachuteStateData).GetProperty(nameof(MaxYawVelocity));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
