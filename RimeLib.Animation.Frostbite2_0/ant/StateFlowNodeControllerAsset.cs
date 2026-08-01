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

	[AntBinding(0xbd52af4)]
	[AntBinding(0xe026ce44)] // BF3 alpha schema (adds EnumTrue/FalseConditions)
	public class StateFlowNodeControllerAsset
		: ControllerAsset
	{
		[AntField(0)]
		public bool IsConduit { get; set; }

		[AntField(1)]
		public IdRef<SignalBlendArrayControllerAsset> SubjectController { get; set; } = new();

		[AntField(2)]
		public IdRef<NullTag> SubjectControllerInitParams { get; set; } = new();

		[AntField(3)]
		public IdRefArray<StateFlowTransitionAsset> Transitions { get; set; } = new();

		[AntField(4)]
		public IdRefArray<StateFlowTransitionAsset> TransitionLinks { get; set; } = new();

		[AntField(5)]
		public IdRef<StateOpListAsset> StateOpAsset { get; set; } = new();

		[AntField(6)]
		public IdRefArray<BoolAsset> EntryConditionsRequiredTrue { get; set; } = new();

		[AntField(7)]
		public IdRefArray<BoolAsset> EntryConditionsRequiredFalse { get; set; } = new();

		[AntField(8)]
		public IdRefArray<BoolAsset> ActiveSignals { get; set; } = new();

		[AntField(9)]
		public bool IsTransparent { get; set; }

		// Present only in the pre-release schema and dropped in retail. The parser binds a layout
		// member to the property of the same name, so these have to exist for that schema to parse.
		[AntField(8)]
		public IdRefArray<AntObject> EnumTrueConditions { get; set; } = new();

		[AntField(9)]
		public IdRefArray<AntObject> EnumFalseConditions { get; set; } = new();

	}
}
