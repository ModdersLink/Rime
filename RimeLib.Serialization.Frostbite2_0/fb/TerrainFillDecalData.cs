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
	[ContainerType(4, 52)]
	public class TerrainFillDecalData :
		VisualVectorShapeData
	{
		[ContainerField(44), JsonProperty(Order = 44)]
		public CtrRef<SurfaceShaderBaseAsset> Shader2d { get; set; } = new();

		[ContainerField(48), JsonProperty(Order = 48)]
		public CtrRef<SurfaceShaderBaseAsset> Shader3dZOnly { get; set; } = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(Shader2d));
			p_Writer.Write(p_EbxWriter.WriteImport(Shader3dZOnly));
		}
	}
}
