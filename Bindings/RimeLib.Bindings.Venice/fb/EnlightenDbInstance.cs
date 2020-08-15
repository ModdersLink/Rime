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
	[ContainerType(16)]
	public class EnlightenDbInstance : FrostbiteContainer
	{
		[ContainerField(0), Homogeneous, LayoutImmutable, Blittable]
		public AxisAlignedBox WorldBoundingbox { get; set; } = new AxisAlignedBox(); // 0x0 (0)
		
		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable]
		public LinearTransform WorldTransform { get; set; } = new LinearTransform(); // 0x20 (32)
		
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable]
		public Vec2 UvTranslation { get; set; } = new Vec2(); // 0x60 (96)
		
		[ContainerField(112), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 UvTransform { get; set; } = new Vec4(); // 0x70 (112)
		
		[ContainerField(128), LayoutImmutable, Blittable]
		public uint GeometryId { get; set; } // 0x80 (128)
		
		[ContainerField(132), LayoutImmutable]
		public string ObjectVariation { get; set; } // 0x84 (132)
		
		[ContainerField(136), LayoutImmutable]
		public string GuidString { get; set; } // 0x88 (136)
		
		[ContainerField(140), LayoutImmutable, Blittable]
		public uint UvSizeX { get; set; } // 0x8C (140)
		
		[ContainerField(144), LayoutImmutable, Blittable]
		public uint UvSizeY { get; set; } // 0x90 (144)
		
		[ContainerField(148), LayoutImmutable, Blittable]
		public float PixelSize { get; set; } // 0x94 (148)
		
		[ContainerField(152), LayoutImmutable]
		public string EnlightenMeshName { get; set; } // 0x98 (152)
		
		[ContainerField(156), LayoutImmutable]
		public string MeshAsset { get; set; } // 0x9C (156)
		
		[ContainerField(160)]
		public List<ulong> InstanceAlbedos { get; set; } = new List<ulong>(); // 0xA0 (160)
		
		[ContainerField(164), LayoutImmutable, Blittable]
		public GUID CacheKey { get; set; } // 0xA4 (164)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3818495328:
					WorldBoundingbox = (AxisAlignedBox) p_Value;
					break;

				case 2538324011:
					WorldTransform = (LinearTransform) p_Value;
					break;

				case 2805972397:
					UvTranslation = (Vec2) p_Value;
					break;

				case 2858488202:
					UvTransform = (Vec4) p_Value;
					break;

				case 2646119826:
					GeometryId = (uint) p_Value;
					break;

				case 3624336577:
					ObjectVariation = (string) p_Value;
					break;

				case 1743579631:
					GuidString = (string) p_Value;
					break;

				case 2523551419:
					UvSizeX = (uint) p_Value;
					break;

				case 2523551418:
					UvSizeY = (uint) p_Value;
					break;

				case 854589352:
					PixelSize = (float) p_Value;
					break;

				case 1268643727:
					EnlightenMeshName = (string) p_Value;
					break;

				case 15738982:
					MeshAsset = (string) p_Value;
					break;

				case 1348110462:
					InstanceAlbedos = (List<ulong>) p_Value;
					break;

				case 2796431134:
					CacheKey = (GUID) p_Value;
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
				case 3818495328:
					return WorldBoundingbox;

				case 2538324011:
					return WorldTransform;

				case 2805972397:
					return UvTranslation;

				case 2858488202:
					return UvTransform;

				case 2646119826:
					return GeometryId;

				case 3624336577:
					return ObjectVariation;

				case 1743579631:
					return GuidString;

				case 2523551419:
					return UvSizeX;

				case 2523551418:
					return UvSizeY;

				case 854589352:
					return PixelSize;

				case 1268643727:
					return EnlightenMeshName;

				case 15738982:
					return MeshAsset;

				case 1348110462:
					return InstanceAlbedos;

				case 2796431134:
					return CacheKey;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3818495328:
					return typeof(EnlightenDbInstance).GetProperty(nameof(WorldBoundingbox));

				case 2538324011:
					return typeof(EnlightenDbInstance).GetProperty(nameof(WorldTransform));

				case 2805972397:
					return typeof(EnlightenDbInstance).GetProperty(nameof(UvTranslation));

				case 2858488202:
					return typeof(EnlightenDbInstance).GetProperty(nameof(UvTransform));

				case 2646119826:
					return typeof(EnlightenDbInstance).GetProperty(nameof(GeometryId));

				case 3624336577:
					return typeof(EnlightenDbInstance).GetProperty(nameof(ObjectVariation));

				case 1743579631:
					return typeof(EnlightenDbInstance).GetProperty(nameof(GuidString));

				case 2523551419:
					return typeof(EnlightenDbInstance).GetProperty(nameof(UvSizeX));

				case 2523551418:
					return typeof(EnlightenDbInstance).GetProperty(nameof(UvSizeY));

				case 854589352:
					return typeof(EnlightenDbInstance).GetProperty(nameof(PixelSize));

				case 1268643727:
					return typeof(EnlightenDbInstance).GetProperty(nameof(EnlightenMeshName));

				case 15738982:
					return typeof(EnlightenDbInstance).GetProperty(nameof(MeshAsset));

				case 1348110462:
					return typeof(EnlightenDbInstance).GetProperty(nameof(InstanceAlbedos));

				case 2796431134:
					return typeof(EnlightenDbInstance).GetProperty(nameof(CacheKey));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
