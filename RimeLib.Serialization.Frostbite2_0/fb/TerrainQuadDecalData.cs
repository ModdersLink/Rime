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
	[ContainerType(16, 96)]
	public class TerrainQuadDecalData :
		VisualVectorShapeData
	{
		[ContainerField(48), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		public Vec4 UserMasks { get; set; } = new();

		[ContainerField(64), JsonProperty(Order = 64)]
		public CtrRef<SurfaceShaderBaseAsset> Shader3dZOnly { get; set; } = new();

		[ContainerField(68), JsonProperty(Order = 68)]
		public CtrRef<SurfaceShaderBaseAsset> Shader2d { get; set; } = new();

		[ContainerField(72), JsonProperty(Order = 72)]
		public CtrRef<TerrainQuadDecalAtlasTileTemplateData> AtlasTileTemplate { get; set; } = new();

		[ContainerField(76), JsonProperty(Order = 76)]
		public TerrainQuadDecalAtlasTile AtlasTile { get; set; } = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(4);
			UserMasks.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(Shader3dZOnly));
			p_Writer.Write(p_EbxWriter.WriteImport(Shader2d));
			p_Writer.Write(p_EbxWriter.WriteImport(AtlasTileTemplate));
			AtlasTile.Serialize(p_Writer, p_EbxWriter);
		}
	}
}
