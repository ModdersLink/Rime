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

	[AntBinding(0xe9f1a301)]
	public class EffectorFeatureAsset
		: RigFeatureAsset
	{
		[AntField(0)]
		public List<EffectorFeatureAsset__EffectorInfo> Effectors { get; set; } = new();

	}
}
