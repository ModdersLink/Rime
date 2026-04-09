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
	[ContainerType(4, 48)]
	public partial class UITextDataBinding :
		UIDataBinding
	{
		[ObservableProperty]
		[property: ContainerField(8), LayoutImmutable, JsonProperty(Order = 8)]
		private string _StaticText = string.Empty;

		[ObservableProperty]
		[property: ContainerField(12), JsonProperty(Order = 12)]
		private UIDataSourceInfo _TextData = new();

		[ObservableProperty]
		[property: ContainerField(28), JsonProperty(Order = 28)]
		private UIDataSourceInfo _Visibility = new();

		[ObservableProperty]
		[property: ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		private bool _Refresh;

		[ObservableProperty]
		[property: ContainerField(45), LayoutImmutable, Blittable, JsonProperty(Order = 45)]
		private bool _OverrideDirectAccess;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteString(StaticText));
			TextData.Serialize(p_Writer, p_EbxWriter);
			Visibility.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(Refresh);
			p_Writer.Write(OverrideDirectAccess);
			p_Writer.WriteNullBytes(2);
		}
	}
}
