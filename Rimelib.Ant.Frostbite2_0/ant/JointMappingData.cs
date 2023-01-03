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

	[AntBinding(0x9905895b)]
	public class JointMappingData
		: AntObject
	{
		[AntField(0)]
		public IdRef<BaseJointMapTemplateAsset> JointTemplate { get; set; } = new();

		[AntField(1)]
		public List<int> JointIndices { get; set; } = new();

	}
}
