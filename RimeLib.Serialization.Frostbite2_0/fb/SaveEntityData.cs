///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(4, 32)]
	public class SaveEntityData :
		EntityData
	{
		[ContainerField(12), JsonProperty(Order = 12)]
		public CtrRef<TextureAsset> SaveScreenTexture { get; set; } = new();

		[ContainerField(16), LayoutImmutable, JsonProperty(Order = 16)]
		public string LevelName { get; set; } = string.Empty;

		[ContainerField(20), LayoutImmutable, JsonProperty(Order = 20)]
		public string SaveFileName { get; set; } = string.Empty;

		[ContainerField(24), LayoutImmutable, JsonProperty(Order = 24)]
		public string SaveNameSID { get; set; } = string.Empty;

		[ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		public bool CheckForHumanPlayer { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(SaveScreenTexture));
			p_Writer.Write(p_EbxWriter.WriteString(LevelName));
			p_Writer.Write(p_EbxWriter.WriteString(SaveFileName));
			p_Writer.Write(p_EbxWriter.WriteString(SaveNameSID));
			p_Writer.Write(CheckForHumanPlayer);
			p_Writer.WriteNullBytes(3);
		}
	}
}
