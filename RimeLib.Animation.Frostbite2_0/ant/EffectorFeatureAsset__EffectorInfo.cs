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

	[AntBinding(0xb47c153e)]
	public class EffectorFeatureAsset__EffectorInfo
		: AntObject
	{
		[AntField(0)]
		public int EffectorID { get; set; }

		[AntField(1)]
		public float ReachR { get; set; }

		[AntField(2)]
		public float ReachT { get; set; }

		[AntField(3)]
		public float Pull { get; set; }

		[AntField(4)]
		public float Resist { get; set; }

	}
}
