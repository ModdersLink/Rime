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

namespace fb.Entity;

[ContainerType(8, 88)]
public class SubWorldData
	: fb.Entity.SpatialPrefabBlueprint
{
	[ContainerField(0x48), JsonProperty(Order = 72)]
	public CtrRef<MaterialGridData> RuntimeMaterialGrid { get; set; } = new();
	
	[ContainerField(0x50), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public bool IsWin32SubLevel { get; set; } = true;
	
	[ContainerField(0x51), LayoutImmutable, Blittable, JsonProperty(Order = 81)]
	public bool IsXenonSubLevel { get; set; } = true;
	
	[ContainerField(0x52), LayoutImmutable, Blittable, JsonProperty(Order = 82)]
	public bool IsPs3SubLevel { get; set; } = true;
	
	[ContainerField(0x53), LayoutImmutable, Blittable, JsonProperty(Order = 83)]
	public bool IsGen4aSubLevel { get; set; } = true;
	
	[ContainerField(0x54), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
	public bool IsGen4bSubLevel { get; set; } = true;
	
	[ContainerField(0x55), LayoutImmutable, Blittable, JsonProperty(Order = 85)]
	public bool RememberStateOnStreamOut { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(RuntimeMaterialGrid));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(IsWin32SubLevel);
		p_Writer.Write(IsXenonSubLevel);
		p_Writer.Write(IsPs3SubLevel);
		p_Writer.Write(IsGen4aSubLevel);
		p_Writer.Write(IsGen4bSubLevel);
		p_Writer.Write(RememberStateOnStreamOut);
		p_Writer.WriteNullBytes(2);
	}
}

