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
	public class ShaderTextureUnlockPartCollection : 
		ShaderCustomizationUnlockPartCollection
	{
		[ContainerField(20)]
		public CtrRef<TextureReference> DefaultTextureReference { get; set; } = new CtrRef<TextureReference>(); // 0x14 (20)
		
		[ContainerField(24)]
		public RefArray<TextureUnlockPartData> UnlockParts { get; set; } = new RefArray<TextureUnlockPartData>(); // 0x18 (24)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 796555962:
					DefaultTextureReference = (CtrRef<TextureReference>) p_Value;
					break;

				case 4116003953:
					UnlockParts = (RefArray<TextureUnlockPartData>) p_Value;
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
				case 796555962:
					return DefaultTextureReference;

				case 4116003953:
					return UnlockParts;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 796555962:
					return typeof(ShaderTextureUnlockPartCollection).GetProperty(nameof(DefaultTextureReference));

				case 4116003953:
					return typeof(ShaderTextureUnlockPartCollection).GetProperty(nameof(UnlockParts));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
