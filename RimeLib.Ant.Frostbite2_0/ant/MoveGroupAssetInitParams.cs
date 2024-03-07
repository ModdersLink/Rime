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

	[AntBinding(0x105c4214)]
	public class MoveGroupAssetInitParams
		: AntObject
	{
		[AntField(0)]
		public float Speed { get; set; }

		[AntField(1)]
		public float CycleLength { get; set; }

		[AntField(2)]
		public float RelMoveAngle { get; set; }

		[AntField(3)]
		public float Phase { get; set; }

	}
}
