///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using RimeLib.IO;
using RimeLib.Frostbite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Reflection;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 4,  Flags: 41, Size: 12)]
	public class SoundWaveVariationSegment : FrostbiteContainer
	{
		[ContainerField(Name: "SamplesOffset", Offset: 0, NameHash: 3907359197, Flags: 49421), LayoutImmutable, Blittable]
		public uint SamplesOffset { get; set; } // 0x0 (0)
		
		[ContainerField(Name: "SeekTableOffset", Offset: 4, NameHash: 3573995342, Flags: 49421), LayoutImmutable, Blittable]
		public uint SeekTableOffset { get; set; } // 0x4 (4)
		
		[ContainerField(Name: "SegmentLength", Offset: 8, NameHash: 3630503322, Flags: 49469), LayoutImmutable, Blittable]
		public float SegmentLength { get; set; } // 0x8 (8)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3907359197:
					SamplesOffset = (uint) p_Value;
					break;

				case 3573995342:
					SeekTableOffset = (uint) p_Value;
					break;

				case 3630503322:
					SegmentLength = (float) p_Value;
					break;

				default:
					base.Bind(p_Descriptor, p_Value);
					break;
			}
		}

		public override object GetFieldValueByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3907359197:
					return SamplesOffset;

				case 3573995342:
					return SeekTableOffset;

				case 3630503322:
					return SegmentLength;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3907359197:
					return typeof(SoundWaveVariationSegment).GetProperty(nameof(SamplesOffset));

				case 3573995342:
					return typeof(SoundWaveVariationSegment).GetProperty(nameof(SeekTableOffset));

				case 3630503322:
					return typeof(SoundWaveVariationSegment).GetProperty(nameof(SegmentLength));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
