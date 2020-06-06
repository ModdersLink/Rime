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
	public class UIKitItemDescription : 
		UIItemDescription
	{
		[ContainerField(16), LayoutImmutable]
		public string Name { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable]
		public string UnlockName { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable]
		public string Description { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable]
		public string Category { get; set; } // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable]
		public string TexturePath { get; set; } // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable]
		public string IconTexturePath { get; set; } // 0x24 (36)
		
		[ContainerField(40), LayoutImmutable]
		public string UnlockTexturePath { get; set; } // 0x28 (40)
		
		[ContainerField(44)]
		public UIHudIcon HudIcon { get; set; } = new UIHudIcon(); // 0x2C (44)
		
		[ContainerField(48), LayoutImmutable, Blittable]
		public bool NotExplicitelySelectable { get; set; } // 0x30 (48)
		
		[ContainerField(49), LayoutImmutable, Blittable]
		public bool HiddenInProgression { get; set; } // 0x31 (49)
		
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
