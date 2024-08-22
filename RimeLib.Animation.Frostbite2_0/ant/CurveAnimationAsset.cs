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

	[AntBinding(0x96d93a9f)]
	public class CurveAnimationAsset
		: AnimationAsset
	{
		[AntField(0)]
		public float FPS { get; set; }

		[AntField(1)]
		public ushort NumRotations { get; set; }

		[AntField(2)]
		public ushort NumVectors { get; set; }

		[AntField(3)]
		public ushort NumFloats { get; set; }

		[AntField(4)]
		public List<float> Values { get; set; } = new();

		[AntField(5)]
		public List<ushort> Keys { get; set; } = new();

		[AntField(6)]
		public List<float> Consts { get; set; } = new();

		[AntField(7)]
		public List<ushort> ConstOffsets { get; set; } = new();

		[AntField(8)]
		public List<CurveAnimationAsset__KeysBlock> KeysBlocks { get; set; } = new();

		[AntField(9)]
		public List<CurveAnimationAsset__ChannelGroup> ChannelGroups { get; set; } = new();

		[AntField(10)]
		public List<ushort> ChannelOffsets { get; set; } = new();

	}
}
