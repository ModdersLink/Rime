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

	[AntBinding(0xd1eb399e)]
	public class GameStateEnumerationAsset
		: AntObject
	{
		[AntField(0)]
		public IdRef<EnumerationAsset> EnumerationAsset { get; set; } = new();

		[AntField(1)]
		public int Default { get; set; }

	}
}
