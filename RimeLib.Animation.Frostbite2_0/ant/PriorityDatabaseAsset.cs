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

	[AntBinding(0xd1394606)]
	public class PriorityDatabaseAsset
		: AntObject
	{
		[AntField(0)]
		public ContextDatabaseAsset? ContextDB { get; set; } = null;

		[AntField(1)]
		public List<PriorityLayerAsset?> Layers { get; set; } = new();

	}
}
