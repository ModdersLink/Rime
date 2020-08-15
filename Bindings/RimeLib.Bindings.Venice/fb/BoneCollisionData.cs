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
	[ContainerType(16)]
	public class BoneCollisionData : FrostbiteContainer
	{
		[ContainerField(0), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 DebugDrawColor { get; set; } = new Vec4(); // 0x0 (0)
		
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 CapsuleOffset { get; set; } = new Vec3(); // 0x10 (16)
		
		[ContainerField(32), LayoutImmutable]
		public string BoneName { get; set; } // 0x20 (32)
		
		[ContainerField(36)]
		public HitReactionType AnimationHitReactionType { get; set; } = new HitReactionType(); // 0x24 (36)
		
		[ContainerField(40)]
		public CtrRef<MaterialContainerPair> MaterialPair { get; set; } = new CtrRef<MaterialContainerPair>(); // 0x28 (40)
		
		[ContainerField(44), LayoutImmutable, Blittable]
		public int BoneAxis { get; set; } // 0x2C (44)
		
		[ContainerField(48), LayoutImmutable, Blittable]
		public float CapsuleLength { get; set; } // 0x30 (48)
		
		[ContainerField(52), LayoutImmutable, Blittable]
		public float CapsuleRadius { get; set; } // 0x34 (52)
		
		[ContainerField(64)]
		public PitchModifier MinPitch { get; set; } = new PitchModifier(); // 0x40 (64)
		
		[ContainerField(96)]
		public PitchModifier MaxPitch { get; set; } = new PitchModifier(); // 0x60 (96)
		
		[ContainerField(128), LayoutImmutable, Blittable]
		public bool ValidInHiLod { get; set; } // 0x80 (128)
		
		[ContainerField(129), LayoutImmutable, Blittable]
		public bool ValidInLowLod { get; set; } // 0x81 (129)
		
		[ContainerField(130), LayoutImmutable, Blittable]
		public bool UsePhysicsRotation { get; set; } // 0x82 (130)
		
		[ContainerField(131), LayoutImmutable, Blittable]
		public bool DeactivateIfBehindWall { get; set; } // 0x83 (131)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 34201065:
					DebugDrawColor = (Vec4) p_Value;
					break;

				case 1863560277:
					CapsuleOffset = (Vec3) p_Value;
					break;

				case 1590647844:
					BoneName = (string) p_Value;
					break;

				case 3424827895:
						AnimationHitReactionType = (HitReactionType) Enum.ToObject(typeof(HitReactionType), p_Value);
					break;

				case 161392100:
					MaterialPair = (CtrRef<MaterialContainerPair>) p_Value;
					break;

				case 1590208000:
					BoneAxis = (int) p_Value;
					break;

				case 1676345540:
					CapsuleLength = (float) p_Value;
					break;

				case 1441176608:
					CapsuleRadius = (float) p_Value;
					break;

				case 3374061353:
					MinPitch = (PitchModifier) p_Value;
					break;

				case 397101687:
					MaxPitch = (PitchModifier) p_Value;
					break;

				case 1872072018:
					ValidInHiLod = (bool) p_Value;
					break;

				case 1492667495:
					ValidInLowLod = (bool) p_Value;
					break;

				case 979803673:
					UsePhysicsRotation = (bool) p_Value;
					break;

				case 4263951528:
					DeactivateIfBehindWall = (bool) p_Value;
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
				case 34201065:
					return DebugDrawColor;

				case 1863560277:
					return CapsuleOffset;

				case 1590647844:
					return BoneName;

				case 3424827895:
					return AnimationHitReactionType;

				case 161392100:
					return MaterialPair;

				case 1590208000:
					return BoneAxis;

				case 1676345540:
					return CapsuleLength;

				case 1441176608:
					return CapsuleRadius;

				case 3374061353:
					return MinPitch;

				case 397101687:
					return MaxPitch;

				case 1872072018:
					return ValidInHiLod;

				case 1492667495:
					return ValidInLowLod;

				case 979803673:
					return UsePhysicsRotation;

				case 4263951528:
					return DeactivateIfBehindWall;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 34201065:
					return typeof(BoneCollisionData).GetProperty(nameof(DebugDrawColor));

				case 1863560277:
					return typeof(BoneCollisionData).GetProperty(nameof(CapsuleOffset));

				case 1590647844:
					return typeof(BoneCollisionData).GetProperty(nameof(BoneName));

				case 3424827895:
					return typeof(BoneCollisionData).GetProperty(nameof(AnimationHitReactionType));

				case 161392100:
					return typeof(BoneCollisionData).GetProperty(nameof(MaterialPair));

				case 1590208000:
					return typeof(BoneCollisionData).GetProperty(nameof(BoneAxis));

				case 1676345540:
					return typeof(BoneCollisionData).GetProperty(nameof(CapsuleLength));

				case 1441176608:
					return typeof(BoneCollisionData).GetProperty(nameof(CapsuleRadius));

				case 3374061353:
					return typeof(BoneCollisionData).GetProperty(nameof(MinPitch));

				case 397101687:
					return typeof(BoneCollisionData).GetProperty(nameof(MaxPitch));

				case 1872072018:
					return typeof(BoneCollisionData).GetProperty(nameof(ValidInHiLod));

				case 1492667495:
					return typeof(BoneCollisionData).GetProperty(nameof(ValidInLowLod));

				case 979803673:
					return typeof(BoneCollisionData).GetProperty(nameof(UsePhysicsRotation));

				case 4263951528:
					return typeof(BoneCollisionData).GetProperty(nameof(DeactivateIfBehindWall));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
