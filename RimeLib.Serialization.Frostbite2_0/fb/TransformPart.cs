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
	public enum TransformPart : int
	{
		TransformPart_TranslationX = 0,
		TransformPart_TranslationY = 1,
		TransformPart_TranslationZ = 2,
		TransformPart_RotationX = 3,
		TransformPart_RotationY = 4,
		TransformPart_RotationZ = 5
	}

}
