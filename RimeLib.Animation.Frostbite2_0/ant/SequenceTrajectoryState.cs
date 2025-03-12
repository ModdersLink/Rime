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

	[AntBinding(0x2cac4852)]
	public class SequenceTrajectoryState
		: AntObject
	{
		[AntField(0)]
		public int TrajCount { get; set; }

		[AntField(1)]
		public List<float> TrajX { get; set; } = new();

		[AntField(2)]
		public List<float> TrajY { get; set; } = new();

		[AntField(3)]
		public List<float> TrajZ { get; set; } = new();

		[AntField(4)]
		public List<float> TrajAngles { get; set; } = new();

	}
}
