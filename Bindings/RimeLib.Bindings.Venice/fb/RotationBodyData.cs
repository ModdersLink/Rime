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
	public class RotationBodyData : 
		MovingBodyData
	{
		[ContainerField(16), LayoutImmutable, Blittable]
		public float AngularMomentumMultiplier { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float AngularMomentumThreshold { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public float AngularMomentumDamping { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public float AngularMomentumDampingAcc { get; set; } // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public float AngularMomentumDampingDeacc { get; set; } // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public float AngularConstraintMin { get; set; } // 0x24 (36)
		
		[ContainerField(40)]
		public CtrRef<ExtendedConstraintsData> ExtendedConstraints { get; set; } = new CtrRef<ExtendedConstraintsData>(); // 0x28 (40)
		
		[ContainerField(44), LayoutImmutable, Blittable]
		public float AngularConstraintMax { get; set; } // 0x2C (44)
		
		[ContainerField(48), LayoutImmutable, Blittable]
		public int RotationAxis { get; set; } // 0x30 (48)
		
		[ContainerField(52), LayoutImmutable, Blittable]
		public bool UsePostSatisfyConstraints { get; set; } // 0x34 (52)
		
		[ContainerField(53), LayoutImmutable, Blittable]
		public bool UseAngularMomentumThreshold { get; set; } // 0x35 (53)
		
		[ContainerField(54), LayoutImmutable, Blittable]
		public bool UseAngularMomentumDamping { get; set; } // 0x36 (54)
		
		[ContainerField(55), LayoutImmutable, Blittable]
		public bool UseAngularConstraint { get; set; } // 0x37 (55)
		
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
