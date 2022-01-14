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
	public class ProfileOptionsAsset :
		Asset
	{
		[ContainerField(12), LayoutImmutable, JsonProperty(Order = 12)]
		public string FileName { get; set; } = string.Empty;

		[ContainerField(16), LayoutImmutable, JsonProperty(Order = 16)]
		public string ContentName { get; set; } = string.Empty;

		[ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		public uint FileSize { get; set; }

		[ContainerField(24), JsonProperty(Order = 24)]
		public RefArray<ProfileOptionData> Options { get; set; } = new();

		[ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		public bool AutoSaveOnQuit { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteString(FileName));
			p_Writer.Write(p_EbxWriter.WriteString(ContentName));
			p_Writer.Write(FileSize);
			(RimeWriter Writer, uint ArrayIndex) s_Options = p_EbxWriter.GetArrayWriter(Options.GetType(), Options.Count);
			p_Writer.Write(s_Options.ArrayIndex);
			foreach (var s_Entry in Options)
			{
				s_Options.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			p_Writer.Write(AutoSaveOnQuit);
			p_Writer.WriteNullBytes(3);
		}
	}
}
