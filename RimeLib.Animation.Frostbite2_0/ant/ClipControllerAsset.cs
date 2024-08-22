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

	[AntBinding(0xfc431be4)]
	public class ClipControllerAsset
		: ControllerAsset
	{
		[AntField(0)]
		public IdRef<LayoutHierarchyAsset> Target { get; set; } = new();

		[AntField(1)]
		public IdRef<AnimationAsset> Anim { get; set; } = new();

		[AntField(3)]
		public float NumTicks { get; set; }

		[AntField(4)]
		public float FPS { get; set; }

		[AntField(5)]
		public float FPSScale { get; set; }

		[AntField(6)]
		public byte DeltaTrajectory { get; set; }

		[AntField(7)]
		public float Distance { get; set; }

	}
}
