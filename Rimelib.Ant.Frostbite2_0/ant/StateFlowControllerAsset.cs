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

	[AntBinding(0x48b5b0ad)]
	public class StateFlowControllerAsset
		: ControllerAsset
	{
		[AntField(0)]
		public IdRef<StateFlowNodeControllerAsset> StartNode { get; set; } = new();

		[AntField(1)]
		public IdRef<AntObject> MirroredSignal { get; set; } = new();

		[AntField(2)]
		public IdRef<AntObject> StateOpAsset { get; set; } = new();

		[AntField(3)]
		public IdRefArray<StateFlowNodeControllerAsset> StateFlowNodeAssets { get; set; } = new();

		[AntField(4)]
		public IdRefArray<StateFlowTransitionAsset> StateFlowTransitionAssets { get; set; } = new();

		[AntField(5)]
		public uint MaxActiveNodes { get; set; }

		[AntField(6)]
		public uint Identifier { get; set; }

	}
}
