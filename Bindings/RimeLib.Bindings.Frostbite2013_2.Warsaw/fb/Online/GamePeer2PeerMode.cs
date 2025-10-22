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
public enum GamePeer2PeerMode : int
{
	GamePeer2PeerMode_FullMesh = 0,
	GamePeer2PeerMode_PartialMesh = 1,
	GamePeer2PeerMode_DirtyCastFailover = 2,
}

