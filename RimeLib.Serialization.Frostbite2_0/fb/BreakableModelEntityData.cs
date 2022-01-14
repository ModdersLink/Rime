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
	[ContainerType(16, 144)]
	public class BreakableModelEntityData :
		GamePhysicsEntityData
	{
		[ContainerField(112), JsonProperty(Order = 112)]
		public CtrRef<SurfaceShaderBaseAsset> DecalVolumeShader { get; set; } = new();

		[ContainerField(116), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
		public float DecalVolumeScaleFactor { get; set; }

		[ContainerField(120), JsonProperty(Order = 120)]
		public CtrRef<MeshAsset> Mesh { get; set; } = new();

		[ContainerField(124), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
		public uint BoneCount { get; set; }

		[ContainerField(128), JsonProperty(Order = 128)]
		public CtrRef<EdgeModelLightMapData> EdgeModelLightMapData { get; set; } = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(DecalVolumeShader));
			p_Writer.Write(DecalVolumeScaleFactor);
			p_Writer.Write(p_EbxWriter.WriteImport(Mesh));
			p_Writer.Write(BoneCount);
			p_Writer.Write(p_EbxWriter.WriteImport(EdgeModelLightMapData));
			p_Writer.WriteNullBytes(12);
		}
	}
}
