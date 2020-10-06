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
	[ContainerType(4), MemberInfoFlag(41), ContainerSize(32), ContainerStruct]
	public class AntiSpamConfig : FrostbiteContainer
	{
		[ContainerField(0), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float DetectionInterval { get; set; } // 0x0 (0)
		
		[ContainerField(4), LayoutImmutable, Blittable, MemberInfoFlag(49421)]
		public uint DetectionIntervalMaxMessageCount { get; set; } // 0x4 (4)
		
		[ContainerField(8), LayoutImmutable, Blittable, MemberInfoFlag(49421)]
		public uint ServerSideMessageCountTolerance { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable, MemberInfoFlag(49421)]
		public uint SecondsBlocked { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable, MemberInfoFlag(49421)]
		public uint ServerSideSecondsBlockedTolerance { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, MemberInfoFlag(16509)]
		public string NotificationSid { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, MemberInfoFlag(16509)]
		public string StillBlockedSid { get; set; } // 0x18 (24)
		
		[ContainerField(28), MemberInfoFlag(53), ContainerCtrRef]
		public CtrRef<SoundWaveAsset> WarningSound { get; set; } = new CtrRef<SoundWaveAsset>(); // 0x1C (28)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2687662965:
					DetectionInterval = (float) p_Value;
					break;

				case 1519475401:
					DetectionIntervalMaxMessageCount = (uint) p_Value;
					break;

				case 2059768186:
					ServerSideMessageCountTolerance = (uint) p_Value;
					break;

				case 3680341614:
					SecondsBlocked = (uint) p_Value;
					break;

				case 2942017753:
					ServerSideSecondsBlockedTolerance = (uint) p_Value;
					break;

				case 4064585174:
					NotificationSid = (string) p_Value;
					break;

				case 928322077:
					StillBlockedSid = (string) p_Value;
					break;

				case 2673651404:
					WarningSound = (CtrRef<SoundWaveAsset>) p_Value;
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
				case 2687662965:
					return DetectionInterval;

				case 1519475401:
					return DetectionIntervalMaxMessageCount;

				case 2059768186:
					return ServerSideMessageCountTolerance;

				case 3680341614:
					return SecondsBlocked;

				case 2942017753:
					return ServerSideSecondsBlockedTolerance;

				case 4064585174:
					return NotificationSid;

				case 928322077:
					return StillBlockedSid;

				case 2673651404:
					return WarningSound;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2687662965:
					return typeof(AntiSpamConfig).GetProperty(nameof(DetectionInterval));

				case 1519475401:
					return typeof(AntiSpamConfig).GetProperty(nameof(DetectionIntervalMaxMessageCount));

				case 2059768186:
					return typeof(AntiSpamConfig).GetProperty(nameof(ServerSideMessageCountTolerance));

				case 3680341614:
					return typeof(AntiSpamConfig).GetProperty(nameof(SecondsBlocked));

				case 2942017753:
					return typeof(AntiSpamConfig).GetProperty(nameof(ServerSideSecondsBlockedTolerance));

				case 4064585174:
					return typeof(AntiSpamConfig).GetProperty(nameof(NotificationSid));

				case 928322077:
					return typeof(AntiSpamConfig).GetProperty(nameof(StillBlockedSid));

				case 2673651404:
					return typeof(AntiSpamConfig).GetProperty(nameof(WarningSound));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
