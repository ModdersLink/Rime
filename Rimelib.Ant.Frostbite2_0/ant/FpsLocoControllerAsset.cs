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

	[AntBinding(0xcba573ec)]
	public class FpsLocoControllerAsset
		: AntObject
	{
		[AntField(0)]
		public IdRefArray<AccelBlendAsset> Blends { get; set; } = new();

		[AntField(1)]
		public IdRefArray<BoolAsset> GameState { get; set; } = new();

		[AntField(2)]
		public IdRefArray<IndexChooserControllerAsset> Controllers { get; set; } = new();

		[AntField(3)]
		public List<sbyte> BlendRefs { get; set; } = new();

		[AntField(4)]
		public List<float> ControllerSpeed { get; set; } = new();

		[AntField(5)]
		public float InputDebounceTicks { get; set; }

		[AntField(6)]
		public List<sbyte> PhaseOffsets { get; set; } = new();

		[AntField(7)]
		public List<uint> TransitionChoices { get; set; } = new();

		[AntField(8)]
		public IdRef<AntObject> ZeroSpeedController { get; set; } = new();

		[AntField(9)]
		public float ZeroSpeed { get; set; }

		[AntField(10)]
		public float FullSpeed { get; set; }

		[AntField(11)]
		public float MaxZeroBlendIncDec { get; set; }

		[AntField(12)]
		public float TransitionLength { get; set; }

		[AntField(13)]
		public float DelayAfterTransition { get; set; }

		[AntField(14)]
		public float BlendDeadZone { get; set; }

		[AntField(15)]
		public List<float> DirectionPhaseOffsets { get; set; } = new();

	}
}
