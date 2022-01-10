///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4, 12)]
	public class AnimatedPointCloudAttributeDesc
	{
		[ContainerField(0)]
		public PointCloudAttributeUsage Usage { get; set; } = new();
		
		[ContainerField(4)]
		public PointCloudAttributeQuantization IFrameQuantization { get; set; } = new();
		
		[ContainerField(8)]
		public PointCloudAttributeQuantization DFrameQuantization { get; set; } = new();
		
		public static void Deserialize(AnimatedPointCloudAttributeDesc p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Usage = (PointCloudAttributeUsage) p_Reader.ReadInt32();
			p_Instance.IFrameQuantization = (PointCloudAttributeQuantization) p_Reader.ReadInt32();
			p_Instance.DFrameQuantization = (PointCloudAttributeQuantization) p_Reader.ReadInt32();
		}
	}
}
