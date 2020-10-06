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
	[ContainerType(4), MemberInfoFlag(41), ContainerSize(92), ContainerStruct]
	public class SoldierHealthModuleBinding : FrostbiteContainer
	{
		[ContainerField(0), MemberInfoFlag(41)]
		public AntRef HeadShot { get; set; } = new AntRef(); // 0x0 (0)
		
		[ContainerField(4), MemberInfoFlag(41)]
		public AntRef LeftArmHit { get; set; } = new AntRef(); // 0x4 (4)
		
		[ContainerField(8), MemberInfoFlag(41)]
		public AntRef RightArmHit { get; set; } = new AntRef(); // 0x8 (8)
		
		[ContainerField(12), MemberInfoFlag(41)]
		public AntRef LeftLegHit { get; set; } = new AntRef(); // 0xC (12)
		
		[ContainerField(16), MemberInfoFlag(41)]
		public AntRef RightLegHit { get; set; } = new AntRef(); // 0x10 (16)
		
		[ContainerField(20), MemberInfoFlag(41)]
		public AntRef OnGround { get; set; } = new AntRef(); // 0x14 (20)
		
		[ContainerField(24), MemberInfoFlag(41)]
		public AntRef DeathAnimationTriggered { get; set; } = new AntRef(); // 0x18 (24)
		
		[ContainerField(28), MemberInfoFlag(41)]
		public AntRef RandomAnimationIndex { get; set; } = new AntRef(); // 0x1C (28)
		
		[ContainerField(32), MemberInfoFlag(41)]
		public AntRef Sprinting { get; set; } = new AntRef(); // 0x20 (32)
		
		[ContainerField(36), MemberInfoFlag(41)]
		public AntRef HitLeft { get; set; } = new AntRef(); // 0x24 (36)
		
		[ContainerField(40), MemberInfoFlag(41)]
		public AntRef HitRight { get; set; } = new AntRef(); // 0x28 (40)
		
		[ContainerField(44), MemberInfoFlag(41)]
		public AntRef HitFront { get; set; } = new AntRef(); // 0x2C (44)
		
		[ContainerField(48), MemberInfoFlag(41)]
		public AntRef HitBack { get; set; } = new AntRef(); // 0x30 (48)
		
		[ContainerField(52), MemberInfoFlag(41)]
		public AntRef DeathHitDirection { get; set; } = new AntRef(); // 0x34 (52)
		
		[ContainerField(56), MemberInfoFlag(41)]
		public AntRef Explosion { get; set; } = new AntRef(); // 0x38 (56)
		
		[ContainerField(60), MemberInfoFlag(41)]
		public AntRef Dead { get; set; } = new AntRef(); // 0x3C (60)
		
		[ContainerField(64), MemberInfoFlag(41)]
		public AntRef Revived { get; set; } = new AntRef(); // 0x40 (64)
		
		[ContainerField(68), MemberInfoFlag(41)]
		public AntRef RandomValue { get; set; } = new AntRef(); // 0x44 (68)
		
		[ContainerField(72), MemberInfoFlag(41)]
		public AntRef Pose { get; set; } = new AntRef(); // 0x48 (72)
		
		[ContainerField(76), MemberInfoFlag(41)]
		public AntRef RightSpeed { get; set; } = new AntRef(); // 0x4C (76)
		
		[ContainerField(80), MemberInfoFlag(41)]
		public AntRef ForwardSpeed { get; set; } = new AntRef(); // 0x50 (80)
		
		[ContainerField(84), MemberInfoFlag(41)]
		public AntRef CriticallyHit { get; set; } = new AntRef(); // 0x54 (84)
		
		[ContainerField(88), MemberInfoFlag(41)]
		public AntRef InteractiveManDown { get; set; } = new AntRef(); // 0x58 (88)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1879088173:
					HeadShot = (AntRef) p_Value;
					break;

				case 3127433237:
					LeftArmHit = (AntRef) p_Value;
					break;

				case 2197362286:
					RightArmHit = (AntRef) p_Value;
					break;

				case 2411705509:
					LeftLegHit = (AntRef) p_Value;
					break;

				case 2600294366:
					RightLegHit = (AntRef) p_Value;
					break;

				case 1569364897:
					OnGround = (AntRef) p_Value;
					break;

				case 47349622:
					DeathAnimationTriggered = (AntRef) p_Value;
					break;

				case 3646496566:
					RandomAnimationIndex = (AntRef) p_Value;
					break;

				case 3687360775:
					Sprinting = (AntRef) p_Value;
					break;

				case 1867156715:
					HitLeft = (AntRef) p_Value;
					break;

				case 1460819504:
					HitRight = (AntRef) p_Value;
					break;

				case 1483500369:
					HitFront = (AntRef) p_Value;
					break;

				case 1866940763:
					HitBack = (AntRef) p_Value;
					break;

				case 2501867113:
					DeathHitDirection = (AntRef) p_Value;
					break;

				case 2222171184:
					Explosion = (AntRef) p_Value;
					break;

				case 2088734529:
					Dead = (AntRef) p_Value;
					break;

				case 1309478938:
					Revived = (AntRef) p_Value;
					break;

				case 1123937429:
					RandomValue = (AntRef) p_Value;
					break;

				case 2089458956:
					Pose = (AntRef) p_Value;
					break;

				case 742191746:
					RightSpeed = (AntRef) p_Value;
					break;

				case 333477913:
					ForwardSpeed = (AntRef) p_Value;
					break;

				case 2270513582:
					CriticallyHit = (AntRef) p_Value;
					break;

				case 701073533:
					InteractiveManDown = (AntRef) p_Value;
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
				case 1879088173:
					return HeadShot;

				case 3127433237:
					return LeftArmHit;

				case 2197362286:
					return RightArmHit;

				case 2411705509:
					return LeftLegHit;

				case 2600294366:
					return RightLegHit;

				case 1569364897:
					return OnGround;

				case 47349622:
					return DeathAnimationTriggered;

				case 3646496566:
					return RandomAnimationIndex;

				case 3687360775:
					return Sprinting;

				case 1867156715:
					return HitLeft;

				case 1460819504:
					return HitRight;

				case 1483500369:
					return HitFront;

				case 1866940763:
					return HitBack;

				case 2501867113:
					return DeathHitDirection;

				case 2222171184:
					return Explosion;

				case 2088734529:
					return Dead;

				case 1309478938:
					return Revived;

				case 1123937429:
					return RandomValue;

				case 2089458956:
					return Pose;

				case 742191746:
					return RightSpeed;

				case 333477913:
					return ForwardSpeed;

				case 2270513582:
					return CriticallyHit;

				case 701073533:
					return InteractiveManDown;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1879088173:
					return typeof(SoldierHealthModuleBinding).GetProperty(nameof(HeadShot));

				case 3127433237:
					return typeof(SoldierHealthModuleBinding).GetProperty(nameof(LeftArmHit));

				case 2197362286:
					return typeof(SoldierHealthModuleBinding).GetProperty(nameof(RightArmHit));

				case 2411705509:
					return typeof(SoldierHealthModuleBinding).GetProperty(nameof(LeftLegHit));

				case 2600294366:
					return typeof(SoldierHealthModuleBinding).GetProperty(nameof(RightLegHit));

				case 1569364897:
					return typeof(SoldierHealthModuleBinding).GetProperty(nameof(OnGround));

				case 47349622:
					return typeof(SoldierHealthModuleBinding).GetProperty(nameof(DeathAnimationTriggered));

				case 3646496566:
					return typeof(SoldierHealthModuleBinding).GetProperty(nameof(RandomAnimationIndex));

				case 3687360775:
					return typeof(SoldierHealthModuleBinding).GetProperty(nameof(Sprinting));

				case 1867156715:
					return typeof(SoldierHealthModuleBinding).GetProperty(nameof(HitLeft));

				case 1460819504:
					return typeof(SoldierHealthModuleBinding).GetProperty(nameof(HitRight));

				case 1483500369:
					return typeof(SoldierHealthModuleBinding).GetProperty(nameof(HitFront));

				case 1866940763:
					return typeof(SoldierHealthModuleBinding).GetProperty(nameof(HitBack));

				case 2501867113:
					return typeof(SoldierHealthModuleBinding).GetProperty(nameof(DeathHitDirection));

				case 2222171184:
					return typeof(SoldierHealthModuleBinding).GetProperty(nameof(Explosion));

				case 2088734529:
					return typeof(SoldierHealthModuleBinding).GetProperty(nameof(Dead));

				case 1309478938:
					return typeof(SoldierHealthModuleBinding).GetProperty(nameof(Revived));

				case 1123937429:
					return typeof(SoldierHealthModuleBinding).GetProperty(nameof(RandomValue));

				case 2089458956:
					return typeof(SoldierHealthModuleBinding).GetProperty(nameof(Pose));

				case 742191746:
					return typeof(SoldierHealthModuleBinding).GetProperty(nameof(RightSpeed));

				case 333477913:
					return typeof(SoldierHealthModuleBinding).GetProperty(nameof(ForwardSpeed));

				case 2270513582:
					return typeof(SoldierHealthModuleBinding).GetProperty(nameof(CriticallyHit));

				case 701073533:
					return typeof(SoldierHealthModuleBinding).GetProperty(nameof(InteractiveManDown));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
