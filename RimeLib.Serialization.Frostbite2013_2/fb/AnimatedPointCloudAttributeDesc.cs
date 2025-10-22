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


namespace fb.Render;

[ContainerType(4, 12)]
public class AnimatedPointCloudAttributeDesc
	: EbxSerializable
{
	[ContainerField(0x0), LayoutImmutable, Blittable, JsonProperty(Order = 0)]
	public PointCloudAttributeUsage Usage { get; set; } = PointCloudAttributeUsage.PointCloudAttributeUsage_Position;
	
	[ContainerField(0x4), LayoutImmutable, Blittable, JsonProperty(Order = 4)]
	public PointCloudAttributeQuantization IFrameQuantization { get; set; } = PointCloudAttributeQuantization.PointCloudAttributeQuantization_s10e5;
	
	[ContainerField(0x8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
	public PointCloudAttributeQuantization DFrameQuantization { get; set; } = PointCloudAttributeQuantization.PointCloudAttributeQuantization_s5e5;
	
}

