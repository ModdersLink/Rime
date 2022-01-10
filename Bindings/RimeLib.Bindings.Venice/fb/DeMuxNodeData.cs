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
	public class DeMuxNodeData : 
		AudioGraphNodeData
	{
		[ContainerField(8)]
		public List<CtrRef<DeMuxOutput>> Outputs { get; set; } = new();

		[ContainerField(12)]
		public AudioGraphNodePort Trigger { get; set; } = new();

		[ContainerField(20)]
		public AudioGraphNodePort Value { get; set; } = new();

		[ContainerField(28), LayoutImmutable, Blittable]
		public bool WrapValue { get; set; }

		public static void Deserialize(DeMuxNodeData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Outputs.Clear();
			(RimeReader Reader, uint Count) s_Outputs = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Outputs.Count; ++i)
			{
				var s_CtrRef = new CtrRef<DeMuxOutput>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_Outputs.Reader.ReadUInt32()));
				p_Instance.Outputs.Add(s_CtrRef);
			}
			
			s_Outputs.Reader.Dispose();
			fb.AudioGraphNodePort.Deserialize(p_Instance.Trigger, p_Reader, p_Parser);
			fb.AudioGraphNodePort.Deserialize(p_Instance.Value, p_Reader, p_Parser);
			p_Instance.WrapValue = p_Reader.ReadBool();
			p_Reader.Seek(3, SeekOrigin.Current);
		}

	}
}
