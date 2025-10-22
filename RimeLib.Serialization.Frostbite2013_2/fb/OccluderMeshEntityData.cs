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

using fb.Render;
using fb.Entity;
using fb.Core;

namespace fb.WorldRender;

[ContainerType(16, 112)]
public class OccluderMeshEntityData
	: fb.Entity.SpatialEntityData
{
	[ContainerField(0x60), JsonProperty(Order = 96)]
	public CtrRef<RigidMeshAsset> Mesh { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(Mesh));
		p_Writer.WriteNullBytes(12);
	}
}

