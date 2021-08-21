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
using RimeLib.Frostbite.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 16,  Flags: 53, Size: 144)]
	public class Minimap2DEntityData : 
		GameEntityData
	{
		protected Vec3 m_CameraTransform = new Vec3();
		[ContainerField(Name: "CameraTransform", Offset: 96, NameHash: 2221896688, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 CameraTransform { get { return m_CameraTransform; } set { if (OnPropertyChanging("Minimap2DEntityData." + nameof(CameraTransform), this, m_CameraTransform, value)) m_CameraTransform = value; } } // 0x60 (96)
		
		protected uint m_ImageHeight = new uint();
		[ContainerField(Name: "ImageHeight", Offset: 112, NameHash: 1206650749, Flags: 49421), LayoutImmutable, Blittable]
		public uint ImageHeight { get { return m_ImageHeight; } set { if (OnPropertyChanging("Minimap2DEntityData." + nameof(ImageHeight), this, m_ImageHeight, value)) m_ImageHeight = value; } } // 0x70 (112)
		
		protected uint m_ImageWidth = new uint();
		[ContainerField(Name: "ImageWidth", Offset: 116, NameHash: 2524707716, Flags: 49421), LayoutImmutable, Blittable]
		public uint ImageWidth { get { return m_ImageWidth; } set { if (OnPropertyChanging("Minimap2DEntityData." + nameof(ImageWidth), this, m_ImageWidth, value)) m_ImageWidth = value; } } // 0x74 (116)
		
		protected uint m_AntialiasMultiplier = new uint();
		[ContainerField(Name: "AntialiasMultiplier", Offset: 120, NameHash: 1311946794, Flags: 49421), LayoutImmutable, Blittable]
		public uint AntialiasMultiplier { get { return m_AntialiasMultiplier; } set { if (OnPropertyChanging("Minimap2DEntityData." + nameof(AntialiasMultiplier), this, m_AntialiasMultiplier, value)) m_AntialiasMultiplier = value; } } // 0x78 (120)
		
		protected uint m_TerrainHeight = new uint();
		[ContainerField(Name: "TerrainHeight", Offset: 124, NameHash: 3163704045, Flags: 49421), LayoutImmutable, Blittable]
		public uint TerrainHeight { get { return m_TerrainHeight; } set { if (OnPropertyChanging("Minimap2DEntityData." + nameof(TerrainHeight), this, m_TerrainHeight, value)) m_TerrainHeight = value; } } // 0x7C (124)
		
		protected uint m_Fov = new uint();
		[ContainerField(Name: "Fov", Offset: 128, NameHash: 193443802, Flags: 49421), LayoutImmutable, Blittable]
		public uint Fov { get { return m_Fov; } set { if (OnPropertyChanging("Minimap2DEntityData." + nameof(Fov), this, m_Fov, value)) m_Fov = value; } } // 0x80 (128)
		
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
