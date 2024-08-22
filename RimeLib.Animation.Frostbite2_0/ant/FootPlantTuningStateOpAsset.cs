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

	[AntBinding(0xaf9e23fa)]
	public class FootPlantTuningStateOpAsset
		: AntObject
	{
		[AntField(0)]
		public new string Name { get; set; } = string.Empty;

		[AntField(1)]
		public float EntryValue { get; set; }

		[AntField(2)]
		public float ExitValue { get; set; }

		[AntField(3)]
		public int EntryBlendTime { get; set; }

		[AntField(4)]
		public int ExitBlendTime { get; set; }

	}
}
