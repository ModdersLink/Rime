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
using RimeLib.Serialization.Frostbite2_0.Ebx;
using CommunityToolkit.Mvvm.ComponentModel;

namespace fb
{
	[ContainerType(4, 4)]
	public enum RenderBlendMode : int
	{
		RenderBlendMode_Zero = 0,
		RenderBlendMode_One = 1,
		RenderBlendMode_SourceColor = 2,
		RenderBlendMode_InvSourceColor = 3,
		RenderBlendMode_SourceAlpha = 4,
		RenderBlendMode_InvSourceAlpha = 5,
		RenderBlendMode_DestColor = 6,
		RenderBlendMode_InvDestColor = 7,
		RenderBlendMode_DestAlpha = 8,
		RenderBlendMode_InvDestAlpha = 9,
		RenderBlendMode_SourceAlphaSaturate = 10
	}

}
