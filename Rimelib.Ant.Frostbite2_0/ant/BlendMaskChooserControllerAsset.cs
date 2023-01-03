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

	[AntBinding(0x7e3aba09)]
	public class BlendMaskChooserControllerAsset
		: AntObject
	{
		[AntField(0)]
		public IdRefArray<EnumChooserEntryAsset> EntryAssetList { get; set; } = new();

		[AntField(1)]
		public IdRef<EnumChooserPolicyAsset> PolicyAsset { get; set; } = new();

		[AntField(2)]
		public bool ChooseOnReset { get; set; }

		[AntField(3)]
		public bool ChooseEveryUpdate { get; set; }

		[AntField(4)]
		public int BlendType { get; set; }

		[AntField(5)]
		public float NumBlendFrames { get; set; }

		[AntField(6)]
		public IdRef<AntObject> CurrentChoice { get; set; } = new();

	}
}
