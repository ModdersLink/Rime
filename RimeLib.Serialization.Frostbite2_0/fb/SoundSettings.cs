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
	[ContainerType(4, 44)]
	public partial class SoundSettings :
		SystemSettings
	{
		[ObservableProperty]
		[property: ContainerField(12), LayoutImmutable, JsonProperty(Order = 12)]
		private string _VOEnglish = string.Empty;

		[ObservableProperty]
		[property: ContainerField(16), LayoutImmutable, JsonProperty(Order = 16)]
		private string _AudioSystemUri = string.Empty;

		[ObservableProperty]
		[property: ContainerField(20), LayoutImmutable, JsonProperty(Order = 20)]
		private string _VOCommon = string.Empty;

		[ObservableProperty]
		[property: ContainerField(24), LayoutImmutable, JsonProperty(Order = 24)]
		private string _VOItalian = string.Empty;

		[ObservableProperty]
		[property: ContainerField(28), LayoutImmutable, JsonProperty(Order = 28)]
		private string _VOSpanish = string.Empty;

		[ObservableProperty]
		[property: ContainerField(32), LayoutImmutable, JsonProperty(Order = 32)]
		private string _VOFrench = string.Empty;

		[ObservableProperty]
		[property: ContainerField(36), LayoutImmutable, JsonProperty(Order = 36)]
		private string _VOGerman = string.Empty;

		[ObservableProperty]
		[property: ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		private bool _Enable;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteString(VOEnglish));
			p_Writer.Write(p_EbxWriter.WriteString(AudioSystemUri));
			p_Writer.Write(p_EbxWriter.WriteString(VOCommon));
			p_Writer.Write(p_EbxWriter.WriteString(VOItalian));
			p_Writer.Write(p_EbxWriter.WriteString(VOSpanish));
			p_Writer.Write(p_EbxWriter.WriteString(VOFrench));
			p_Writer.Write(p_EbxWriter.WriteString(VOGerman));
			p_Writer.Write(Enable);
			p_Writer.WriteNullBytes(3);
		}
	}
}
