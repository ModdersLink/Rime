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

namespace fb
{
	[ContainerType(4, 32)]
	public class ScreenshotInfo
	{
		[ContainerField(0), LayoutImmutable, JsonProperty(Order = 0)]
		public string Name { get; set; } = string.Empty;
		
		[ContainerField(4), LayoutImmutable, Blittable, JsonProperty(Order = 4)]
		public uint CropImageY1 { get; set; }
		
		[ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		public uint CropImageX1 { get; set; }
		
		[ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		public uint CropImageX2 { get; set; }
		
		[ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public uint CropImageY2 { get; set; }
		
		[ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		public uint ResizeOutputImageHeight { get; set; }
		
		[ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		public uint ResizeOutputImageWidth { get; set; }
		
		[ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		public bool ResizeOutputImage { get; set; }
		
		[ContainerField(29), LayoutImmutable, Blittable, JsonProperty(Order = 29)]
		public bool CropImage { get; set; }
		
	}
}
