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
	public class EmitterSystemAsset : 
		Asset
	{
		[ContainerField(12)]
		public List<EmitterTextureAtlasInfo> TextureInfos { get; set; } = new List<EmitterTextureAtlasInfo>(); // 0xC (12)
		
		[ContainerField(16)]
		public CtrRef<TextureAsset> BaseAtlasTexture { get; set; } = new CtrRef<TextureAsset>(); // 0x10 (16)
		
		[ContainerField(20)]
		public CtrRef<TextureAsset> NormalAtlasTexture { get; set; } = new CtrRef<TextureAsset>(); // 0x14 (20)
		
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
