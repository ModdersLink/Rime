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
	public class WingPhysicsData : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public float Lift { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public float FlapLift { get; set; } // 0xC (12)
		
		[ContainerField(16)]
		public CtrRef<Curve2D> LiftCoefficient { get; set; } = new CtrRef<Curve2D>(); // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float Drag { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public float FlapDrag { get; set; } // 0x18 (24)
		
		[ContainerField(28)]
		public CtrRef<Curve2D> DragCoefficient { get; set; } = new CtrRef<Curve2D>(); // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public float AngularVelocityLiftModifier { get; set; } // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public float DragRotationModifier { get; set; } // 0x24 (36)
		
		[ContainerField(40), LayoutImmutable, Blittable]
		public float BaseAngleOfAttack { get; set; } // 0x28 (40)
		
		[ContainerField(44), LayoutImmutable, Blittable]
		public int InputForFlap { get; set; } // 0x2C (44)
		
		[ContainerField(48), LayoutImmutable, Blittable]
		public float FlapTurnSpeed { get; set; } // 0x30 (48)
		
		[ContainerField(52), LayoutImmutable, Blittable]
		public float VisualFlapTurnSpeed { get; set; } // 0x34 (52)
		
		[ContainerField(56), LayoutImmutable, Blittable]
		public float VisualFlapAngleLimit { get; set; } // 0x38 (56)
		
		[ContainerField(60)]
		public CtrRef<Curve2D> MaxFlapAngleScaleFactor { get; set; } = new CtrRef<Curve2D>(); // 0x3C (60)
		
		[ContainerField(64), LayoutImmutable, Blittable]
		public float LandingFlapLift { get; set; } // 0x40 (64)
		
		[ContainerField(68)]
		public CtrRef<LandingFlapData> LandingFlapLogic { get; set; } = new CtrRef<LandingFlapData>(); // 0x44 (68)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2089009074:
					Lift = (float) p_Value;
					break;

				case 2436170665:
					FlapLift = (float) p_Value;
					break;

				case 2899213127:
					LiftCoefficient = (CtrRef<Curve2D>) p_Value;
					break;

				case 2088752789:
					Drag = (float) p_Value;
					break;

				case 2436426702:
					FlapDrag = (float) p_Value;
					break;

				case 4054248384:
					DragCoefficient = (CtrRef<Curve2D>) p_Value;
					break;

				case 1734554736:
					AngularVelocityLiftModifier = (float) p_Value;
					break;

				case 951001014:
					DragRotationModifier = (float) p_Value;
					break;

				case 335385008:
					BaseAngleOfAttack = (float) p_Value;
					break;

				case 1375426899:
					InputForFlap = (int) p_Value;
					break;

				case 2891422820:
					FlapTurnSpeed = (float) p_Value;
					break;

				case 443872528:
					VisualFlapTurnSpeed = (float) p_Value;
					break;

				case 2332810590:
					VisualFlapAngleLimit = (float) p_Value;
					break;

				case 924054846:
					MaxFlapAngleScaleFactor = (CtrRef<Curve2D>) p_Value;
					break;

				case 3100228014:
					LandingFlapLift = (float) p_Value;
					break;

				case 3523347703:
					LandingFlapLogic = (CtrRef<LandingFlapData>) p_Value;
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
				case 2089009074:
					return Lift;

				case 2436170665:
					return FlapLift;

				case 2899213127:
					return LiftCoefficient;

				case 2088752789:
					return Drag;

				case 2436426702:
					return FlapDrag;

				case 4054248384:
					return DragCoefficient;

				case 1734554736:
					return AngularVelocityLiftModifier;

				case 951001014:
					return DragRotationModifier;

				case 335385008:
					return BaseAngleOfAttack;

				case 1375426899:
					return InputForFlap;

				case 2891422820:
					return FlapTurnSpeed;

				case 443872528:
					return VisualFlapTurnSpeed;

				case 2332810590:
					return VisualFlapAngleLimit;

				case 924054846:
					return MaxFlapAngleScaleFactor;

				case 3100228014:
					return LandingFlapLift;

				case 3523347703:
					return LandingFlapLogic;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2089009074:
					return typeof(WingPhysicsData).GetProperty(nameof(Lift));

				case 2436170665:
					return typeof(WingPhysicsData).GetProperty(nameof(FlapLift));

				case 2899213127:
					return typeof(WingPhysicsData).GetProperty(nameof(LiftCoefficient));

				case 2088752789:
					return typeof(WingPhysicsData).GetProperty(nameof(Drag));

				case 2436426702:
					return typeof(WingPhysicsData).GetProperty(nameof(FlapDrag));

				case 4054248384:
					return typeof(WingPhysicsData).GetProperty(nameof(DragCoefficient));

				case 1734554736:
					return typeof(WingPhysicsData).GetProperty(nameof(AngularVelocityLiftModifier));

				case 951001014:
					return typeof(WingPhysicsData).GetProperty(nameof(DragRotationModifier));

				case 335385008:
					return typeof(WingPhysicsData).GetProperty(nameof(BaseAngleOfAttack));

				case 1375426899:
					return typeof(WingPhysicsData).GetProperty(nameof(InputForFlap));

				case 2891422820:
					return typeof(WingPhysicsData).GetProperty(nameof(FlapTurnSpeed));

				case 443872528:
					return typeof(WingPhysicsData).GetProperty(nameof(VisualFlapTurnSpeed));

				case 2332810590:
					return typeof(WingPhysicsData).GetProperty(nameof(VisualFlapAngleLimit));

				case 924054846:
					return typeof(WingPhysicsData).GetProperty(nameof(MaxFlapAngleScaleFactor));

				case 3100228014:
					return typeof(WingPhysicsData).GetProperty(nameof(LandingFlapLift));

				case 3523347703:
					return typeof(WingPhysicsData).GetProperty(nameof(LandingFlapLogic));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
