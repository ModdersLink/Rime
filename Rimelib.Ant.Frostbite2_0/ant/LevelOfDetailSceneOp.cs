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

	[AntBinding(0x9020256a)]
	public class LevelOfDetailSceneOp
		: AntObject
	{
		[AntField(0)]
		public IdRef<BoolAsset> InEnableFootPlanting { get; set; } = new();

		[AntField(1)]
		public IdRef<BoolAsset> InEnableLeftHandIK { get; set; } = new();

		[AntField(2)]
		public IdRef<BoolAsset> InEnableRightHandIK { get; set; } = new();

		[AntField(3)]
		public IdRef<FloatAsset> InLeftHandIKReach { get; set; } = new();

		[AntField(4)]
		public IdRef<FloatAsset> InRightHandIKReach { get; set; } = new();

		[AntField(5)]
		public IdRef<FloatAsset> InDistanceFromViewer { get; set; } = new();

		[AntField(6)]
		public IdRef<BoolAsset> InDisablePoseUpdate { get; set; } = new();

		[AntField(7)]
		public IdRef<BoolAsset> InDisableControllerUpdate { get; set; } = new();

		[AntField(8)]
		public IdRef<FloatAsset> InMovementSpeed { get; set; } = new();

		[AntField(9)]
		public IdRef<FloatAsset> InHideWeapon { get; set; } = new();

		[AntField(10)]
		public IdRef<BoolAsset> OutLeftHandIKEnable { get; set; } = new();

		[AntField(11)]
		public IdRef<BoolAsset> OutRightHandIKEnable { get; set; } = new();

		[AntField(12)]
		public IdRef<FloatAsset> OutLeftHandIKReach { get; set; } = new();

		[AntField(13)]
		public IdRef<FloatAsset> OutRightHandIKReach { get; set; } = new();

		[AntField(14)]
		public IdRef<BoolAsset> OutEnableIK { get; set; } = new();

		[AntField(15)]
		public IdRef<BoolSinkAsset> OutEnableLowLodIK { get; set; } = new();

		[AntField(16)]
		public IdRef<BoolAsset> OutEnableMoveFootPlanting { get; set; } = new();

		[AntField(17)]
		public IdRef<BoolAsset> OutEnableStillFootPlanting { get; set; } = new();

		[AntField(18)]
		public IdRef<BoolAsset> OutEnableFootPlanting { get; set; } = new();

		[AntField(19)]
		public IdRef<AntObject> LeftFootPlantState { get; set; } = new();

		[AntField(20)]
		public IdRef<AntObject> RightFootPlantState { get; set; } = new();

		[AntField(21)]
		public float FootPlantLodDistance { get; set; }

		[AntField(23)]
		public float HandsIKLodDistance { get; set; }

	}
}
