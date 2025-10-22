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
using fb.Physics;
using fb.Entity;

namespace fb.Destruction;

[ContainerType(16, 128)]
public class EdgeModelComponentData
	: fb.Physics.DestructionEdgeModelComponentData
{
	[ContainerField(0x70), JsonProperty(Order = 112)]
	public RefArray<RigidMeshAsset> RigidMeshes { get; set; } = new();
	
	[ContainerField(0x78), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
	public uint MaxInstanceCount { get; set; } = 0;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_RigidMeshes = p_EbxWriter.GetArrayWriter(RigidMeshes.GetType(), RigidMeshes.Count);
		p_Writer.Write(s_RigidMeshes.ArrayIndex);
		foreach (var s_Entry in RigidMeshes)
		{
			s_RigidMeshes.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(MaxInstanceCount);
		p_Writer.WriteNullBytes(4);
	}
}

