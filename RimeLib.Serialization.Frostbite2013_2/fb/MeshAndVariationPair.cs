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

using fb.Entity;
using fb.Render;
using fb.Core;

namespace fb.GameShared;

[ContainerType(8, 88)]
public class MeshAndVariationPair
	: fb.Entity.ObjectBlueprint
{
	[ContainerField(0x48), JsonProperty(Order = 72)]
	public CtrRef<MeshAsset> MeshAsset { get; set; } = new();
	
	[ContainerField(0x50), JsonProperty(Order = 80)]
	public CtrRef<ObjectVariation> Variation { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(MeshAsset));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(Variation));
		p_Writer.WriteNullBytes(4);
	}
}

