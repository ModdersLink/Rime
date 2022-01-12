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
	public class TransformPartPropertyTrackData : 
		PropertyTrackData
	{
		[ContainerField(16)]
		public TransformPart TransformPart { get; set; } = new();

		[ContainerField(20)]
		public CurveInfinityType PreInfinity { get; set; } = new();

		[ContainerField(24)]
		public CurveInfinityType PostInfinity { get; set; } = new();

		[ContainerField(28), LayoutImmutable, Blittable]
		public uint KeyStartIndex { get; set; }

		[ContainerField(32), LayoutImmutable]
		public string ResourceName { get; set; } = string.Empty;

		[ContainerField(36), LayoutImmutable, Blittable]
		public uint KeyCount { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable]
		public bool Weighted { get; set; }

		[ContainerField(41), LayoutImmutable, Blittable]
		public bool IsStatic { get; set; }

	}
}
