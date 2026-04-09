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
	[ContainerType(16, 128)]
	public partial class AdvertisementComponentData :
		PartComponentData
	{
		[ObservableProperty]
		[property: ContainerField(112), LayoutImmutable, JsonProperty(Order = 112)]
		private string _Identifier = string.Empty;

		[ObservableProperty]
		[property: ContainerField(116), LayoutImmutable, JsonProperty(Order = 116)]
		private string _AdTexture = string.Empty;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteString(Identifier));
			p_Writer.Write(p_EbxWriter.WriteString(AdTexture));
			p_Writer.WriteNullBytes(8);
		}
	}
}
