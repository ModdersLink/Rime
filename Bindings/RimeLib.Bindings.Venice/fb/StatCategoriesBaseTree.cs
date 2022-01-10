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
	public class StatCategoriesBaseTree : 
		TreeBase
	{
		[ContainerField(12)]
		public List<CtrRef<StatsCategoryBaseData>> RootBaseCategories { get; set; } = new();

		[ContainerField(16)]
		public List<CtrRef<CriteriaData>> ParamX { get; set; } = new();

		[ContainerField(20)]
		public List<CtrRef<CriteriaData>> ParamY { get; set; } = new();

		[ContainerField(24), LayoutImmutable, Blittable]
		public bool ProcessAllLevelsInTree { get; set; }

		public static void Deserialize(StatCategoriesBaseTree p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.RootBaseCategories.Clear();
			(RimeReader Reader, uint Count) s_RootBaseCategories = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_RootBaseCategories.Count; ++i)
			{
				var s_CtrRef = new CtrRef<StatsCategoryBaseData>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_RootBaseCategories.Reader.ReadUInt32()));
				p_Instance.RootBaseCategories.Add(s_CtrRef);
			}
			
			s_RootBaseCategories.Reader.Dispose();
			p_Instance.ParamX.Clear();
			(RimeReader Reader, uint Count) s_ParamX = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_ParamX.Count; ++i)
			{
				var s_CtrRef = new CtrRef<CriteriaData>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_ParamX.Reader.ReadUInt32()));
				p_Instance.ParamX.Add(s_CtrRef);
			}
			
			s_ParamX.Reader.Dispose();
			p_Instance.ParamY.Clear();
			(RimeReader Reader, uint Count) s_ParamY = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_ParamY.Count; ++i)
			{
				var s_CtrRef = new CtrRef<CriteriaData>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_ParamY.Reader.ReadUInt32()));
				p_Instance.ParamY.Add(s_CtrRef);
			}
			
			s_ParamY.Reader.Dispose();
			p_Instance.ProcessAllLevelsInTree = p_Reader.ReadBool();
			p_Reader.Seek(3, SeekOrigin.Current);
		}

	}
}
