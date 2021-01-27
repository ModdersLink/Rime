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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 56)]
	public class RotorParameters : 
		DataContainer
	{
		protected float m_CyclicInputScaleRoll = new float();
		[ContainerField(Name: "CyclicInputScaleRoll", Offset: 8, NameHash: 3891841257, Flags: 49469), LayoutImmutable, Blittable]
		public float CyclicInputScaleRoll { get { return m_CyclicInputScaleRoll; } set { if (OnPropertyChanging("RotorParameters." + nameof(CyclicInputScaleRoll), this, m_CyclicInputScaleRoll, value)) m_CyclicInputScaleRoll = value; } } // 0x8 (8)
		
		protected float m_CyclicInputScalePitch = new float();
		[ContainerField(Name: "CyclicInputScalePitch", Offset: 12, NameHash: 3869827346, Flags: 49469), LayoutImmutable, Blittable]
		public float CyclicInputScalePitch { get { return m_CyclicInputScalePitch; } set { if (OnPropertyChanging("RotorParameters." + nameof(CyclicInputScalePitch), this, m_CyclicInputScalePitch, value)) m_CyclicInputScalePitch = value; } } // 0xC (12)
		
		protected float m_CollectiveThrottleInputScale = new float();
		[ContainerField(Name: "CollectiveThrottleInputScale", Offset: 16, NameHash: 2328068935, Flags: 49469), LayoutImmutable, Blittable]
		public float CollectiveThrottleInputScale { get { return m_CollectiveThrottleInputScale; } set { if (OnPropertyChanging("RotorParameters." + nameof(CollectiveThrottleInputScale), this, m_CollectiveThrottleInputScale, value)) m_CollectiveThrottleInputScale = value; } } // 0x10 (16)
		
		protected float m_CollectiveBrakeInputScale = new float();
		[ContainerField(Name: "CollectiveBrakeInputScale", Offset: 20, NameHash: 3062684400, Flags: 49469), LayoutImmutable, Blittable]
		public float CollectiveBrakeInputScale { get { return m_CollectiveBrakeInputScale; } set { if (OnPropertyChanging("RotorParameters." + nameof(CollectiveBrakeInputScale), this, m_CollectiveBrakeInputScale, value)) m_CollectiveBrakeInputScale = value; } } // 0x14 (20)
		
		protected float m_CollectiveInputIdle = new float();
		[ContainerField(Name: "CollectiveInputIdle", Offset: 24, NameHash: 3489057395, Flags: 49469), LayoutImmutable, Blittable]
		public float CollectiveInputIdle { get { return m_CollectiveInputIdle; } set { if (OnPropertyChanging("RotorParameters." + nameof(CollectiveInputIdle), this, m_CollectiveInputIdle, value)) m_CollectiveInputIdle = value; } } // 0x18 (24)
		
		protected float m_HorizontalForceModifier = new float();
		[ContainerField(Name: "HorizontalForceModifier", Offset: 28, NameHash: 3642867601, Flags: 49469), LayoutImmutable, Blittable]
		public float HorizontalForceModifier { get { return m_HorizontalForceModifier; } set { if (OnPropertyChanging("RotorParameters." + nameof(HorizontalForceModifier), this, m_HorizontalForceModifier, value)) m_HorizontalForceModifier = value; } } // 0x1C (28)
		
		protected List<Vec2> m_AngleOfAttack = new List<Vec2>();
		[ContainerField(Name: "AngleOfAttack", Offset: 32, NameHash: 2971529797, Flags: 65)]
		public List<Vec2> AngleOfAttack { get { return m_AngleOfAttack; } set { if (OnPropertyChanging("RotorParameters." + nameof(AngleOfAttack), this, m_AngleOfAttack, value)) m_AngleOfAttack = value; } } // 0x20 (32)
		
		protected float m_CyclicFadeOutOffset = new float();
		[ContainerField(Name: "CyclicFadeOutOffset", Offset: 36, NameHash: 3865352255, Flags: 49469), LayoutImmutable, Blittable]
		public float CyclicFadeOutOffset { get { return m_CyclicFadeOutOffset; } set { if (OnPropertyChanging("RotorParameters." + nameof(CyclicFadeOutOffset), this, m_CyclicFadeOutOffset, value)) m_CyclicFadeOutOffset = value; } } // 0x24 (36)
		
		protected float m_AdditionalGravityModifier = new float();
		[ContainerField(Name: "AdditionalGravityModifier", Offset: 40, NameHash: 1847749677, Flags: 49469), LayoutImmutable, Blittable]
		public float AdditionalGravityModifier { get { return m_AdditionalGravityModifier; } set { if (OnPropertyChanging("RotorParameters." + nameof(AdditionalGravityModifier), this, m_AdditionalGravityModifier, value)) m_AdditionalGravityModifier = value; } } // 0x28 (40)
		
		protected float m_HorisontalMinEffectMod = new float();
		[ContainerField(Name: "HorisontalMinEffectMod", Offset: 44, NameHash: 2678032425, Flags: 49469), LayoutImmutable, Blittable]
		public float HorisontalMinEffectMod { get { return m_HorisontalMinEffectMod; } set { if (OnPropertyChanging("RotorParameters." + nameof(HorisontalMinEffectMod), this, m_HorisontalMinEffectMod, value)) m_HorisontalMinEffectMod = value; } } // 0x2C (44)
		
		protected float m_HorisontalMinEffectVelocity = new float();
		[ContainerField(Name: "HorisontalMinEffectVelocity", Offset: 48, NameHash: 3650611512, Flags: 49469), LayoutImmutable, Blittable]
		public float HorisontalMinEffectVelocity { get { return m_HorisontalMinEffectVelocity; } set { if (OnPropertyChanging("RotorParameters." + nameof(HorisontalMinEffectVelocity), this, m_HorisontalMinEffectVelocity, value)) m_HorisontalMinEffectVelocity = value; } } // 0x30 (48)
		
		protected bool m_EnableHorisontalMinEffect = new bool();
		[ContainerField(Name: "EnableHorisontalMinEffect", Offset: 52, NameHash: 2851288174, Flags: 49325), LayoutImmutable, Blittable]
		public bool EnableHorisontalMinEffect { get { return m_EnableHorisontalMinEffect; } set { if (OnPropertyChanging("RotorParameters." + nameof(EnableHorisontalMinEffect), this, m_EnableHorisontalMinEffect, value)) m_EnableHorisontalMinEffect = value; } } // 0x34 (52)
		
		protected bool m_ReverseThrottle = new bool();
		[ContainerField(Name: "ReverseThrottle", Offset: 53, NameHash: 3564540269, Flags: 49325), LayoutImmutable, Blittable]
		public bool ReverseThrottle { get { return m_ReverseThrottle; } set { if (OnPropertyChanging("RotorParameters." + nameof(ReverseThrottle), this, m_ReverseThrottle, value)) m_ReverseThrottle = value; } } // 0x35 (53)
		
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
