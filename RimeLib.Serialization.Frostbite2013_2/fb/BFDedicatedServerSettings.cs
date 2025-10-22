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

[ContainerType(8, 40)]
public class BFDedicatedServerSettings
	: fb.Core.SystemSettings
{
	public BFDedicatedServerSettings()
	{
		//SystemSettings
		Name = @"BFDedicatedServer";
	}
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public CtrRef<PersistenceConfiguration> PersistenceConfig { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(PersistenceConfig));
		p_Writer.WriteNullBytes(4);
	}
}

