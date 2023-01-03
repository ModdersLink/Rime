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

	[AntBinding(0xf8c332e2)]
	public class BlendMaskListAsset
		: AntObject
	{
		[AntField(0)]
		public IdRef<LayoutHierarchyAsset> DofSetListKey { get; set; } = new();

		[AntField(1)]
		public IdRefArray<BlendMaskAsset> MaskKeys { get; set; } = new();

		[AntField(2)]
		public IdRefArray<LayoutAsset> DefaultDofSetKeys { get; set; } = new();

		[AntField(3)]
		public List<float> DefaultValues { get; set; } = new();

	}
}
