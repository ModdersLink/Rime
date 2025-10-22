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


namespace fb.Online;

[ContainerType(1, 4)]
public enum GameNetworkTopology : int
{
	GameNetworkTopology_Disabled = 0,
	GameNetworkTopology_Peer2Peer = 1,
	GameNetworkTopology_PeerHosted = 2,
	GameNetworkTopology_DedicatedServer = 3,
}

