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

	[AntBinding(0x7979b6c6)]
	public class DefaultDofVector4
		: AntObject
	{
		[AntField(0)]
		public string DofName { get; set; } = string.Empty;

		[AntField(1)]
		public AntVector4 Value { get; set; } = new();

	}
}
