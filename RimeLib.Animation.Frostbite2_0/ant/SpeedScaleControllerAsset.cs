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

	[AntBinding(0x9320cd50)]
	public class SpeedScaleControllerAsset
		: AntObject
	{
		[AntField(0)]
		public IdRef<ClipInitParam> SubjectControllerInit { get; set; } = new();

		[AntField(1)]
		public IdRef<SequenceContainerAsset> SubjectControllerAsset { get; set; } = new();

		[AntField(2)]
		public IdRef<FloatAsset> SpeedValueAsset { get; set; } = new();

		[AntField(3)]
		public float SubjectSpeed { get; set; }

		[AntField(4)]
		public float MinSpeed { get; set; }

		[AntField(5)]
		public bool AutomaticSubjectSpeed { get; set; }

	}
}
