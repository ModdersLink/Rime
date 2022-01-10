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
	public class StatsCategoryData : 
		StatsCategoryBaseData
	{
		[ContainerField(20)]
		public List<CtrRef<StatsCategoryData>> Categories { get; set; } = new();

		[ContainerField(24)]
		public List<string> Members { get; set; } = new();

		public static void Deserialize(StatsCategoryData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Categories.Clear();
			(RimeReader Reader, uint Count) s_Categories = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Categories.Count; ++i)
			{
				var s_CtrRef = new CtrRef<StatsCategoryData>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_Categories.Reader.ReadUInt32()));
				p_Instance.Categories.Add(s_CtrRef);
			}
			
			s_Categories.Reader.Dispose();
			p_Instance.Members.Clear();
			(RimeReader Reader, uint Count) s_Members = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Members.Count; ++i)
			{
				var s_Value = p_Parser.GetStringAtOffset(s_Members.Reader.ReadUInt32());
				p_Instance.Members.Add(s_Value);
			}
			
			s_Members.Reader.Dispose();
		}

	}
}
