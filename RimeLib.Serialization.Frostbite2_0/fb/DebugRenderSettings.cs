///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(4, 40)]
	public class DebugRenderSettings :
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		public float TextQueueTimeVisible { get; set; }

		[ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		public uint Ps3SpuFrameBufferSize { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public float TextViewDistance { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		public uint TextQueueMaxLineCount { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		public uint DxMaxVertexCount { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		public int ProcessJobCount { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public bool DrawStatsEnable { get; set; }

		[ContainerField(33), LayoutImmutable, Blittable, JsonProperty(Order = 33)]
		public bool Ps3SpuEnable { get; set; }

		[ContainerField(34), LayoutImmutable, Blittable, JsonProperty(Order = 34)]
		public bool Enable { get; set; }

		[ContainerField(35), LayoutImmutable, Blittable, JsonProperty(Order = 35)]
		public bool TextQueueLocationTop { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		public bool DxLine2dAntialiasingEnable { get; set; }

		[ContainerField(37), LayoutImmutable, Blittable, JsonProperty(Order = 37)]
		public bool DxLine3dAntialiasingEnable { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(TextQueueTimeVisible);
			p_Writer.Write(Ps3SpuFrameBufferSize);
			p_Writer.Write(TextViewDistance);
			p_Writer.Write(TextQueueMaxLineCount);
			p_Writer.Write(DxMaxVertexCount);
			p_Writer.Write(ProcessJobCount);
			p_Writer.Write(DrawStatsEnable);
			p_Writer.Write(Ps3SpuEnable);
			p_Writer.Write(Enable);
			p_Writer.Write(TextQueueLocationTop);
			p_Writer.Write(DxLine2dAntialiasingEnable);
			p_Writer.Write(DxLine3dAntialiasingEnable);
			p_Writer.WriteNullBytes(2);
		}
	}
}
