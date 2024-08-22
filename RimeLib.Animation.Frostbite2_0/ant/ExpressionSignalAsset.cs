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

	[AntBinding(0x525f59de)]
	public class ExpressionSignalAsset
		: AntObject
	{
		[AntField(0)]
		public List<float> Constants { get; set; } = new();

		[AntField(1)]
		public List<byte> ByteCode { get; set; } = new();

		[AntField(2)]
		public sbyte OutputType { get; set; }

		[AntField(3)]
		public uint BakedExpressionIndex { get; set; }

		[AntField(4)]
		public IdRefArray<AntObject> InputFloats { get; set; } = new();

		[AntField(5)]
		public IdRefArray<AntObject> InputBools { get; set; } = new();

		[AntField(6)]
		public IdRefArray<AntObject> InputInts { get; set; } = new();

		[AntField(7)]
		public bool DeactivateAfterUpdate { get; set; }

		[AntField(8)]
		public bool DeactivateAfterTransition { get; set; }

		[AntField(9)]
		public float DefaultFloat { get; set; }

		[AntField(10)]
		public bool DefaultBool { get; set; }

	}
}
