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

using fb.Render;
using fb.GameShared;
using fb.Entity;
using fb.Core;

namespace fb.VeniceShared;

[ContainerType(16, 144)]
public class PlayerLogoComponentData
	: fb.GameShared.ShaderParameterComponentData
{
	[ContainerField(0x80), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public PlayerDefaultLogoType DefaultLogoType { get; set; } = PlayerDefaultLogoType.PlayerDefaultLogoType_Land;
	
	[ContainerField(0x88), JsonProperty(Order = 136)]
	public CtrRef<TextureAsset> DefaultTexture { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) DefaultLogoType);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(DefaultTexture));
		p_Writer.WriteNullBytes(4);
	}
}

