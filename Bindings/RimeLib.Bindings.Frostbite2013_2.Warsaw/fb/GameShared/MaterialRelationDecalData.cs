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
using fb.Entity;
using fb.Core;

namespace fb.GameShared;

[ContainerType(8, 32)]
public class MaterialRelationDecalData
	: fb.Entity.PhysicsMaterialRelationPropertyData
{
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public CtrRef<DecalTemplateData> Decal { get; set; } = new();
	
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public CtrRef<DecalTemplateData> ExitDecal { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(Decal));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(ExitDecal));
		p_Writer.WriteNullBytes(4);
	}
}

