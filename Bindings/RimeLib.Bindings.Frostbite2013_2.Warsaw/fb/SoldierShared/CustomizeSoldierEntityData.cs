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
using fb.GameShared;
using fb.Entity;

namespace fb.SoldierShared;

[ContainerType(8, 48)]
public class CustomizeSoldierEntityData
	: fb.GameShared.CustomizeBaseEntityData
{
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public CtrRef<CustomizeSoldierData> CustomizeSoldierData { get; set; } = new();
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public bool AutoPreloadOnCreation { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(CustomizeSoldierData));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(AutoPreloadOnCreation);
		p_Writer.WriteNullBytes(7);
	}
}

