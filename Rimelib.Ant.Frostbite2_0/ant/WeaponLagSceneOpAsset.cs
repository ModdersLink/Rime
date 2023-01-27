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

	[AntBinding(0x1fc2e8a7)]
	public class WeaponLagSceneOpAsset
		: AntObject
	{
		[AntField(0)]
		public IdRef<FloatAsset> PitchInput { get; set; } = new();

		[AntField(1)]
		public IdRef<FloatAsset> YawInput { get; set; } = new();

		[AntField(2)]
		public IdRef<FloatAsset> RollInput { get; set; } = new();

		[AntField(3)]
		public IdRef<FloatAsset> PitchLag { get; set; } = new();

		[AntField(4)]
		public IdRef<FloatAsset> YawLag { get; set; } = new();

		[AntField(5)]
		public IdRef<FloatAsset> RollLag { get; set; } = new();

		[AntField(6)]
		public IdRef<ContextDatabaseAsset> LagDataDatabase { get; set; } = new();

	}
}
