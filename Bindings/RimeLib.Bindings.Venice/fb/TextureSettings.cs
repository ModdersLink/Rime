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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 16)]
	public class TextureSettings : 
		DataContainer
	{
		protected uint m_SkipMipmapCount = new uint();
		[ContainerField(Name: "SkipMipmapCount", Offset: 8, NameHash: 679697071, Flags: 49421), LayoutImmutable, Blittable]
		public uint SkipMipmapCount { get { return m_SkipMipmapCount; } set { if (OnPropertyChanging("TextureSettings." + nameof(SkipMipmapCount), this, m_SkipMipmapCount, value)) m_SkipMipmapCount = value; } } // 0x8 (8)
		
		protected bool m_LoadingEnabled = new bool();
		[ContainerField(Name: "LoadingEnabled", Offset: 12, NameHash: 1695799750, Flags: 49325), LayoutImmutable, Blittable]
		public bool LoadingEnabled { get { return m_LoadingEnabled; } set { if (OnPropertyChanging("TextureSettings." + nameof(LoadingEnabled), this, m_LoadingEnabled, value)) m_LoadingEnabled = value; } } // 0xC (12)
		
		protected bool m_RenderTexturesEnabled = new bool();
		[ContainerField(Name: "RenderTexturesEnabled", Offset: 13, NameHash: 437746662, Flags: 49325), LayoutImmutable, Blittable]
		public bool RenderTexturesEnabled { get { return m_RenderTexturesEnabled; } set { if (OnPropertyChanging("TextureSettings." + nameof(RenderTexturesEnabled), this, m_RenderTexturesEnabled, value)) m_RenderTexturesEnabled = value; } } // 0xD (13)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 679697071:
					SkipMipmapCount = (uint) p_Value;
					break;

				case 1695799750:
					LoadingEnabled = (bool) p_Value;
					break;

				case 437746662:
					RenderTexturesEnabled = (bool) p_Value;
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
				case 679697071:
					return SkipMipmapCount;

				case 1695799750:
					return LoadingEnabled;

				case 437746662:
					return RenderTexturesEnabled;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 679697071:
					return typeof(TextureSettings).GetProperty(nameof(SkipMipmapCount));

				case 1695799750:
					return typeof(TextureSettings).GetProperty(nameof(LoadingEnabled));

				case 437746662:
					return typeof(TextureSettings).GetProperty(nameof(RenderTexturesEnabled));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
