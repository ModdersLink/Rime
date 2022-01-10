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
	[ContainerType(4, 32)]
	public class StatCategoriesTree : 
		StatCategoriesBaseTree
	{
		[ContainerField(28)]
		public List<CtrRef<StatsCategoryData>> Categories { get; set; } = new();

		public static void Deserialize(StatCategoriesTree p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
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
		}

	}
}
