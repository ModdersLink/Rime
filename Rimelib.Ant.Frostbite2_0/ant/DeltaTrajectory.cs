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

	[AntBinding(0x36dd7d3e)]
	public class DeltaTrajectory
		: AntObject
	{
		[AntField(0)]
		public IdRef<FloatAsset> DeltaTicks { get; set; } = new();

		[AntField(1)]
		public uint VelocityMode { get; set; }

	}
}
