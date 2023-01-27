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

	[AntBinding(0xb614df97)]
	public class ReceiverControllerAsset
		: ControllerAsset
	{
		[AntField(0)]
		public IdRefArray<InteractionTypeAsset> InteractionTypeList { get; set; } = new();

		[AntField(1)]
		public IdRefArray<BranchTypeAsset> BranchTypeList { get; set; } = new();

		[AntField(2)]
		public IdRef<PointerAsset> InteractionManagerPtr { get; set; } = new();

	}
}
