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

	[AntBinding(0xe851f362)]
	public class SignalBlendSpaceControllerAsset
		: ControllerAsset
	{
		[AntField(0)]
		public IdRef<SequenceContainerAsset> MasterControllerAsset { get; set; } = new();

		[AntField(1)]
		public IdRef<ClipInitParam> MasterControllerInitParams { get; set; } = new();

		[AntField(2)]
		public float MasterLength { get; set; }

		[AntField(3)]
		public IdRef<BlendSpace> SubjectControllerAsset { get; set; } = new();

		[AntField(4)]
		public IdRef<InitParamsNDRT> SubjectControllerInitParams { get; set; } = new();

		[AntField(5)]
		public IdRef<FloatAsset> SignalAssetX { get; set; } = new();

		[AntField(6)]
		public IdRef<FloatAsset> SignalAssetY { get; set; } = new();

		[AntField(7)]
		public float SignalXMaxDec { get; set; }

		[AntField(8)]
		public float SignalXMaxInc { get; set; }

		[AntField(9)]
		public float SignalXMaxAcc { get; set; }

		[AntField(10)]
		public float SignalYMaxDec { get; set; }

		[AntField(11)]
		public float SignalYMaxInc { get; set; }

		[AntField(12)]
		public float SignalYMaxAcc { get; set; }

		[AntField(13)]
		public float RegionXMin { get; set; }

		[AntField(14)]
		public float RegionXMax { get; set; }

		[AntField(15)]
		public float RegionYMin { get; set; }

		[AntField(16)]
		public float RegionYMax { get; set; }

		[AntField(17)]
		public bool IsWrapX { get; set; }

		[AntField(18)]
		public bool IsWrapY { get; set; }

		[AntField(19)]
		public bool AbsoluteIncDecX { get; set; }

		[AntField(20)]
		public bool AbsoluteIncDecY { get; set; }

	}
}
