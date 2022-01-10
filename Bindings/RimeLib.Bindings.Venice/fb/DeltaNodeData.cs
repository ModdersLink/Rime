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
	[ContainerType(4, 12)]
	public class DeltaNodeData : 
		AudioGraphNodeData
	{
		[ContainerField(8)]
		public List<CtrRef<DeltaGroup>> Deltas { get; set; } = new();

		public static void Deserialize(DeltaNodeData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Deltas.Clear();
			(RimeReader Reader, uint Count) s_Deltas = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Deltas.Count; ++i)
			{
				var s_CtrRef = new CtrRef<DeltaGroup>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_Deltas.Reader.ReadUInt32()));
				p_Instance.Deltas.Add(s_CtrRef);
			}
			
			s_Deltas.Reader.Dispose();
		}

	}
}
