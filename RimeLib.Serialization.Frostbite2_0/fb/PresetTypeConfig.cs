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
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(4, 24)]
	public class PresetTypeConfig :
		EbxSerializable
	{
		[ContainerField(0), LayoutImmutable, Blittable, JsonProperty(Order = 0)]
		public int PresetId { get; set; }
		
		[ContainerField(4), LayoutImmutable, JsonProperty(Order = 4)]
		public string Key { get; set; } = string.Empty;
		
		[ContainerField(8), LayoutImmutable, JsonProperty(Order = 8)]
		public string NameSid { get; set; } = string.Empty;
		
		[ContainerField(12), LayoutImmutable, JsonProperty(Order = 12)]
		public string DescSid { get; set; } = string.Empty;
		
		[ContainerField(16), JsonProperty(Order = 16)]
		public List<LockedSettingConfig> LockedSettings { get; set; } = new();
		
		[ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		public bool Predefined { get; set; }
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(PresetId);
			p_Writer.Write(p_EbxWriter.WriteString(Key));
			p_Writer.Write(p_EbxWriter.WriteString(NameSid));
			p_Writer.Write(p_EbxWriter.WriteString(DescSid));
			(RimeWriter Writer, uint ArrayIndex) s_LockedSettings = p_EbxWriter.GetArrayWriter(LockedSettings.GetType(), LockedSettings.Count);
			p_Writer.Write(s_LockedSettings.ArrayIndex);
			foreach (var s_Entry in LockedSettings)
			{
				s_Entry.Serialize(s_LockedSettings.Writer, p_EbxWriter);
			}
			p_Writer.Write(Predefined);
			p_Writer.WriteNullBytes(3);
		}
	}
}
