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

	[AntBinding(0xfe4702a)]
	public class LayoutAsset
		: AntObject
	{
		[AntField(0)]
		public bool NoReorder { get; set; }

		[AntField(1)]
		public uint MinAlignment { get; set; }

		[AntField(2)]
		public List<LayoutEntry> Slots { get; set; } = new();

	}
}
