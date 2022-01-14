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
	[ContainerType(4, 8)]
	public class UISettingsPage :
		EbxSerializable
	{
		[ContainerField(0), LayoutImmutable, JsonProperty(Order = 0)]
		public string NameSid { get; set; } = string.Empty;
		
		[ContainerField(4), JsonProperty(Order = 4)]
		public List<UISettingsGroup> SettingsGroups { get; set; } = new();
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteString(NameSid));
			(RimeWriter Writer, uint ArrayIndex) s_SettingsGroups = p_EbxWriter.GetArrayWriter(SettingsGroups.GetType(), SettingsGroups.Count);
			p_Writer.Write(s_SettingsGroups.ArrayIndex);
			foreach (var s_Entry in SettingsGroups)
			{
				s_Entry.Serialize(s_SettingsGroups.Writer, p_EbxWriter);
			}
		}
	}
}
