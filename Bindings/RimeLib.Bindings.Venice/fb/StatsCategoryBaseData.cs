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
	[ContainerType(4, 20)]
	public class StatsCategoryBaseData : 
		TreeNodeBase
	{
		[ContainerField(12)]
		public List<CtrRef<StatsCategoryBaseData>> BaseSubCategories { get; set; } = new();

		[ContainerField(16), LayoutImmutable]
		public string Code { get; set; } = string.Empty;

		public static void Deserialize(StatsCategoryBaseData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.BaseSubCategories.Clear();
			(RimeReader Reader, uint Count) s_BaseSubCategories = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_BaseSubCategories.Count; ++i)
			{
				var s_CtrRef = new CtrRef<StatsCategoryBaseData>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_BaseSubCategories.Reader.ReadUInt32()));
				p_Instance.BaseSubCategories.Add(s_CtrRef);
			}
			
			s_BaseSubCategories.Reader.Dispose();
			p_Instance.Code = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
		}

	}
}
