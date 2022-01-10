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
	[ContainerType(4, 48)]
	public class UIWeaponAccessoryDescription : 
		UIItemDescription
	{
		[ContainerField(16), LayoutImmutable]
		public string Name { get; set; } = string.Empty;

		[ContainerField(20), LayoutImmutable]
		public string Description { get; set; } = string.Empty;

		[ContainerField(24), LayoutImmutable]
		public string Category { get; set; } = string.Empty;

		[ContainerField(28), LayoutImmutable]
		public string TexturePath { get; set; } = string.Empty;

		[ContainerField(32), LayoutImmutable]
		public string IconTexturePath { get; set; } = string.Empty;

		[ContainerField(36), LayoutImmutable]
		public string UnlockTexturePath { get; set; } = string.Empty;

		[ContainerField(40), LayoutImmutable]
		public string MiscTexturePath { get; set; } = string.Empty;

		[ContainerField(44), LayoutImmutable, Blittable]
		public bool CoreAccessory { get; set; }

		[ContainerField(45), LayoutImmutable, Blittable]
		public bool HiddenInProgression { get; set; }

		public static void Deserialize(UIWeaponAccessoryDescription p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Name = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.Description = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.Category = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.TexturePath = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.IconTexturePath = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.UnlockTexturePath = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.MiscTexturePath = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.CoreAccessory = p_Reader.ReadBool();
			p_Instance.HiddenInProgression = p_Reader.ReadBool();
			p_Reader.Seek(2, SeekOrigin.Current);
		}

	}
}
