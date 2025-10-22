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
using fb.Entity;

namespace fb.GameShared;

[ContainerType(8, 72)]
public class GroundAttachTransformLayerData
	: fb.Entity.TransformLayerData
{
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public GroundAttachMethod AttachMethod { get; set; } = GroundAttachMethod.GroundAttachMethod_AsyncRaycast;
	
	[ContainerField(0x3c), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
	public float RaycastStartHeight { get; set; } = 1.000f;
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public float RaycastEndHeight { get; set; } = -1.000f;
	
	[ContainerField(0x44), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
	public bool AllowAboveGround { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) AttachMethod);
		p_Writer.Write(RaycastStartHeight);
		p_Writer.Write(RaycastEndHeight);
		p_Writer.Write(AllowAboveGround);
		p_Writer.WriteNullBytes(3);
	}
}

