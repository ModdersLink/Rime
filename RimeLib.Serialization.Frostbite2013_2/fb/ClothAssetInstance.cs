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
using fb.Entity;

namespace fb.Cloth;

[ContainerType(8, 40)]
public class ClothAssetInstance
	: fb.Entity.DataContainerPolicyAsset
{
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public CtrRef<ClothObjectBlueprint> Cloth { get; set; } = new();
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public bool WorldCollision { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(Cloth));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(WorldCollision);
		p_Writer.WriteNullBytes(7);
	}
}

