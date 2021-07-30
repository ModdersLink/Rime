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
	public class RotationBodyData : 
		MovingBodyData
	{
		protected float m_AngularMomentumMultiplier = new float();
		[ContainerField(Name: "AngularMomentumMultiplier", Offset: 16, NameHash: 2539978340, Flags: 49469), LayoutImmutable, Blittable]
		public float AngularMomentumMultiplier { get { return m_AngularMomentumMultiplier; } set { if (OnPropertyChanging("RotationBodyData." + nameof(AngularMomentumMultiplier), this, m_AngularMomentumMultiplier, value)) m_AngularMomentumMultiplier = value; } } // 0x10 (16)
		
		protected float m_AngularMomentumThreshold = new float();
		[ContainerField(Name: "AngularMomentumThreshold", Offset: 20, NameHash: 3648174776, Flags: 49469), LayoutImmutable, Blittable]
		public float AngularMomentumThreshold { get { return m_AngularMomentumThreshold; } set { if (OnPropertyChanging("RotationBodyData." + nameof(AngularMomentumThreshold), this, m_AngularMomentumThreshold, value)) m_AngularMomentumThreshold = value; } } // 0x14 (20)
		
		protected float m_AngularMomentumDamping = new float();
		[ContainerField(Name: "AngularMomentumDamping", Offset: 24, NameHash: 408122487, Flags: 49469), LayoutImmutable, Blittable]
		public float AngularMomentumDamping { get { return m_AngularMomentumDamping; } set { if (OnPropertyChanging("RotationBodyData." + nameof(AngularMomentumDamping), this, m_AngularMomentumDamping, value)) m_AngularMomentumDamping = value; } } // 0x18 (24)
		
		protected float m_AngularMomentumDampingAcc = new float();
		[ContainerField(Name: "AngularMomentumDampingAcc", Offset: 28, NameHash: 3679394870, Flags: 49469), LayoutImmutable, Blittable]
		public float AngularMomentumDampingAcc { get { return m_AngularMomentumDampingAcc; } set { if (OnPropertyChanging("RotationBodyData." + nameof(AngularMomentumDampingAcc), this, m_AngularMomentumDampingAcc, value)) m_AngularMomentumDampingAcc = value; } } // 0x1C (28)
		
		protected float m_AngularMomentumDampingDeacc = new float();
		[ContainerField(Name: "AngularMomentumDampingDeacc", Offset: 32, NameHash: 3945782551, Flags: 49469), LayoutImmutable, Blittable]
		public float AngularMomentumDampingDeacc { get { return m_AngularMomentumDampingDeacc; } set { if (OnPropertyChanging("RotationBodyData." + nameof(AngularMomentumDampingDeacc), this, m_AngularMomentumDampingDeacc, value)) m_AngularMomentumDampingDeacc = value; } } // 0x20 (32)
		
		protected float m_AngularConstraintMin = new float();
		[ContainerField(Name: "AngularConstraintMin", Offset: 36, NameHash: 731814824, Flags: 49469), LayoutImmutable, Blittable]
		public float AngularConstraintMin { get { return m_AngularConstraintMin; } set { if (OnPropertyChanging("RotationBodyData." + nameof(AngularConstraintMin), this, m_AngularConstraintMin, value)) m_AngularConstraintMin = value; } } // 0x24 (36)
		
		protected CtrRef<ExtendedConstraintsData> m_ExtendedConstraints = new CtrRef<ExtendedConstraintsData>();
		[ContainerField(Name: "ExtendedConstraints", Offset: 40, NameHash: 1460566804, Flags: 53)]
		public CtrRef<ExtendedConstraintsData> ExtendedConstraints { get { return m_ExtendedConstraints; } set { if (OnPropertyChanging("RotationBodyData." + nameof(ExtendedConstraints), this, m_ExtendedConstraints, value)) m_ExtendedConstraints = value; } } // 0x28 (40)
		
		protected float m_AngularConstraintMax = new float();
		[ContainerField(Name: "AngularConstraintMax", Offset: 44, NameHash: 731815094, Flags: 49469), LayoutImmutable, Blittable]
		public float AngularConstraintMax { get { return m_AngularConstraintMax; } set { if (OnPropertyChanging("RotationBodyData." + nameof(AngularConstraintMax), this, m_AngularConstraintMax, value)) m_AngularConstraintMax = value; } } // 0x2C (44)
		
		protected int m_RotationAxis = new int();
		[ContainerField(Name: "RotationAxis", Offset: 48, NameHash: 3148542130, Flags: 49405), LayoutImmutable, Blittable]
		public int RotationAxis { get { return m_RotationAxis; } set { if (OnPropertyChanging("RotationBodyData." + nameof(RotationAxis), this, m_RotationAxis, value)) m_RotationAxis = value; } } // 0x30 (48)
		
		protected bool m_UsePostSatisfyConstraints = new bool();
		[ContainerField(Name: "UsePostSatisfyConstraints", Offset: 52, NameHash: 2580431755, Flags: 49325), LayoutImmutable, Blittable]
		public bool UsePostSatisfyConstraints { get { return m_UsePostSatisfyConstraints; } set { if (OnPropertyChanging("RotationBodyData." + nameof(UsePostSatisfyConstraints), this, m_UsePostSatisfyConstraints, value)) m_UsePostSatisfyConstraints = value; } } // 0x34 (52)
		
		protected bool m_UseAngularMomentumThreshold = new bool();
		[ContainerField(Name: "UseAngularMomentumThreshold", Offset: 53, NameHash: 1737105787, Flags: 49325), LayoutImmutable, Blittable]
		public bool UseAngularMomentumThreshold { get { return m_UseAngularMomentumThreshold; } set { if (OnPropertyChanging("RotationBodyData." + nameof(UseAngularMomentumThreshold), this, m_UseAngularMomentumThreshold, value)) m_UseAngularMomentumThreshold = value; } } // 0x35 (53)
		
		protected bool m_UseAngularMomentumDamping = new bool();
		[ContainerField(Name: "UseAngularMomentumDamping", Offset: 54, NameHash: 246050484, Flags: 49325), LayoutImmutable, Blittable]
		public bool UseAngularMomentumDamping { get { return m_UseAngularMomentumDamping; } set { if (OnPropertyChanging("RotationBodyData." + nameof(UseAngularMomentumDamping), this, m_UseAngularMomentumDamping, value)) m_UseAngularMomentumDamping = value; } } // 0x36 (54)
		
		protected bool m_UseAngularConstraint = new bool();
		[ContainerField(Name: "UseAngularConstraint", Offset: 55, NameHash: 3510444449, Flags: 49325), LayoutImmutable, Blittable]
		public bool UseAngularConstraint { get { return m_UseAngularConstraint; } set { if (OnPropertyChanging("RotationBodyData." + nameof(UseAngularConstraint), this, m_UseAngularConstraint, value)) m_UseAngularConstraint = value; } } // 0x37 (55)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2539978340:
					AngularMomentumMultiplier = (float) p_Value;
					break;

				case 3648174776:
					AngularMomentumThreshold = (float) p_Value;
					break;

				case 408122487:
					AngularMomentumDamping = (float) p_Value;
					break;

				case 3679394870:
					AngularMomentumDampingAcc = (float) p_Value;
					break;

				case 3945782551:
					AngularMomentumDampingDeacc = (float) p_Value;
					break;

				case 731814824:
					AngularConstraintMin = (float) p_Value;
					break;

				case 1460566804:
					ExtendedConstraints = (CtrRef<ExtendedConstraintsData>) p_Value;
					break;

				case 731815094:
					AngularConstraintMax = (float) p_Value;
					break;

				case 3148542130:
					RotationAxis = (int) p_Value;
					break;

				case 2580431755:
					UsePostSatisfyConstraints = (bool) p_Value;
					break;

				case 1737105787:
					UseAngularMomentumThreshold = (bool) p_Value;
					break;

				case 246050484:
					UseAngularMomentumDamping = (bool) p_Value;
					break;

				case 3510444449:
					UseAngularConstraint = (bool) p_Value;
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
				case 2539978340:
					return AngularMomentumMultiplier;

				case 3648174776:
					return AngularMomentumThreshold;

				case 408122487:
					return AngularMomentumDamping;

				case 3679394870:
					return AngularMomentumDampingAcc;

				case 3945782551:
					return AngularMomentumDampingDeacc;

				case 731814824:
					return AngularConstraintMin;

				case 1460566804:
					return ExtendedConstraints;

				case 731815094:
					return AngularConstraintMax;

				case 3148542130:
					return RotationAxis;

				case 2580431755:
					return UsePostSatisfyConstraints;

				case 1737105787:
					return UseAngularMomentumThreshold;

				case 246050484:
					return UseAngularMomentumDamping;

				case 3510444449:
					return UseAngularConstraint;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2539978340:
					return typeof(RotationBodyData).GetProperty(nameof(AngularMomentumMultiplier));

				case 3648174776:
					return typeof(RotationBodyData).GetProperty(nameof(AngularMomentumThreshold));

				case 408122487:
					return typeof(RotationBodyData).GetProperty(nameof(AngularMomentumDamping));

				case 3679394870:
					return typeof(RotationBodyData).GetProperty(nameof(AngularMomentumDampingAcc));

				case 3945782551:
					return typeof(RotationBodyData).GetProperty(nameof(AngularMomentumDampingDeacc));

				case 731814824:
					return typeof(RotationBodyData).GetProperty(nameof(AngularConstraintMin));

				case 1460566804:
					return typeof(RotationBodyData).GetProperty(nameof(ExtendedConstraints));

				case 731815094:
					return typeof(RotationBodyData).GetProperty(nameof(AngularConstraintMax));

				case 3148542130:
					return typeof(RotationBodyData).GetProperty(nameof(RotationAxis));

				case 2580431755:
					return typeof(RotationBodyData).GetProperty(nameof(UsePostSatisfyConstraints));

				case 1737105787:
					return typeof(RotationBodyData).GetProperty(nameof(UseAngularMomentumThreshold));

				case 246050484:
					return typeof(RotationBodyData).GetProperty(nameof(UseAngularMomentumDamping));

				case 3510444449:
					return typeof(RotationBodyData).GetProperty(nameof(UseAngularConstraint));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
