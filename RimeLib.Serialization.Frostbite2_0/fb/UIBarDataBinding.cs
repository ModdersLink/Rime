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
	[ContainerType(4, 60)]
	public partial class UIBarDataBinding :
		UIDataBinding
	{
		[ObservableProperty]
		[property: ContainerField(8), JsonProperty(Order = 8)]
		private UIDataSourceInfo _Visibility = new();

		[ObservableProperty]
		[property: ContainerField(24), JsonProperty(Order = 24)]
		private UIDataSourceInfo _Value = new();

		[ObservableProperty]
		[property: ContainerField(40), JsonProperty(Order = 40)]
		private UIDataSourceInfo _Color = new();

		[ObservableProperty]
		[property: ContainerField(56), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
		private bool _Refresh;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			Visibility.Serialize(p_Writer, p_EbxWriter);
			Value.Serialize(p_Writer, p_EbxWriter);
			Color.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(Refresh);
			p_Writer.WriteNullBytes(3);
		}
	}
}
