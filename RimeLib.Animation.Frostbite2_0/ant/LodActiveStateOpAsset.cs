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

	[AntBinding(0x949ecc80)]
	public class LodActiveStateOpAsset
		: AntObject
	{
		[AntField(0)]
		public bool ActiveValue { get; set; }

		[AntField(1)]
		public IdRef<BoolAsset> ActiveGameState { get; set; } = new();

	}
}
