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
	public class UIMinimapIconTextureAtlasAsset : 
		Asset
	{
		protected List<UIMinimapIconTexture> m_Icons = new List<UIMinimapIconTexture>();
		[ContainerField(12), ContainerFieldNameHash(214893277)]
		public List<UIMinimapIconTexture> Icons { get { return m_Icons; } set { if (OnPropertyChanging("UIMinimapIconTextureAtlasAsset." + nameof(Icons), this, m_Icons, value)) m_Icons = value; } } // 0xC (12)
		
		protected CtrRef<TextureAsset> m_TextureAtlas = new CtrRef<TextureAsset>();
		[ContainerField(16), ContainerFieldNameHash(2162950897)]
		public CtrRef<TextureAsset> TextureAtlas { get { return m_TextureAtlas; } set { if (OnPropertyChanging("UIMinimapIconTextureAtlasAsset." + nameof(TextureAtlas), this, m_TextureAtlas, value)) m_TextureAtlas = value; } } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 214893277:
					Icons = (List<UIMinimapIconTexture>) p_Value;
					break;

				case 2162950897:
					TextureAtlas = (CtrRef<TextureAsset>) p_Value;
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
				case 214893277:
					return Icons;

				case 2162950897:
					return TextureAtlas;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 214893277:
					return typeof(UIMinimapIconTextureAtlasAsset).GetProperty(nameof(Icons));

				case 2162950897:
					return typeof(UIMinimapIconTextureAtlasAsset).GetProperty(nameof(TextureAtlas));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
