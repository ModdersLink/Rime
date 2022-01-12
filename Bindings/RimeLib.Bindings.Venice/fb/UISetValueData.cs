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
	public class UISetValueData : 
		EntityData
	{
		[ContainerField(12)]
		public UIDataSourceInfo DataSource { get; set; } = new();

		[ContainerField(28), LayoutImmutable, Blittable]
		public int IntValue { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable]
		public float FloatValue { get; set; }

		[ContainerField(36), LayoutImmutable]
		public string StringValue { get; set; } = string.Empty;

		[ContainerField(40), LayoutImmutable, Blittable]
		public bool BoolValue { get; set; }

	}
}
