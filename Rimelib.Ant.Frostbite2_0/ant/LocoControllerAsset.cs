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

	[AntBinding(0x2939854a)]
	public class LocoControllerAsset
		: AntObject
	{
		[AntField(0)]
		public IdRef<PriorityDatabaseAsset> PriorityDatabase { get; set; } = new();

		[AntField(2)]
		public IdRefArray<AntObject> BlendMasks { get; set; } = new();

		[AntField(3)]
		public IdRef<ContextDatabaseAsset> IdleContextDatabase { get; set; } = new();

		[AntField(4)]
		public string HipDofIdx { get; set; } = string.Empty;

		[AntField(5)]
		public string LeftFootDofIdx { get; set; } = string.Empty;

		[AntField(6)]
		public string RightFootDofIdx { get; set; } = string.Empty;

		[AntField(11)]
		public IdRef<PointerAsset> RailtrackPointer { get; set; } = new();

		[AntField(12)]
		public IdRef<PointerAsset> ContextPointer { get; set; } = new();

		[AntField(13)]
		public IdRef<AntObject> CadenceOverride { get; set; } = new();

		[AntField(14)]
		public IdRef<AntObject> TurnDatabase { get; set; } = new();

		[AntField(15)]
		public IdRef<ContextDatabaseAsset> TurnContextDatabase { get; set; } = new();

		[AntField(16)]
		public IdRef<ContextDatabaseAsset> RunCurvesDatabase { get; set; } = new();

		[AntField(17)]
		public IdRef<AntObject> DefaultWarpContextDatabaseAsset { get; set; } = new();

		[AntField(18)]
		public IdRef<ContextDatabaseAsset> OneOffContextDatabase { get; set; } = new();

		[AntField(19)]
		public bool UserSupplyInitParam { get; set; }

		[AntField(20)]
		public IdRef<PointerAsset> MoveToTargetJobPointer { get; set; } = new();

	}
}
