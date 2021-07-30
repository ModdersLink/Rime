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
	[ContainerType(Alignment: 4,  Flags: 41, Size: 20)]
	public class TerrainQuadDecalAtlasTile : FrostbiteContainer
	{
		[ContainerField(Name: "TileIndexX", Offset: 0, NameHash: 2534612119, Flags: 49421), LayoutImmutable, Blittable]
		public uint TileIndexX { get; set; } // 0x0 (0)
		
		[ContainerField(Name: "TileIndexY", Offset: 4, NameHash: 2534612118, Flags: 49421), LayoutImmutable, Blittable]
		public uint TileIndexY { get; set; } // 0x4 (4)
		
		[ContainerField(Name: "TileCountX", Offset: 8, NameHash: 2473222698, Flags: 49421), LayoutImmutable, Blittable]
		public uint TileCountX { get; set; } // 0x8 (8)
		
		[ContainerField(Name: "TileCountY", Offset: 12, NameHash: 2473222699, Flags: 49421), LayoutImmutable, Blittable]
		public uint TileCountY { get; set; } // 0xC (12)
		
		[ContainerField(Name: "FlipX", Offset: 16, NameHash: 207056974, Flags: 49325), LayoutImmutable, Blittable]
		public bool FlipX { get; set; } // 0x10 (16)
		
		[ContainerField(Name: "FlipY", Offset: 17, NameHash: 207056975, Flags: 49325), LayoutImmutable, Blittable]
		public bool FlipY { get; set; } // 0x11 (17)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2534612119:
					TileIndexX = (uint) p_Value;
					break;

				case 2534612118:
					TileIndexY = (uint) p_Value;
					break;

				case 2473222698:
					TileCountX = (uint) p_Value;
					break;

				case 2473222699:
					TileCountY = (uint) p_Value;
					break;

				case 207056974:
					FlipX = (bool) p_Value;
					break;

				case 207056975:
					FlipY = (bool) p_Value;
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
				case 2534612119:
					return TileIndexX;

				case 2534612118:
					return TileIndexY;

				case 2473222698:
					return TileCountX;

				case 2473222699:
					return TileCountY;

				case 207056974:
					return FlipX;

				case 207056975:
					return FlipY;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2534612119:
					return typeof(TerrainQuadDecalAtlasTile).GetProperty(nameof(TileIndexX));

				case 2534612118:
					return typeof(TerrainQuadDecalAtlasTile).GetProperty(nameof(TileIndexY));

				case 2473222698:
					return typeof(TerrainQuadDecalAtlasTile).GetProperty(nameof(TileCountX));

				case 2473222699:
					return typeof(TerrainQuadDecalAtlasTile).GetProperty(nameof(TileCountY));

				case 207056974:
					return typeof(TerrainQuadDecalAtlasTile).GetProperty(nameof(FlipX));

				case 207056975:
					return typeof(TerrainQuadDecalAtlasTile).GetProperty(nameof(FlipY));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
