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
	[ContainerType(4, 52)]
	public partial class GunnerSpottingTrackerData :
		HudTrackerData
	{
		[ObservableProperty]
		[property: ContainerField(44), JsonProperty(Order = 44)]
		private UIHudIcon _SpottedInfantryIcon = new();

		[ObservableProperty]
		[property: ContainerField(48), JsonProperty(Order = 48)]
		private UIHudIcon _SpottedVehicleIcon = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write((int) SpottedInfantryIcon);
			p_Writer.Write((int) SpottedVehicleIcon);
		}
	}
}
