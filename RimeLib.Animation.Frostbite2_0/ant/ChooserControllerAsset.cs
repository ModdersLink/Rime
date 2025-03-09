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

	[AntBinding(0x25d8fda4)]
	public class ChooserControllerAsset
		: ControllerAsset
	{
		[AntField(0)]
		public IdRef<EnumChooserPolicyAsset> PolicyAsset { get; set; } = new();

		[AntField(1)]
		public IdRefArray<EnumChooserEntryAsset> EntryAssetList { get; set; } = new();

		[AntField(2)]
		public bool ChooseOnReset { get; set; }

		[AntField(3)]
		public bool ChooseEveryUpdate { get; set; }

		[AntField(4)]
		public IdRef<AntObject> CurrentChoice { get; set; } = new();

		[AntField(5)]
		public bool Looping { get; set; }

		[AntField(6)]
		public bool ChooseOnLoop { get; set; }

		[AntField(7)]
		public bool PhaseMatchPrevious { get; set; }

		[AntField(8)]
		public IdRef<BlendCurveAsset> BlendTag { get; set; } = new();

	}
}
