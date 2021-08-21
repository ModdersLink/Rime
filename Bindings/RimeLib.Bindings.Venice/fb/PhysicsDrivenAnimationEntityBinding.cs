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
	[ContainerType(Alignment: 4,  Flags: 41, Size: 116)]
	public class PhysicsDrivenAnimationEntityBinding : FrostbiteContainer
	{
		[ContainerField(Name: "AimLeftRight", Offset: 0, NameHash: 159833211, Flags: 41)]
		public AntRef AimLeftRight { get; set; } = new AntRef(); // 0x0 (0)
		
		[ContainerField(Name: "AimUpDown", Offset: 4, NameHash: 2778567511, Flags: 41)]
		public AntRef AimUpDown { get; set; } = new AntRef(); // 0x4 (4)
		
		[ContainerField(Name: "Crouch", Offset: 8, NameHash: 2729602053, Flags: 41)]
		public AntRef Crouch { get; set; } = new AntRef(); // 0x8 (8)
		
		[ContainerField(Name: "ForceSetTrajectory", Offset: 12, NameHash: 622503969, Flags: 41)]
		public AntRef ForceSetTrajectory { get; set; } = new AntRef(); // 0xC (12)
		
		[ContainerField(Name: "InAir", Offset: 16, NameHash: 214471736, Flags: 41)]
		public AntRef InAir { get; set; } = new AntRef(); // 0x10 (16)
		
		[ContainerField(Name: "Skydive", Offset: 20, NameHash: 2978576858, Flags: 41)]
		public AntRef Skydive { get; set; } = new AntRef(); // 0x14 (20)
		
		[ContainerField(Name: "Parachute", Offset: 24, NameHash: 2952549480, Flags: 41)]
		public AntRef Parachute { get; set; } = new AntRef(); // 0x18 (24)
		
		[ContainerField(Name: "Swim", Offset: 28, NameHash: 2089393637, Flags: 41)]
		public AntRef Swim { get; set; } = new AntRef(); // 0x1C (28)
		
		[ContainerField(Name: "InputBackward", Offset: 32, NameHash: 1803140280, Flags: 41)]
		public AntRef InputBackward { get; set; } = new AntRef(); // 0x20 (32)
		
		[ContainerField(Name: "InputForward", Offset: 36, NameHash: 1377055592, Flags: 41)]
		public AntRef InputForward { get; set; } = new AntRef(); // 0x24 (36)
		
		[ContainerField(Name: "InputLeft", Offset: 40, NameHash: 2652303016, Flags: 41)]
		public AntRef InputLeft { get; set; } = new AntRef(); // 0x28 (40)
		
		[ContainerField(Name: "InputRight", Offset: 44, NameHash: 1586915283, Flags: 41)]
		public AntRef InputRight { get; set; } = new AntRef(); // 0x2C (44)
		
		[ContainerField(Name: "IsEnemy", Offset: 48, NameHash: 2758954501, Flags: 41)]
		public AntRef IsEnemy { get; set; } = new AntRef(); // 0x30 (48)
		
		[ContainerField(Name: "Jump", Offset: 52, NameHash: 2089106695, Flags: 41)]
		public AntRef Jump { get; set; } = new AntRef(); // 0x34 (52)
		
		[ContainerField(Name: "LeanLeftRight", Offset: 56, NameHash: 1838371096, Flags: 41)]
		public AntRef LeanLeftRight { get; set; } = new AntRef(); // 0x38 (56)
		
		[ContainerField(Name: "Prone", Offset: 60, NameHash: 231940067, Flags: 41)]
		public AntRef Prone { get; set; } = new AntRef(); // 0x3C (60)
		
		[ContainerField(Name: "Sprint", Offset: 64, NameHash: 3324856903, Flags: 41)]
		public AntRef Sprint { get; set; } = new AntRef(); // 0x40 (64)
		
		[ContainerField(Name: "GroundSupported", Offset: 68, NameHash: 3938707566, Flags: 41)]
		public AntRef GroundSupported { get; set; } = new AntRef(); // 0x44 (68)
		
		[ContainerField(Name: "GroundNormal", Offset: 72, NameHash: 3081183731, Flags: 41)]
		public AntRef GroundNormal { get; set; } = new AntRef(); // 0x48 (72)
		
		[ContainerField(Name: "GroundDistance", Offset: 76, NameHash: 1468700707, Flags: 41)]
		public AntRef GroundDistance { get; set; } = new AntRef(); // 0x4C (76)
		
		[ContainerField(Name: "GroundAngleZ", Offset: 80, NameHash: 2681866779, Flags: 41)]
		public AntRef GroundAngleZ { get; set; } = new AntRef(); // 0x50 (80)
		
		[ContainerField(Name: "GroundAngleX", Offset: 84, NameHash: 2681866777, Flags: 41)]
		public AntRef GroundAngleX { get; set; } = new AntRef(); // 0x54 (84)
		
		[ContainerField(Name: "GroundAngleFromNormal", Offset: 88, NameHash: 3644136484, Flags: 41)]
		public AntRef GroundAngleFromNormal { get; set; } = new AntRef(); // 0x58 (88)
		
		[ContainerField(Name: "IsClientAnimatable", Offset: 92, NameHash: 2825869266, Flags: 41)]
		public AntRef IsClientAnimatable { get; set; } = new AntRef(); // 0x5C (92)
		
		[ContainerField(Name: "CustomizationScreen", Offset: 96, NameHash: 1606661556, Flags: 41)]
		public AntRef CustomizationScreen { get; set; } = new AntRef(); // 0x60 (96)
		
		[ContainerField(Name: "Minimal3pServer", Offset: 100, NameHash: 4030580672, Flags: 41)]
		public AntRef Minimal3pServer { get; set; } = new AntRef(); // 0x64 (100)
		
		[ContainerField(Name: "VerticalImpact", Offset: 104, NameHash: 2494325141, Flags: 41)]
		public AntRef VerticalImpact { get; set; } = new AntRef(); // 0x68 (104)
		
		[ContainerField(Name: "FalseSignal", Offset: 108, NameHash: 486591334, Flags: 41)]
		public AntRef FalseSignal { get; set; } = new AntRef(); // 0x6C (108)
		
		[ContainerField(Name: "LockArmsToCameraWeight", Offset: 112, NameHash: 4025942465, Flags: 41)]
		public AntRef LockArmsToCameraWeight { get; set; } = new AntRef(); // 0x70 (112)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 159833211:
					AimLeftRight = (AntRef) p_Value;
					break;

				case 2778567511:
					AimUpDown = (AntRef) p_Value;
					break;

				case 2729602053:
					Crouch = (AntRef) p_Value;
					break;

				case 622503969:
					ForceSetTrajectory = (AntRef) p_Value;
					break;

				case 214471736:
					InAir = (AntRef) p_Value;
					break;

				case 2978576858:
					Skydive = (AntRef) p_Value;
					break;

				case 2952549480:
					Parachute = (AntRef) p_Value;
					break;

				case 2089393637:
					Swim = (AntRef) p_Value;
					break;

				case 1803140280:
					InputBackward = (AntRef) p_Value;
					break;

				case 1377055592:
					InputForward = (AntRef) p_Value;
					break;

				case 2652303016:
					InputLeft = (AntRef) p_Value;
					break;

				case 1586915283:
					InputRight = (AntRef) p_Value;
					break;

				case 2758954501:
					IsEnemy = (AntRef) p_Value;
					break;

				case 2089106695:
					Jump = (AntRef) p_Value;
					break;

				case 1838371096:
					LeanLeftRight = (AntRef) p_Value;
					break;

				case 231940067:
					Prone = (AntRef) p_Value;
					break;

				case 3324856903:
					Sprint = (AntRef) p_Value;
					break;

				case 3938707566:
					GroundSupported = (AntRef) p_Value;
					break;

				case 3081183731:
					GroundNormal = (AntRef) p_Value;
					break;

				case 1468700707:
					GroundDistance = (AntRef) p_Value;
					break;

				case 2681866779:
					GroundAngleZ = (AntRef) p_Value;
					break;

				case 2681866777:
					GroundAngleX = (AntRef) p_Value;
					break;

				case 3644136484:
					GroundAngleFromNormal = (AntRef) p_Value;
					break;

				case 2825869266:
					IsClientAnimatable = (AntRef) p_Value;
					break;

				case 1606661556:
					CustomizationScreen = (AntRef) p_Value;
					break;

				case 4030580672:
					Minimal3pServer = (AntRef) p_Value;
					break;

				case 2494325141:
					VerticalImpact = (AntRef) p_Value;
					break;

				case 486591334:
					FalseSignal = (AntRef) p_Value;
					break;

				case 4025942465:
					LockArmsToCameraWeight = (AntRef) p_Value;
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
				case 159833211:
					return AimLeftRight;

				case 2778567511:
					return AimUpDown;

				case 2729602053:
					return Crouch;

				case 622503969:
					return ForceSetTrajectory;

				case 214471736:
					return InAir;

				case 2978576858:
					return Skydive;

				case 2952549480:
					return Parachute;

				case 2089393637:
					return Swim;

				case 1803140280:
					return InputBackward;

				case 1377055592:
					return InputForward;

				case 2652303016:
					return InputLeft;

				case 1586915283:
					return InputRight;

				case 2758954501:
					return IsEnemy;

				case 2089106695:
					return Jump;

				case 1838371096:
					return LeanLeftRight;

				case 231940067:
					return Prone;

				case 3324856903:
					return Sprint;

				case 3938707566:
					return GroundSupported;

				case 3081183731:
					return GroundNormal;

				case 1468700707:
					return GroundDistance;

				case 2681866779:
					return GroundAngleZ;

				case 2681866777:
					return GroundAngleX;

				case 3644136484:
					return GroundAngleFromNormal;

				case 2825869266:
					return IsClientAnimatable;

				case 1606661556:
					return CustomizationScreen;

				case 4030580672:
					return Minimal3pServer;

				case 2494325141:
					return VerticalImpact;

				case 486591334:
					return FalseSignal;

				case 4025942465:
					return LockArmsToCameraWeight;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 159833211:
					return typeof(PhysicsDrivenAnimationEntityBinding).GetProperty(nameof(AimLeftRight));

				case 2778567511:
					return typeof(PhysicsDrivenAnimationEntityBinding).GetProperty(nameof(AimUpDown));

				case 2729602053:
					return typeof(PhysicsDrivenAnimationEntityBinding).GetProperty(nameof(Crouch));

				case 622503969:
					return typeof(PhysicsDrivenAnimationEntityBinding).GetProperty(nameof(ForceSetTrajectory));

				case 214471736:
					return typeof(PhysicsDrivenAnimationEntityBinding).GetProperty(nameof(InAir));

				case 2978576858:
					return typeof(PhysicsDrivenAnimationEntityBinding).GetProperty(nameof(Skydive));

				case 2952549480:
					return typeof(PhysicsDrivenAnimationEntityBinding).GetProperty(nameof(Parachute));

				case 2089393637:
					return typeof(PhysicsDrivenAnimationEntityBinding).GetProperty(nameof(Swim));

				case 1803140280:
					return typeof(PhysicsDrivenAnimationEntityBinding).GetProperty(nameof(InputBackward));

				case 1377055592:
					return typeof(PhysicsDrivenAnimationEntityBinding).GetProperty(nameof(InputForward));

				case 2652303016:
					return typeof(PhysicsDrivenAnimationEntityBinding).GetProperty(nameof(InputLeft));

				case 1586915283:
					return typeof(PhysicsDrivenAnimationEntityBinding).GetProperty(nameof(InputRight));

				case 2758954501:
					return typeof(PhysicsDrivenAnimationEntityBinding).GetProperty(nameof(IsEnemy));

				case 2089106695:
					return typeof(PhysicsDrivenAnimationEntityBinding).GetProperty(nameof(Jump));

				case 1838371096:
					return typeof(PhysicsDrivenAnimationEntityBinding).GetProperty(nameof(LeanLeftRight));

				case 231940067:
					return typeof(PhysicsDrivenAnimationEntityBinding).GetProperty(nameof(Prone));

				case 3324856903:
					return typeof(PhysicsDrivenAnimationEntityBinding).GetProperty(nameof(Sprint));

				case 3938707566:
					return typeof(PhysicsDrivenAnimationEntityBinding).GetProperty(nameof(GroundSupported));

				case 3081183731:
					return typeof(PhysicsDrivenAnimationEntityBinding).GetProperty(nameof(GroundNormal));

				case 1468700707:
					return typeof(PhysicsDrivenAnimationEntityBinding).GetProperty(nameof(GroundDistance));

				case 2681866779:
					return typeof(PhysicsDrivenAnimationEntityBinding).GetProperty(nameof(GroundAngleZ));

				case 2681866777:
					return typeof(PhysicsDrivenAnimationEntityBinding).GetProperty(nameof(GroundAngleX));

				case 3644136484:
					return typeof(PhysicsDrivenAnimationEntityBinding).GetProperty(nameof(GroundAngleFromNormal));

				case 2825869266:
					return typeof(PhysicsDrivenAnimationEntityBinding).GetProperty(nameof(IsClientAnimatable));

				case 1606661556:
					return typeof(PhysicsDrivenAnimationEntityBinding).GetProperty(nameof(CustomizationScreen));

				case 4030580672:
					return typeof(PhysicsDrivenAnimationEntityBinding).GetProperty(nameof(Minimal3pServer));

				case 2494325141:
					return typeof(PhysicsDrivenAnimationEntityBinding).GetProperty(nameof(VerticalImpact));

				case 486591334:
					return typeof(PhysicsDrivenAnimationEntityBinding).GetProperty(nameof(FalseSignal));

				case 4025942465:
					return typeof(PhysicsDrivenAnimationEntityBinding).GetProperty(nameof(LockArmsToCameraWeight));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
