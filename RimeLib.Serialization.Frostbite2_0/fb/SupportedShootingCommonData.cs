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

namespace fb
{
	[ContainerType(4, 100)]
	public class SupportedShootingCommonData : 
		Asset
	{
		[ContainerField(12), JsonProperty(Order = 12)]
		public AimingConstraintsData AimingConstraints { get; set; } = new();

		[ContainerField(28), JsonProperty(Order = 28)]
		public EntryInputActionEnum EnterSupportedShootingAction { get; set; } = new();

		[ContainerField(32), JsonProperty(Order = 32)]
		public SupportedShootingBinding Binding { get; set; } = new();

		[ContainerField(68), JsonProperty(Order = 68)]
		public SupportedShootingProximityChecking Stand { get; set; } = new();

		[ContainerField(84), JsonProperty(Order = 84)]
		public SupportedShootingProximityChecking Crouch { get; set; } = new();

	}
}
