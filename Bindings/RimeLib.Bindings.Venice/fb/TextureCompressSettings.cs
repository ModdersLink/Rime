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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 24)]
	public class TextureCompressSettings : 
		DataContainer
	{
		protected TextureCompressQualityMode m_ViewMode = new TextureCompressQualityMode();
		[ContainerField(Name: "ViewMode", Offset: 8, NameHash: 381898379, Flags: 137)]
		public TextureCompressQualityMode ViewMode { get { return m_ViewMode; } set { if (OnPropertyChanging("TextureCompressSettings." + nameof(ViewMode), this, m_ViewMode, value)) m_ViewMode = value; } } // 0x8 (8)
		
		protected uint m_TextureCompressJobPoolSize = new uint();
		[ContainerField(Name: "TextureCompressJobPoolSize", Offset: 12, NameHash: 3498014626, Flags: 49421), LayoutImmutable, Blittable]
		public uint TextureCompressJobPoolSize { get { return m_TextureCompressJobPoolSize; } set { if (OnPropertyChanging("TextureCompressSettings." + nameof(TextureCompressJobPoolSize), this, m_TextureCompressJobPoolSize, value)) m_TextureCompressJobPoolSize = value; } } // 0xC (12)
		
		protected float m_DebugDrawAlphaOverlayScale = new float();
		[ContainerField(Name: "DebugDrawAlphaOverlayScale", Offset: 16, NameHash: 3510039778, Flags: 49469), LayoutImmutable, Blittable]
		public float DebugDrawAlphaOverlayScale { get { return m_DebugDrawAlphaOverlayScale; } set { if (OnPropertyChanging("TextureCompressSettings." + nameof(DebugDrawAlphaOverlayScale), this, m_DebugDrawAlphaOverlayScale, value)) m_DebugDrawAlphaOverlayScale = value; } } // 0x10 (16)
		
		protected bool m_DebugDrawEnable = new bool();
		[ContainerField(Name: "DebugDrawEnable", Offset: 20, NameHash: 1058766101, Flags: 49325), LayoutImmutable, Blittable]
		public bool DebugDrawEnable { get { return m_DebugDrawEnable; } set { if (OnPropertyChanging("TextureCompressSettings." + nameof(DebugDrawEnable), this, m_DebugDrawEnable, value)) m_DebugDrawEnable = value; } } // 0x14 (20)
		
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
