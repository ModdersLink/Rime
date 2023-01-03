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

	[AntBinding(0x95c07894)]
	public class RigAsset
		: AntObject
	{
		[AntField(0)]
		public IdRef<FeatureCollectionAsset> FeatureCollection { get; set; } = new();

		[AntField(1)]
		public IdRef<SkeletonAsset> Skeleton { get; set; } = new();

		[AntField(2)]
		public IdRefArray<LayoutHierarchyAsset> DofSetLists { get; set; } = new();

		[AntField(3)]
		public List<DefaultDofFloat> DefaultFloatValues { get; set; } = new();

		[AntField(4)]
		public List<DefaultDofInt> DefaultIntValues { get; set; } = new();

		[AntField(5)]
		public List<DefaultDofVector3> DefaultVector3Values { get; set; } = new();

		[AntField(6)]
		public List<DefaultDofVector4> DefaultVector4Values { get; set; } = new();

		[AntField(7)]
		public IdRef<DeltaTrajLayoutAsset> DeltaTrajDofSet { get; set; } = new();

	}
}
