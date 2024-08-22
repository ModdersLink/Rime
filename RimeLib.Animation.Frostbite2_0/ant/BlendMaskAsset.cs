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

	[AntBinding(0x92c0aadd)]
	public class BlendMaskAsset
		: AntObject
	{
		[AntField(0)]
		public List<float> Values { get; set; } = new();

		[AntField(1)]
		public IdRef<LayoutAsset> DofSetKey { get; set; } = new();

	}
}
