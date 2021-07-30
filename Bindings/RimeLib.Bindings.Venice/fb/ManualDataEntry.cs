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
	[ContainerType(Alignment: 4,  Flags: 41, Size: 12)]
	public class ManualDataEntry : FrostbiteContainer
	{
		[ContainerField(Name: "Platform", Offset: 0, NameHash: 942751002, Flags: 137)]
		public GamePlatform Platform { get; set; } = new GamePlatform(); // 0x0 (0)
		
		[ContainerField(Name: "Language", Offset: 4, NameHash: 3872303031, Flags: 137)]
		public LanguageFormat Language { get; set; } = new LanguageFormat(); // 0x4 (4)
		
		[ContainerField(Name: "Textures", Offset: 8, NameHash: 2027158633, Flags: 65)]
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
