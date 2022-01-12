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
	[ContainerType(4, 40)]
	public class DebugRenderSettings : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public float TextQueueTimeVisible { get; set; }

		[ContainerField(12), LayoutImmutable, Blittable]
		public uint Ps3SpuFrameBufferSize { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable]
		public float TextViewDistance { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public uint TextQueueMaxLineCount { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public uint DxMaxVertexCount { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable]
		public int ProcessJobCount { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable]
		public bool DrawStatsEnable { get; set; }

		[ContainerField(33), LayoutImmutable, Blittable]
		public bool Ps3SpuEnable { get; set; }

		[ContainerField(34), LayoutImmutable, Blittable]
		public bool Enable { get; set; }

		[ContainerField(35), LayoutImmutable, Blittable]
		public bool TextQueueLocationTop { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable]
		public bool DxLine2dAntialiasingEnable { get; set; }

		[ContainerField(37), LayoutImmutable, Blittable]
		public bool DxLine3dAntialiasingEnable { get; set; }

	}
}
