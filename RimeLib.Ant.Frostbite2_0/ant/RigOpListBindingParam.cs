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

	[AntBinding(0xa99f6406)]
	public class RigOpListBindingParam
		: AntObject
	{
		[AntField(0)]
		public IdRef<LayoutHierarchyAsset> DataDSLKey { get; set; } = new();

		[AntField(1)]
		public IdRef<DeltaTrajLayoutAsset> DataDSKey { get; set; } = new();

		[AntField(2)]
		public string DataName { get; set; } = string.Empty;

		[AntField(3)]
		public IdRef<FloatAsset> DataValueKey { get; set; } = new();

		[AntField(4)]
		public string DataParameterName { get; set; } = string.Empty;

	}
}
