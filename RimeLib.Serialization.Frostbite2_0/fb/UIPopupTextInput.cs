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
	[ContainerType(4, 16)]
	public partial class UIPopupTextInput :
		EbxSerializable
	{
		[ObservableProperty]
		[property: ContainerField(0), LayoutImmutable, JsonProperty(Order = 0)]
		private string _Id = string.Empty;
		
		[ObservableProperty]
		[property: ContainerField(4), LayoutImmutable, JsonProperty(Order = 4)]
		private string _Label = string.Empty;
		
		[ObservableProperty]
		[property: ContainerField(8), LayoutImmutable, JsonProperty(Order = 8)]
		private string _DefaultValue = string.Empty;
		
		[ObservableProperty]
		[property: ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		private bool _IsPassword;
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteString(Id));
			p_Writer.Write(p_EbxWriter.WriteString(Label));
			p_Writer.Write(p_EbxWriter.WriteString(DefaultValue));
			p_Writer.Write(IsPassword);
			p_Writer.WriteNullBytes(3);
		}
	}
}
