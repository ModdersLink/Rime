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

	[AntBinding(0xe95262d5)]
	public class BezierBlendAsset
		: IBlendAsset
	{
		[AntField(2)]
		public List<float> Samples { get; set; } = new();

		[AntField(3)]
		public bool BlendBallActive { get; set; }

		[AntField(4)]
		public float BlendBallTime { get; set; }

	}
}
