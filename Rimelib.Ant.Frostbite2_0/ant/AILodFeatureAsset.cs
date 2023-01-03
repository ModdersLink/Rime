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

	[AntBinding(0x8d8817f7)]
	public class AILodFeatureAsset
		: AntObject
	{
		[AntField(0)]
		public IdRef<BoolAsset> ToggleLocomotionOnly { get; set; } = new();

		[AntField(1)]
		public IdRef<PointerAsset> LocoCommandHandle { get; set; } = new();

		[AntField(2)]
		public IdRef<PointerAsset> CommandQueue { get; set; } = new();

		[AntField(3)]
		public IdRef<RigOpListAsset> FullRigOpList { get; set; } = new();

		[AntField(4)]
		public IdRef<RigOpListAsset> DeltaTrajectoryRigOpList { get; set; } = new();

	}
}
