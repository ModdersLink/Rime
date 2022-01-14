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
	[ContainerType(4, 12)]
	public class MeshVariationInfo :
		EbxSerializable
	{
		[ContainerField(0), JsonProperty(Order = 0)]
		public CtrRef<MeshAsset> MeshAsset { get; set; } = new();
		
		[ContainerField(4), JsonProperty(Order = 4)]
		public CtrRef<MeshAsset> OrigMeshAsset { get; set; } = new();
		
		[ContainerField(8), JsonProperty(Order = 8)]
		public CtrRef<ObjectVariation> VariationAsset { get; set; } = new();
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(MeshAsset));
			p_Writer.Write(p_EbxWriter.WriteImport(OrigMeshAsset));
			p_Writer.Write(p_EbxWriter.WriteImport(VariationAsset));
		}
	}
}
