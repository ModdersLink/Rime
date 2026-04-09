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
	[ContainerType(4, 72)]
	public partial class UIListItem :
		EbxSerializable
	{
		[ObservableProperty]
		[property: ContainerField(0), LayoutImmutable, JsonProperty(Order = 0)]
		private string _Label = string.Empty;
		
		[ObservableProperty]
		[property: ContainerField(4), JsonProperty(Order = 4)]
		private UIDataSourceInfo _IsEnabled = new();
		
		[ObservableProperty]
		[property: ContainerField(20), JsonProperty(Order = 20)]
		private UIDataSourceInfo _IsVisible = new();
		
		[ObservableProperty]
		[property: ContainerField(36), JsonProperty(Order = 36)]
		private UIDataSourceInfo _ToggleItems = new();
		
		[ObservableProperty]
		[property: ContainerField(52), JsonProperty(Order = 52)]
		private UIDataSourceInfo _DataUpdate = new();
		
		[ObservableProperty]
		[property: ContainerField(68), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
		private bool _DefaultIsVisible;
		
		[ObservableProperty]
		[property: ContainerField(69), LayoutImmutable, Blittable, JsonProperty(Order = 69)]
		private bool _DefaultIsEnabled;
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteString(Label));
			IsEnabled.Serialize(p_Writer, p_EbxWriter);
			IsVisible.Serialize(p_Writer, p_EbxWriter);
			ToggleItems.Serialize(p_Writer, p_EbxWriter);
			DataUpdate.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(DefaultIsVisible);
			p_Writer.Write(DefaultIsEnabled);
			p_Writer.WriteNullBytes(2);
		}
	}
}
