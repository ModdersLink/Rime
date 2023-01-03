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

	[AntBinding(0x25058d1)]
	public class Traj2RefFeatureAsset
		: RigFeatureAsset
	{
		[AntField(0)]
		public IdRef<BaseJointMapTemplateAsset> ReferenceTemplate { get; set; } = new();

		[AntField(1)]
		public IdRef<BaseJointMapTemplateAsset> TrajectoryTemplate { get; set; } = new();

		[AntField(2)]
		public int ReferenceJoint { get; set; }

		[AntField(3)]
		public int TrajectoryJoint { get; set; }

	}
}
