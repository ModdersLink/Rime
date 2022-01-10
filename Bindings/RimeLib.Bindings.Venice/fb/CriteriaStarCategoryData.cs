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
	public class CriteriaStarCategoryData : 
		DataContainer
	{
		[ContainerField(8)]
		public List<CriteriaStarCategoryInstance> CriteriaInstances { get; set; } = new();

		public static void Deserialize(CriteriaStarCategoryData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.CriteriaInstances.Clear();
			(RimeReader Reader, uint Count) s_CriteriaInstances = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_CriteriaInstances.Count; ++i)
			{
				var s_Value = new CriteriaStarCategoryInstance();
				fb.CriteriaStarCategoryInstance.Deserialize(s_Value, s_CriteriaInstances.Reader, p_Parser);
				p_Instance.CriteriaInstances.Add(s_Value);
			}
			
			s_CriteriaInstances.Reader.Dispose();
		}

	}
}
