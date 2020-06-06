///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Collections.Generic;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class RotorParameters : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public float CyclicInputScaleRoll { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public float CyclicInputScalePitch { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float CollectiveThrottleInputScale { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float CollectiveBrakeInputScale { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public float CollectiveInputIdle { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public float HorizontalForceModifier { get; set; } // 0x1C (28)
		
		[ContainerField(32)]
		public List<Vec2> AngleOfAttack { get; set; } = new List<Vec2>(); // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public float CyclicFadeOutOffset { get; set; } // 0x24 (36)
		
		[ContainerField(40), LayoutImmutable, Blittable]
		public float AdditionalGravityModifier { get; set; } // 0x28 (40)
		
		[ContainerField(44), LayoutImmutable, Blittable]
		public float HorisontalMinEffectMod { get; set; } // 0x2C (44)
		
		[ContainerField(48), LayoutImmutable, Blittable]
		public float HorisontalMinEffectVelocity { get; set; } // 0x30 (48)
		
		[ContainerField(52), LayoutImmutable, Blittable]
		public bool EnableHorisontalMinEffect { get; set; } // 0x34 (52)
		
		[ContainerField(53), LayoutImmutable, Blittable]
		public bool ReverseThrottle { get; set; } // 0x35 (53)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3891841257:
					CyclicInputScaleRoll = (float) p_Value;
					break;

				case 3869827346:
					CyclicInputScalePitch = (float) p_Value;
					break;

				case 2328068935:
					CollectiveThrottleInputScale = (float) p_Value;
					break;

				case 3062684400:
					CollectiveBrakeInputScale = (float) p_Value;
					break;

				case 3489057395:
					CollectiveInputIdle = (float) p_Value;
					break;

				case 3642867601:
					HorizontalForceModifier = (float) p_Value;
					break;

				case 2971529797:
					AngleOfAttack = (List<Vec2>) p_Value;
					break;

				case 3865352255:
					CyclicFadeOutOffset = (float) p_Value;
					break;

				case 1847749677:
					AdditionalGravityModifier = (float) p_Value;
					break;

				case 2678032425:
					HorisontalMinEffectMod = (float) p_Value;
					break;

				case 3650611512:
					HorisontalMinEffectVelocity = (float) p_Value;
					break;

				case 2851288174:
					EnableHorisontalMinEffect = (bool) p_Value;
					break;

				case 3564540269:
					ReverseThrottle = (bool) p_Value;
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
				case 3891841257:
					return CyclicInputScaleRoll;

				case 3869827346:
					return CyclicInputScalePitch;

				case 2328068935:
					return CollectiveThrottleInputScale;

				case 3062684400:
					return CollectiveBrakeInputScale;

				case 3489057395:
					return CollectiveInputIdle;

				case 3642867601:
					return HorizontalForceModifier;

				case 2971529797:
					return AngleOfAttack;

				case 3865352255:
					return CyclicFadeOutOffset;

				case 1847749677:
					return AdditionalGravityModifier;

				case 2678032425:
					return HorisontalMinEffectMod;

				case 3650611512:
					return HorisontalMinEffectVelocity;

				case 2851288174:
					return EnableHorisontalMinEffect;

				case 3564540269:
					return ReverseThrottle;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3891841257:
					return typeof(RotorParameters).GetProperty(nameof(CyclicInputScaleRoll));

				case 3869827346:
					return typeof(RotorParameters).GetProperty(nameof(CyclicInputScalePitch));

				case 2328068935:
					return typeof(RotorParameters).GetProperty(nameof(CollectiveThrottleInputScale));

				case 3062684400:
					return typeof(RotorParameters).GetProperty(nameof(CollectiveBrakeInputScale));

				case 3489057395:
					return typeof(RotorParameters).GetProperty(nameof(CollectiveInputIdle));

				case 3642867601:
					return typeof(RotorParameters).GetProperty(nameof(HorizontalForceModifier));

				case 2971529797:
					return typeof(RotorParameters).GetProperty(nameof(AngleOfAttack));

				case 3865352255:
					return typeof(RotorParameters).GetProperty(nameof(CyclicFadeOutOffset));

				case 1847749677:
					return typeof(RotorParameters).GetProperty(nameof(AdditionalGravityModifier));

				case 2678032425:
					return typeof(RotorParameters).GetProperty(nameof(HorisontalMinEffectMod));

				case 3650611512:
					return typeof(RotorParameters).GetProperty(nameof(HorisontalMinEffectVelocity));

				case 2851288174:
					return typeof(RotorParameters).GetProperty(nameof(EnableHorisontalMinEffect));

				case 3564540269:
					return typeof(RotorParameters).GetProperty(nameof(ReverseThrottle));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
