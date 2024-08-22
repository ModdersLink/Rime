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

	[AntBinding(0x6e6759f5)]
	public class LinearSignalChooserEntryAsset
		: ChooserEntryAsset
	{
		[AntField(0)]
		public IdRef<FloatAsset> SignalAsset { get; set; } = new();

		[AntField(1)]
		public float Threshold { get; set; }

	}
}
