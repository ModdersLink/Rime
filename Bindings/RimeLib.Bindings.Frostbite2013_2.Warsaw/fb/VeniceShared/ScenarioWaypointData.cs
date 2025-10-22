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

using fb.Ant;
using fb.GameShared;
using fb.Core;

namespace fb.VeniceShared;

[ContainerType(16, 192)]
public class ScenarioWaypointData
	: fb.VeniceShared.AbstractLocoWaypointData
{
	[ContainerField(0x40), JsonProperty(Order = 64)]
	public CtrRef<PlayAnimationData> PlayAnimation { get; set; } = new();
	
	[ContainerField(0x48), JsonProperty(Order = 72)]
	public AntRef ScenarioAntRef { get; set; } = new();
	
	[ContainerField(0x60), JsonProperty(Order = 96)]
	public ScenarioTaskData ScenarioTask { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(PlayAnimation));
		p_Writer.WriteNullBytes(4);
		ScenarioAntRef.Serialize(p_Writer, p_EbxWriter);
		p_Writer.WriteNullBytes(4);
		ScenarioTask.Serialize(p_Writer, p_EbxWriter);
	}
}

