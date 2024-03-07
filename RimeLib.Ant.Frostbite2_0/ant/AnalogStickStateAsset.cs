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

	[AntBinding(0xafe1d040)]
	public class AnalogStickStateAsset
		: AntObject
	{
		[AntField(0)]
		public AnalogStickData Current { get; set; } = new();

		[AntField(1)]
		public AnalogStickData Previous { get; set; } = new();

		[AntField(2)]
		public float DeltaTicks { get; set; }

	}
}
