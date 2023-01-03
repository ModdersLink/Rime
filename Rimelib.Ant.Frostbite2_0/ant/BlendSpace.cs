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

	[AntBinding(0xe9f0c678)]
	public class BlendSpace
		: ControllerAsset
	{
		[AntField(0)]
		public uint ValueType { get; set; }

		[AntField(1)]
		public VoronoiDiagram VoronoiDiagram { get; set; } = new();

		[AntField(2)]
		public int BlendMode { get; set; }

		[AntField(3)]
		public float SnapTolerance { get; set; }

		[AntField(4)]
		public int ClampMode { get; set; }

	}
}
