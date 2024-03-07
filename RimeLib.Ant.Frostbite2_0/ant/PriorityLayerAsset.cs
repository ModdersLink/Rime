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

	[AntBinding(0x179bd40b)]
	public class PriorityLayerAsset
		: AntObject
	{
		[AntField(0)]
		public int Default { get; set; }

		[AntField(1)]
		public List<sbyte> Priority { get; set; } = new();

	}
}
