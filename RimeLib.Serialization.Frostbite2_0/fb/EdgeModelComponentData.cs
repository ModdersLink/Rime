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
using RimeLib.Serialization.Ebx;
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(16, 112)]
	public class EdgeModelComponentData :
		DestructionEdgeModelComponentData
	{
		[ContainerField(96), JsonProperty(Order = 96)]
		public RefArray<RigidMeshAsset> RigidMeshes { get; set; } = new();

		[ContainerField(100), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
		public uint MaxInstanceCount { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_RigidMeshes = p_EbxWriter.GetArrayWriter(RigidMeshes.GetType(), RigidMeshes.Count);
			p_Writer.Write(s_RigidMeshes.ArrayIndex);
			foreach (var s_Entry in RigidMeshes)
			{
				s_RigidMeshes.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			p_Writer.Write(MaxInstanceCount);
			p_Writer.WriteNullBytes(8);
		}
	}
}
