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
	[ContainerType(4, 88)]
	public partial class UICompassDataBinding :
		UIDataBinding
	{
		[ObservableProperty]
		[property: ContainerField(8), JsonProperty(Order = 8)]
		private UIDataSourceInfo _Heading = new();

		[ObservableProperty]
		[property: ContainerField(24), JsonProperty(Order = 24)]
		private UIDataSourceInfo _Objectives = new();

		[ObservableProperty]
		[property: ContainerField(40), JsonProperty(Order = 40)]
		private UIDataSourceInfo _Visibility = new();

		[ObservableProperty]
		[property: ContainerField(56), JsonProperty(Order = 56)]
		private UIDataSourceInfo _ShowAirRadar = new();

		[ObservableProperty]
		[property: ContainerField(72), JsonProperty(Order = 72)]
		private UIDataSourceInfo _RadarSweepDegree = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			Heading.Serialize(p_Writer, p_EbxWriter);
			Objectives.Serialize(p_Writer, p_EbxWriter);
			Visibility.Serialize(p_Writer, p_EbxWriter);
			ShowAirRadar.Serialize(p_Writer, p_EbxWriter);
			RadarSweepDegree.Serialize(p_Writer, p_EbxWriter);
		}
	}
}
