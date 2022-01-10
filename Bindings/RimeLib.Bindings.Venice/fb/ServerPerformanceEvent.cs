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
	[ContainerType(8, 40)]
	public class ServerPerformanceEvent : 
		MetricEvent
	{
		[ContainerField(16), LayoutImmutable, Blittable]
		public float CPUAverage { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public float CPUMemory { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public uint Received { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable]
		public uint Sent { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable]
		public float ReceivedAverage { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable]
		public float SentAverage { get; set; }

		public static void Deserialize(ServerPerformanceEvent p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.CPUAverage = p_Reader.ReadSingle();
			p_Instance.CPUMemory = p_Reader.ReadSingle();
			p_Instance.Received = p_Reader.ReadUInt32();
			p_Instance.Sent = p_Reader.ReadUInt32();
			p_Instance.ReceivedAverage = p_Reader.ReadSingle();
			p_Instance.SentAverage = p_Reader.ReadSingle();
		}

	}
}
