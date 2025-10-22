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

namespace fb.VeniceShared;

[ContainerType(8, 32)]
public class FreeCameraSpectatorViewComponentData
	: fb.VeniceShared.SpectatorViewComponentData
{
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public CtrRef<CollidableFreeCameraData> FreeCameraData { get; set; } = new();
	
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public bool CheckSpectatorAreas { get; set; } = true;
	
	[ContainerField(0x19), LayoutImmutable, Blittable, JsonProperty(Order = 25)]
	public bool CheckCombatAreas { get; set; } = false;
	
	[ContainerField(0x1a), LayoutImmutable, Blittable, JsonProperty(Order = 26)]
	public bool Scannable { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(FreeCameraData));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(CheckSpectatorAreas);
		p_Writer.Write(CheckCombatAreas);
		p_Writer.Write(Scannable);
		p_Writer.WriteNullBytes(5);
	}
}

