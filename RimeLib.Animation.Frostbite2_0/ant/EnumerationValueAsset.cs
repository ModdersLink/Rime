///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// As type schemas dont contain full information, modifying  //
// can be done to fix information thats wrong or missing.    //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Collections.Generic;
using RimeLib.Animation.EA.Attributes;
using RimeLib.Animation.EA.Types;

namespace ant
{

	[AntBinding(0x5bea76b1)]
	public class EnumerationValueAsset
		: AntObject
	{
		[AntField(0)]
		public IdRef<EnumerationAsset> EnumerationAsset { get; set; } = new();

		[AntField(1)]
		public int Value { get; set; }

	}
}
