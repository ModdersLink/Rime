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
	[ContainerType(4, 36)]
	public class UIAwardsScreenCompData : 
		UIComponentData
	{
		[ContainerField(28)]
		public List<CtrRef<StatsCategoryBaseData>> TrackableAwardRow { get; set; } = new();

		[ContainerField(32)]
		public List<CtrRef<StatsCategoryBaseData>> TrackableAwardCol { get; set; } = new();

		public static void Deserialize(UIAwardsScreenCompData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.TrackableAwardRow.Clear();
			(RimeReader Reader, uint Count) s_TrackableAwardRow = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_TrackableAwardRow.Count; ++i)
			{
				var s_CtrRef = new CtrRef<StatsCategoryBaseData>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_TrackableAwardRow.Reader.ReadUInt32()));
				p_Instance.TrackableAwardRow.Add(s_CtrRef);
			}
			
			s_TrackableAwardRow.Reader.Dispose();
			p_Instance.TrackableAwardCol.Clear();
			(RimeReader Reader, uint Count) s_TrackableAwardCol = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_TrackableAwardCol.Count; ++i)
			{
				var s_CtrRef = new CtrRef<StatsCategoryBaseData>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_TrackableAwardCol.Reader.ReadUInt32()));
				p_Instance.TrackableAwardCol.Add(s_CtrRef);
			}
			
			s_TrackableAwardCol.Reader.Dispose();
		}

	}
}
