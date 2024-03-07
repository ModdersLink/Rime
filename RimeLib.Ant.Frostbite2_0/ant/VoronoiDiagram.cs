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

	[AntBinding(0x56e62d95)]
	public class VoronoiDiagram
		: AntObject
	{
		[AntField(0)]
		public AntVector2 PosMin { get; set; } = new();

		[AntField(1)]
		public AntVector2 PosMax { get; set; } = new();

		[AntField(2)]
		public AntVector2 PosCentroid { get; set; } = new();

		[AntField(3)]
		public float GridStepX { get; set; }

		[AntField(4)]
		public float GridStepY { get; set; }

		[AntField(5)]
		public List<VoronoiItem> Items { get; set; } = new();

		[AntField(6)]
		public List<VoronoiTriangle> Triangles { get; set; } = new();

		[AntField(7)]
		public List<VoronoiEdge> Edges { get; set; } = new();

		[AntField(8)]
		public List<VoronoiGridItem> GridItems { get; set; } = new();

		[AntField(9)]
		public uint NumColumns { get; set; }

		[AntField(10)]
		public uint NumRows { get; set; }

	}
}
