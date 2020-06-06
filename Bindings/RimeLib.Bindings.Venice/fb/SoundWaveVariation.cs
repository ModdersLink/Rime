///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Collections.Generic;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class SoundWaveVariation : 
		DataContainer
	{
		[ContainerField(8)]
		public List<SoundWaveSubtitle> Subtitles { get; set; } = new List<SoundWaveSubtitle>(); // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public uint SeekTablesSize { get; set; } // 0xC (12)
		
		[ContainerField(16)]
		public List<SoundWaveVariationSegment> Segments { get; set; } = new List<SoundWaveVariationSegment>(); // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public sbyte ChunkIndex { get; set; } // 0x14 (20)
		
		[ContainerField(21), LayoutImmutable, Blittable]
		public sbyte FirstLoopSegmentIndex { get; set; } // 0x15 (21)
		
		[ContainerField(22), LayoutImmutable, Blittable]
		public sbyte LastLoopSegmentIndex { get; set; } // 0x16 (22)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 595907762:
					Subtitles = (List<SoundWaveSubtitle>) p_Value;
					break;

				case 1711190261:
					SeekTablesSize = (uint) p_Value;
					break;

				case 1071820757:
					Segments = (List<SoundWaveVariationSegment>) p_Value;
					break;

				case 1614610304:
					ChunkIndex = (sbyte) p_Value;
					break;

				case 1804204094:
					FirstLoopSegmentIndex = (sbyte) p_Value;
					break;

				case 64641870:
					LastLoopSegmentIndex = (sbyte) p_Value;
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
				case 595907762:
					return Subtitles;

				case 1711190261:
					return SeekTablesSize;

				case 1071820757:
					return Segments;

				case 1614610304:
					return ChunkIndex;

				case 1804204094:
					return FirstLoopSegmentIndex;

				case 64641870:
					return LastLoopSegmentIndex;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 595907762:
					return typeof(SoundWaveVariation).GetProperty(nameof(Subtitles));

				case 1711190261:
					return typeof(SoundWaveVariation).GetProperty(nameof(SeekTablesSize));

				case 1071820757:
					return typeof(SoundWaveVariation).GetProperty(nameof(Segments));

				case 1614610304:
					return typeof(SoundWaveVariation).GetProperty(nameof(ChunkIndex));

				case 1804204094:
					return typeof(SoundWaveVariation).GetProperty(nameof(FirstLoopSegmentIndex));

				case 64641870:
					return typeof(SoundWaveVariation).GetProperty(nameof(LastLoopSegmentIndex));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
