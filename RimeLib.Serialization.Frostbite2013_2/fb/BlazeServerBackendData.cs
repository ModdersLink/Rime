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

namespace fb.Online;

[ContainerType(8, 40)]
public class BlazeServerBackendData
	: fb.Online.ServerBackendData
{
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public BlazeCreateGameParameters CreateParameters { get; set; } = new();
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public OnlineEnvironmentConsoleUrl ConfigUrl { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		CreateParameters.Serialize(p_Writer, p_EbxWriter);
		ConfigUrl.Serialize(p_Writer, p_EbxWriter);
	}
}

