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

	[AntBinding(0xebf7e252)]
	public class OverrideTrajectorySceneOpAsset
		: AntObject
	{
		[AntField(0)]
		public IdRef<BoolAsset> EnableQuery { get; set; } = new();

		[AntField(1)]
		public IdRef<PointerAsset> QueryPointer { get; set; } = new();

		[AntField(2)]
		public IdRef<Vector3Asset> SafePosition { get; set; } = new();

		[AntField(3)]
		public int HeadJointIndex { get; set; }

		[AntField(4)]
		public int LeftKneeJointIndex { get; set; }

		[AntField(5)]
		public int RightKneeJointIndex { get; set; }

	}
}
