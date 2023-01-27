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

	[AntBinding(0xba6cb211)]
	public class SceneOpMatrixAsset
		: AntObject
	{
		[AntField(0)]
		public IdRefArray<ControllerUpdate> SceneOpAssets { get; set; } = new();

		[AntField(1)]
		public IdRefArray<AnimatableAsset> AnimatableAssets { get; set; } = new();

		[AntField(2)]
		public List<bool> CellInfo { get; set; } = new();

		[AntField(3)]
		public IdRef<FloatAsset> DeltaTicks { get; set; } = new();

	}
}
