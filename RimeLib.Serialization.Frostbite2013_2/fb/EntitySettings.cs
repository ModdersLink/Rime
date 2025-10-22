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

[ContainerType(8, 48)]
public class EntitySettings
	: fb.Core.SystemSettings
{
	public EntitySettings()
	{
		//SystemSettings
		Name = @"Entity";
	}
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public ExecutionModeType ExecutionMode { get; set; } = ExecutionModeType.ExecutionMode_Play;
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public uint OutOfEntityBusNetworkIdThreshold { get; set; } = 100;
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public bool EditorGameViewEnable { get; set; } = false;
	
	[ContainerField(0x29), LayoutImmutable, Blittable, JsonProperty(Order = 41)]
	public bool SpawnSubLevelsFromLogic { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) ExecutionMode);
		p_Writer.Write(OutOfEntityBusNetworkIdThreshold);
		p_Writer.Write(EditorGameViewEnable);
		p_Writer.Write(SpawnSubLevelsFromLogic);
		p_Writer.WriteNullBytes(6);
	}
}

