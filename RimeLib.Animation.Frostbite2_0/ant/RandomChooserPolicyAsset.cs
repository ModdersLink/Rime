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

	[AntBinding(0x77f000e8)]
	public class RandomChooserPolicyAsset
		: AntObject
	{
		[AntField(0)]
		public IdRef<RandomValueAsset> RandomValueAsset { get; set; } = new();

	}
}
