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

	[AntBinding(0x4f1512e7)]
	public class FpsFootPlantSceneOpAsset
		: AntObject
	{
		[AntField(0)]
		public IdRef<PointerAsset> AsyncQueryPointer { get; set; } = new();

		[AntField(1)]
		public IdRef<AntObject> FallingGameState { get; set; } = new();

		[AntField(2)]
		public IdRef<FloatAsset> GroundAngleGameState { get; set; } = new();

		[AntField(3)]
		public IdRef<Vector3Asset> WaypointGameState { get; set; } = new();

		[AntField(4)]
		public IdRef<Vector3Asset> EntitySpaceTrans { get; set; } = new();

		[AntField(5)]
		public IdRef<QuaternionAsset> EntitySpaceRot { get; set; } = new();

		[AntField(6)]
		public IdRef<FloatAsset> DeltaTrajWeight { get; set; } = new();

		[AntField(7)]
		public bool ProceduralFall { get; set; }

		[AntField(8)]
		public float GravitationalAcceleration { get; set; }

	}
}
