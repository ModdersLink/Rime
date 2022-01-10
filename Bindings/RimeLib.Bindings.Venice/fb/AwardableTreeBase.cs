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
	[ContainerType(4, 24)]
	public class AwardableTreeBase : 
		TreeBase
	{
		[ContainerField(12)]
		public CtrRef<StatCategoryTreeCollection> StatCategoryTreeCollection { get; set; } = new();

		[ContainerField(16)]
		public List<CtrRef<CriteriaData>> GeneralCriteria { get; set; } = new();

		[ContainerField(20), LayoutImmutable, Blittable]
		public bool GeneralStatistics { get; set; }

		public static void Deserialize(AwardableTreeBase p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.StatCategoryTreeCollection.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.GeneralCriteria.Clear();
			(RimeReader Reader, uint Count) s_GeneralCriteria = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_GeneralCriteria.Count; ++i)
			{
				var s_CtrRef = new CtrRef<CriteriaData>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_GeneralCriteria.Reader.ReadUInt32()));
				p_Instance.GeneralCriteria.Add(s_CtrRef);
			}
			
			s_GeneralCriteria.Reader.Dispose();
			p_Instance.GeneralStatistics = p_Reader.ReadBool();
			p_Reader.Seek(3, SeekOrigin.Current);
		}

	}
}
