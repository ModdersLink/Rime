///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4, 32)]
	public class AntiSpamConfig
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public float DetectionInterval { get; set; }
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public uint DetectionIntervalMaxMessageCount { get; set; }
		
		[ContainerField(8), LayoutImmutable, Blittable]
		public uint ServerSideMessageCountTolerance { get; set; }
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public uint SecondsBlocked { get; set; }
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public uint ServerSideSecondsBlockedTolerance { get; set; }
		
		[ContainerField(20), LayoutImmutable]
		public string NotificationSid { get; set; } = string.Empty;
		
		[ContainerField(24), LayoutImmutable]
		public string StillBlockedSid { get; set; } = string.Empty;
		
		[ContainerField(28)]
		public CtrRef<SoundWaveAsset> WarningSound { get; set; } = new();
		
		public static void Deserialize(AntiSpamConfig p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.DetectionInterval = p_Reader.ReadSingle();
			p_Instance.DetectionIntervalMaxMessageCount = p_Reader.ReadUInt32();
			p_Instance.ServerSideMessageCountTolerance = p_Reader.ReadUInt32();
			p_Instance.SecondsBlocked = p_Reader.ReadUInt32();
			p_Instance.ServerSideSecondsBlockedTolerance = p_Reader.ReadUInt32();
			p_Instance.NotificationSid = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.StillBlockedSid = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.WarningSound.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
		}
	}
}
