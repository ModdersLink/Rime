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
	public class PlayerViewData : 
		DataContainer
	{
		[ContainerField(8)]
		public List<CtrRef<SubViewData>> SubViews { get; set; } = new();

		public static void Deserialize(PlayerViewData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.SubViews.Clear();
			(RimeReader Reader, uint Count) s_SubViews = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_SubViews.Count; ++i)
			{
				var s_CtrRef = new CtrRef<SubViewData>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_SubViews.Reader.ReadUInt32()));
				p_Instance.SubViews.Add(s_CtrRef);
			}
			
			s_SubViews.Reader.Dispose();
		}

	}
}
