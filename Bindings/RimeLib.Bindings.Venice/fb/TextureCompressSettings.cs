///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class TextureCompressSettings : 
		DataContainer
	{
		[ContainerField(8)]
		public TextureCompressQualityMode ViewMode { get; set; } = new TextureCompressQualityMode(); // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public uint TextureCompressJobPoolSize { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float DebugDrawAlphaOverlayScale { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public bool DebugDrawEnable { get; set; } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 381898379:
					ViewMode = (TextureCompressQualityMode) Enum.ToObject(typeof(TextureCompressQualityMode), p_Value);
					break;

				case 3498014626:
					TextureCompressJobPoolSize = (uint) p_Value;
					break;

				case 3510039778:
					DebugDrawAlphaOverlayScale = (float) p_Value;
					break;

				case 1058766101:
					DebugDrawEnable = (bool) p_Value;
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
				case 381898379:
					return ViewMode;

				case 3498014626:
					return TextureCompressJobPoolSize;

				case 3510039778:
					return DebugDrawAlphaOverlayScale;

				case 1058766101:
					return DebugDrawEnable;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 381898379:
					return typeof(TextureCompressSettings).GetProperty(nameof(ViewMode));

				case 3498014626:
					return typeof(TextureCompressSettings).GetProperty(nameof(TextureCompressJobPoolSize));

				case 3510039778:
					return typeof(TextureCompressSettings).GetProperty(nameof(DebugDrawAlphaOverlayScale));

				case 1058766101:
					return typeof(TextureCompressSettings).GetProperty(nameof(DebugDrawEnable));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
