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
	[ContainerType(4, 16)]
	public class DifficultyDatas : 
		Asset
	{
		[ContainerField(12)]
		public List<CtrRef<DifficultyData>> Difficulties { get; set; } = new();

		public static void Deserialize(DifficultyDatas p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Difficulties.Clear();
			(RimeReader Reader, uint Count) s_Difficulties = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Difficulties.Count; ++i)
			{
				var s_CtrRef = new CtrRef<DifficultyData>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_Difficulties.Reader.ReadUInt32()));
				p_Instance.Difficulties.Add(s_CtrRef);
			}
			
			s_Difficulties.Reader.Dispose();
		}

	}
}
