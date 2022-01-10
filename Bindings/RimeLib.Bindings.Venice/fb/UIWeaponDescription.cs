///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4, 60)]
	public class UIWeaponDescription : 
		UIItemDescription
	{
		[ContainerField(16), LayoutImmutable]
		public string Name { get; set; } = string.Empty;

		[ContainerField(20), LayoutImmutable]
		public string UnlockName { get; set; } = string.Empty;

		[ContainerField(24), LayoutImmutable]
		public string Description { get; set; } = string.Empty;

		[ContainerField(28), LayoutImmutable]
		public string Category { get; set; } = string.Empty;

		[ContainerField(32), LayoutImmutable]
		public string TexturePath { get; set; } = string.Empty;

		[ContainerField(36), LayoutImmutable]
		public string IconTexturePath { get; set; } = string.Empty;

		[ContainerField(40), LayoutImmutable]
		public string UnlockTexturePath { get; set; } = string.Empty;

		[ContainerField(44), LayoutImmutable]
		public string Ammo { get; set; } = string.Empty;

		[ContainerField(48), LayoutImmutable]
		public string RateOfFire { get; set; } = string.Empty;

		[ContainerField(52), LayoutImmutable]
		public string Range { get; set; } = string.Empty;

		[ContainerField(56), LayoutImmutable, Blittable]
		public bool FireModeSingle { get; set; }

		[ContainerField(57), LayoutImmutable, Blittable]
		public bool FireModeBurst { get; set; }

		[ContainerField(58), LayoutImmutable, Blittable]
		public bool FireModeAuto { get; set; }

		[ContainerField(59), LayoutImmutable, Blittable]
		public bool HiddenInProgression { get; set; }

		public static void Deserialize(UIWeaponDescription p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Name = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.UnlockName = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.Description = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.Category = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.TexturePath = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.IconTexturePath = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.UnlockTexturePath = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.Ammo = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.RateOfFire = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.Range = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.FireModeSingle = p_Reader.ReadBool();
			p_Instance.FireModeBurst = p_Reader.ReadBool();
			p_Instance.FireModeAuto = p_Reader.ReadBool();
			p_Instance.HiddenInProgression = p_Reader.ReadBool();
		}

	}
}
