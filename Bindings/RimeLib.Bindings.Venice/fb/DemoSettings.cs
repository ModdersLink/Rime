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
	[ContainerType(4, 52)]
	public class DemoSettings : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable]
		public string RecordDemoFileName { get; set; } = string.Empty;

		[ContainerField(12), LayoutImmutable]
		public string PlaybackDemoFileName { get; set; } = string.Empty;

		[ContainerField(16), LayoutImmutable]
		public string TimeDemo { get; set; } = string.Empty;

		[ContainerField(20), LayoutImmutable]
		public string LockToPlayerName { get; set; } = string.Empty;

		[ContainerField(24), LayoutImmutable, Blittable]
		public uint ChangePlayerInterval { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable]
		public uint ForcedDeltaTickCount { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable]
		public uint StartProfilingOnFrame { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable]
		public uint StopProfilingOnFrame { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable]
		public uint TakeScreenshotOnFrame { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable]
		public bool AllowOverwrite { get; set; }

		[ContainerField(45), LayoutImmutable, Blittable]
		public bool LogPerformance { get; set; }

		[ContainerField(46), LayoutImmutable, Blittable]
		public bool SuppressDebugLog { get; set; }

		[ContainerField(47), LayoutImmutable, Blittable]
		public bool ShutdownOnDemoComplete { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable]
		public bool LoopingDemo { get; set; }

		[ContainerField(49), LayoutImmutable, Blittable]
		public bool LockToRandomPlayer { get; set; }

		[ContainerField(50), LayoutImmutable, Blittable]
		public bool PauseOnStartup { get; set; }

		public static void Deserialize(DemoSettings p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.RecordDemoFileName = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.PlaybackDemoFileName = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.TimeDemo = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.LockToPlayerName = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.ChangePlayerInterval = p_Reader.ReadUInt32();
			p_Instance.ForcedDeltaTickCount = p_Reader.ReadUInt32();
			p_Instance.StartProfilingOnFrame = p_Reader.ReadUInt32();
			p_Instance.StopProfilingOnFrame = p_Reader.ReadUInt32();
			p_Instance.TakeScreenshotOnFrame = p_Reader.ReadUInt32();
			p_Instance.AllowOverwrite = p_Reader.ReadBool();
			p_Instance.LogPerformance = p_Reader.ReadBool();
			p_Instance.SuppressDebugLog = p_Reader.ReadBool();
			p_Instance.ShutdownOnDemoComplete = p_Reader.ReadBool();
			p_Instance.LoopingDemo = p_Reader.ReadBool();
			p_Instance.LockToRandomPlayer = p_Reader.ReadBool();
			p_Instance.PauseOnStartup = p_Reader.ReadBool();
			p_Reader.Seek(1, SeekOrigin.Current);
		}

	}
}
