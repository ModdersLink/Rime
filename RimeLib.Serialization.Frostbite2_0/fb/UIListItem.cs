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

namespace fb
{
	[ContainerType(4, 72)]
	public class UIListItem :
		EbxSerializable
	{
		[ContainerField(0), LayoutImmutable, JsonProperty(Order = 0)]
		public string Label { get; set; } = string.Empty;
		
		[ContainerField(4), JsonProperty(Order = 4)]
		public UIDataSourceInfo IsEnabled { get; set; } = new();
		
		[ContainerField(20), JsonProperty(Order = 20)]
		public UIDataSourceInfo IsVisible { get; set; } = new();
		
		[ContainerField(36), JsonProperty(Order = 36)]
		public UIDataSourceInfo ToggleItems { get; set; } = new();
		
		[ContainerField(52), JsonProperty(Order = 52)]
		public UIDataSourceInfo DataUpdate { get; set; } = new();
		
		[ContainerField(68), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
		public bool DefaultIsVisible { get; set; }
		
		[ContainerField(69), LayoutImmutable, Blittable, JsonProperty(Order = 69)]
		public bool DefaultIsEnabled { get; set; }
		
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
