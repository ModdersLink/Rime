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

[ContainerType(8, 48)]
public class PadInputActionData
	: fb.GameShared.AxesInputActionData
{
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public InputDevicePadButtons Button { get; set; } = InputDevicePadButtons.IDB_Undefined;
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public InputDevicePadButtons PS3AlternativeButton { get; set; } = InputDevicePadButtons.IDB_Undefined;
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public InputDevicePOVs Pov { get; set; } = InputDevicePOVs.IDP_POV_Undefined;
	
	[ContainerField(0x2c), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
	public bool UseSquareInput { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) Button);
		p_Writer.Write((int) PS3AlternativeButton);
		p_Writer.Write((int) Pov);
		p_Writer.Write(UseSquareInput);
		p_Writer.WriteNullBytes(3);
	}
}

