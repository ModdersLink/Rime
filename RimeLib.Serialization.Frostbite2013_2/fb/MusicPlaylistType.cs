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


namespace fb.Audio;

[ContainerType(1, 4)]
public enum MusicPlaylistType : int
{
	MusicPlaylistType_PlayFirstAndShuffle = 0,
	MusicPlaylistType_Random = 1,
	MusicPlaylistType_Shuffle = 2,
	MusicPlaylistType_Sequential = 3,
}

