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
	public class MeshMergingSettings : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public int StatsSeedIndex { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public int StatsLodIndex { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public uint TextureAtlasWidth { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public bool DrawStatsEnable { get; set; } // 0x14 (20)
		
		[ContainerField(21), LayoutImmutable, Blittable]
		public bool DrawDebugTexturesEnable { get; set; } // 0x15 (21)
		
		[ContainerField(22), LayoutImmutable, Blittable]
		public bool VirtualTextureArrayStreamingEnable { get; set; } // 0x16 (22)
		
		[ContainerField(23), LayoutImmutable, Blittable]
		public bool Enable { get; set; } // 0x17 (23)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public bool TextureAtlasMergeEnable { get; set; } // 0x18 (24)
		
		[ContainerField(25), LayoutImmutable, Blittable]
		public bool ClearMergeReport { get; set; } // 0x19 (25)
		
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
