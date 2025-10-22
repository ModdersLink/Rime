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
public class SnowrollerSettings
	: fb.Core.SystemSettings
{
	public SnowrollerSettings()
	{
		//SystemSettings
		Name = @"Snowroller";
	}
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public bool ShutdownOnLevelLoad { get; set; } = false;
	
	[ContainerField(0x21), LayoutImmutable, Blittable, JsonProperty(Order = 33)]
	public bool ShutdownGameOnError { get; set; } = true;
	
	[ContainerField(0x22), LayoutImmutable, Blittable, JsonProperty(Order = 34)]
	public bool SkipOnlineFlow { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(ShutdownOnLevelLoad);
		p_Writer.Write(ShutdownGameOnError);
		p_Writer.Write(SkipOnlineFlow);
		p_Writer.WriteNullBytes(5);
	}
}

