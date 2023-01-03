///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// As type schemas dont contain full information, modifying  //
// can be done to fix information thats wrong or missing.    //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Collections.Generic;
using RimeLib.Ant.EA.Attributes;
using RimeLib.Ant.EA.Types;

namespace ant
{

	[AntBinding(0x4684311d)]
	public class EnumChooserEntryAsset
		: ChooserEntryAsset
	{
		[AntField(0)]
		public IdRef<EnumerationValueAsset> EnumerationValueAsset { get; set; } = new();

	}
}
