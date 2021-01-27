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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 28)]
	public class UILevelDescription : 
		UIItemDescription
	{
		protected string m_LevelName = string.Empty;
		[ContainerField(Name: "LevelName", Offset: 16, NameHash: 1599082292, Flags: 16509), LayoutImmutable]
		public string LevelName { get { return m_LevelName; } set { if (OnPropertyChanging("UILevelDescription." + nameof(LevelName), this, m_LevelName, value)) m_LevelName = value; } } // 0x10 (16)
		
		protected string m_TexturePath = string.Empty;
		[ContainerField(Name: "TexturePath", Offset: 20, NameHash: 3058477943, Flags: 16509), LayoutImmutable]
		public string TexturePath { get { return m_TexturePath; } set { if (OnPropertyChanging("UILevelDescription." + nameof(TexturePath), this, m_TexturePath, value)) m_TexturePath = value; } } // 0x14 (20)
		
		protected string m_ThumbnailTexturePath = string.Empty;
		[ContainerField(Name: "ThumbnailTexturePath", Offset: 24, NameHash: 2407220379, Flags: 16509), LayoutImmutable]
		public string ThumbnailTexturePath { get { return m_ThumbnailTexturePath; } set { if (OnPropertyChanging("UILevelDescription." + nameof(ThumbnailTexturePath), this, m_ThumbnailTexturePath, value)) m_ThumbnailTexturePath = value; } } // 0x18 (24)
		
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
