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
	[ContainerType(4, 44)]
	public class UIScreenshotCompData : 
		UIComponentData
	{
		[ContainerField(28), LayoutImmutable, Blittable]
		public uint ResizeImageWidth { get; set; }

		[ContainerField(32)]
		public List<ScreenshotInfo> ScreenshotInfos { get; set; } = new();

		[ContainerField(36), LayoutImmutable, Blittable]
		public uint ResizeImageHeight { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable]
		public bool AutoResizeImage { get; set; }

	}
}
