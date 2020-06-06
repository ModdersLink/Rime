///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Collections.Generic;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class UIAnimatedTextureAsset : 
		Asset
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public float FrameRate { get; set; } // 0xC (12)
		
		[ContainerField(16)]
		public CtrRef<TextureAsset> TextureAtlas { get; set; } = new CtrRef<TextureAsset>(); // 0x10 (16)
		
		[ContainerField(20)]
		public List<UITextureAtlasInfo> TextureInfos { get; set; } = new List<UITextureAtlasInfo>(); // 0x14 (20)
		
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
