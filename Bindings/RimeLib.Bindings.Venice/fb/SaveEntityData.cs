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
	[ContainerType(4, 32)]
	public class SaveEntityData : 
		EntityData
	{
		[ContainerField(12)]
		public CtrRef<TextureAsset> SaveScreenTexture { get; set; } = new();

		[ContainerField(16), LayoutImmutable]
		public string LevelName { get; set; } = string.Empty;

		[ContainerField(20), LayoutImmutable]
		public string SaveFileName { get; set; } = string.Empty;

		[ContainerField(24), LayoutImmutable]
		public string SaveNameSID { get; set; } = string.Empty;

		[ContainerField(28), LayoutImmutable, Blittable]
		public bool CheckForHumanPlayer { get; set; }

		public static void Deserialize(SaveEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.SaveScreenTexture.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.LevelName = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.SaveFileName = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.SaveNameSID = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.CheckForHumanPlayer = p_Reader.ReadBool();
			p_Reader.Seek(3, SeekOrigin.Current);
		}

	}
}
