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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(28), ContainerClass]
	public class MeshMergingSettings : 
		DataContainer
	{
		protected int m_StatsSeedIndex = new int();
		[ContainerField(8), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(4014781069)]
		public int StatsSeedIndex { get { return m_StatsSeedIndex; } set { if (OnPropertyChanging("MeshMergingSettings." + nameof(StatsSeedIndex), this, m_StatsSeedIndex, value)) m_StatsSeedIndex = value; } } // 0x8 (8)
		
		protected int m_StatsLodIndex = new int();
		[ContainerField(12), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(1875375645)]
		public int StatsLodIndex { get { return m_StatsLodIndex; } set { if (OnPropertyChanging("MeshMergingSettings." + nameof(StatsLodIndex), this, m_StatsLodIndex, value)) m_StatsLodIndex = value; } } // 0xC (12)
		
		protected uint m_TextureAtlasWidth = new uint();
		[ContainerField(16), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(3571490231)]
		public uint TextureAtlasWidth { get { return m_TextureAtlasWidth; } set { if (OnPropertyChanging("MeshMergingSettings." + nameof(TextureAtlasWidth), this, m_TextureAtlasWidth, value)) m_TextureAtlasWidth = value; } } // 0x10 (16)
		
		protected bool m_DrawStatsEnable = new bool();
		[ContainerField(20), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(711726149)]
		public bool DrawStatsEnable { get { return m_DrawStatsEnable; } set { if (OnPropertyChanging("MeshMergingSettings." + nameof(DrawStatsEnable), this, m_DrawStatsEnable, value)) m_DrawStatsEnable = value; } } // 0x14 (20)
		
		protected bool m_DrawDebugTexturesEnable = new bool();
		[ContainerField(21), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3201068793)]
		public bool DrawDebugTexturesEnable { get { return m_DrawDebugTexturesEnable; } set { if (OnPropertyChanging("MeshMergingSettings." + nameof(DrawDebugTexturesEnable), this, m_DrawDebugTexturesEnable, value)) m_DrawDebugTexturesEnable = value; } } // 0x15 (21)
		
		protected bool m_VirtualTextureArrayStreamingEnable = new bool();
		[ContainerField(22), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(211951999)]
		public bool VirtualTextureArrayStreamingEnable { get { return m_VirtualTextureArrayStreamingEnable; } set { if (OnPropertyChanging("MeshMergingSettings." + nameof(VirtualTextureArrayStreamingEnable), this, m_VirtualTextureArrayStreamingEnable, value)) m_VirtualTextureArrayStreamingEnable = value; } } // 0x16 (22)
		
		protected bool m_Enable = new bool();
		[ContainerField(23), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2342790116)]
		public bool Enable { get { return m_Enable; } set { if (OnPropertyChanging("MeshMergingSettings." + nameof(Enable), this, m_Enable, value)) m_Enable = value; } } // 0x17 (23)
		
		protected bool m_TextureAtlasMergeEnable = new bool();
		[ContainerField(24), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2089084008)]
		public bool TextureAtlasMergeEnable { get { return m_TextureAtlasMergeEnable; } set { if (OnPropertyChanging("MeshMergingSettings." + nameof(TextureAtlasMergeEnable), this, m_TextureAtlasMergeEnable, value)) m_TextureAtlasMergeEnable = value; } } // 0x18 (24)
		
		protected bool m_ClearMergeReport = new bool();
		[ContainerField(25), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1920586794)]
		public bool ClearMergeReport { get { return m_ClearMergeReport; } set { if (OnPropertyChanging("MeshMergingSettings." + nameof(ClearMergeReport), this, m_ClearMergeReport, value)) m_ClearMergeReport = value; } } // 0x19 (25)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 4014781069:
					StatsSeedIndex = (int) p_Value;
					break;

				case 1875375645:
					StatsLodIndex = (int) p_Value;
					break;

				case 3571490231:
					TextureAtlasWidth = (uint) p_Value;
					break;

				case 711726149:
					DrawStatsEnable = (bool) p_Value;
					break;

				case 3201068793:
					DrawDebugTexturesEnable = (bool) p_Value;
					break;

				case 211951999:
					VirtualTextureArrayStreamingEnable = (bool) p_Value;
					break;

				case 2342790116:
					Enable = (bool) p_Value;
					break;

				case 2089084008:
					TextureAtlasMergeEnable = (bool) p_Value;
					break;

				case 1920586794:
					ClearMergeReport = (bool) p_Value;
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
				case 4014781069:
					return StatsSeedIndex;

				case 1875375645:
					return StatsLodIndex;

				case 3571490231:
					return TextureAtlasWidth;

				case 711726149:
					return DrawStatsEnable;

				case 3201068793:
					return DrawDebugTexturesEnable;

				case 211951999:
					return VirtualTextureArrayStreamingEnable;

				case 2342790116:
					return Enable;

				case 2089084008:
					return TextureAtlasMergeEnable;

				case 1920586794:
					return ClearMergeReport;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 4014781069:
					return typeof(MeshMergingSettings).GetProperty(nameof(StatsSeedIndex));

				case 1875375645:
					return typeof(MeshMergingSettings).GetProperty(nameof(StatsLodIndex));

				case 3571490231:
					return typeof(MeshMergingSettings).GetProperty(nameof(TextureAtlasWidth));

				case 711726149:
					return typeof(MeshMergingSettings).GetProperty(nameof(DrawStatsEnable));

				case 3201068793:
					return typeof(MeshMergingSettings).GetProperty(nameof(DrawDebugTexturesEnable));

				case 211951999:
					return typeof(MeshMergingSettings).GetProperty(nameof(VirtualTextureArrayStreamingEnable));

				case 2342790116:
					return typeof(MeshMergingSettings).GetProperty(nameof(Enable));

				case 2089084008:
					return typeof(MeshMergingSettings).GetProperty(nameof(TextureAtlasMergeEnable));

				case 1920586794:
					return typeof(MeshMergingSettings).GetProperty(nameof(ClearMergeReport));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
