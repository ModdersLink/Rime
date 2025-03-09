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

	[AntBinding(0x10d730ca)]
	public class SequenceWarper
		: AntObject
	{
		[AntField(0)]
		public short StartTime { get; set; }

		[AntField(1)]
		public short Duration { get; set; }

		[AntField(2)]
		public int BlendType { get; set; }

		[AntField(3)]
		public float TranslateX { get; set; }

		[AntField(4)]
		public float TranslateY { get; set; }

		[AntField(5)]
		public float TranslateZ { get; set; }

		[AntField(6)]
		public float Rotation { get; set; }

		[AntField(7)]
		public string TranslateYJointName0 { get; set; } = string.Empty;

		[AntField(8)]
		public string TranslateYDofIndex1 { get; set; } = string.Empty;

		[AntField(9)]
		public string TranslateYDofIndex2 { get; set; } = string.Empty;

		[AntField(10)]
		public IdRef<AntObject> WarpSignal { get; set; } = new();

		[AntField(11)]
		public bool YTranslateFootEffectors { get; set; }

		[AntField(12)]
		public bool FullBodyYTranslation { get; set; }

	}
}
