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

	[AntBinding(0xf997a7a3)]
	public class VbrAnimationAsset
		: AnimationAsset
	{
		[AntField(0)]
		public float QuatMin { get; set; }

		[AntField(1)]
		public float TrajMin { get; set; }

		[AntField(2)]
		public float Vec3Min { get; set; }

		[AntField(3)]
		public float FloatMin { get; set; }

		[AntField(4)]
		public float QuatMax { get; set; }

		[AntField(5)]
		public float TrajMax { get; set; }

		[AntField(6)]
		public float Vec3Max { get; set; }

		[AntField(7)]
		public float FloatMax { get; set; }

		[AntField(8)]
		public float VectorOffsetScale { get; set; }

		[AntField(9)]
		public float FloatOffsetScale { get; set; }

		[AntField(10)]
		public float Dct { get; set; }

		[AntField(11)]
		public ushort QuaternionCount { get; set; }

		[AntField(12)]
		public ushort Vector3Count { get; set; }

		[AntField(13)]
		public ushort FloatCount { get; set; }

		[AntField(14)]
		public ushort ConstQuaternionCount { get; set; }

		[AntField(15)]
		public ushort ConstVector3Count { get; set; }

		[AntField(16)]
		public ushort ConstFloatCount { get; set; }

		[AntField(17)]
		public ushort KeyTimeSize { get; set; }

		[AntField(18)]
		public ushort NumKeys { get; set; }

		[AntField(19)]
		public ushort ConstChanMapSize { get; set; }

		[AntField(20)]
		public ushort ConstPaletteSize { get; set; }

		[AntField(21)]
		public ushort VectorOffsetSize { get; set; }

		[AntField(22)]
		public ushort FloatOffsetSize { get; set; }

		[AntField(23)]
		public ushort Flags { get; set; }

		[AntField(24)]
		public List<float> ConstantPalette { get; set; } = new();

		[AntField(25)]
		public List<ushort> FrameBlockSizes { get; set; } = new();

		[AntField(26)]
		public List<byte> Data { get; set; } = new();

	}
}
