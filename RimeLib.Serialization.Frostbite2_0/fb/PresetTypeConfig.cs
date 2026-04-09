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
	[ContainerType(4, 24)]
	public partial class PresetTypeConfig :
		EbxSerializable
	{
		[ObservableProperty]
		[property: ContainerField(0), LayoutImmutable, Blittable, JsonProperty(Order = 0)]
		private int _PresetId;
		
		[ObservableProperty]
		[property: ContainerField(4), LayoutImmutable, JsonProperty(Order = 4)]
		private string _Key = string.Empty;
		
		[ObservableProperty]
		[property: ContainerField(8), LayoutImmutable, JsonProperty(Order = 8)]
		private string _NameSid = string.Empty;
		
		[ObservableProperty]
		[property: ContainerField(12), LayoutImmutable, JsonProperty(Order = 12)]
		private string _DescSid = string.Empty;
		
		[ObservableProperty]
		[property: ContainerField(16), JsonProperty(Order = 16)]
		private List<LockedSettingConfig> _LockedSettings = new();
		
		[ObservableProperty]
		[property: ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		private bool _Predefined;
		
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
