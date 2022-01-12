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
	[ContainerType(4, 56)]
	public class UITextDatabase : 
		Asset
	{
		[ContainerField(12)]
		public LanguageFormat Language { get; set; } = new();

		[ContainerField(16), LayoutImmutable, Blittable]
		public GUID BinaryChunk { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable]
		public uint BinaryChunkSize { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable]
		public GUID HistogramChunk { get; set; }

		[ContainerField(52), LayoutImmutable, Blittable]
		public uint HistogramChunkSize { get; set; }

	}
}
