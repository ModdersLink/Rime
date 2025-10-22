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
using fb.Core;

namespace fb.VeniceShared;

[ContainerType(8, 24)]
public class BFOnlineLevelDescriptionComponent
	: fb.GameShared.LevelDescriptionComponent
{
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public PersistenceGameType ForcedPersistenceGameType { get; set; } = PersistenceGameType.PersistenceGameType_Singleplayer;
	
	[ContainerField(0x14), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
	public bool ForceLocalServerBackend { get; set; } = false;
	
	[ContainerField(0x15), LayoutImmutable, Blittable, JsonProperty(Order = 21)]
	public bool ForcePersistenceGameType { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) ForcedPersistenceGameType);
		p_Writer.Write(ForceLocalServerBackend);
		p_Writer.Write(ForcePersistenceGameType);
		p_Writer.WriteNullBytes(2);
	}
}

