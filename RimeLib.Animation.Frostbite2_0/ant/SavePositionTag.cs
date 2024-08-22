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

	[AntBinding(0x123b94eb)]
	public class SavePositionTag
		: GameStateTagAsset
	{
		[AntField(0)]
		public IdRef<SkeletonAsset> PositionSkeleton { get; set; } = new();

		[AntField(1)]
		public int PositionJointIndex { get; set; }

		[AntField(2)]
		public IdRef<Vector3Asset> TranslationValue { get; set; } = new();

		[AntField(3)]
		public AntVector3 TranslationOffset { get; set; } = new();

		[AntField(4)]
		public IdRef<QuaternionAsset> QuaternionValue { get; set; } = new();

		[AntField(5)]
		public AntQuaternion QuaternionOffset { get; set; } = new();

		[AntField(6)]
		public IdRef<AntObject> ScaleValue { get; set; } = new();

		[AntField(7)]
		public AntVector3 ScaleOffset { get; set; } = new();

		[AntField(8)]
		public bool SaveOnlyOnEnter { get; set; }

	}
}
