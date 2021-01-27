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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 60)]
	public class UIWeaponDescription : 
		UIItemDescription
	{
		protected string m_Name = string.Empty;
		[ContainerField(Name: "Name", Offset: 16, NameHash: 2088949890, Flags: 16509), LayoutImmutable]
		public string Name { get { return m_Name; } set { if (OnPropertyChanging("UIWeaponDescription." + nameof(Name), this, m_Name, value)) m_Name = value; } } // 0x10 (16)
		
		protected string m_UnlockName = string.Empty;
		[ContainerField(Name: "UnlockName", Offset: 20, NameHash: 1036710322, Flags: 16509), LayoutImmutable]
		public string UnlockName { get { return m_UnlockName; } set { if (OnPropertyChanging("UIWeaponDescription." + nameof(UnlockName), this, m_UnlockName, value)) m_UnlockName = value; } } // 0x14 (20)
		
		protected string m_Description = string.Empty;
		[ContainerField(Name: "Description", Offset: 24, NameHash: 1636673251, Flags: 16509), LayoutImmutable]
		public string Description { get { return m_Description; } set { if (OnPropertyChanging("UIWeaponDescription." + nameof(Description), this, m_Description, value)) m_Description = value; } } // 0x18 (24)
		
		protected string m_Category = string.Empty;
		[ContainerField(Name: "Category", Offset: 28, NameHash: 3455858997, Flags: 16509), LayoutImmutable]
		public string Category { get { return m_Category; } set { if (OnPropertyChanging("UIWeaponDescription." + nameof(Category), this, m_Category, value)) m_Category = value; } } // 0x1C (28)
		
		protected string m_TexturePath = string.Empty;
		[ContainerField(Name: "TexturePath", Offset: 32, NameHash: 3058477943, Flags: 16509), LayoutImmutable]
		public string TexturePath { get { return m_TexturePath; } set { if (OnPropertyChanging("UIWeaponDescription." + nameof(TexturePath), this, m_TexturePath, value)) m_TexturePath = value; } } // 0x20 (32)
		
		protected string m_IconTexturePath = string.Empty;
		[ContainerField(Name: "IconTexturePath", Offset: 36, NameHash: 377747068, Flags: 16509), LayoutImmutable]
		public string IconTexturePath { get { return m_IconTexturePath; } set { if (OnPropertyChanging("UIWeaponDescription." + nameof(IconTexturePath), this, m_IconTexturePath, value)) m_IconTexturePath = value; } } // 0x24 (36)
		
		protected string m_UnlockTexturePath = string.Empty;
		[ContainerField(Name: "UnlockTexturePath", Offset: 40, NameHash: 2699666183, Flags: 16509), LayoutImmutable]
		public string UnlockTexturePath { get { return m_UnlockTexturePath; } set { if (OnPropertyChanging("UIWeaponDescription." + nameof(UnlockTexturePath), this, m_UnlockTexturePath, value)) m_UnlockTexturePath = value; } } // 0x28 (40)
		
		protected string m_Ammo = string.Empty;
		[ContainerField(Name: "Ammo", Offset: 44, NameHash: 2088639403, Flags: 16509), LayoutImmutable]
		public string Ammo { get { return m_Ammo; } set { if (OnPropertyChanging("UIWeaponDescription." + nameof(Ammo), this, m_Ammo, value)) m_Ammo = value; } } // 0x2C (44)
		
		protected string m_RateOfFire = string.Empty;
		[ContainerField(Name: "RateOfFire", Offset: 48, NameHash: 3866082710, Flags: 16509), LayoutImmutable]
		public string RateOfFire { get { return m_RateOfFire; } set { if (OnPropertyChanging("UIWeaponDescription." + nameof(RateOfFire), this, m_RateOfFire, value)) m_RateOfFire = value; } } // 0x30 (48)
		
		protected string m_Range = string.Empty;
		[ContainerField(Name: "Range", Offset: 52, NameHash: 230112826, Flags: 16509), LayoutImmutable]
		public string Range { get { return m_Range; } set { if (OnPropertyChanging("UIWeaponDescription." + nameof(Range), this, m_Range, value)) m_Range = value; } } // 0x34 (52)
		
		protected bool m_FireModeSingle = new bool();
		[ContainerField(Name: "FireModeSingle", Offset: 56, NameHash: 380723556, Flags: 49325), LayoutImmutable, Blittable]
		public bool FireModeSingle { get { return m_FireModeSingle; } set { if (OnPropertyChanging("UIWeaponDescription." + nameof(FireModeSingle), this, m_FireModeSingle, value)) m_FireModeSingle = value; } } // 0x38 (56)
		
		protected bool m_FireModeBurst = new bool();
		[ContainerField(Name: "FireModeBurst", Offset: 57, NameHash: 2764294140, Flags: 49325), LayoutImmutable, Blittable]
		public bool FireModeBurst { get { return m_FireModeBurst; } set { if (OnPropertyChanging("UIWeaponDescription." + nameof(FireModeBurst), this, m_FireModeBurst, value)) m_FireModeBurst = value; } } // 0x39 (57)
		
		protected bool m_FireModeAuto = new bool();
		[ContainerField(Name: "FireModeAuto", Offset: 58, NameHash: 2686956785, Flags: 49325), LayoutImmutable, Blittable]
		public bool FireModeAuto { get { return m_FireModeAuto; } set { if (OnPropertyChanging("UIWeaponDescription." + nameof(FireModeAuto), this, m_FireModeAuto, value)) m_FireModeAuto = value; } } // 0x3A (58)
		
		protected bool m_HiddenInProgression = new bool();
		[ContainerField(Name: "HiddenInProgression", Offset: 59, NameHash: 1800564573, Flags: 49325), LayoutImmutable, Blittable]
		public bool HiddenInProgression { get { return m_HiddenInProgression; } set { if (OnPropertyChanging("UIWeaponDescription." + nameof(HiddenInProgression), this, m_HiddenInProgression, value)) m_HiddenInProgression = value; } } // 0x3B (59)
		
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

				case 2088639403:
					Ammo = (string) p_Value;
					break;

				case 3866082710:
					RateOfFire = (string) p_Value;
					break;

				case 230112826:
					Range = (string) p_Value;
					break;

				case 380723556:
					FireModeSingle = (bool) p_Value;
					break;

				case 2764294140:
					FireModeBurst = (bool) p_Value;
					break;

				case 2686956785:
					FireModeAuto = (bool) p_Value;
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

				case 2088639403:
					return Ammo;

				case 3866082710:
					return RateOfFire;

				case 230112826:
					return Range;

				case 380723556:
					return FireModeSingle;

				case 2764294140:
					return FireModeBurst;

				case 2686956785:
					return FireModeAuto;

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
					return typeof(UIWeaponDescription).GetProperty(nameof(Name));

				case 1036710322:
					return typeof(UIWeaponDescription).GetProperty(nameof(UnlockName));

				case 1636673251:
					return typeof(UIWeaponDescription).GetProperty(nameof(Description));

				case 3455858997:
					return typeof(UIWeaponDescription).GetProperty(nameof(Category));

				case 3058477943:
					return typeof(UIWeaponDescription).GetProperty(nameof(TexturePath));

				case 377747068:
					return typeof(UIWeaponDescription).GetProperty(nameof(IconTexturePath));

				case 2699666183:
					return typeof(UIWeaponDescription).GetProperty(nameof(UnlockTexturePath));

				case 2088639403:
					return typeof(UIWeaponDescription).GetProperty(nameof(Ammo));

				case 3866082710:
					return typeof(UIWeaponDescription).GetProperty(nameof(RateOfFire));

				case 230112826:
					return typeof(UIWeaponDescription).GetProperty(nameof(Range));

				case 380723556:
					return typeof(UIWeaponDescription).GetProperty(nameof(FireModeSingle));

				case 2764294140:
					return typeof(UIWeaponDescription).GetProperty(nameof(FireModeBurst));

				case 2686956785:
					return typeof(UIWeaponDescription).GetProperty(nameof(FireModeAuto));

				case 1800564573:
					return typeof(UIWeaponDescription).GetProperty(nameof(HiddenInProgression));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
