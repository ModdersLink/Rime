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
	public partial class UIButtonDataBinding :
		UIDataBinding
	{
		[ObservableProperty]
		[property: ContainerField(8), JsonProperty(Order = 8)]
		private UIDataSourceInfo _ButtonsDatasource = new();

		[ObservableProperty]
		[property: ContainerField(24), JsonProperty(Order = 24)]
		private UIButtonSet _DefaultButtonSet = new();

		[ObservableProperty]
		[property: ContainerField(28), JsonProperty(Order = 28)]
		private UIDataSourceInfo _Visibility = new();

		[ObservableProperty]
		[property: ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		private bool _InvertVisible;

		[ObservableProperty]
		[property: ContainerField(45), LayoutImmutable, Blittable, JsonProperty(Order = 45)]
		private bool _Visible;

		[ObservableProperty]
		[property: ContainerField(46), LayoutImmutable, Blittable, JsonProperty(Order = 46)]
		private bool _InputOnRelease;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			ButtonsDatasource.Serialize(p_Writer, p_EbxWriter);
			DefaultButtonSet.Serialize(p_Writer, p_EbxWriter);
			Visibility.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(InvertVisible);
			p_Writer.Write(Visible);
			p_Writer.Write(InputOnRelease);
			p_Writer.WriteNullBytes(1);
		}
	}
}
