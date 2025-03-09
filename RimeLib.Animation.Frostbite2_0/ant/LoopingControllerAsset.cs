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

	[AntBinding(0xb7c81789)]
	public class LoopingControllerAsset
		: ControllerAsset
	{
		[AntField(0)]
		public IdRef<ClipControllerAsset> SubjectControllerAsset { get; set; } = new();

		[AntField(1)]
		public IdRef<ClipInitParam> SubjectInitParams { get; set; } = new();

		[AntField(2)]
		public bool IsLoopControl { get; set; }

		[AntField(3)]
		public float StartTime { get; set; }

		[AntField(4)]
		public float LoopStartTime { get; set; }

		[AntField(5)]
		public float LoopEndTime { get; set; }

	}
}
