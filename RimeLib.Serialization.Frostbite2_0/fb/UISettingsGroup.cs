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
	[ContainerType(4, 12)]
	public class UISettingsGroup :
		EbxSerializable
	{
		[ContainerField(0), LayoutImmutable, JsonProperty(Order = 0)]
		public string NameSid { get; set; } = string.Empty;
		
		[ContainerField(4), LayoutImmutable, Blittable, JsonProperty(Order = 4)]
		public int ScreenColumn { get; set; }
		
		[ContainerField(8), JsonProperty(Order = 8)]
		public List<UISettingsItem> SettingsItems { get; set; } = new();
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteString(NameSid));
			p_Writer.Write(ScreenColumn);
			(RimeWriter Writer, uint ArrayIndex) s_SettingsItems = p_EbxWriter.GetArrayWriter(SettingsItems.GetType(), SettingsItems.Count);
			p_Writer.Write(s_SettingsItems.ArrayIndex);
			foreach (var s_Entry in SettingsItems)
			{
				s_Entry.Serialize(s_SettingsItems.Writer, p_EbxWriter);
			}
		}
	}
}
