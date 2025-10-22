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


namespace fb.Venice;

[ContainerType(8, 24)]
public class TabletCommanderMessageListPacket
	: EbxSerializable
{
	[ContainerField(0x0), JsonProperty(Order = 0)]
	public TabletCommanderPacketBase PacketBase { get; set; } = new();
	
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public List<TabletCommanderMessageType> MessageTypeList { get; set; } = new();
	
}

