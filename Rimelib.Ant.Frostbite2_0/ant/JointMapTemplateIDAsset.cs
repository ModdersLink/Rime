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

	[AntBinding(0xaa2961e6)]
	public class JointMapTemplateIDAsset
		: AntObject
	{
		[AntField(0)]
		public IdRef<BaseJointMapTemplateAsset> TemplateAsset { get; set; } = new();

		[AntField(1)]
		public int EnumValue { get; set; }

	}
}
