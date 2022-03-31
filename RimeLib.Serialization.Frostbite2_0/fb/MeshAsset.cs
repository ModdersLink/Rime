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
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(4, 40)]
	public class MeshAsset :
		Asset
	{
		[ContainerField(12), JsonProperty(Order = 12)]
		public CtrRef<MeshLodGroup> LodGroup { get; set; } = new();

		[ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public float LodScale { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		public float CullScale { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		public uint NameHash { get; set; }

		[ContainerField(28), JsonProperty(Order = 28)]
		public EnlightenType EnlightenType { get; set; } = new();

		[ContainerField(32), JsonProperty(Order = 32)]
		public RefArray<MeshMaterial> Materials { get; set; } = new();

		[ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		public bool OccluderHighPriority { get; set; }

		[ContainerField(37), LayoutImmutable, Blittable, JsonProperty(Order = 37)]
		public bool StreamingEnable { get; set; }

		[ContainerField(38), LayoutImmutable, Blittable, JsonProperty(Order = 38)]
		public bool DestructionMaterialEnable { get; set; }

		[ContainerField(39), LayoutImmutable, Blittable, JsonProperty(Order = 39)]
		public bool OccluderMeshEnable { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(LodGroup));
			p_Writer.Write(LodScale);
			p_Writer.Write(CullScale);
			p_Writer.Write(NameHash);
			p_Writer.Write((int) EnlightenType);
			(RimeWriter Writer, uint ArrayIndex) s_Materials = p_EbxWriter.GetArrayWriter(Materials.GetType(), Materials.Count);
			p_Writer.Write(s_Materials.ArrayIndex);
			foreach (var s_Entry in Materials)
			{
				s_Materials.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			p_Writer.Write(OccluderHighPriority);
			p_Writer.Write(StreamingEnable);
			p_Writer.Write(DestructionMaterialEnable);
			p_Writer.Write(OccluderMeshEnable);
		}
	}
}
