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
	[ContainerType(16, 48)]
	public class ProcessorData : 
		EmitterComponentData
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 DefaultValues { get; set; } = new();

		[ContainerField(32)]
		public CtrRef<ProcessorData> NextProcessor { get; set; } = new();

		[ContainerField(36)]
		public CtrRef<EmitterComponentData> Pre { get; set; } = new();

		[ContainerField(40)]
		public EmittableField EvaluatorInput { get; set; } = new();

		[ContainerField(44), LayoutImmutable, Blittable]
		public bool Enable { get; set; }

		public static void Deserialize(ProcessorData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Reader.Seek(8, SeekOrigin.Current);
			fb.Vec4.Deserialize(p_Instance.DefaultValues, p_Reader, p_Parser);
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.NextProcessor.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.Pre.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.EvaluatorInput = (EmittableField) p_Reader.ReadInt32();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.Enable = p_Reader.ReadBool();
			p_Reader.Seek(11, SeekOrigin.Current);
		}

	}
}
