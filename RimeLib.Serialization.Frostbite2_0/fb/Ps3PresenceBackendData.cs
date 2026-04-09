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
	[ContainerType(4, 32)]
	public partial class Ps3PresenceBackendData :
		PresenceBackendData
	{
		[ObservableProperty]
		[property: ContainerField(16), LayoutImmutable, JsonProperty(Order = 16)]
		private string _CommunicationId = string.Empty;

		[ObservableProperty]
		[property: ContainerField(20), LayoutImmutable, JsonProperty(Order = 20)]
		private string _CommunicationSignature = string.Empty;

		[ObservableProperty]
		[property: ContainerField(24), JsonProperty(Order = 24)]
		private List<Ps3SkuSettings> _SkuSettings = new();

		[ObservableProperty]
		[property: ContainerField(28), JsonProperty(Order = 28)]
		private List<Ps3ParentalLockAgeSettings> _ParentalLockAgeSettings = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteString(CommunicationId));
			p_Writer.Write(p_EbxWriter.WriteString(CommunicationSignature));
			(RimeWriter Writer, uint ArrayIndex) s_SkuSettings = p_EbxWriter.GetArrayWriter(SkuSettings.GetType(), SkuSettings.Count);
			p_Writer.Write(s_SkuSettings.ArrayIndex);
			foreach (var s_Entry in SkuSettings)
			{
				s_Entry.Serialize(s_SkuSettings.Writer, p_EbxWriter);
			}
			(RimeWriter Writer, uint ArrayIndex) s_ParentalLockAgeSettings = p_EbxWriter.GetArrayWriter(ParentalLockAgeSettings.GetType(), ParentalLockAgeSettings.Count);
			p_Writer.Write(s_ParentalLockAgeSettings.ArrayIndex);
			foreach (var s_Entry in ParentalLockAgeSettings)
			{
				s_Entry.Serialize(s_ParentalLockAgeSettings.Writer, p_EbxWriter);
			}
		}
	}
}
