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
	public class UIMinimapIconTextureAtlasAsset : 
		Asset
	{
		[ContainerField(12)]
		public List<UIMinimapIconTexture> Icons { get; set; } = new List<UIMinimapIconTexture>(); // 0xC (12)
		
		[ContainerField(16)]
		public CtrRef<TextureAsset> TextureAtlas { get; set; } = new CtrRef<TextureAsset>(); // 0x10 (16)
		
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
