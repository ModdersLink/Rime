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

	[AntBinding(0xc11fde95)]
	public class LayersControllerAsset
		: ControllerAsset
	{
		[AntField(0)]
		public IdRefArray<SignalBlendArrayControllerAsset> ControllerAssets { get; set; } = new();

		[AntField(1)]
		public IdRefArray<NullTag> ControllerInitParams { get; set; } = new();

		[AntField(2)]
		public IdRefArray<FloatAsset> SignalAssets { get; set; } = new();

		[AntField(3)]
		public IdRefArray<BlendMaskChooserControllerAsset> BlendMaskControllers { get; set; } = new();

		[AntField(4)]
		public List<uint> UpdateModes { get; set; } = new();

		[AntField(5)]
		public List<uint> UpdateRates { get; set; } = new();

		[AntField(6)]
		public List<uint> BlendModes { get; set; } = new();

		[AntField(7)]
		public List<uint> BranchInModes { get; set; } = new();

		[AntField(8)]
		public byte MasterEntryIndex { get; set; }

	}
}
