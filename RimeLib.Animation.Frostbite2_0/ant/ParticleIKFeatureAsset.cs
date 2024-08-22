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

	[AntBinding(0x476e80a1)]
	public class ParticleIKFeatureAsset
		: RigFeatureAsset
	{
		[AntField(0)]
		public int NumTotalJoints { get; set; }

		[AntField(1)]
		public List<int> MappedJoints { get; set; } = new();

		[AntField(2)]
		public IdRef<BaseJointMapTemplateAsset> TrajectoryTemplate { get; set; } = new();

		[AntField(3)]
		public IdRef<BaseJointMapTemplateAsset> HumanoidTemplate { get; set; } = new();

	}
}
