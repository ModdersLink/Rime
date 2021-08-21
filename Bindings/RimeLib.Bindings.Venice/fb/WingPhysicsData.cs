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
using RimeLib.Frostbite.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 4,  Flags: 53, Size: 72)]
	public class WingPhysicsData : 
		DataContainer
	{
		protected float m_Lift = new float();
		[ContainerField(Name: "Lift", Offset: 8, NameHash: 2089009074, Flags: 49469), LayoutImmutable, Blittable]
		public float Lift { get { return m_Lift; } set { if (OnPropertyChanging("WingPhysicsData." + nameof(Lift), this, m_Lift, value)) m_Lift = value; } } // 0x8 (8)
		
		protected float m_FlapLift = new float();
		[ContainerField(Name: "FlapLift", Offset: 12, NameHash: 2436170665, Flags: 49469), LayoutImmutable, Blittable]
		public float FlapLift { get { return m_FlapLift; } set { if (OnPropertyChanging("WingPhysicsData." + nameof(FlapLift), this, m_FlapLift, value)) m_FlapLift = value; } } // 0xC (12)
		
		protected CtrRef<Curve2D> m_LiftCoefficient = new CtrRef<Curve2D>();
		[ContainerField(Name: "LiftCoefficient", Offset: 16, NameHash: 2899213127, Flags: 53)]
		public CtrRef<Curve2D> LiftCoefficient { get { return m_LiftCoefficient; } set { if (OnPropertyChanging("WingPhysicsData." + nameof(LiftCoefficient), this, m_LiftCoefficient, value)) m_LiftCoefficient = value; } } // 0x10 (16)
		
		protected float m_Drag = new float();
		[ContainerField(Name: "Drag", Offset: 20, NameHash: 2088752789, Flags: 49469), LayoutImmutable, Blittable]
		public float Drag { get { return m_Drag; } set { if (OnPropertyChanging("WingPhysicsData." + nameof(Drag), this, m_Drag, value)) m_Drag = value; } } // 0x14 (20)
		
		protected float m_FlapDrag = new float();
		[ContainerField(Name: "FlapDrag", Offset: 24, NameHash: 2436426702, Flags: 49469), LayoutImmutable, Blittable]
		public float FlapDrag { get { return m_FlapDrag; } set { if (OnPropertyChanging("WingPhysicsData." + nameof(FlapDrag), this, m_FlapDrag, value)) m_FlapDrag = value; } } // 0x18 (24)
		
		protected CtrRef<Curve2D> m_DragCoefficient = new CtrRef<Curve2D>();
		[ContainerField(Name: "DragCoefficient", Offset: 28, NameHash: 4054248384, Flags: 53)]
		public CtrRef<Curve2D> DragCoefficient { get { return m_DragCoefficient; } set { if (OnPropertyChanging("WingPhysicsData." + nameof(DragCoefficient), this, m_DragCoefficient, value)) m_DragCoefficient = value; } } // 0x1C (28)
		
		protected float m_AngularVelocityLiftModifier = new float();
		[ContainerField(Name: "AngularVelocityLiftModifier", Offset: 32, NameHash: 1734554736, Flags: 49469), LayoutImmutable, Blittable]
		public float AngularVelocityLiftModifier { get { return m_AngularVelocityLiftModifier; } set { if (OnPropertyChanging("WingPhysicsData." + nameof(AngularVelocityLiftModifier), this, m_AngularVelocityLiftModifier, value)) m_AngularVelocityLiftModifier = value; } } // 0x20 (32)
		
		protected float m_DragRotationModifier = new float();
		[ContainerField(Name: "DragRotationModifier", Offset: 36, NameHash: 951001014, Flags: 49469), LayoutImmutable, Blittable]
		public float DragRotationModifier { get { return m_DragRotationModifier; } set { if (OnPropertyChanging("WingPhysicsData." + nameof(DragRotationModifier), this, m_DragRotationModifier, value)) m_DragRotationModifier = value; } } // 0x24 (36)
		
		protected float m_BaseAngleOfAttack = new float();
		[ContainerField(Name: "BaseAngleOfAttack", Offset: 40, NameHash: 335385008, Flags: 49469), LayoutImmutable, Blittable]
		public float BaseAngleOfAttack { get { return m_BaseAngleOfAttack; } set { if (OnPropertyChanging("WingPhysicsData." + nameof(BaseAngleOfAttack), this, m_BaseAngleOfAttack, value)) m_BaseAngleOfAttack = value; } } // 0x28 (40)
		
		protected int m_InputForFlap = new int();
		[ContainerField(Name: "InputForFlap", Offset: 44, NameHash: 1375426899, Flags: 49405), LayoutImmutable, Blittable]
		public int InputForFlap { get { return m_InputForFlap; } set { if (OnPropertyChanging("WingPhysicsData." + nameof(InputForFlap), this, m_InputForFlap, value)) m_InputForFlap = value; } } // 0x2C (44)
		
		protected float m_FlapTurnSpeed = new float();
		[ContainerField(Name: "FlapTurnSpeed", Offset: 48, NameHash: 2891422820, Flags: 49469), LayoutImmutable, Blittable]
		public float FlapTurnSpeed { get { return m_FlapTurnSpeed; } set { if (OnPropertyChanging("WingPhysicsData." + nameof(FlapTurnSpeed), this, m_FlapTurnSpeed, value)) m_FlapTurnSpeed = value; } } // 0x30 (48)
		
		protected float m_VisualFlapTurnSpeed = new float();
		[ContainerField(Name: "VisualFlapTurnSpeed", Offset: 52, NameHash: 443872528, Flags: 49469), LayoutImmutable, Blittable]
		public float VisualFlapTurnSpeed { get { return m_VisualFlapTurnSpeed; } set { if (OnPropertyChanging("WingPhysicsData." + nameof(VisualFlapTurnSpeed), this, m_VisualFlapTurnSpeed, value)) m_VisualFlapTurnSpeed = value; } } // 0x34 (52)
		
		protected float m_VisualFlapAngleLimit = new float();
		[ContainerField(Name: "VisualFlapAngleLimit", Offset: 56, NameHash: 2332810590, Flags: 49469), LayoutImmutable, Blittable]
		public float VisualFlapAngleLimit { get { return m_VisualFlapAngleLimit; } set { if (OnPropertyChanging("WingPhysicsData." + nameof(VisualFlapAngleLimit), this, m_VisualFlapAngleLimit, value)) m_VisualFlapAngleLimit = value; } } // 0x38 (56)
		
		protected CtrRef<Curve2D> m_MaxFlapAngleScaleFactor = new CtrRef<Curve2D>();
		[ContainerField(Name: "MaxFlapAngleScaleFactor", Offset: 60, NameHash: 924054846, Flags: 53)]
		public CtrRef<Curve2D> MaxFlapAngleScaleFactor { get { return m_MaxFlapAngleScaleFactor; } set { if (OnPropertyChanging("WingPhysicsData." + nameof(MaxFlapAngleScaleFactor), this, m_MaxFlapAngleScaleFactor, value)) m_MaxFlapAngleScaleFactor = value; } } // 0x3C (60)
		
		protected float m_LandingFlapLift = new float();
		[ContainerField(Name: "LandingFlapLift", Offset: 64, NameHash: 3100228014, Flags: 49469), LayoutImmutable, Blittable]
		public float LandingFlapLift { get { return m_LandingFlapLift; } set { if (OnPropertyChanging("WingPhysicsData." + nameof(LandingFlapLift), this, m_LandingFlapLift, value)) m_LandingFlapLift = value; } } // 0x40 (64)
		
		protected CtrRef<LandingFlapData> m_LandingFlapLogic = new CtrRef<LandingFlapData>();
		[ContainerField(Name: "LandingFlapLogic", Offset: 68, NameHash: 3523347703, Flags: 53)]
		public CtrRef<LandingFlapData> LandingFlapLogic { get { return m_LandingFlapLogic; } set { if (OnPropertyChanging("WingPhysicsData." + nameof(LandingFlapLogic), this, m_LandingFlapLogic, value)) m_LandingFlapLogic = value; } } // 0x44 (68)
		
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
