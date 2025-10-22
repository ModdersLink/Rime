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
using fb.GameShared;
using fb.Entity;

namespace fb.VeniceShared;

[ContainerType(16, 144)]
public class UINotificationMessageWidgetData
	: fb.VeniceShared.BFUIWidgetEntityData
{
	[ContainerField(0x68), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
	public float MessageDuration { get; set; } = 3.000f;
	
	[ContainerField(0x6c), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
	public float FadeDuration { get; set; } = 0.500f;
	
	[ContainerField(0x70), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public Vec3 YellMessageColor { get; set; } = new()
	{
		z = 0.000f,
		y = 0.590f,
		x = 0.900f,
	};
	
	[ContainerField(0x80), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public float MessageMinDuration { get; set; } = 0.100f;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(MessageDuration);
		p_Writer.Write(FadeDuration);
		YellMessageColor.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(MessageMinDuration);
		p_Writer.WriteNullBytes(12);
	}
}

