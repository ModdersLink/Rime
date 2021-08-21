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
	[ContainerType(Alignment: 4,  Flags: 41, Size: 72)]
	public class AILocoCoverBinding : FrostbiteContainer
	{
		[ContainerField(Name: "PrepareFire", Offset: 0, NameHash: 2746539868, Flags: 41)]
		public AntRef PrepareFire { get; set; } = new AntRef(); // 0x0 (0)
		
		[ContainerField(Name: "ThrowGrenade", Offset: 4, NameHash: 2210644077, Flags: 41)]
		public AntRef ThrowGrenade { get; set; } = new AntRef(); // 0x4 (4)
		
		[ContainerField(Name: "PeekOut", Offset: 8, NameHash: 3756039152, Flags: 41)]
		public AntRef PeekOut { get; set; } = new AntRef(); // 0x8 (8)
		
		[ContainerField(Name: "IdleBehindCover", Offset: 12, NameHash: 2661629696, Flags: 41)]
		public AntRef IdleBehindCover { get; set; } = new AntRef(); // 0xC (12)
		
		[ContainerField(Name: "PeekType", Offset: 16, NameHash: 3690184166, Flags: 41)]
		public AntRef PeekType { get; set; } = new AntRef(); // 0x10 (16)
		
		[ContainerField(Name: "CoverTypeEnum", Offset: 20, NameHash: 2254217891, Flags: 41)]
		public AntRef CoverTypeEnum { get; set; } = new AntRef(); // 0x14 (20)
		
		[ContainerField(Name: "CoverFireStyle", Offset: 24, NameHash: 1027634375, Flags: 41)]
		public AntRef CoverFireStyle { get; set; } = new AntRef(); // 0x18 (24)
		
		[ContainerField(Name: "EnterCover", Offset: 28, NameHash: 4242418080, Flags: 41)]
		public AntRef EnterCover { get; set; } = new AntRef(); // 0x1C (28)
		
		[ContainerField(Name: "ExitCover", Offset: 32, NameHash: 3825704328, Flags: 41)]
		public AntRef ExitCover { get; set; } = new AntRef(); // 0x20 (32)
		
		[ContainerField(Name: "IsCloseCover", Offset: 36, NameHash: 1859127588, Flags: 41)]
		public AntRef IsCloseCover { get; set; } = new AntRef(); // 0x24 (36)
		
		[ContainerField(Name: "DistanceScale", Offset: 40, NameHash: 773140030, Flags: 41)]
		public AntRef DistanceScale { get; set; } = new AntRef(); // 0x28 (40)
		
		[ContainerField(Name: "AbsoluteDistance", Offset: 44, NameHash: 1029013297, Flags: 41)]
		public AntRef AbsoluteDistance { get; set; } = new AntRef(); // 0x2C (44)
		
		[ContainerField(Name: "AngleToNormal", Offset: 48, NameHash: 3510389260, Flags: 41)]
		public AntRef AngleToNormal { get; set; } = new AntRef(); // 0x30 (48)
		
		[ContainerField(Name: "OutAngle", Offset: 52, NameHash: 968880426, Flags: 41)]
		public AntRef OutAngle { get; set; } = new AntRef(); // 0x34 (52)
		
		[ContainerField(Name: "ThreatAngle", Offset: 56, NameHash: 1510288250, Flags: 41)]
		public AntRef ThreatAngle { get; set; } = new AntRef(); // 0x38 (56)
		
		[ContainerField(Name: "StopExitCoverOutAround", Offset: 60, NameHash: 2863174461, Flags: 41)]
		public AntRef StopExitCoverOutAround { get; set; } = new AntRef(); // 0x3C (60)
		
		[ContainerField(Name: "EnterStrategy", Offset: 64, NameHash: 2784850742, Flags: 41)]
		public AntRef EnterStrategy { get; set; } = new AntRef(); // 0x40 (64)
		
		[ContainerField(Name: "ExitStyle", Offset: 68, NameHash: 3843788370, Flags: 41)]
		public AntRef ExitStyle { get; set; } = new AntRef(); // 0x44 (68)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2746539868:
					PrepareFire = (AntRef) p_Value;
					break;

				case 2210644077:
					ThrowGrenade = (AntRef) p_Value;
					break;

				case 3756039152:
					PeekOut = (AntRef) p_Value;
					break;

				case 2661629696:
					IdleBehindCover = (AntRef) p_Value;
					break;

				case 3690184166:
					PeekType = (AntRef) p_Value;
					break;

				case 2254217891:
					CoverTypeEnum = (AntRef) p_Value;
					break;

				case 1027634375:
					CoverFireStyle = (AntRef) p_Value;
					break;

				case 4242418080:
					EnterCover = (AntRef) p_Value;
					break;

				case 3825704328:
					ExitCover = (AntRef) p_Value;
					break;

				case 1859127588:
					IsCloseCover = (AntRef) p_Value;
					break;

				case 773140030:
					DistanceScale = (AntRef) p_Value;
					break;

				case 1029013297:
					AbsoluteDistance = (AntRef) p_Value;
					break;

				case 3510389260:
					AngleToNormal = (AntRef) p_Value;
					break;

				case 968880426:
					OutAngle = (AntRef) p_Value;
					break;

				case 1510288250:
					ThreatAngle = (AntRef) p_Value;
					break;

				case 2863174461:
					StopExitCoverOutAround = (AntRef) p_Value;
					break;

				case 2784850742:
					EnterStrategy = (AntRef) p_Value;
					break;

				case 3843788370:
					ExitStyle = (AntRef) p_Value;
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
				case 2746539868:
					return PrepareFire;

				case 2210644077:
					return ThrowGrenade;

				case 3756039152:
					return PeekOut;

				case 2661629696:
					return IdleBehindCover;

				case 3690184166:
					return PeekType;

				case 2254217891:
					return CoverTypeEnum;

				case 1027634375:
					return CoverFireStyle;

				case 4242418080:
					return EnterCover;

				case 3825704328:
					return ExitCover;

				case 1859127588:
					return IsCloseCover;

				case 773140030:
					return DistanceScale;

				case 1029013297:
					return AbsoluteDistance;

				case 3510389260:
					return AngleToNormal;

				case 968880426:
					return OutAngle;

				case 1510288250:
					return ThreatAngle;

				case 2863174461:
					return StopExitCoverOutAround;

				case 2784850742:
					return EnterStrategy;

				case 3843788370:
					return ExitStyle;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2746539868:
					return typeof(AILocoCoverBinding).GetProperty(nameof(PrepareFire));

				case 2210644077:
					return typeof(AILocoCoverBinding).GetProperty(nameof(ThrowGrenade));

				case 3756039152:
					return typeof(AILocoCoverBinding).GetProperty(nameof(PeekOut));

				case 2661629696:
					return typeof(AILocoCoverBinding).GetProperty(nameof(IdleBehindCover));

				case 3690184166:
					return typeof(AILocoCoverBinding).GetProperty(nameof(PeekType));

				case 2254217891:
					return typeof(AILocoCoverBinding).GetProperty(nameof(CoverTypeEnum));

				case 1027634375:
					return typeof(AILocoCoverBinding).GetProperty(nameof(CoverFireStyle));

				case 4242418080:
					return typeof(AILocoCoverBinding).GetProperty(nameof(EnterCover));

				case 3825704328:
					return typeof(AILocoCoverBinding).GetProperty(nameof(ExitCover));

				case 1859127588:
					return typeof(AILocoCoverBinding).GetProperty(nameof(IsCloseCover));

				case 773140030:
					return typeof(AILocoCoverBinding).GetProperty(nameof(DistanceScale));

				case 1029013297:
					return typeof(AILocoCoverBinding).GetProperty(nameof(AbsoluteDistance));

				case 3510389260:
					return typeof(AILocoCoverBinding).GetProperty(nameof(AngleToNormal));

				case 968880426:
					return typeof(AILocoCoverBinding).GetProperty(nameof(OutAngle));

				case 1510288250:
					return typeof(AILocoCoverBinding).GetProperty(nameof(ThreatAngle));

				case 2863174461:
					return typeof(AILocoCoverBinding).GetProperty(nameof(StopExitCoverOutAround));

				case 2784850742:
					return typeof(AILocoCoverBinding).GetProperty(nameof(EnterStrategy));

				case 3843788370:
					return typeof(AILocoCoverBinding).GetProperty(nameof(ExitStyle));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
