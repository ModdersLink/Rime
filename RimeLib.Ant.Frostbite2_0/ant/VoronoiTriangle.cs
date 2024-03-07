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

	[AntBinding(0x5b6c2e0e)]
	public class VoronoiTriangle
		: AntObject
	{
		[AntField(0)]
		public List<AntVector2> Positions { get; set; } = new();

		[AntField(1)]
		public List<AntVector2> EdgeNormals { get; set; } = new();

		[AntField(2)]
		public List<int> V { get; set; } = new();

		[AntField(3)]
		public float Area { get; set; }

		[AntField(4)]
		public float InverseArea { get; set; }

	}
}
