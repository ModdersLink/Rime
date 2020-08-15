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
	[ContainerType(4)]
	public class DecalAtlasTile : FrostbiteContainer
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public float TileIndexX { get; set; } // 0x0 (0)
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public float TileIndexY { get; set; } // 0x4 (4)
		
		[ContainerField(8), LayoutImmutable, Blittable]
		public float TileCountX { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public float TileCountY { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public bool FlipX { get; set; } // 0x10 (16)
		
		[ContainerField(17), LayoutImmutable, Blittable]
		public bool FlipY { get; set; } // 0x11 (17)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2534612119:
					TileIndexX = (float) p_Value;
					break;

				case 2534612118:
					TileIndexY = (float) p_Value;
					break;

				case 2473222698:
					TileCountX = (float) p_Value;
					break;

				case 2473222699:
					TileCountY = (float) p_Value;
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
					return typeof(DecalAtlasTile).GetProperty(nameof(TileIndexX));

				case 2534612118:
					return typeof(DecalAtlasTile).GetProperty(nameof(TileIndexY));

				case 2473222698:
					return typeof(DecalAtlasTile).GetProperty(nameof(TileCountX));

				case 2473222699:
					return typeof(DecalAtlasTile).GetProperty(nameof(TileCountY));

				case 207056974:
					return typeof(DecalAtlasTile).GetProperty(nameof(FlipX));

				case 207056975:
					return typeof(DecalAtlasTile).GetProperty(nameof(FlipY));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
