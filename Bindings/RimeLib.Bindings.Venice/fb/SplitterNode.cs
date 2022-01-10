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
	[ContainerType(4, 28)]
	public class SplitterNode : 
		UINodeData
	{
		[ContainerField(20)]
		public CtrRef<UINodePort> In { get; set; } = new();

		[ContainerField(24)]
		public List<CtrRef<UINodePort>> Outputs { get; set; } = new();

		public static void Deserialize(SplitterNode p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.In.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.Outputs.Clear();
			(RimeReader Reader, uint Count) s_Outputs = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Outputs.Count; ++i)
			{
				var s_CtrRef = new CtrRef<UINodePort>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_Outputs.Reader.ReadUInt32()));
				p_Instance.Outputs.Add(s_CtrRef);
			}
			
			s_Outputs.Reader.Dispose();
		}

	}
}
