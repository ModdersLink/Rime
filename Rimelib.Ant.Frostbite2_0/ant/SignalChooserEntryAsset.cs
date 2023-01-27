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

	[AntBinding(0xc94024ab)]
	public class SignalChooserEntryAsset
		: ChooserEntryAsset
	{
		[AntField(0)]
		public IdRefArray<BoolAsset> TrueSignals { get; set; } = new();

		[AntField(1)]
		public IdRefArray<BoolAsset> FalseSignals { get; set; } = new();

	}
}
