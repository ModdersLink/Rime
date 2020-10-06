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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(24), ContainerClass]
	public class UIAnimatedTextureAsset : 
		Asset
	{
		protected float m_FrameRate = new float();
		[ContainerField(12), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(21928954)]
		public float FrameRate { get { return m_FrameRate; } set { if (OnPropertyChanging("UIAnimatedTextureAsset." + nameof(FrameRate), this, m_FrameRate, value)) m_FrameRate = value; } } // 0xC (12)
		
		protected CtrRef<TextureAsset> m_TextureAtlas = new CtrRef<TextureAsset>();
		[ContainerField(16), MemberInfoFlag(53), ContainerFieldNameHash(2162950897), ContainerCtrRef]
		public CtrRef<TextureAsset> TextureAtlas { get { return m_TextureAtlas; } set { if (OnPropertyChanging("UIAnimatedTextureAsset." + nameof(TextureAtlas), this, m_TextureAtlas, value)) m_TextureAtlas = value; } } // 0x10 (16)
		
		protected List<UITextureAtlasInfo> m_TextureInfos = new List<UITextureAtlasInfo>();
		[ContainerField(20), MemberInfoFlag(65), ContainerFieldNameHash(2154121191), ContainerArray]
		public List<UITextureAtlasInfo> TextureInfos { get { return m_TextureInfos; } set { if (OnPropertyChanging("UIAnimatedTextureAsset." + nameof(TextureInfos), this, m_TextureInfos, value)) m_TextureInfos = value; } } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 21928954:
					FrameRate = (float) p_Value;
					break;

				case 2162950897:
					TextureAtlas = (CtrRef<TextureAsset>) p_Value;
					break;

				case 2154121191:
					TextureInfos = (List<UITextureAtlasInfo>) p_Value;
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
				case 21928954:
					return FrameRate;

				case 2162950897:
					return TextureAtlas;

				case 2154121191:
					return TextureInfos;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 21928954:
					return typeof(UIAnimatedTextureAsset).GetProperty(nameof(FrameRate));

				case 2162950897:
					return typeof(UIAnimatedTextureAsset).GetProperty(nameof(TextureAtlas));

				case 2154121191:
					return typeof(UIAnimatedTextureAsset).GetProperty(nameof(TextureInfos));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
