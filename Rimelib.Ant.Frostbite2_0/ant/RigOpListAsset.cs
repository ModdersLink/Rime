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

	[AntBinding(0xe0e7b866)]
	public class RigOpListAsset
		: AntObject
	{
		[AntField(0)]
		public List<RigOpListBinding> DataRigOps { get; set; } = new();

	}
}
