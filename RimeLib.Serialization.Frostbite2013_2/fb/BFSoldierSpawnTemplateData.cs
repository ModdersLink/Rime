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

using fb.GameShared;
using fb.VeniceShared;
using fb.Core;
using fb.Audio;

namespace fb.BFAI2Data;

[ContainerType(8, 96)]
public class BFSoldierSpawnTemplateData
	: fb.VeniceShared.BFNamedCharacterSpawnTemplateData
{
	[ContainerField(0x50), JsonProperty(Order = 80)]
	public CtrRef<SoldierTactics> Tactics { get; set; } = new();
	
	[ContainerField(0x58), JsonProperty(Order = 88)]
	public CtrRef<AntEnumeration> Projectile { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(Tactics));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(Projectile));
		p_Writer.WriteNullBytes(4);
	}
}

