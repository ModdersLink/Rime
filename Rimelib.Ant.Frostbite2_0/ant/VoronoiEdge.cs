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

	[AntBinding(0x26e3fe8b)]
	public class VoronoiEdge
		: AntObject
	{
		[AntField(0)]
		public AntVector2 PosBegin { get; set; } = new();

		[AntField(1)]
		public AntVector2 PosEnd { get; set; } = new();

		[AntField(2)]
		public AntVector2 Edge { get; set; } = new();

		[AntField(3)]
		public AntVector2 Normal { get; set; } = new();

		[AntField(4)]
		public float Length { get; set; }

		[AntField(5)]
		public bool IsDegenerate { get; set; }

		[AntField(6)]
		public int TriangleIndex { get; set; }

	}
}
