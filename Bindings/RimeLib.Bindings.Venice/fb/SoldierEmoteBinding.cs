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
	[ContainerType(4), MemberInfoFlag(41), ContainerSize(64), ContainerStruct]
	public class SoldierEmoteBinding : FrostbiteContainer
	{
		[ContainerField(0), MemberInfoFlag(41)]
		public AntRef Speak { get; set; } = new AntRef(); // 0x0 (0)
		
		[ContainerField(4), MemberInfoFlag(41)]
		public AntRef IsSquadLeader { get; set; } = new AntRef(); // 0x4 (4)
		
		[ContainerField(8), MemberInfoFlag(41)]
		public AntRef EmoteSpot { get; set; } = new AntRef(); // 0x8 (8)
		
		[ContainerField(12), MemberInfoFlag(41)]
		public AntRef EmoteOk { get; set; } = new AntRef(); // 0xC (12)
		
		[ContainerField(16), MemberInfoFlag(41)]
		public AntRef EmoteNeedARide { get; set; } = new AntRef(); // 0x10 (16)
		
		[ContainerField(20), MemberInfoFlag(41)]
		public AntRef EmoteGoGoGo { get; set; } = new AntRef(); // 0x14 (20)
		
		[ContainerField(24), MemberInfoFlag(41)]
		public AntRef EmoteNeedBackup { get; set; } = new AntRef(); // 0x18 (24)
		
		[ContainerField(28), MemberInfoFlag(41)]
		public AntRef EmoteThanks { get; set; } = new AntRef(); // 0x1C (28)
		
		[ContainerField(32), MemberInfoFlag(41)]
		public AntRef EmoteNeedMedic { get; set; } = new AntRef(); // 0x20 (32)
		
		[ContainerField(36), MemberInfoFlag(41)]
		public AntRef EmoteFollowMe { get; set; } = new AntRef(); // 0x24 (36)
		
		[ContainerField(40), MemberInfoFlag(41)]
		public AntRef EmoteNeedAmmo { get; set; } = new AntRef(); // 0x28 (40)
		
		[ContainerField(44), MemberInfoFlag(41)]
		public AntRef EmoteSorry { get; set; } = new AntRef(); // 0x2C (44)
		
		[ContainerField(48), MemberInfoFlag(41)]
		public AntRef EmoteNo { get; set; } = new AntRef(); // 0x30 (48)
		
		[ContainerField(52), MemberInfoFlag(41)]
		public AntRef EmoteDefendCapturePoint { get; set; } = new AntRef(); // 0x34 (52)
		
		[ContainerField(56), MemberInfoFlag(41)]
		public AntRef EmoteAttackCapturePoint { get; set; } = new AntRef(); // 0x38 (56)
		
		[ContainerField(60), MemberInfoFlag(41)]
		public AntRef EmoteMoveToPosition { get; set; } = new AntRef(); // 0x3C (60)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 230886921:
					Speak = (AntRef) p_Value;
					break;

				case 215794326:
					IsSquadLeader = (AntRef) p_Value;
					break;

				case 2461279019:
					EmoteSpot = (AntRef) p_Value;
					break;

				case 25924759:
					EmoteOk = (AntRef) p_Value;
					break;

				case 1724790978:
					EmoteNeedARide = (AntRef) p_Value;
					break;

				case 1039124251:
					EmoteGoGoGo = (AntRef) p_Value;
					break;

				case 1254362103:
					EmoteNeedBackup = (AntRef) p_Value;
					break;

				case 613118968:
					EmoteThanks = (AntRef) p_Value;
					break;

				case 1719165247:
					EmoteNeedMedic = (AntRef) p_Value;
					break;

				case 1620732426:
					EmoteFollowMe = (AntRef) p_Value;
					break;

				case 2785400695:
					EmoteNeedAmmo = (AntRef) p_Value;
					break;

				case 3912552534:
					EmoteSorry = (AntRef) p_Value;
					break;

				case 25924978:
					EmoteNo = (AntRef) p_Value;
					break;

				case 3478388147:
					EmoteDefendCapturePoint = (AntRef) p_Value;
					break;

				case 534389299:
					EmoteAttackCapturePoint = (AntRef) p_Value;
					break;

				case 1059056960:
					EmoteMoveToPosition = (AntRef) p_Value;
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
				case 230886921:
					return Speak;

				case 215794326:
					return IsSquadLeader;

				case 2461279019:
					return EmoteSpot;

				case 25924759:
					return EmoteOk;

				case 1724790978:
					return EmoteNeedARide;

				case 1039124251:
					return EmoteGoGoGo;

				case 1254362103:
					return EmoteNeedBackup;

				case 613118968:
					return EmoteThanks;

				case 1719165247:
					return EmoteNeedMedic;

				case 1620732426:
					return EmoteFollowMe;

				case 2785400695:
					return EmoteNeedAmmo;

				case 3912552534:
					return EmoteSorry;

				case 25924978:
					return EmoteNo;

				case 3478388147:
					return EmoteDefendCapturePoint;

				case 534389299:
					return EmoteAttackCapturePoint;

				case 1059056960:
					return EmoteMoveToPosition;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 230886921:
					return typeof(SoldierEmoteBinding).GetProperty(nameof(Speak));

				case 215794326:
					return typeof(SoldierEmoteBinding).GetProperty(nameof(IsSquadLeader));

				case 2461279019:
					return typeof(SoldierEmoteBinding).GetProperty(nameof(EmoteSpot));

				case 25924759:
					return typeof(SoldierEmoteBinding).GetProperty(nameof(EmoteOk));

				case 1724790978:
					return typeof(SoldierEmoteBinding).GetProperty(nameof(EmoteNeedARide));

				case 1039124251:
					return typeof(SoldierEmoteBinding).GetProperty(nameof(EmoteGoGoGo));

				case 1254362103:
					return typeof(SoldierEmoteBinding).GetProperty(nameof(EmoteNeedBackup));

				case 613118968:
					return typeof(SoldierEmoteBinding).GetProperty(nameof(EmoteThanks));

				case 1719165247:
					return typeof(SoldierEmoteBinding).GetProperty(nameof(EmoteNeedMedic));

				case 1620732426:
					return typeof(SoldierEmoteBinding).GetProperty(nameof(EmoteFollowMe));

				case 2785400695:
					return typeof(SoldierEmoteBinding).GetProperty(nameof(EmoteNeedAmmo));

				case 3912552534:
					return typeof(SoldierEmoteBinding).GetProperty(nameof(EmoteSorry));

				case 25924978:
					return typeof(SoldierEmoteBinding).GetProperty(nameof(EmoteNo));

				case 3478388147:
					return typeof(SoldierEmoteBinding).GetProperty(nameof(EmoteDefendCapturePoint));

				case 534389299:
					return typeof(SoldierEmoteBinding).GetProperty(nameof(EmoteAttackCapturePoint));

				case 1059056960:
					return typeof(SoldierEmoteBinding).GetProperty(nameof(EmoteMoveToPosition));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
