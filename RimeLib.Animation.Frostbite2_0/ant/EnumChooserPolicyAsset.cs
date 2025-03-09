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

	[AntBinding(0x3a6aa1f3)]
	public class EnumChooserPolicyAsset
		: AntObject
	{
		[AntField(0)]
		public IdRef<GameStateEnumerationAsset> GameStateAsset { get; set; } = new();

		[AntField(1)]
		public IdRef<EnumerationAsset> EnumerationAsset { get; set; } = new();

	}
}
