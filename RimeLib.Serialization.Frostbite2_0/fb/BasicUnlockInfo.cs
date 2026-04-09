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
	[ContainerType(4, 36)]
	public partial class BasicUnlockInfo :
		EbxSerializable
	{
		[ObservableProperty]
		[property: ContainerField(0), LayoutImmutable, Blittable, JsonProperty(Order = 0)]
		private GUID _UnlockGuid = GUID.Empty;
		
		[ObservableProperty]
		[property: ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private uint _Identifier;
		
		[ObservableProperty]
		[property: ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		private uint _UnlockScore;
		
		[ObservableProperty]
		[property: ContainerField(24), JsonProperty(Order = 24)]
		private List<string> _Licenses = new();
		
		[ObservableProperty]
		[property: ContainerField(28), JsonProperty(Order = 28)]
		private List<string> _AdditionalLicenses = new();
		
		[ObservableProperty]
		[property: ContainerField(32), LayoutImmutable, JsonProperty(Order = 32)]
		private string _StringId = string.Empty;
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			UnlockGuid.Serialize(p_Writer);
			p_Writer.Write(Identifier);
			p_Writer.Write(UnlockScore);
			(RimeWriter Writer, uint ArrayIndex) s_Licenses = p_EbxWriter.GetArrayWriter(Licenses.GetType(), Licenses.Count);
			p_Writer.Write(s_Licenses.ArrayIndex);
			foreach (var s_Entry in Licenses)
			{
				s_Licenses.Writer.Write(p_EbxWriter.WriteString(s_Entry));
			}
			(RimeWriter Writer, uint ArrayIndex) s_AdditionalLicenses = p_EbxWriter.GetArrayWriter(AdditionalLicenses.GetType(), AdditionalLicenses.Count);
			p_Writer.Write(s_AdditionalLicenses.ArrayIndex);
			foreach (var s_Entry in AdditionalLicenses)
			{
				s_AdditionalLicenses.Writer.Write(p_EbxWriter.WriteString(s_Entry));
			}
			p_Writer.Write(p_EbxWriter.WriteString(StringId));
		}
	}
}
