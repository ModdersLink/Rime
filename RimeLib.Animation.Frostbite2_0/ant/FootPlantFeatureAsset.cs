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

	[AntBinding(0xd03b5156)]
	public class FootPlantFeatureAsset
		: RigFeatureAsset
	{
		[AntField(0)]
		public float FootHeightTolerance { get; set; }

		[AntField(1)]
		public float ToeHeightTolerance { get; set; }

		[AntField(2)]
		public float SpeedTolerance { get; set; }

		[AntField(3)]
		public float FootHeight { get; set; }

		[AntField(4)]
		public float ToeHeight { get; set; }

		[AntField(5)]
		public float HeightClamprate { get; set; }

		[AntField(6)]
		public float MaxLegStretch { get; set; }

		[AntField(7)]
		public int MagicCircle { get; set; }

		[AntField(8)]
		public float MaxCorrection { get; set; }

		[AntField(9)]
		public IdRef<FloatAsset> BlendFramesAsset { get; set; } = new();

		[AntField(10)]
		public int LeftAnkleEffectorAux { get; set; }

		[AntField(11)]
		public int RightAnkleEffectorAux { get; set; }

		[AntField(12)]
		public IdRef<LayoutAsset> LeftFootVelLayoutAsset { get; set; } = new();

		[AntField(13)]
		public IdRef<LayoutAsset> RightFootVelLayoutAsset { get; set; } = new();

		[AntField(14)]
		public string LeftFootVelDof { get; set; } = string.Empty;

		[AntField(15)]
		public string RightFootVelDof { get; set; } = string.Empty;

		[AntField(16)]
		public IdRef<LayoutAsset> LeftToeBaseVelLayoutAsset { get; set; } = new();

		[AntField(17)]
		public IdRef<LayoutAsset> RightToeBaseVelLayoutAsset { get; set; } = new();

		[AntField(18)]
		public string LeftToeBaseVelDof { get; set; } = string.Empty;

		[AntField(19)]
		public string RightToeBaseVelDof { get; set; } = string.Empty;

		[AntField(20)]
		public IdRef<LayoutAsset> LeftFootHeightLayoutAsset { get; set; } = new();

		[AntField(21)]
		public IdRef<LayoutAsset> RightFootHeightLayoutAsset { get; set; } = new();

		[AntField(22)]
		public string LeftFootHeightDof { get; set; } = string.Empty;

		[AntField(23)]
		public string RightFootHeightDof { get; set; } = string.Empty;

		[AntField(24)]
		public IdRef<LayoutAsset> LeftToeBaseHeightLayoutAsset { get; set; } = new();

		[AntField(25)]
		public IdRef<LayoutAsset> RightToeBaseHeightLayoutAsset { get; set; } = new();

		[AntField(26)]
		public string LeftToeBaseHeightDof { get; set; } = string.Empty;

		[AntField(27)]
		public string RightToeBaseHeightDof { get; set; } = string.Empty;

		[AntField(28)]
		public IdRef<PointerAsset> LeftFootPlantState { get; set; } = new();

		[AntField(29)]
		public IdRef<PointerAsset> RightFootPlantState { get; set; } = new();

		[AntField(30)]
		public IdRef<FloatAsset> DeltaTicksAsset { get; set; } = new();

		[AntField(31)]
		public IdRef<BaseJointMapTemplateAsset> HumanoidTemplate { get; set; } = new();

	}
}
