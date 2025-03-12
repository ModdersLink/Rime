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

	[AntBinding(0xc4a8b42)]
	public class IndexChooserControllerAsset
		: AntObject
	{
		[AntField(0)]
		public IdRefArray<ControllerAsset> ChoiceAssetList { get; set; } = new();

		[AntField(1)]
		public bool ChooseOnce { get; set; }

		[AntField(2)]
		public bool ChooseOnReset { get; set; }

		[AntField(3)]
		public IdRef<GameStateEnumerationAsset> IndexAsset { get; set; } = new();

	}
}
