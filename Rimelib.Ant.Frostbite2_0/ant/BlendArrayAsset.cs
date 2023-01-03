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

	[AntBinding(0xe7d02906)]
	public class BlendArrayAsset
		: ControllerAsset
	{
		[AntField(1)]
		public int NumItems { get; set; }

		[AntField(2)]
		public List<BlendArrayItem?> Items { get; set; } = new();

		[AntField(3)]
		public float Min { get; set; }

		[AntField(4)]
		public float Max { get; set; }

		[AntField(5)]
		public int SnapToAnim { get; set; }

	}
}
