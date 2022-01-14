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
	[ContainerType(4, 24)]
	public class InputRecorderData :
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, JsonProperty(Order = 8)]
		public string FileNamePrefix { get; set; } = string.Empty;

		[ContainerField(12), LayoutImmutable, JsonProperty(Order = 12)]
		public string FileName { get; set; } = string.Empty;

		[ContainerField(16), JsonProperty(Order = 16)]
		public EntryInputActionEnum ToggleRecordAction { get; set; } = new();

		[ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		public bool AutoIncrementFileName { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteString(FileNamePrefix));
			p_Writer.Write(p_EbxWriter.WriteString(FileName));
			p_Writer.Write((int) ToggleRecordAction);
			p_Writer.Write(AutoIncrementFileName);
			p_Writer.WriteNullBytes(3);
		}
	}
}
