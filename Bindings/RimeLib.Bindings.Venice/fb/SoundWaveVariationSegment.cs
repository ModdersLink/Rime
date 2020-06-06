///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class SoundWaveVariationSegment : FrostbiteContainer
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public uint SamplesOffset { get; set; } // 0x0 (0)
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public uint SeekTableOffset { get; set; } // 0x4 (4)
		
		[ContainerField(8), LayoutImmutable, Blittable]
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
