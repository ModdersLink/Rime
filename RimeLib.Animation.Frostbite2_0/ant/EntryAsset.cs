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

	[AntBinding(0x11932ed2)]
	public class EntryAsset
		: AntObject
	{
		[AntField(0)]
		public IdRef<AntObject> Asset { get; set; } = new();

		[AntField(1)]
		public List<AntObject?> Cells { get; set; } = new();

	}
}
