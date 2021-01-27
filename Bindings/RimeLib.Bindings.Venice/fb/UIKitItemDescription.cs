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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 52)]
	public class UIKitItemDescription : 
		UIItemDescription
	{
		protected string m_Name = string.Empty;
		[ContainerField(Name: "Name", Offset: 16, NameHash: 2088949890, Flags: 16509), LayoutImmutable]
		public string Name { get { return m_Name; } set { if (OnPropertyChanging("UIKitItemDescription." + nameof(Name), this, m_Name, value)) m_Name = value; } } // 0x10 (16)
		
		protected string m_UnlockName = string.Empty;
		[ContainerField(Name: "UnlockName", Offset: 20, NameHash: 1036710322, Flags: 16509), LayoutImmutable]
		public string UnlockName { get { return m_UnlockName; } set { if (OnPropertyChanging("UIKitItemDescription." + nameof(UnlockName), this, m_UnlockName, value)) m_UnlockName = value; } } // 0x14 (20)
		
		protected string m_Description = string.Empty;
		[ContainerField(Name: "Description", Offset: 24, NameHash: 1636673251, Flags: 16509), LayoutImmutable]
		public string Description { get { return m_Description; } set { if (OnPropertyChanging("UIKitItemDescription." + nameof(Description), this, m_Description, value)) m_Description = value; } } // 0x18 (24)
		
		protected string m_Category = string.Empty;
		[ContainerField(Name: "Category", Offset: 28, NameHash: 3455858997, Flags: 16509), LayoutImmutable]
		public string Category { get { return m_Category; } set { if (OnPropertyChanging("UIKitItemDescription." + nameof(Category), this, m_Category, value)) m_Category = value; } } // 0x1C (28)
		
		protected string m_TexturePath = string.Empty;
		[ContainerField(Name: "TexturePath", Offset: 32, NameHash: 3058477943, Flags: 16509), LayoutImmutable]
		public string TexturePath { get { return m_TexturePath; } set { if (OnPropertyChanging("UIKitItemDescription." + nameof(TexturePath), this, m_TexturePath, value)) m_TexturePath = value; } } // 0x20 (32)
		
		protected string m_IconTexturePath = string.Empty;
		[ContainerField(Name: "IconTexturePath", Offset: 36, NameHash: 377747068, Flags: 16509), LayoutImmutable]
		public string IconTexturePath { get { return m_IconTexturePath; } set { if (OnPropertyChanging("UIKitItemDescription." + nameof(IconTexturePath), this, m_IconTexturePath, value)) m_IconTexturePath = value; } } // 0x24 (36)
		
		protected string m_UnlockTexturePath = string.Empty;
		[ContainerField(Name: "UnlockTexturePath", Offset: 40, NameHash: 2699666183, Flags: 16509), LayoutImmutable]
		public string UnlockTexturePath { get { return m_UnlockTexturePath; } set { if (OnPropertyChanging("UIKitItemDescription." + nameof(UnlockTexturePath), this, m_UnlockTexturePath, value)) m_UnlockTexturePath = value; } } // 0x28 (40)
		
		protected UIHudIcon m_HudIcon = new UIHudIcon();
		[ContainerField(Name: "HudIcon", Offset: 44, NameHash: 2639628855, Flags: 137)]
		public UIHudIcon HudIcon { get { return m_HudIcon; } set { if (OnPropertyChanging("UIKitItemDescription." + nameof(HudIcon), this, m_HudIcon, value)) m_HudIcon = value; } } // 0x2C (44)
		
		protected bool m_NotExplicitelySelectable = new bool();
		[ContainerField(Name: "NotExplicitelySelectable", Offset: 48, NameHash: 3852874612, Flags: 49325), LayoutImmutable, Blittable]
		public bool NotExplicitelySelectable { get { return m_NotExplicitelySelectable; } set { if (OnPropertyChanging("UIKitItemDescription." + nameof(NotExplicitelySelectable), this, m_NotExplicitelySelectable, value)) m_NotExplicitelySelectable = value; } } // 0x30 (48)
		
		protected bool m_HiddenInProgression = new bool();
		[ContainerField(Name: "HiddenInProgression", Offset: 49, NameHash: 1800564573, Flags: 49325), LayoutImmutable, Blittable]
		public bool HiddenInProgression { get { return m_HiddenInProgression; } set { if (OnPropertyChanging("UIKitItemDescription." + nameof(HiddenInProgression), this, m_HiddenInProgression, value)) m_HiddenInProgression = value; } } // 0x31 (49)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2088949890:
					Name = (string) p_Value;
					break;

				case 1036710322:
					UnlockName = (string) p_Value;
					break;

				case 1636673251:
					Description = (string) p_Value;
					break;

				case 3455858997:
					Category = (string) p_Value;
					break;

				case 3058477943:
					TexturePath = (string) p_Value;
					break;

				case 377747068:
					IconTexturePath = (string) p_Value;
					break;

				case 2699666183:
					UnlockTexturePath = (string) p_Value;
					break;

				case 2639628855:
					HudIcon = (UIHudIcon) Enum.ToObject(typeof(UIHudIcon), p_Value);
					break;

				case 3852874612:
					NotExplicitelySelectable = (bool) p_Value;
					break;

				case 1800564573:
					HiddenInProgression = (bool) p_Value;
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
				case 2088949890:
					return Name;

				case 1036710322:
					return UnlockName;

				case 1636673251:
					return Description;

				case 3455858997:
					return Category;

				case 3058477943:
					return TexturePath;

				case 377747068:
					return IconTexturePath;

				case 2699666183:
					return UnlockTexturePath;

				case 2639628855:
					return HudIcon;

				case 3852874612:
					return NotExplicitelySelectable;

				case 1800564573:
					return HiddenInProgression;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2088949890:
					return typeof(UIKitItemDescription).GetProperty(nameof(Name));

				case 1036710322:
					return typeof(UIKitItemDescription).GetProperty(nameof(UnlockName));

				case 1636673251:
					return typeof(UIKitItemDescription).GetProperty(nameof(Description));

				case 3455858997:
					return typeof(UIKitItemDescription).GetProperty(nameof(Category));

				case 3058477943:
					return typeof(UIKitItemDescription).GetProperty(nameof(TexturePath));

				case 377747068:
					return typeof(UIKitItemDescription).GetProperty(nameof(IconTexturePath));

				case 2699666183:
					return typeof(UIKitItemDescription).GetProperty(nameof(UnlockTexturePath));

				case 2639628855:
					return typeof(UIKitItemDescription).GetProperty(nameof(HudIcon));

				case 3852874612:
					return typeof(UIKitItemDescription).GetProperty(nameof(NotExplicitelySelectable));

				case 1800564573:
					return typeof(UIKitItemDescription).GetProperty(nameof(HiddenInProgression));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
