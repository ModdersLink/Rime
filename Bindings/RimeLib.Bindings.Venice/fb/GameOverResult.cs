///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using RimeLib.IO;
using RimeLib.Frostbite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Reflection;
using RimeLib.Serialization.Attributes;
using RimeLib.Frostbite.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Flags: 137, Size: 4  )]
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
