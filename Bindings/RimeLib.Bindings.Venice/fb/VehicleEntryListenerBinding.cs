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
	[ContainerType(4, 60)]
	public class VehicleEntryListenerBinding
	{
		[ContainerField(0)]
		public AntRef InVehicle { get; set; } = new();
		
		[ContainerField(4)]
		public AntRef InOpenEntry { get; set; } = new();
		
		[ContainerField(8)]
		public AntRef VehicleEntryFire { get; set; } = new();
		
		[ContainerField(12)]
		public AntRef VehicleEntryYaw { get; set; } = new();
		
		[ContainerField(16)]
		public AntRef VehicleEntryPitch { get; set; } = new();
		
		[ContainerField(20)]
		public AntRef VehicleEntryRoll { get; set; } = new();
		
		[ContainerField(24)]
		public AntRef VehicleEntryRotation { get; set; } = new();
		
		[ContainerField(28)]
		public AntRef VehicleEntryForceX { get; set; } = new();
		
		[ContainerField(32)]
		public AntRef VehicleEntryForceY { get; set; } = new();
		
		[ContainerField(36)]
		public AntRef VehicleEntryForceZ { get; set; } = new();
		
		[ContainerField(40)]
		public AntRef VehicleEntryIndex { get; set; } = new();
		
		[ContainerField(44)]
		public AntRef VehicleEntryIndexUpdated { get; set; } = new();
		
		[ContainerField(48)]
		public AntRef VehicleOpenEntryIndex { get; set; } = new();
		
		[ContainerField(52)]
		public AntRef InVehicleRetrigger { get; set; } = new();
		
		[ContainerField(56)]
		public AntRef VehicleEntryChooserIndex { get; set; } = new();
		
	}
}
