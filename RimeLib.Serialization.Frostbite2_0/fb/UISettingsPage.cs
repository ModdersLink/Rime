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
using CommunityToolkit.Mvvm.ComponentModel;

namespace fb
{
	[ContainerType(4, 8)]
	public partial class UISettingsPage :
		EbxSerializable
	{
		[ObservableProperty]
		[property: ContainerField(0), LayoutImmutable, JsonProperty(Order = 0)]
		private string _NameSid = string.Empty;
		
		[ObservableProperty]
		[property: ContainerField(4), JsonProperty(Order = 4)]
		private List<UISettingsGroup> _SettingsGroups = new();
		
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
