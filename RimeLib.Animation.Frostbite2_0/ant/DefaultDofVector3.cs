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

	[AntBinding(0x63207a9d)]
	public class DefaultDofVector3
		: AntObject
	{
		[AntField(0)]
		public string DofName { get; set; } = string.Empty;

		[AntField(1)]
		public AntVector3 Value { get; set; } = new();

	}
}
