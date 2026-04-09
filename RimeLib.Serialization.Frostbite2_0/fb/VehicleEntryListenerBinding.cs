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
	public partial class VehicleEntryListenerBinding :
		EbxSerializable
	{
		[ObservableProperty]
		[property: ContainerField(0), JsonProperty(Order = 0)]
		private AntRef _InVehicle = new();
		
		[ObservableProperty]
		[property: ContainerField(4), JsonProperty(Order = 4)]
		private AntRef _InOpenEntry = new();
		
		[ObservableProperty]
		[property: ContainerField(8), JsonProperty(Order = 8)]
		private AntRef _VehicleEntryFire = new();
		
		[ObservableProperty]
		[property: ContainerField(12), JsonProperty(Order = 12)]
		private AntRef _VehicleEntryYaw = new();
		
		[ObservableProperty]
		[property: ContainerField(16), JsonProperty(Order = 16)]
		private AntRef _VehicleEntryPitch = new();
		
		[ObservableProperty]
		[property: ContainerField(20), JsonProperty(Order = 20)]
		private AntRef _VehicleEntryRoll = new();
		
		[ObservableProperty]
		[property: ContainerField(24), JsonProperty(Order = 24)]
		private AntRef _VehicleEntryRotation = new();
		
		[ObservableProperty]
		[property: ContainerField(28), JsonProperty(Order = 28)]
		private AntRef _VehicleEntryForceX = new();
		
		[ObservableProperty]
		[property: ContainerField(32), JsonProperty(Order = 32)]
		private AntRef _VehicleEntryForceY = new();
		
		[ObservableProperty]
		[property: ContainerField(36), JsonProperty(Order = 36)]
		private AntRef _VehicleEntryForceZ = new();
		
		[ObservableProperty]
		[property: ContainerField(40), JsonProperty(Order = 40)]
		private AntRef _VehicleEntryIndex = new();
		
		[ObservableProperty]
		[property: ContainerField(44), JsonProperty(Order = 44)]
		private AntRef _VehicleEntryIndexUpdated = new();
		
		[ObservableProperty]
		[property: ContainerField(48), JsonProperty(Order = 48)]
		private AntRef _VehicleOpenEntryIndex = new();
		
		[ObservableProperty]
		[property: ContainerField(52), JsonProperty(Order = 52)]
		private AntRef _InVehicleRetrigger = new();
		
		[ObservableProperty]
		[property: ContainerField(56), JsonProperty(Order = 56)]
		private AntRef _VehicleEntryChooserIndex = new();
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			InVehicle.Serialize(p_Writer, p_EbxWriter);
			InOpenEntry.Serialize(p_Writer, p_EbxWriter);
			VehicleEntryFire.Serialize(p_Writer, p_EbxWriter);
			VehicleEntryYaw.Serialize(p_Writer, p_EbxWriter);
			VehicleEntryPitch.Serialize(p_Writer, p_EbxWriter);
			VehicleEntryRoll.Serialize(p_Writer, p_EbxWriter);
			VehicleEntryRotation.Serialize(p_Writer, p_EbxWriter);
			VehicleEntryForceX.Serialize(p_Writer, p_EbxWriter);
			VehicleEntryForceY.Serialize(p_Writer, p_EbxWriter);
			VehicleEntryForceZ.Serialize(p_Writer, p_EbxWriter);
			VehicleEntryIndex.Serialize(p_Writer, p_EbxWriter);
			VehicleEntryIndexUpdated.Serialize(p_Writer, p_EbxWriter);
			VehicleOpenEntryIndex.Serialize(p_Writer, p_EbxWriter);
			InVehicleRetrigger.Serialize(p_Writer, p_EbxWriter);
			VehicleEntryChooserIndex.Serialize(p_Writer, p_EbxWriter);
		}
	}
}
