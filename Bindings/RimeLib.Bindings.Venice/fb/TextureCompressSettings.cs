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
	public class TextureCompressSettings : 
		DataContainer
	{
		protected TextureCompressQualityMode m_ViewMode = new TextureCompressQualityMode();
		[ContainerField(8), ContainerFieldNameHash(381898379)]
		public TextureCompressQualityMode ViewMode { get { return m_ViewMode; } set { if (OnPropertyChanging("TextureCompressSettings." + nameof(ViewMode), this, m_ViewMode, value)) m_ViewMode = value; } } // 0x8 (8)
		
		protected uint m_TextureCompressJobPoolSize = new uint();
		[ContainerField(12), LayoutImmutable, Blittable, ContainerFieldNameHash(3498014626)]
		public uint TextureCompressJobPoolSize { get { return m_TextureCompressJobPoolSize; } set { if (OnPropertyChanging("TextureCompressSettings." + nameof(TextureCompressJobPoolSize), this, m_TextureCompressJobPoolSize, value)) m_TextureCompressJobPoolSize = value; } } // 0xC (12)
		
		protected float m_DebugDrawAlphaOverlayScale = new float();
		[ContainerField(16), LayoutImmutable, Blittable, ContainerFieldNameHash(3510039778)]
		public float DebugDrawAlphaOverlayScale { get { return m_DebugDrawAlphaOverlayScale; } set { if (OnPropertyChanging("TextureCompressSettings." + nameof(DebugDrawAlphaOverlayScale), this, m_DebugDrawAlphaOverlayScale, value)) m_DebugDrawAlphaOverlayScale = value; } } // 0x10 (16)
		
		protected bool m_DebugDrawEnable = new bool();
		[ContainerField(20), LayoutImmutable, Blittable, ContainerFieldNameHash(1058766101)]
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
