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

using fb.VeniceShared;
using fb.Core;
using fb.GameShared;
using fb.Entity;

namespace fb.Venice;

[ContainerType(8, 256)]
public class SupportedShootingCommonData
	: fb.Entity.DataContainerPolicyAsset
{
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public AimingConstraintsData AimingConstraints { get; set; } = new();
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public int EnterSupportedShootingAction { get; set; } = 1018302687;
	
	[ContainerField(0x2c), JsonProperty(Order = 44)]
	public SupportedShootingBinding Binding { get; set; } = new();
	
	[ContainerField(0xe0), JsonProperty(Order = 224)]
	public SupportedShootingProximityChecking Stand { get; set; } = new();
	
	[ContainerField(0xf0), JsonProperty(Order = 240)]
	public SupportedShootingProximityChecking Crouch { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		AimingConstraints.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(EnterSupportedShootingAction);
		Binding.Serialize(p_Writer, p_EbxWriter);
		Stand.Serialize(p_Writer, p_EbxWriter);
		Crouch.Serialize(p_Writer, p_EbxWriter);
	}
}

