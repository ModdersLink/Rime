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
	[ContainerType(4, 12)]
	public class AnimatedPointCloudAttributeDesc :
		EbxSerializable
	{
		[ContainerField(0), JsonProperty(Order = 0)]
		public PointCloudAttributeUsage Usage { get; set; } = new();
		
		[ContainerField(4), JsonProperty(Order = 4)]
		public PointCloudAttributeQuantization IFrameQuantization { get; set; } = new();
		
		[ContainerField(8), JsonProperty(Order = 8)]
		public PointCloudAttributeQuantization DFrameQuantization { get; set; } = new();
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write((int) Usage);
			p_Writer.Write((int) IFrameQuantization);
			p_Writer.Write((int) DFrameQuantization);
		}
	}
}
