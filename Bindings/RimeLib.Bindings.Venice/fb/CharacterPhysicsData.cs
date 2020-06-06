///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class CharacterPhysicsData : 
		Asset
	{
		[ContainerField(12)]
		public RefArray<CharacterPoseData> Poses { get; set; } = new RefArray<CharacterPoseData>(); // 0xC (12)
		
		[ContainerField(16)]
		public RefArray<CharacterStateData> States { get; set; } = new RefArray<CharacterStateData>(); // 0x10 (16)
		
		[ContainerField(20)]
		public CharacterStateType DefaultState { get; set; } = new CharacterStateType(); // 0x14 (20)
		
		[ContainerField(24)]
		public CtrRef<CharacterSprintData> Sprint { get; set; } = new CtrRef<CharacterSprintData>(); // 0x18 (24)
		
		[ContainerField(28)]
		public CtrRef<MaterialContainerPair> MaterialPair { get; set; } = new CtrRef<MaterialContainerPair>(); // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public int PushableObjectWeight { get; set; } // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public float Mass { get; set; } // 0x24 (36)
		
		[ContainerField(40), LayoutImmutable, Blittable]
		public float MaxAscendAngle { get; set; } // 0x28 (40)
		
		[ContainerField(44), LayoutImmutable, Blittable]
		public float PhysicalRadius { get; set; } // 0x2C (44)
		
		[ContainerField(48), LayoutImmutable, Blittable]
		public float WaterDepthLimit { get; set; } // 0x30 (48)
		
		[ContainerField(52), LayoutImmutable, Blittable]
		public float InputAcceleration { get; set; } // 0x34 (52)
		
		[ContainerField(56), LayoutImmutable, Blittable]
		public float LadderAcceptAngle { get; set; } // 0x38 (56)
		
		[ContainerField(60), LayoutImmutable, Blittable]
		public float LadderAcceptAnglePitch { get; set; } // 0x3C (60)
		
		[ContainerField(64), LayoutImmutable, Blittable]
		public float JumpPenaltyTime { get; set; } // 0x40 (64)
		
		[ContainerField(68), LayoutImmutable, Blittable]
		public float JumpPenaltyFactor { get; set; } // 0x44 (68)
		
		[ContainerField(72), LayoutImmutable, Blittable]
		public float RadiusToPredictCollisionOnCharacters { get; set; } // 0x48 (72)
		
		[ContainerField(76), LayoutImmutable, Blittable]
		public bool AllowPoseChangeDuringTransition { get; set; } // 0x4C (76)
		
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
