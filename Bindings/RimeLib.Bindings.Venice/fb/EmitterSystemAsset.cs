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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 24)]
	public class EmitterSystemAsset : 
		Asset
	{
		protected List<EmitterTextureAtlasInfo> m_TextureInfos = new List<EmitterTextureAtlasInfo>();
		[ContainerField(Name: "TextureInfos", Offset: 12, NameHash: 2154121191, Flags: 65)]
		public List<EmitterTextureAtlasInfo> TextureInfos { get { return m_TextureInfos; } set { if (OnPropertyChanging("EmitterSystemAsset." + nameof(TextureInfos), this, m_TextureInfos, value)) m_TextureInfos = value; } } // 0xC (12)
		
		protected CtrRef<TextureAsset> m_BaseAtlasTexture = new CtrRef<TextureAsset>();
		[ContainerField(Name: "BaseAtlasTexture", Offset: 16, NameHash: 1736187172, Flags: 53)]
		public CtrRef<TextureAsset> BaseAtlasTexture { get { return m_BaseAtlasTexture; } set { if (OnPropertyChanging("EmitterSystemAsset." + nameof(BaseAtlasTexture), this, m_BaseAtlasTexture, value)) m_BaseAtlasTexture = value; } } // 0x10 (16)
		
		protected CtrRef<TextureAsset> m_NormalAtlasTexture = new CtrRef<TextureAsset>();
		[ContainerField(Name: "NormalAtlasTexture", Offset: 20, NameHash: 2946813282, Flags: 53)]
		public CtrRef<TextureAsset> NormalAtlasTexture { get { return m_NormalAtlasTexture; } set { if (OnPropertyChanging("EmitterSystemAsset." + nameof(NormalAtlasTexture), this, m_NormalAtlasTexture, value)) m_NormalAtlasTexture = value; } } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2154121191:
					TextureInfos = (List<EmitterTextureAtlasInfo>) p_Value;
					break;

				case 1736187172:
					BaseAtlasTexture = (CtrRef<TextureAsset>) p_Value;
					break;

				case 2946813282:
					NormalAtlasTexture = (CtrRef<TextureAsset>) p_Value;
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
				case 2154121191:
					return TextureInfos;

				case 1736187172:
					return BaseAtlasTexture;

				case 2946813282:
					return NormalAtlasTexture;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2154121191:
					return typeof(EmitterSystemAsset).GetProperty(nameof(TextureInfos));

				case 1736187172:
					return typeof(EmitterSystemAsset).GetProperty(nameof(BaseAtlasTexture));

				case 2946813282:
					return typeof(EmitterSystemAsset).GetProperty(nameof(NormalAtlasTexture));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
