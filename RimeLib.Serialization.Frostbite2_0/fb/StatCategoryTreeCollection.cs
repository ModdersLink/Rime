///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(4, 16)]
	public class StatCategoryTreeCollection :
		Asset
	{
		[ContainerField(12), JsonProperty(Order = 12)]
		public RefArray<StatCategoriesBaseTree> CategoryTrees { get; set; } = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_CategoryTrees = p_EbxWriter.GetArrayWriter(CategoryTrees.GetType(), CategoryTrees.Count);
			p_Writer.Write(s_CategoryTrees.ArrayIndex);
			foreach (var s_Entry in CategoryTrees)
			{
				s_CategoryTrees.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
		}
	}
}
