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
	[ContainerType(4, 32)]
	public class UINumberDataBinding : 
		UIDataBinding
	{
		[ContainerField(8)]
		public UIDataSourceInfo Value { get; set; } = new();

		[ContainerField(24), LayoutImmutable, Blittable]
		public int NumValue { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable]
		public bool Refresh { get; set; }

	}
}
