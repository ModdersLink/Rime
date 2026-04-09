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
	[ContainerType(4, 40)]
	public partial class StaticListItem :
		EbxSerializable
	{
		[ObservableProperty]
		[property: ContainerField(0), LayoutImmutable, JsonProperty(Order = 0)]
		private string _ItemName = string.Empty;
		
		[ObservableProperty]
		[property: ContainerField(4), JsonProperty(Order = 4)]
		private UIDataSourceInfo _DynamicDisable = new();
		
		[ObservableProperty]
		[property: ContainerField(20), JsonProperty(Order = 20)]
		private UIDataSourceInfo _DynamicNewContent = new();
		
		[ObservableProperty]
		[property: ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		private bool _AppendPlatformToSID;
		
		[ObservableProperty]
		[property: ContainerField(37), LayoutImmutable, Blittable, JsonProperty(Order = 37)]
		private bool _ExcludeInRetail;
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteString(ItemName));
			DynamicDisable.Serialize(p_Writer, p_EbxWriter);
			DynamicNewContent.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(AppendPlatformToSID);
			p_Writer.Write(ExcludeInRetail);
			p_Writer.WriteNullBytes(2);
		}
	}
}
