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
using RimeLib.Serialization.Ebx;
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(4, 4)]
	public enum GameOverResult : int
	{
		GameOver_MajorDefeat = 1,
		GameOver_Defeat = 2,
		GameOver_MinorDefeat = 3,
		GameOver_MajorVictory = 4,
		GameOver_Victory = 5,
		GameOver_MinorVictory = 6,
		GameOver_Draw = 7
	}

}
