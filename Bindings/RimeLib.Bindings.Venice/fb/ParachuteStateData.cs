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
	public class ParachuteStateData : 
		CharacterStateData
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public float DeployTime { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float TerminalVelocity { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float ForwardDragCoefficient { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public float AngleOfAttack { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public float BankOffset { get; set; } // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public float ThrottleOffset { get; set; } // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public float BrakeOffset { get; set; } // 0x24 (36)
		
		[ContainerField(40), LayoutImmutable, Blittable]
		public float MaxRollVelocity { get; set; } // 0x28 (40)
		
		[ContainerField(44), LayoutImmutable, Blittable]
		public float MaxPitchVelocity { get; set; } // 0x2C (44)
		
		[ContainerField(48), LayoutImmutable, Blittable]
		public float MaxYawVelocity { get; set; } // 0x30 (48)
		
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
