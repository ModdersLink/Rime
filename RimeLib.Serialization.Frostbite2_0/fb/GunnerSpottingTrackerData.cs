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
using RimeLib.Serialization.Ebx;
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(4, 52)]
	public class GunnerSpottingTrackerData :
		HudTrackerData
	{
		[ContainerField(44), JsonProperty(Order = 44)]
		public UIHudIcon SpottedInfantryIcon { get; set; } = new();

		[ContainerField(48), JsonProperty(Order = 48)]
		public UIHudIcon SpottedVehicleIcon { get; set; } = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write((int) SpottedInfantryIcon);
			p_Writer.Write((int) SpottedVehicleIcon);
		}
	}
}
