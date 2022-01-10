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
	public class SceneRecordingData : 
		DataContainer
	{
		[ContainerField(8)]
		public List<CtrRef<EntityRecordingData>> Data { get; set; } = new();

		public static void Deserialize(SceneRecordingData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Data.Clear();
			(RimeReader Reader, uint Count) s_Data = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Data.Count; ++i)
			{
				var s_CtrRef = new CtrRef<EntityRecordingData>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_Data.Reader.ReadUInt32()));
				p_Instance.Data.Add(s_CtrRef);
			}
			
			s_Data.Reader.Dispose();
		}

	}
}
