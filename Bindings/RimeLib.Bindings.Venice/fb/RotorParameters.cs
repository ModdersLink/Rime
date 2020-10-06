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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(56), ContainerClass]
	public class RotorParameters : 
		DataContainer
	{
		protected float m_CyclicInputScaleRoll = new float();
		[ContainerField(8), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3891841257)]
		public float CyclicInputScaleRoll { get { return m_CyclicInputScaleRoll; } set { if (OnPropertyChanging("RotorParameters." + nameof(CyclicInputScaleRoll), this, m_CyclicInputScaleRoll, value)) m_CyclicInputScaleRoll = value; } } // 0x8 (8)
		
		protected float m_CyclicInputScalePitch = new float();
		[ContainerField(12), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3869827346)]
		public float CyclicInputScalePitch { get { return m_CyclicInputScalePitch; } set { if (OnPropertyChanging("RotorParameters." + nameof(CyclicInputScalePitch), this, m_CyclicInputScalePitch, value)) m_CyclicInputScalePitch = value; } } // 0xC (12)
		
		protected float m_CollectiveThrottleInputScale = new float();
		[ContainerField(16), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2328068935)]
		public float CollectiveThrottleInputScale { get { return m_CollectiveThrottleInputScale; } set { if (OnPropertyChanging("RotorParameters." + nameof(CollectiveThrottleInputScale), this, m_CollectiveThrottleInputScale, value)) m_CollectiveThrottleInputScale = value; } } // 0x10 (16)
		
		protected float m_CollectiveBrakeInputScale = new float();
		[ContainerField(20), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3062684400)]
		public float CollectiveBrakeInputScale { get { return m_CollectiveBrakeInputScale; } set { if (OnPropertyChanging("RotorParameters." + nameof(CollectiveBrakeInputScale), this, m_CollectiveBrakeInputScale, value)) m_CollectiveBrakeInputScale = value; } } // 0x14 (20)
		
		protected float m_CollectiveInputIdle = new float();
		[ContainerField(24), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3489057395)]
		public float CollectiveInputIdle { get { return m_CollectiveInputIdle; } set { if (OnPropertyChanging("RotorParameters." + nameof(CollectiveInputIdle), this, m_CollectiveInputIdle, value)) m_CollectiveInputIdle = value; } } // 0x18 (24)
		
		protected float m_HorizontalForceModifier = new float();
		[ContainerField(28), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3642867601)]
		public float HorizontalForceModifier { get { return m_HorizontalForceModifier; } set { if (OnPropertyChanging("RotorParameters." + nameof(HorizontalForceModifier), this, m_HorizontalForceModifier, value)) m_HorizontalForceModifier = value; } } // 0x1C (28)
		
		protected List<Vec2> m_AngleOfAttack = new List<Vec2>();
		[ContainerField(32), MemberInfoFlag(65), ContainerFieldNameHash(2971529797), ContainerArray]
		public List<Vec2> AngleOfAttack { get { return m_AngleOfAttack; } set { if (OnPropertyChanging("RotorParameters." + nameof(AngleOfAttack), this, m_AngleOfAttack, value)) m_AngleOfAttack = value; } } // 0x20 (32)
		
		protected float m_CyclicFadeOutOffset = new float();
		[ContainerField(36), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3865352255)]
		public float CyclicFadeOutOffset { get { return m_CyclicFadeOutOffset; } set { if (OnPropertyChanging("RotorParameters." + nameof(CyclicFadeOutOffset), this, m_CyclicFadeOutOffset, value)) m_CyclicFadeOutOffset = value; } } // 0x24 (36)
		
		protected float m_AdditionalGravityModifier = new float();
		[ContainerField(40), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1847749677)]
		public float AdditionalGravityModifier { get { return m_AdditionalGravityModifier; } set { if (OnPropertyChanging("RotorParameters." + nameof(AdditionalGravityModifier), this, m_AdditionalGravityModifier, value)) m_AdditionalGravityModifier = value; } } // 0x28 (40)
		
		protected float m_HorisontalMinEffectMod = new float();
		[ContainerField(44), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2678032425)]
		public float HorisontalMinEffectMod { get { return m_HorisontalMinEffectMod; } set { if (OnPropertyChanging("RotorParameters." + nameof(HorisontalMinEffectMod), this, m_HorisontalMinEffectMod, value)) m_HorisontalMinEffectMod = value; } } // 0x2C (44)
		
		protected float m_HorisontalMinEffectVelocity = new float();
		[ContainerField(48), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3650611512)]
		public float HorisontalMinEffectVelocity { get { return m_HorisontalMinEffectVelocity; } set { if (OnPropertyChanging("RotorParameters." + nameof(HorisontalMinEffectVelocity), this, m_HorisontalMinEffectVelocity, value)) m_HorisontalMinEffectVelocity = value; } } // 0x30 (48)
		
		protected bool m_EnableHorisontalMinEffect = new bool();
		[ContainerField(52), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2851288174)]
		public bool EnableHorisontalMinEffect { get { return m_EnableHorisontalMinEffect; } set { if (OnPropertyChanging("RotorParameters." + nameof(EnableHorisontalMinEffect), this, m_EnableHorisontalMinEffect, value)) m_EnableHorisontalMinEffect = value; } } // 0x34 (52)
		
		protected bool m_ReverseThrottle = new bool();
		[ContainerField(53), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3564540269)]
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
