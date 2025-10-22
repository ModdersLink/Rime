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
using fb.Render;

namespace fb.GameShared;

[ContainerType(16, 128)]
public class AnimatedCameraData
	: fb.GameShared.CameraData
{
	[ContainerField(0x60), JsonProperty(Order = 96)]
	public CtrRef<SkeletonAsset> Skeleton { get; set; } = new();
	
	[ContainerField(0x68), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
	public string CameraBone { get; set; } = string.Empty;
	
	[ContainerField(0x70), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public string FovBone { get; set; } = string.Empty;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(Skeleton));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteString(CameraBone));
		p_Writer.Write(p_EbxWriter.WriteString(FovBone));
		p_Writer.WriteNullBytes(8);
	}
}

