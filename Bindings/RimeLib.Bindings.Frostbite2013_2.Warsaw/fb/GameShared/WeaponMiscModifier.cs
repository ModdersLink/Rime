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

using fb.Core;

namespace fb.GameShared;

[ContainerType(8, 32)]
public class WeaponMiscModifier
	: fb.GameShared.WeaponModifierBase
{
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public bool EnableBreathControl { get; set; } = false;
	
	[ContainerField(0x19), LayoutImmutable, Blittable, JsonProperty(Order = 25)]
	public bool CanBeInSupportedShooting { get; set; } = false;
	
	[ContainerField(0x1a), LayoutImmutable, Blittable, JsonProperty(Order = 26)]
	public bool UnZoomOnBoltAction { get; set; } = true;
	
	[ContainerField(0x1b), LayoutImmutable, Blittable, JsonProperty(Order = 27)]
	public bool HoldBoltActionUntilZoomRelease { get; set; } = true;
	
	[ContainerField(0x1c), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
	public bool IsSilenced { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(EnableBreathControl);
		p_Writer.Write(CanBeInSupportedShooting);
		p_Writer.Write(UnZoomOnBoltAction);
		p_Writer.Write(HoldBoltActionUntilZoomRelease);
		p_Writer.Write(IsSilenced);
		p_Writer.WriteNullBytes(3);
	}
}

