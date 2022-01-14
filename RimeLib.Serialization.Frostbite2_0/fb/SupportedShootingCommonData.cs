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

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			AimingConstraints.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write((int) EnterSupportedShootingAction);
			Binding.Serialize(p_Writer, p_EbxWriter);
			Stand.Serialize(p_Writer, p_EbxWriter);
			Crouch.Serialize(p_Writer, p_EbxWriter);
		}
	}
}
