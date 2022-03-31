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
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(4, 44)]
	public class TransformPartPropertyTrackData :
		PropertyTrackData
	{
		[ContainerField(16), JsonProperty(Order = 16)]
		public TransformPart TransformPart { get; set; } = new();

		[ContainerField(20), JsonProperty(Order = 20)]
		public CurveInfinityType PreInfinity { get; set; } = new();

		[ContainerField(24), JsonProperty(Order = 24)]
		public CurveInfinityType PostInfinity { get; set; } = new();

		[ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		public uint KeyStartIndex { get; set; }

		[ContainerField(32), LayoutImmutable, JsonProperty(Order = 32)]
		public string ResourceName { get; set; } = string.Empty;

		[ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		public uint KeyCount { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		public bool Weighted { get; set; }

		[ContainerField(41), LayoutImmutable, Blittable, JsonProperty(Order = 41)]
		public bool IsStatic { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write((int) TransformPart);
			p_Writer.Write((int) PreInfinity);
			p_Writer.Write((int) PostInfinity);
			p_Writer.Write(KeyStartIndex);
			p_Writer.Write(p_EbxWriter.WriteString(ResourceName));
			p_Writer.Write(KeyCount);
			p_Writer.Write(Weighted);
			p_Writer.Write(IsStatic);
			p_Writer.WriteNullBytes(2);
		}
	}
}
