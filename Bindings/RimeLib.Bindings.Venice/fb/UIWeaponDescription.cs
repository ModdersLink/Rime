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
	[ContainerType(4)]
	public class UIWeaponDescription : 
		UIItemDescription
	{
		protected string m_Name = string.Empty;
		[ContainerField(16), LayoutImmutable, ContainerFieldNameHash(2088949890)]
		public string Name { get { return m_Name; } set { if (OnPropertyChanging("UIWeaponDescription." + nameof(Name), this, m_Name, value)) m_Name = value; } } // 0x10 (16)
		
		protected string m_UnlockName = string.Empty;
		[ContainerField(20), LayoutImmutable, ContainerFieldNameHash(1036710322)]
		public string UnlockName { get { return m_UnlockName; } set { if (OnPropertyChanging("UIWeaponDescription." + nameof(UnlockName), this, m_UnlockName, value)) m_UnlockName = value; } } // 0x14 (20)
		
		protected string m_Description = string.Empty;
		[ContainerField(24), LayoutImmutable, ContainerFieldNameHash(1636673251)]
		public string Description { get { return m_Description; } set { if (OnPropertyChanging("UIWeaponDescription." + nameof(Description), this, m_Description, value)) m_Description = value; } } // 0x18 (24)
		
		protected string m_Category = string.Empty;
		[ContainerField(28), LayoutImmutable, ContainerFieldNameHash(3455858997)]
		public string Category { get { return m_Category; } set { if (OnPropertyChanging("UIWeaponDescription." + nameof(Category), this, m_Category, value)) m_Category = value; } } // 0x1C (28)
		
		protected string m_TexturePath = string.Empty;
		[ContainerField(32), LayoutImmutable, ContainerFieldNameHash(3058477943)]
		public string TexturePath { get { return m_TexturePath; } set { if (OnPropertyChanging("UIWeaponDescription." + nameof(TexturePath), this, m_TexturePath, value)) m_TexturePath = value; } } // 0x20 (32)
		
		protected string m_IconTexturePath = string.Empty;
		[ContainerField(36), LayoutImmutable, ContainerFieldNameHash(377747068)]
		public string IconTexturePath { get { return m_IconTexturePath; } set { if (OnPropertyChanging("UIWeaponDescription." + nameof(IconTexturePath), this, m_IconTexturePath, value)) m_IconTexturePath = value; } } // 0x24 (36)
		
		protected string m_UnlockTexturePath = string.Empty;
		[ContainerField(40), LayoutImmutable, ContainerFieldNameHash(2699666183)]
		public string UnlockTexturePath { get { return m_UnlockTexturePath; } set { if (OnPropertyChanging("UIWeaponDescription." + nameof(UnlockTexturePath), this, m_UnlockTexturePath, value)) m_UnlockTexturePath = value; } } // 0x28 (40)
		
		protected string m_Ammo = string.Empty;
		[ContainerField(44), LayoutImmutable, ContainerFieldNameHash(2088639403)]
		public string Ammo { get { return m_Ammo; } set { if (OnPropertyChanging("UIWeaponDescription." + nameof(Ammo), this, m_Ammo, value)) m_Ammo = value; } } // 0x2C (44)
		
		protected string m_RateOfFire = string.Empty;
		[ContainerField(48), LayoutImmutable, ContainerFieldNameHash(3866082710)]
		public string RateOfFire { get { return m_RateOfFire; } set { if (OnPropertyChanging("UIWeaponDescription." + nameof(RateOfFire), this, m_RateOfFire, value)) m_RateOfFire = value; } } // 0x30 (48)
		
		protected string m_Range = string.Empty;
		[ContainerField(52), LayoutImmutable, ContainerFieldNameHash(230112826)]
		public string Range { get { return m_Range; } set { if (OnPropertyChanging("UIWeaponDescription." + nameof(Range), this, m_Range, value)) m_Range = value; } } // 0x34 (52)
		
		protected bool m_FireModeSingle = new bool();
		[ContainerField(56), LayoutImmutable, Blittable, ContainerFieldNameHash(380723556)]
		public bool FireModeSingle { get { return m_FireModeSingle; } set { if (OnPropertyChanging("UIWeaponDescription." + nameof(FireModeSingle), this, m_FireModeSingle, value)) m_FireModeSingle = value; } } // 0x38 (56)
		
		protected bool m_FireModeBurst = new bool();
		[ContainerField(57), LayoutImmutable, Blittable, ContainerFieldNameHash(2764294140)]
		public bool FireModeBurst { get { return m_FireModeBurst; } set { if (OnPropertyChanging("UIWeaponDescription." + nameof(FireModeBurst), this, m_FireModeBurst, value)) m_FireModeBurst = value; } } // 0x39 (57)
		
		protected bool m_FireModeAuto = new bool();
		[ContainerField(58), LayoutImmutable, Blittable, ContainerFieldNameHash(2686956785)]
		public bool FireModeAuto { get { return m_FireModeAuto; } set { if (OnPropertyChanging("UIWeaponDescription." + nameof(FireModeAuto), this, m_FireModeAuto, value)) m_FireModeAuto = value; } } // 0x3A (58)
		
		protected bool m_HiddenInProgression = new bool();
		[ContainerField(59), LayoutImmutable, Blittable, ContainerFieldNameHash(1800564573)]
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
