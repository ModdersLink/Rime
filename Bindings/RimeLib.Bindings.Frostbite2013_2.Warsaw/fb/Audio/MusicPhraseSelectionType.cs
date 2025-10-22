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
public enum MusicPhraseSelectionType : int
{
	MusicPhraseSelectionType_PlayFirstAndShuffle = 0,
	MusicPhraseSelectionType_PlayAllAndShuffle = 1,
	MusicPhraseSelectionType_Random = 2,
	MusicPhraseSelectionType_Range = 3,
	MusicPhraseSelectionType_Sequential = 4,
	MusicPhraseSelectionType_Shuffle = 5,
	MusicPhraseSelectionType_Weighted = 6,
}

