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
		public RefArray<CriteriaData> GeneralCriteria { get; set; } = new();

		[ContainerField(20), LayoutImmutable, Blittable]
		public bool GeneralStatistics { get; set; }

	}
}
