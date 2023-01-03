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

	[AntBinding(0xc9be6e25)]
	public class BaseJointMapTemplateAsset
		: AntObject
	{
		[AntField(0)]
		public IdRefArray<JointMapTemplateIDAsset> IDList { get; set; } = new();

	}
}
