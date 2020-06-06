///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class ManualDataEntry : FrostbiteContainer
	{
		[ContainerField(0)]
		public GamePlatform Platform { get; set; } = new GamePlatform(); // 0x0 (0)
		
		[ContainerField(4)]
		public LanguageFormat Language { get; set; } = new LanguageFormat(); // 0x4 (4)
		
		[ContainerField(8)]
		public RefArray<TextureAsset> Textures { get; set; } = new RefArray<TextureAsset>(); // 0x8 (8)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 942751002:
						Platform = (GamePlatform) Enum.ToObject(typeof(GamePlatform), p_Value);
					break;

				case 3872303031:
						Language = (LanguageFormat) Enum.ToObject(typeof(LanguageFormat), p_Value);
					break;

				case 2027158633:
					Textures = (RefArray<TextureAsset>) p_Value;
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
				case 942751002:
					return Platform;

				case 3872303031:
					return Language;

				case 2027158633:
					return Textures;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 942751002:
					return typeof(ManualDataEntry).GetProperty(nameof(Platform));

				case 3872303031:
					return typeof(ManualDataEntry).GetProperty(nameof(Language));

				case 2027158633:
					return typeof(ManualDataEntry).GetProperty(nameof(Textures));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
