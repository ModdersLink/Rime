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
	[ContainerType(16), MemberInfoFlag(41), ContainerStruct]
	public class EnlightenDbSystem : FrostbiteContainer
	{
		[ContainerField(0), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289)]
		public AxisAlignedBox BoundingBox { get; set; } = new AxisAlignedBox(); // 0x0 (0)
		
		[ContainerField(32), LayoutImmutable, Blittable, MemberInfoFlag(49421)]
		public uint AtlasStartX { get; set; } // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable, Blittable, MemberInfoFlag(49421)]
		public uint AtlasStartY { get; set; } // 0x24 (36)
		
		[ContainerField(40), LayoutImmutable, Blittable, MemberInfoFlag(49421)]
		public uint OutputWidth { get; set; } // 0x28 (40)
		
		[ContainerField(44), LayoutImmutable, Blittable, MemberInfoFlag(49421)]
		public uint OutputHeight { get; set; } // 0x2C (44)
		
		[ContainerField(48), LayoutImmutable, Blittable, MemberInfoFlag(49421)]
		public uint PixelCount { get; set; } // 0x30 (48)
		
		[ContainerField(52), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float PixelSize { get; set; } // 0x34 (52)
		
		[ContainerField(56), LayoutImmutable, Blittable, MemberInfoFlag(49405)]
		public int SystemId { get; set; } // 0x38 (56)
		
		[ContainerField(60), MemberInfoFlag(65), ContainerArray]
		public List<EnlightenDbInstance> Instances { get; set; } = new List<EnlightenDbInstance>(); // 0x3C (60)
		
		[ContainerField(64), MemberInfoFlag(65), ContainerArray]
		public List<int> InputSystems { get; set; } = new List<int>(); // 0x40 (64)
		
		[ContainerField(68), MemberInfoFlag(41)]
		public PrecomputeCache SystemCache { get; set; } = new PrecomputeCache(); // 0x44 (68)
		
		[ContainerField(92), MemberInfoFlag(41)]
		public PrecomputeCache ClusteringCache { get; set; } = new PrecomputeCache(); // 0x5C (92)
		
		[ContainerField(116), MemberInfoFlag(41)]
		public PrecomputeCache PreClusteringCache { get; set; } = new PrecomputeCache(); // 0x74 (116)
		
		[ContainerField(140), MemberInfoFlag(41)]
		public PrecomputeCache LightTransportCache { get; set; } = new PrecomputeCache(); // 0x8C (140)
		
		[ContainerField(164), MemberInfoFlag(41)]
		public PrecomputeCache VisibilityCache { get; set; } = new PrecomputeCache(); // 0xA4 (164)
		
		[ContainerField(188), LayoutImmutable, Blittable, MemberInfoFlag(49325)]
		public bool TerrainSystem { get; set; } // 0xBC (188)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2648132290:
					BoundingBox = (AxisAlignedBox) p_Value;
					break;

				case 2929172246:
					AtlasStartX = (uint) p_Value;
					break;

				case 2929172247:
					AtlasStartY = (uint) p_Value;
					break;

				case 739018396:
					OutputWidth = (uint) p_Value;
					break;

				case 3054125413:
					OutputHeight = (uint) p_Value;
					break;

				case 2412623662:
					PixelCount = (uint) p_Value;
					break;

				case 854589352:
					PixelSize = (float) p_Value;
					break;

				case 643121549:
					SystemId = (int) p_Value;
					break;

				case 3890087583:
					Instances = (List<EnlightenDbInstance>) p_Value;
					break;

				case 3312183461:
					InputSystems = (List<int>) p_Value;
					break;

				case 637498348:
					SystemCache = (PrecomputeCache) p_Value;
					break;

				case 3343002403:
					ClusteringCache = (PrecomputeCache) p_Value;
					break;

				case 317514276:
					PreClusteringCache = (PrecomputeCache) p_Value;
					break;

				case 3540697556:
					LightTransportCache = (PrecomputeCache) p_Value;
					break;

				case 717943567:
					VisibilityCache = (PrecomputeCache) p_Value;
					break;

				case 2277632311:
					TerrainSystem = (bool) p_Value;
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
				case 2648132290:
					return BoundingBox;

				case 2929172246:
					return AtlasStartX;

				case 2929172247:
					return AtlasStartY;

				case 739018396:
					return OutputWidth;

				case 3054125413:
					return OutputHeight;

				case 2412623662:
					return PixelCount;

				case 854589352:
					return PixelSize;

				case 643121549:
					return SystemId;

				case 3890087583:
					return Instances;

				case 3312183461:
					return InputSystems;

				case 637498348:
					return SystemCache;

				case 3343002403:
					return ClusteringCache;

				case 317514276:
					return PreClusteringCache;

				case 3540697556:
					return LightTransportCache;

				case 717943567:
					return VisibilityCache;

				case 2277632311:
					return TerrainSystem;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2648132290:
					return typeof(EnlightenDbSystem).GetProperty(nameof(BoundingBox));

				case 2929172246:
					return typeof(EnlightenDbSystem).GetProperty(nameof(AtlasStartX));

				case 2929172247:
					return typeof(EnlightenDbSystem).GetProperty(nameof(AtlasStartY));

				case 739018396:
					return typeof(EnlightenDbSystem).GetProperty(nameof(OutputWidth));

				case 3054125413:
					return typeof(EnlightenDbSystem).GetProperty(nameof(OutputHeight));

				case 2412623662:
					return typeof(EnlightenDbSystem).GetProperty(nameof(PixelCount));

				case 854589352:
					return typeof(EnlightenDbSystem).GetProperty(nameof(PixelSize));

				case 643121549:
					return typeof(EnlightenDbSystem).GetProperty(nameof(SystemId));

				case 3890087583:
					return typeof(EnlightenDbSystem).GetProperty(nameof(Instances));

				case 3312183461:
					return typeof(EnlightenDbSystem).GetProperty(nameof(InputSystems));

				case 637498348:
					return typeof(EnlightenDbSystem).GetProperty(nameof(SystemCache));

				case 3343002403:
					return typeof(EnlightenDbSystem).GetProperty(nameof(ClusteringCache));

				case 317514276:
					return typeof(EnlightenDbSystem).GetProperty(nameof(PreClusteringCache));

				case 3540697556:
					return typeof(EnlightenDbSystem).GetProperty(nameof(LightTransportCache));

				case 717943567:
					return typeof(EnlightenDbSystem).GetProperty(nameof(VisibilityCache));

				case 2277632311:
					return typeof(EnlightenDbSystem).GetProperty(nameof(TerrainSystem));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
