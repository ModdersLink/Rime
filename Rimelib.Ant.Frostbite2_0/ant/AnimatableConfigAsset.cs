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

	[AntBinding(0x2cd72428)]
	public class AnimatableConfigAsset
		: AntObject
	{
		[AntField(0)]
		public IdRef<AnimatableConfigAsset> Parent { get; set; } = new();

		[AntField(1)]
		public IdRef<AntObject> DefaultPose { get; set; } = new();

		[AntField(2)]
		public AntVector3 StartPosition { get; set; } = new();

		[AntField(3)]
		public AntQuaternion StartRotation { get; set; } = new();

		[AntField(4)]
		public float PlayerScale { get; set; }

		[AntField(5)]
		public IdRef<FeatureCollectionAsset> FeatureCollection { get; set; } = new();

		[AntField(6)]
		public IdRefArray<GameStateEnumerationAsset> OverrideGameStateTarget { get; set; } = new();

		[AntField(7)]
		public IdRefArray<GameStateEnumerationAsset> OverrideGameStateData { get; set; } = new();

	}
}
