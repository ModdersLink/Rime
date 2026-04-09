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
	public partial class UIHUDMessageBinding :
		UIDataBinding
	{
		[ObservableProperty]
		[property: ContainerField(8), JsonProperty(Order = 8)]
		private UIDataSourceInfo _MessageQuery = new();

		[ObservableProperty]
		[property: ContainerField(24), JsonProperty(Order = 24)]
		private UIDataSourceInfo _VisibilityQuery = new();

		[ObservableProperty]
		[property: ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		private int _NumberOfRows;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			MessageQuery.Serialize(p_Writer, p_EbxWriter);
			VisibilityQuery.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(NumberOfRows);
		}
	}
}
