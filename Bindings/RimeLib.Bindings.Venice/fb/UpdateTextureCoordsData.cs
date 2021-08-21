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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 80)]
	public class UpdateTextureCoordsData : 
		ProcessorData
	{
		protected EmitterTextureInfo m_TextureInfo1 = new EmitterTextureInfo();
		[ContainerField(Name: "TextureInfo1", Offset: 48, NameHash: 2154121125, Flags: 41)]
		public EmitterTextureInfo TextureInfo1 { get { return m_TextureInfo1; } set { if (OnPropertyChanging("UpdateTextureCoordsData." + nameof(TextureInfo1), this, m_TextureInfo1, value)) m_TextureInfo1 = value; } } // 0x30 (48)
		
		protected float m_TextureBlendValue = new float();
		[ContainerField(Name: "TextureBlendValue", Offset: 68, NameHash: 2879784880, Flags: 49469), LayoutImmutable, Blittable]
		public float TextureBlendValue { get { return m_TextureBlendValue; } set { if (OnPropertyChanging("UpdateTextureCoordsData." + nameof(TextureBlendValue), this, m_TextureBlendValue, value)) m_TextureBlendValue = value; } } // 0x44 (68)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2154121125:
					TextureInfo1 = (EmitterTextureInfo) p_Value;
					break;

				case 2879784880:
					TextureBlendValue = (float) p_Value;
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
				case 2154121125:
					return TextureInfo1;

				case 2879784880:
					return TextureBlendValue;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2154121125:
					return typeof(UpdateTextureCoordsData).GetProperty(nameof(TextureInfo1));

				case 2879784880:
					return typeof(UpdateTextureCoordsData).GetProperty(nameof(TextureBlendValue));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
