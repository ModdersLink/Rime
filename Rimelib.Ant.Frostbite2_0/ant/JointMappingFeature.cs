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

	[AntBinding(0x59244a1a)]
	public class JointMappingFeature
		: RigFeatureAsset
	{
		[AntField(0)]
		public List<JointMappingData> JointMappings { get; set; } = new();

	}
}
