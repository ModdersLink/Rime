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
	[ContainerType(4), MemberInfoFlag(53), ContainerClass]
	public class CharacterPhysicsData : 
		Asset
	{
		protected RefArray<CharacterPoseData> m_Poses = new RefArray<CharacterPoseData>();
		[ContainerField(12), MemberInfoFlag(65), ContainerFieldNameHash(232668927), ContainerRefArray]
		public RefArray<CharacterPoseData> Poses { get { return m_Poses; } set { if (OnPropertyChanging("CharacterPhysicsData." + nameof(Poses), this, m_Poses, value)) m_Poses = value; } } // 0xC (12)
		
		protected RefArray<CharacterStateData> m_States = new RefArray<CharacterStateData>();
		[ContainerField(16), MemberInfoFlag(65), ContainerFieldNameHash(3319729985), ContainerRefArray]
		public RefArray<CharacterStateData> States { get { return m_States; } set { if (OnPropertyChanging("CharacterPhysicsData." + nameof(States), this, m_States, value)) m_States = value; } } // 0x10 (16)
		
		protected CharacterStateType m_DefaultState = new CharacterStateType();
		[ContainerField(20), MemberInfoFlag(137), ContainerFieldNameHash(2078198265)]
		public CharacterStateType DefaultState { get { return m_DefaultState; } set { if (OnPropertyChanging("CharacterPhysicsData." + nameof(DefaultState), this, m_DefaultState, value)) m_DefaultState = value; } } // 0x14 (20)
		
		protected CtrRef<CharacterSprintData> m_Sprint = new CtrRef<CharacterSprintData>();
		[ContainerField(24), MemberInfoFlag(53), ContainerFieldNameHash(3324856903), ContainerCtrRef]
		public CtrRef<CharacterSprintData> Sprint { get { return m_Sprint; } set { if (OnPropertyChanging("CharacterPhysicsData." + nameof(Sprint), this, m_Sprint, value)) m_Sprint = value; } } // 0x18 (24)
		
		protected CtrRef<MaterialContainerPair> m_MaterialPair = new CtrRef<MaterialContainerPair>();
		[ContainerField(28), MemberInfoFlag(53), ContainerFieldNameHash(161392100), ContainerCtrRef]
		public CtrRef<MaterialContainerPair> MaterialPair { get { return m_MaterialPair; } set { if (OnPropertyChanging("CharacterPhysicsData." + nameof(MaterialPair), this, m_MaterialPair, value)) m_MaterialPair = value; } } // 0x1C (28)
		
		protected int m_PushableObjectWeight = new int();
		[ContainerField(32), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(4244631780)]
		public int PushableObjectWeight { get { return m_PushableObjectWeight; } set { if (OnPropertyChanging("CharacterPhysicsData." + nameof(PushableObjectWeight), this, m_PushableObjectWeight, value)) m_PushableObjectWeight = value; } } // 0x20 (32)
		
		protected float m_Mass = new float();
		[ContainerField(36), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2088779625)]
		public float Mass { get { return m_Mass; } set { if (OnPropertyChanging("CharacterPhysicsData." + nameof(Mass), this, m_Mass, value)) m_Mass = value; } } // 0x24 (36)
		
		protected float m_MaxAscendAngle = new float();
		[ContainerField(40), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2324046926)]
		public float MaxAscendAngle { get { return m_MaxAscendAngle; } set { if (OnPropertyChanging("CharacterPhysicsData." + nameof(MaxAscendAngle), this, m_MaxAscendAngle, value)) m_MaxAscendAngle = value; } } // 0x28 (40)
		
		protected float m_PhysicalRadius = new float();
		[ContainerField(44), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2971437576)]
		public float PhysicalRadius { get { return m_PhysicalRadius; } set { if (OnPropertyChanging("CharacterPhysicsData." + nameof(PhysicalRadius), this, m_PhysicalRadius, value)) m_PhysicalRadius = value; } } // 0x2C (44)
		
		protected float m_WaterDepthLimit = new float();
		[ContainerField(48), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3222927400)]
		public float WaterDepthLimit { get { return m_WaterDepthLimit; } set { if (OnPropertyChanging("CharacterPhysicsData." + nameof(WaterDepthLimit), this, m_WaterDepthLimit, value)) m_WaterDepthLimit = value; } } // 0x30 (48)
		
		protected float m_InputAcceleration = new float();
		[ContainerField(52), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2964393169)]
		public float InputAcceleration { get { return m_InputAcceleration; } set { if (OnPropertyChanging("CharacterPhysicsData." + nameof(InputAcceleration), this, m_InputAcceleration, value)) m_InputAcceleration = value; } } // 0x34 (52)
		
		protected float m_LadderAcceptAngle = new float();
		[ContainerField(56), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3049015198)]
		public float LadderAcceptAngle { get { return m_LadderAcceptAngle; } set { if (OnPropertyChanging("CharacterPhysicsData." + nameof(LadderAcceptAngle), this, m_LadderAcceptAngle, value)) m_LadderAcceptAngle = value; } } // 0x38 (56)
		
		protected float m_LadderAcceptAnglePitch = new float();
		[ContainerField(60), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3025434200)]
		public float LadderAcceptAnglePitch { get { return m_LadderAcceptAnglePitch; } set { if (OnPropertyChanging("CharacterPhysicsData." + nameof(LadderAcceptAnglePitch), this, m_LadderAcceptAnglePitch, value)) m_LadderAcceptAnglePitch = value; } } // 0x3C (60)
		
		protected float m_JumpPenaltyTime = new float();
		[ContainerField(64), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(535572137)]
		public float JumpPenaltyTime { get { return m_JumpPenaltyTime; } set { if (OnPropertyChanging("CharacterPhysicsData." + nameof(JumpPenaltyTime), this, m_JumpPenaltyTime, value)) m_JumpPenaltyTime = value; } } // 0x40 (64)
		
		protected float m_JumpPenaltyFactor = new float();
		[ContainerField(68), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(4282682449)]
		public float JumpPenaltyFactor { get { return m_JumpPenaltyFactor; } set { if (OnPropertyChanging("CharacterPhysicsData." + nameof(JumpPenaltyFactor), this, m_JumpPenaltyFactor, value)) m_JumpPenaltyFactor = value; } } // 0x44 (68)
		
		protected float m_RadiusToPredictCollisionOnCharacters = new float();
		[ContainerField(72), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3672523982)]
		public float RadiusToPredictCollisionOnCharacters { get { return m_RadiusToPredictCollisionOnCharacters; } set { if (OnPropertyChanging("CharacterPhysicsData." + nameof(RadiusToPredictCollisionOnCharacters), this, m_RadiusToPredictCollisionOnCharacters, value)) m_RadiusToPredictCollisionOnCharacters = value; } } // 0x48 (72)
		
		protected bool m_AllowPoseChangeDuringTransition = new bool();
		[ContainerField(76), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(366111807)]
		public bool AllowPoseChangeDuringTransition { get { return m_AllowPoseChangeDuringTransition; } set { if (OnPropertyChanging("CharacterPhysicsData." + nameof(AllowPoseChangeDuringTransition), this, m_AllowPoseChangeDuringTransition, value)) m_AllowPoseChangeDuringTransition = value; } } // 0x4C (76)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 232668927:
					Poses = (RefArray<CharacterPoseData>) p_Value;
					break;

				case 3319729985:
					States = (RefArray<CharacterStateData>) p_Value;
					break;

				case 2078198265:
					DefaultState = (CharacterStateType) Enum.ToObject(typeof(CharacterStateType), p_Value);
					break;

				case 3324856903:
					Sprint = (CtrRef<CharacterSprintData>) p_Value;
					break;

				case 161392100:
					MaterialPair = (CtrRef<MaterialContainerPair>) p_Value;
					break;

				case 4244631780:
					PushableObjectWeight = (int) p_Value;
					break;

				case 2088779625:
					Mass = (float) p_Value;
					break;

				case 2324046926:
					MaxAscendAngle = (float) p_Value;
					break;

				case 2971437576:
					PhysicalRadius = (float) p_Value;
					break;

				case 3222927400:
					WaterDepthLimit = (float) p_Value;
					break;

				case 2964393169:
					InputAcceleration = (float) p_Value;
					break;

				case 3049015198:
					LadderAcceptAngle = (float) p_Value;
					break;

				case 3025434200:
					LadderAcceptAnglePitch = (float) p_Value;
					break;

				case 535572137:
					JumpPenaltyTime = (float) p_Value;
					break;

				case 4282682449:
					JumpPenaltyFactor = (float) p_Value;
					break;

				case 3672523982:
					RadiusToPredictCollisionOnCharacters = (float) p_Value;
					break;

				case 366111807:
					AllowPoseChangeDuringTransition = (bool) p_Value;
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
				case 232668927:
					return Poses;

				case 3319729985:
					return States;

				case 2078198265:
					return DefaultState;

				case 3324856903:
					return Sprint;

				case 161392100:
					return MaterialPair;

				case 4244631780:
					return PushableObjectWeight;

				case 2088779625:
					return Mass;

				case 2324046926:
					return MaxAscendAngle;

				case 2971437576:
					return PhysicalRadius;

				case 3222927400:
					return WaterDepthLimit;

				case 2964393169:
					return InputAcceleration;

				case 3049015198:
					return LadderAcceptAngle;

				case 3025434200:
					return LadderAcceptAnglePitch;

				case 535572137:
					return JumpPenaltyTime;

				case 4282682449:
					return JumpPenaltyFactor;

				case 3672523982:
					return RadiusToPredictCollisionOnCharacters;

				case 366111807:
					return AllowPoseChangeDuringTransition;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 232668927:
					return typeof(CharacterPhysicsData).GetProperty(nameof(Poses));

				case 3319729985:
					return typeof(CharacterPhysicsData).GetProperty(nameof(States));

				case 2078198265:
					return typeof(CharacterPhysicsData).GetProperty(nameof(DefaultState));

				case 3324856903:
					return typeof(CharacterPhysicsData).GetProperty(nameof(Sprint));

				case 161392100:
					return typeof(CharacterPhysicsData).GetProperty(nameof(MaterialPair));

				case 4244631780:
					return typeof(CharacterPhysicsData).GetProperty(nameof(PushableObjectWeight));

				case 2088779625:
					return typeof(CharacterPhysicsData).GetProperty(nameof(Mass));

				case 2324046926:
					return typeof(CharacterPhysicsData).GetProperty(nameof(MaxAscendAngle));

				case 2971437576:
					return typeof(CharacterPhysicsData).GetProperty(nameof(PhysicalRadius));

				case 3222927400:
					return typeof(CharacterPhysicsData).GetProperty(nameof(WaterDepthLimit));

				case 2964393169:
					return typeof(CharacterPhysicsData).GetProperty(nameof(InputAcceleration));

				case 3049015198:
					return typeof(CharacterPhysicsData).GetProperty(nameof(LadderAcceptAngle));

				case 3025434200:
					return typeof(CharacterPhysicsData).GetProperty(nameof(LadderAcceptAnglePitch));

				case 535572137:
					return typeof(CharacterPhysicsData).GetProperty(nameof(JumpPenaltyTime));

				case 4282682449:
					return typeof(CharacterPhysicsData).GetProperty(nameof(JumpPenaltyFactor));

				case 3672523982:
					return typeof(CharacterPhysicsData).GetProperty(nameof(RadiusToPredictCollisionOnCharacters));

				case 366111807:
					return typeof(CharacterPhysicsData).GetProperty(nameof(AllowPoseChangeDuringTransition));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
