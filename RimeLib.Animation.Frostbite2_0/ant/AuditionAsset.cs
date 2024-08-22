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

	[AntBinding(0xac657d86)]
	public class AuditionAsset
		: AntObject
	{
		[AntField(0)]
		public IdRef<ActorGroupContainerAsset> ActorGroupAsset { get; set; } = new();

		[AntField(1)]
		public IdRef<SceneOpMatrixAsset> SceneOpMatrixAsset { get; set; } = new();

		[AntField(2)]
		public float UpdateFrequency { get; set; }

	}
}
