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

using fb.Online;
using fb.Core;

namespace fb.VeniceShared;

[ContainerType(8, 48)]
public class BattlelogConfigData
	: fb.Core.Asset
{
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public OnlineEnvironmentConsoleUrl BattlelogClientApiUrl { get; set; } = new();
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public OnlineEnvironmentConsoleUrl BattlelogServerApiUrl { get; set; } = new();
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public OnlineEnvironmentConsoleUrl BattlelogReportUrl { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		BattlelogClientApiUrl.Serialize(p_Writer, p_EbxWriter);
		BattlelogServerApiUrl.Serialize(p_Writer, p_EbxWriter);
		BattlelogReportUrl.Serialize(p_Writer, p_EbxWriter);
	}
}

