///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(4, 32)]
	public class HitReactionComponentBinding :
		EbxSerializable
	{
		[ContainerField(0), JsonProperty(Order = 0)]
		public AntRef Hit { get; set; } = new();
		
		[ContainerField(4), JsonProperty(Order = 4)]
		public AntRef AllowKillFromAnimation { get; set; } = new();
		
		[ContainerField(8), JsonProperty(Order = 8)]
		public AntRef Direction { get; set; } = new();
		
		[ContainerField(12), JsonProperty(Order = 12)]
		public AntRef FiringDistance { get; set; } = new();
		
		[ContainerField(16), JsonProperty(Order = 16)]
		public AntRef BoneType { get; set; } = new();
		
		[ContainerField(20), JsonProperty(Order = 20)]
		public AntRef ImpactType { get; set; } = new();
		
		[ContainerField(24), JsonProperty(Order = 24)]
		public AntRef Immortal { get; set; } = new();
		
		[ContainerField(28), JsonProperty(Order = 28)]
		public AntRef RandomAnimationIndex { get; set; } = new();
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			Hit.Serialize(p_Writer, p_EbxWriter);
			AllowKillFromAnimation.Serialize(p_Writer, p_EbxWriter);
			Direction.Serialize(p_Writer, p_EbxWriter);
			FiringDistance.Serialize(p_Writer, p_EbxWriter);
			BoneType.Serialize(p_Writer, p_EbxWriter);
			ImpactType.Serialize(p_Writer, p_EbxWriter);
			Immortal.Serialize(p_Writer, p_EbxWriter);
			RandomAnimationIndex.Serialize(p_Writer, p_EbxWriter);
		}
	}
}
