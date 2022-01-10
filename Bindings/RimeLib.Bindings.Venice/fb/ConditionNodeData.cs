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
	public class ConditionNodeData : 
		AudioGraphNodeData
	{
		[ContainerField(8)]
		public List<CtrRef<ConditionGroup>> Conditions { get; set; } = new();

		public static void Deserialize(ConditionNodeData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Conditions.Clear();
			(RimeReader Reader, uint Count) s_Conditions = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Conditions.Count; ++i)
			{
				var s_CtrRef = new CtrRef<ConditionGroup>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_Conditions.Reader.ReadUInt32()));
				p_Instance.Conditions.Add(s_CtrRef);
			}
			
			s_Conditions.Reader.Dispose();
		}

	}
}
