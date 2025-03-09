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

	[AntBinding(0x7f40f4ca)]
	public class BoolGameStateTag
		: GameStateTagAsset
	{
		[AntField(0)]
		public bool Value { get; set; }

		[AntField(1)]
		public int Mode { get; set; }

	}
}
