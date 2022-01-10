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
	[ContainerType(4, 72)]
	public class NetworkSettings : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public uint ProtocolVersion { get; set; }

		[ContainerField(12), LayoutImmutable]
		public string TitleId { get; set; } = string.Empty;

		[ContainerField(16), LayoutImmutable, Blittable]
		public uint ClientPort { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public uint ServerPort { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public uint MaxGhostCount { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable]
		public uint MaxClientCount { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable]
		public uint MaxClientFrameSize { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable]
		public uint MaxServerFrameSize { get; set; }

		[ContainerField(40), LayoutImmutable]
		public string XlspAddress { get; set; } = string.Empty;

		[ContainerField(44), LayoutImmutable]
		public string ServerAddress { get; set; } = string.Empty;

		[ContainerField(48), LayoutImmutable]
		public string ClientConnectionDebugFilePrefix { get; set; } = string.Empty;

		[ContainerField(52), LayoutImmutable]
		public string ServerConnectionDebugFilePrefix { get; set; } = string.Empty;

		[ContainerField(56), LayoutImmutable, Blittable]
		public float TimeNudgeGhostFrequencyFactor { get; set; }

		[ContainerField(60), LayoutImmutable, Blittable]
		public float TimeNudgeBias { get; set; }

		[ContainerField(64), LayoutImmutable, Blittable]
		public float ConnectTimeout { get; set; }

		[ContainerField(68), LayoutImmutable, Blittable]
		public bool UseFrameManager { get; set; }

		[ContainerField(69), LayoutImmutable, Blittable]
		public bool TimeSyncEnabled { get; set; }

		[ContainerField(70), LayoutImmutable, Blittable]
		public bool IncrementServerPortOnFail { get; set; }

		public static void Deserialize(NetworkSettings p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.ProtocolVersion = p_Reader.ReadUInt32();
			p_Instance.TitleId = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.ClientPort = p_Reader.ReadUInt32();
			p_Instance.ServerPort = p_Reader.ReadUInt32();
			p_Instance.MaxGhostCount = p_Reader.ReadUInt32();
			p_Instance.MaxClientCount = p_Reader.ReadUInt32();
			p_Instance.MaxClientFrameSize = p_Reader.ReadUInt32();
			p_Instance.MaxServerFrameSize = p_Reader.ReadUInt32();
			p_Instance.XlspAddress = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.ServerAddress = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.ClientConnectionDebugFilePrefix = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.ServerConnectionDebugFilePrefix = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.TimeNudgeGhostFrequencyFactor = p_Reader.ReadSingle();
			p_Instance.TimeNudgeBias = p_Reader.ReadSingle();
			p_Instance.ConnectTimeout = p_Reader.ReadSingle();
			p_Instance.UseFrameManager = p_Reader.ReadBool();
			p_Instance.TimeSyncEnabled = p_Reader.ReadBool();
			p_Instance.IncrementServerPortOnFail = p_Reader.ReadBool();
			p_Reader.Seek(1, SeekOrigin.Current);
		}

	}
}
