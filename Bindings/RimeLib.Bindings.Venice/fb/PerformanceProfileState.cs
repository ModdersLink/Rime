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
	[ContainerType(8, 56)]
	public class PerformanceProfileState : 
		MetricState
	{
		[ContainerField(24), LayoutImmutable, Blittable]
		public uint ProcessorCount { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable]
		public uint ProcessorCoreCount { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable]
		public uint ProcessorClock { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable]
		public uint TotalMemMB { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable]
		public uint GpuMemMB { get; set; }

		[ContainerField(44), LayoutImmutable]
		public string GraphicAdapterName { get; set; } = string.Empty;

		[ContainerField(48), LayoutImmutable]
		public string Platform { get; set; } = string.Empty;

		public static void Deserialize(PerformanceProfileState p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.ProcessorCount = p_Reader.ReadUInt32();
			p_Instance.ProcessorCoreCount = p_Reader.ReadUInt32();
			p_Instance.ProcessorClock = p_Reader.ReadUInt32();
			p_Instance.TotalMemMB = p_Reader.ReadUInt32();
			p_Instance.GpuMemMB = p_Reader.ReadUInt32();
			p_Instance.GraphicAdapterName = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.Platform = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Reader.Seek(4, SeekOrigin.Current);
		}

	}
}
