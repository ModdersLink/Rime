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

	[AntBinding(0x511e92b4)]
	public class InteractionSceneOp
		: AntObject
	{
		[AntField(0)]
		public IdRefArray<AntObject> InteractionSignalAssets { get; set; } = new();

		[AntField(1)]
		public bool SlideCues { get; set; }

		[AntField(2)]
		public IdRef<AntObject> InteracteeHeightScale { get; set; } = new();

		[AntField(3)]
		public IdRef<PointerAsset> InteractionManagerPtr { get; set; } = new();

	}
}
