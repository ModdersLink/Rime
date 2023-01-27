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

	[AntBinding(0xda337aab)]
	public class DefaultTagCollectionAsset
		: AntObject
	{
		[AntField(0)]
		public IdRefArray<BoolGameStateTag> TagKeys { get; set; } = new();

		[AntField(1)]
		public IdRefArray<BoolGameStateTag> MonitoredTagKeys { get; set; } = new();

	}
}
