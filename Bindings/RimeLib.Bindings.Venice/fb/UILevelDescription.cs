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
	public class UILevelDescription : 
		UIItemDescription
	{
		[ContainerField(16), LayoutImmutable]
		public string LevelName { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable]
		public string TexturePath { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable]
		public string ThumbnailTexturePath { get; set; } // 0x18 (24)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1599082292:
					LevelName = (string) p_Value;
					break;

				case 3058477943:
					TexturePath = (string) p_Value;
					break;

				case 2407220379:
					ThumbnailTexturePath = (string) p_Value;
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
				case 1599082292:
					return LevelName;

				case 3058477943:
					return TexturePath;

				case 2407220379:
					return ThumbnailTexturePath;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1599082292:
					return typeof(UILevelDescription).GetProperty(nameof(LevelName));

				case 3058477943:
					return typeof(UILevelDescription).GetProperty(nameof(TexturePath));

				case 2407220379:
					return typeof(UILevelDescription).GetProperty(nameof(ThumbnailTexturePath));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
