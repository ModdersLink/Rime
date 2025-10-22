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
using fb.Render;
using fb.Entity;
using fb.Physics;

namespace fb.GameShared;

[ContainerType(16, 304)]
public class GhostedProjectileEntityData
	: fb.GameShared.MeshProjectileEntityData
{
	[ContainerField(0x120), LayoutImmutable, Blittable, JsonProperty(Order = 288)]
	public float ProxyConvergenceDelay { get; set; } = -1.000f;
	
	[ContainerField(0x124), LayoutImmutable, Blittable, JsonProperty(Order = 292)]
	public float ProxyConvergenceDuration { get; set; } = -1.000f;
	
	[ContainerField(0x128), LayoutImmutable, Blittable, JsonProperty(Order = 296)]
	public bool ProxyConvergenceInstantOnAttach { get; set; } = true;
	
	[ContainerField(0x129), LayoutImmutable, Blittable, JsonProperty(Order = 297)]
	public bool ForceProxyConvergence { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(ProxyConvergenceDelay);
		p_Writer.Write(ProxyConvergenceDuration);
		p_Writer.Write(ProxyConvergenceInstantOnAttach);
		p_Writer.Write(ForceProxyConvergence);
		p_Writer.WriteNullBytes(6);
	}
}

