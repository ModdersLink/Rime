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

	[AntBinding(0xfc6c1bbe)]
	public class JointToEffectorFeatureAsset
		: RigFeatureAsset
	{
		[AntField(0)]
		public List<int> EffectorJoints { get; set; } = new();

		[AntField(1)]
		public IdRefArray<FloatAsset> ReachFloats { get; set; } = new();

		[AntField(2)]
		public IdRefArray<AntObject> CanCopyJoint { get; set; } = new();

	}
}
