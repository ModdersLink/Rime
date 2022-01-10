///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4, 52)]
	public class GunnerSpottingTrackerData : 
		HudTrackerData
	{
		[ContainerField(44)]
		public UIHudIcon SpottedInfantryIcon { get; set; } = new();

		[ContainerField(48)]
		public UIHudIcon SpottedVehicleIcon { get; set; } = new();

		public static void Deserialize(GunnerSpottingTrackerData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.SpottedInfantryIcon = (UIHudIcon) p_Reader.ReadInt32();
			p_Instance.SpottedVehicleIcon = (UIHudIcon) p_Reader.ReadInt32();
		}

	}
}
