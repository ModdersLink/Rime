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

	[AntBinding(0x88b25fcb)]
	public class ContextDatabaseChooserWrapperAsset
		: AntObject
	{
		[AntField(0)]
		public IdRef<ContextDatabaseAsset> ContextDatabaseAsset { get; set; } = new();

	}
}
