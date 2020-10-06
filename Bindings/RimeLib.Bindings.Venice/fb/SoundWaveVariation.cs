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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(24), ContainerClass]
	public class SoundWaveVariation : 
		DataContainer
	{
		protected List<SoundWaveSubtitle> m_Subtitles = new List<SoundWaveSubtitle>();
		[ContainerField(8), MemberInfoFlag(65), ContainerFieldNameHash(595907762), ContainerArray]
		public List<SoundWaveSubtitle> Subtitles { get { return m_Subtitles; } set { if (OnPropertyChanging("SoundWaveVariation." + nameof(Subtitles), this, m_Subtitles, value)) m_Subtitles = value; } } // 0x8 (8)
		
		protected uint m_SeekTablesSize = new uint();
		[ContainerField(12), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(1711190261)]
		public uint SeekTablesSize { get { return m_SeekTablesSize; } set { if (OnPropertyChanging("SoundWaveVariation." + nameof(SeekTablesSize), this, m_SeekTablesSize, value)) m_SeekTablesSize = value; } } // 0xC (12)
		
		protected List<SoundWaveVariationSegment> m_Segments = new List<SoundWaveVariationSegment>();
		[ContainerField(16), MemberInfoFlag(65), ContainerFieldNameHash(1071820757), ContainerArray]
		public List<SoundWaveVariationSegment> Segments { get { return m_Segments; } set { if (OnPropertyChanging("SoundWaveVariation." + nameof(Segments), this, m_Segments, value)) m_Segments = value; } } // 0x10 (16)
		
		protected sbyte m_ChunkIndex = new sbyte();
		[ContainerField(20), LayoutImmutable, Blittable, MemberInfoFlag(49341), ContainerFieldNameHash(1614610304)]
		public sbyte ChunkIndex { get { return m_ChunkIndex; } set { if (OnPropertyChanging("SoundWaveVariation." + nameof(ChunkIndex), this, m_ChunkIndex, value)) m_ChunkIndex = value; } } // 0x14 (20)
		
		protected sbyte m_FirstLoopSegmentIndex = new sbyte();
		[ContainerField(21), LayoutImmutable, Blittable, MemberInfoFlag(49341), ContainerFieldNameHash(1804204094)]
		public sbyte FirstLoopSegmentIndex { get { return m_FirstLoopSegmentIndex; } set { if (OnPropertyChanging("SoundWaveVariation." + nameof(FirstLoopSegmentIndex), this, m_FirstLoopSegmentIndex, value)) m_FirstLoopSegmentIndex = value; } } // 0x15 (21)
		
		protected sbyte m_LastLoopSegmentIndex = new sbyte();
		[ContainerField(22), LayoutImmutable, Blittable, MemberInfoFlag(49341), ContainerFieldNameHash(64641870)]
		public sbyte LastLoopSegmentIndex { get { return m_LastLoopSegmentIndex; } set { if (OnPropertyChanging("SoundWaveVariation." + nameof(LastLoopSegmentIndex), this, m_LastLoopSegmentIndex, value)) m_LastLoopSegmentIndex = value; } } // 0x16 (22)
		
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
