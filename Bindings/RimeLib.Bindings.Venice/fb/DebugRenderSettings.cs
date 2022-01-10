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

		public static void Deserialize(DebugRenderSettings p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.TextQueueTimeVisible = p_Reader.ReadSingle();
			p_Instance.Ps3SpuFrameBufferSize = p_Reader.ReadUInt32();
			p_Instance.TextViewDistance = p_Reader.ReadSingle();
			p_Instance.TextQueueMaxLineCount = p_Reader.ReadUInt32();
			p_Instance.DxMaxVertexCount = p_Reader.ReadUInt32();
			p_Instance.ProcessJobCount = p_Reader.ReadInt32();
			p_Instance.DrawStatsEnable = p_Reader.ReadBool();
			p_Instance.Ps3SpuEnable = p_Reader.ReadBool();
			p_Instance.Enable = p_Reader.ReadBool();
			p_Instance.TextQueueLocationTop = p_Reader.ReadBool();
			p_Instance.DxLine2dAntialiasingEnable = p_Reader.ReadBool();
			p_Instance.DxLine3dAntialiasingEnable = p_Reader.ReadBool();
			p_Reader.Seek(2, SeekOrigin.Current);
		}

	}
}
