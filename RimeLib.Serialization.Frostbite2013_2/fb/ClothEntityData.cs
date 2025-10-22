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
using fb.Physics;
using fb.Render;
using fb.Entity;

namespace fb.Cloth;

[ContainerType(16, 160)]
public class ClothEntityData
	: fb.Entity.GameComponentEntityData
{
	[ContainerField(0x80), JsonProperty(Order = 128)]
	public CtrRef<MeshAsset> Mesh { get; set; } = new();
	
	[ContainerField(0x88), JsonProperty(Order = 136)]
	public CtrRef<ClothAsset> Cloth { get; set; } = new();
	
	[ContainerField(0x90), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
	public bool CharacterLightingEnable { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(Mesh));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(Cloth));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(CharacterLightingEnable);
		p_Writer.WriteNullBytes(15);
	}
}

