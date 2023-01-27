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

	[AntBinding(0xcd685a19)]
	public class PrepareAlignToWorldSceneOp
		: AntObject
	{
		[AntField(0)]
		public IdRef<IntegerAsset> InOverrideAlignIndex { get; set; } = new();

		[AntField(1)]
		public IdRef<FloatAsset> InAlignBlendValue { get; set; } = new();

		[AntField(2)]
		public IdRef<AntObject> InTranslationAlignBlendValue { get; set; } = new();

		[AntField(3)]
		public IdRef<AntObject> InRotationAlignBlendValue { get; set; } = new();

		[AntField(4)]
		public int ConnectorJointIndex { get; set; }

		[AntField(5)]
		public IdRef<ExpressionBoolAsset> InEnablePrepareAlign { get; set; } = new();

		[AntField(6)]
		public IdRef<FbConnectJointGroupAsset> InConnectJointGroup { get; set; } = new();

		[AntField(7)]
		public IdRef<Vector3Asset> OutGlobalStartPosition { get; set; } = new();

		[AntField(8)]
		public IdRef<QuaternionAsset> OutGlobalStartRotation { get; set; } = new();

		[AntField(9)]
		public IdRef<Vector3Asset> OutCurrentAlignPosition { get; set; } = new();

		[AntField(10)]
		public IdRef<QuaternionAsset> OutCurrentAlignRotation { get; set; } = new();

		[AntField(11)]
		public IdRef<BoolAsset> OutEnableAlign { get; set; } = new();

		[AntField(12)]
		public float ConstantDummy { get; set; }

		[AntField(13)]
		public IdRef<BoolAsset> InternalPrevEnablePrepareAlign { get; set; } = new();

	}
}
