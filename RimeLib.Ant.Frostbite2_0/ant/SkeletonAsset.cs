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

	[AntBinding(0x931fe7fb)]
	public class SkeletonAsset
		: AntObject
	{
		[AntField(0)]
		public List<JointInfo> Joints { get; set; } = new();

		[AntField(1)]
		public int TrajJointIndex { get; set; }

	}
}
