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

	[AntBinding(0x611f18a0)]
	public class FieldDescriptionAsset
		: AntObject
	{
		[AntField(0)]
		public string FieldName { get; set; } = string.Empty;

		[AntField(1)]
		public int FieldType { get; set; }

		[AntField(2)]
		public bool IsMetadata { get; set; }

		[AntField(3)]
		public int IntMax { get; set; }

		[AntField(4)]
		public int IntDefault { get; set; }

		[AntField(5)]
		public float FloatMin { get; set; }

		[AntField(6)]
		public float FloatMax { get; set; }

		[AntField(7)]
		public float FloatDefault0 { get; set; }

		[AntField(8)]
		public float FloatDefault1 { get; set; }

		[AntField(9)]
		public float FloatDefault2 { get; set; }

		[AntField(10)]
		public IdRef<AntObject> GameStateDriverAsset0 { get; set; } = new();

		[AntField(11)]
		public int Ordering { get; set; }

		[AntField(12)]
		public bool AutoShiftEnumsForBitmap { get; set; }

	}
}
