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
	[ContainerType(4, 24)]
	public class InputRecorderData : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable]
		public string FileNamePrefix { get; set; } = string.Empty;

		[ContainerField(12), LayoutImmutable]
		public string FileName { get; set; } = string.Empty;

		[ContainerField(16)]
		public EntryInputActionEnum ToggleRecordAction { get; set; } = new();

		[ContainerField(20), LayoutImmutable, Blittable]
		public bool AutoIncrementFileName { get; set; }

	}
}
