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
	public class UIFontCollection : 
		Asset
	{
		[ContainerField(12)]
		public LanguageFormat Language { get; set; } = new();

		[ContainerField(16)]
		public CtrRef<UITextDatabase> TextDatabase { get; set; } = new();

		[ContainerField(20)]
		public RefArray<UIFontAsset> Fonts { get; set; } = new();

		[ContainerField(24)]
		public ResourceBundleKind BundleKind { get; set; } = new();

	}
}
