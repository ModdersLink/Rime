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

	[AntBinding(0xce300c47)]
	public class StateFlowTransitionAsset
		: AntObject
	{
		[AntField(0)]
		public IdRef<BezierBlendAsset> OverrideBlend { get; set; } = new();

		[AntField(1)]
		public IdRef<BranchTypeAsset> BranchWindowTypeAsset { get; set; } = new();

		[AntField(2)]
		public IdRef<BranchTypeAsset> BranchInWindowTypeAsset { get; set; } = new();

		[AntField(3)]
		public IdRef<StateFlowNodeControllerAsset> From { get; set; } = new();

		[AntField(4)]
		public IdRef<StateFlowNodeControllerAsset> To { get; set; } = new();

		[AntField(5)]
		public IdRefArray<BoolAsset> ConditionsRequiredTrue { get; set; } = new();

		[AntField(6)]
		public IdRefArray<BoolAsset> ConditionsRequiredFalse { get; set; } = new();

		[AntField(7)]
		public IdRef<TagCollectionSetAsset> TagCollectionSet { get; set; } = new();

		[AntField(8)]
		public byte BranchInPhase { get; set; }

		[AntField(9)]
		public float DestinationPhase { get; set; }

		[AntField(10)]
		public bool BranchInAny { get; set; }

	}
}
