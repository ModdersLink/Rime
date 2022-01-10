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
	[ContainerType(4, 44)]
	public class AntTrackData : 
		CustomSequenceTrackData
	{
		[ContainerField(40)]
		public List<CtrRef<AntTrackItemData>> AntTrackItemDatas { get; set; } = new();

		public static void Deserialize(AntTrackData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.AntTrackItemDatas.Clear();
			(RimeReader Reader, uint Count) s_AntTrackItemDatas = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_AntTrackItemDatas.Count; ++i)
			{
				var s_CtrRef = new CtrRef<AntTrackItemData>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_AntTrackItemDatas.Reader.ReadUInt32()));
				p_Instance.AntTrackItemDatas.Add(s_CtrRef);
			}
			
			s_AntTrackItemDatas.Reader.Dispose();
		}

	}
}
