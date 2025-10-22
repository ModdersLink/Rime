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

namespace fb.WorldRender;

[ContainerType(16, 112)]
public class MeshProxyEntityData
	: fb.Entity.SpatialEntityData
{
	[ContainerField(0x60), JsonProperty(Order = 96)]
	public CtrRef<MeshAsset> Mesh { get; set; } = new();
	
	[ContainerField(0x68), JsonProperty(Order = 104)]
	public List<LinearTransform> BasePoseTransforms { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(Mesh));
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_BasePoseTransforms = p_EbxWriter.GetArrayWriter(BasePoseTransforms.GetType(), BasePoseTransforms.Count);
		p_Writer.Write(s_BasePoseTransforms.ArrayIndex);
		foreach (var s_Entry in BasePoseTransforms)
		{
			s_Entry.Serialize(s_BasePoseTransforms.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
	}
}

