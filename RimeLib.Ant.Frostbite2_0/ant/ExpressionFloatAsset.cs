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

	[AntBinding(0x4ef435cd)]
	public class ExpressionFloatAsset
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
		public IdRefArray<FloatAsset> InputFloats { get; set; } = new();

		[AntField(5)]
		public IdRefArray<BoolAsset> InputBools { get; set; } = new();

		[AntField(9)]
		public float DefaultFloat { get; set; }

	}
}
