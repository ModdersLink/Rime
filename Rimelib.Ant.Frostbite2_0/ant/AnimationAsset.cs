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

	[AntBinding(0xceafe7c0)]
	public class AnimationAsset
		: AntObject
	{
		[AntField(0)]
		public uint CodecType { get; set; }

		[AntField(1)]
		public uint AnimId { get; set; }

		[AntField(2)]
		public float TrimOffset { get; set; }

		[AntField(3)]
		public ushort EndFrame { get; set; }

		[AntField(4)]
		public bool Additive { get; set; }

		[AntField(5)]
		public IdRef<ChannelToDofAsset> ChannelToDofAsset { get; set; } = new();

	}
}
