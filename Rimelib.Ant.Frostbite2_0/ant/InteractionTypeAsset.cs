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

	[AntBinding(0xa80af103)]
	public class InteractionTypeAsset
		: AntObject
	{
		[AntField(0)]
		public float Min_Range_Max_Receiver { get; set; }

		[AntField(1)]
		public float Min_Range_Min_Receiver { get; set; }

		[AntField(2)]
		public float Max_Range_Max_Receiver { get; set; }

		[AntField(3)]
		public float Max_Range_Min_Receiver { get; set; }

		[AntField(4)]
		public float MinAngle_Max_Receiver { get; set; }

		[AntField(5)]
		public float MinAngle_Min_Receiver { get; set; }

		[AntField(6)]
		public float MaxAngle_Max_Receiver { get; set; }

		[AntField(7)]
		public float MaxAngle_Min_Receiver { get; set; }

		[AntField(8)]
		public float Min_Range_Max_Broadcaster { get; set; }

		[AntField(9)]
		public float Min_Range_Min_Broadcaster { get; set; }

		[AntField(10)]
		public float Max_Range_Max_Broadcaster { get; set; }

		[AntField(11)]
		public float Max_Range_Min_Broadcaster { get; set; }

		[AntField(12)]
		public float MinAngle_Max_Broadcaster { get; set; }

		[AntField(13)]
		public float MinAngle_Min_Broadcaster { get; set; }

		[AntField(14)]
		public float MaxAngle_Max_Broadcaster { get; set; }

		[AntField(15)]
		public float MaxAngle_Min_Broadcaster { get; set; }

		[AntField(16)]
		public float Min_Speed_Receiver { get; set; }

		[AntField(17)]
		public float Max_Speed_Receiver { get; set; }

		[AntField(18)]
		public IdRef<AntObject> SkillSignal { get; set; } = new();

		[AntField(19)]
		public IdRef<AntObject> InvisibleSignal { get; set; } = new();

		[AntField(20)]
		public IdRef<AntObject> GroupID { get; set; } = new();

		[AntField(21)]
		public int TargetGroupID { get; set; }

		[AntField(22)]
		public int ValidityTypeCheck { get; set; }

		[AntField(23)]
		public IdRef<AntObject> SourceSkeleton { get; set; } = new();

		[AntField(24)]
		public int SourceJointIndex { get; set; }

		[AntField(25)]
		public IdRef<AntObject> TargetSkeleton { get; set; } = new();

		[AntField(26)]
		public int TargetJointIndex { get; set; }

	}
}
