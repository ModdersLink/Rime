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
	[ContainerType(4, 28)]
	public class UIFontAsset : 
		Asset
	{
		[ContainerField(12), LayoutImmutable]
		public string SourceFile { get; set; } = string.Empty;

		[ContainerField(16)]
		public CtrRef<UITextDatabase> TextDatabase { get; set; } = new();

		[ContainerField(20)]
		public List<string> ScaleformFontName { get; set; } = new();

		[ContainerField(24), LayoutImmutable, Blittable]
		public bool NumericsOnly { get; set; }

		[ContainerField(25), LayoutImmutable, Blittable]
		public bool CompleteKorean { get; set; }

		[ContainerField(26), LayoutImmutable, Blittable]
		public bool CompleteJapanese { get; set; }

		[ContainerField(27), LayoutImmutable, Blittable]
		public bool CompleteTraditionalChinese { get; set; }

	}
}
