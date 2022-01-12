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
		public RefArray<StatsCategoryBaseData> BaseSubCategories { get; set; } = new();

		[ContainerField(16), LayoutImmutable]
		public string Code { get; set; } = string.Empty;

	}
}
