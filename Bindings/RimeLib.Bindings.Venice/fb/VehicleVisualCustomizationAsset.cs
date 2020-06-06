///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class VehicleVisualCustomizationAsset : 
		Asset
	{
		[ContainerField(12)]
		public RefArray<ShaderTextureUnlockPartCollection> TextureUnlockPartCollections { get; set; } = new RefArray<ShaderTextureUnlockPartCollection>(); // 0xC (12)
		
		[ContainerField(16)]
		public RefArray<TextUnlockPartData> TextUnlockParts { get; set; } = new RefArray<TextUnlockPartData>(); // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3762069016:
					TextureUnlockPartCollections = (RefArray<ShaderTextureUnlockPartCollection>) p_Value;
					break;

				case 1176201452:
					TextUnlockParts = (RefArray<TextUnlockPartData>) p_Value;
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
				case 3762069016:
					return TextureUnlockPartCollections;

				case 1176201452:
					return TextUnlockParts;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3762069016:
					return typeof(VehicleVisualCustomizationAsset).GetProperty(nameof(TextureUnlockPartCollections));

				case 1176201452:
					return typeof(VehicleVisualCustomizationAsset).GetProperty(nameof(TextUnlockParts));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
