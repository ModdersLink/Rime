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

	[AntBinding(0xa9c9e425)]
	public class TouchRegion
		: AntObject
	{
		[AntField(0)]
		public AntVector3 CenterPoint { get; set; } = new();

		[AntField(1)]
		public AntVector3 PositiveBounds { get; set; } = new();

		[AntField(2)]
		public AntVector3 NegativeBounds { get; set; } = new();

		[AntField(3)]
		public float RegionSpeed { get; set; }

	}
}
