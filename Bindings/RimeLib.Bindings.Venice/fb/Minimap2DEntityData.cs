///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class Minimap2DEntityData : 
		GameEntityData
	{
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 CameraTransform { get; set; } = new Vec3(); // 0x60 (96)
		
		[ContainerField(112), LayoutImmutable, Blittable]
		public uint ImageHeight { get; set; } // 0x70 (112)
		
		[ContainerField(116), LayoutImmutable, Blittable]
		public uint ImageWidth { get; set; } // 0x74 (116)
		
		[ContainerField(120), LayoutImmutable, Blittable]
		public uint AntialiasMultiplier { get; set; } // 0x78 (120)
		
		[ContainerField(124), LayoutImmutable, Blittable]
		public uint TerrainHeight { get; set; } // 0x7C (124)
		
		[ContainerField(128), LayoutImmutable, Blittable]
		public uint Fov { get; set; } // 0x80 (128)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2221896688:
					CameraTransform = (Vec3) p_Value;
					break;

				case 1206650749:
					ImageHeight = (uint) p_Value;
					break;

				case 2524707716:
					ImageWidth = (uint) p_Value;
					break;

				case 1311946794:
					AntialiasMultiplier = (uint) p_Value;
					break;

				case 3163704045:
					TerrainHeight = (uint) p_Value;
					break;

				case 193443802:
					Fov = (uint) p_Value;
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
				case 2221896688:
					return CameraTransform;

				case 1206650749:
					return ImageHeight;

				case 2524707716:
					return ImageWidth;

				case 1311946794:
					return AntialiasMultiplier;

				case 3163704045:
					return TerrainHeight;

				case 193443802:
					return Fov;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2221896688:
					return typeof(Minimap2DEntityData).GetProperty(nameof(CameraTransform));

				case 1206650749:
					return typeof(Minimap2DEntityData).GetProperty(nameof(ImageHeight));

				case 2524707716:
					return typeof(Minimap2DEntityData).GetProperty(nameof(ImageWidth));

				case 1311946794:
					return typeof(Minimap2DEntityData).GetProperty(nameof(AntialiasMultiplier));

				case 3163704045:
					return typeof(Minimap2DEntityData).GetProperty(nameof(TerrainHeight));

				case 193443802:
					return typeof(Minimap2DEntityData).GetProperty(nameof(Fov));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
