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
	[ContainerType(16, 128)]
	public class DynamicModelEntityData :
		DynamicGamePhysicsEntityData
	{
		[ContainerField(112), JsonProperty(Order = 112)]
		public CtrRef<PartComponentData> Part { get; set; } = new();

		[ContainerField(116), JsonProperty(Order = 116)]
		public CtrRef<MeshAsset> Mesh { get; set; } = new();

		[ContainerField(120), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
		public bool NoCollision { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(Part));
			p_Writer.Write(p_EbxWriter.WriteImport(Mesh));
			p_Writer.Write(NoCollision);
			p_Writer.WriteNullBytes(7);
		}
	}
}
