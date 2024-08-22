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

	[AntBinding(0x5d66730d)]
	public class BlendMaskArrayControllerAsset
		: AntObject
	{
		[AntField(0)]
		public IdRef<ExpressionFloatAsset> ValueAsset { get; set; } = new();

		[AntField(1)]
		public float MinRange { get; set; }

		[AntField(2)]
		public float MaxRange { get; set; }

		[AntField(3)]
		public float MaxDec { get; set; }

		[AntField(4)]
		public float MaxInc { get; set; }

		[AntField(5)]
		public IdRefArray<BlendMaskListAsset> Masks { get; set; } = new();

		[AntField(6)]
		public List<float> Values { get; set; } = new();

	}
}
