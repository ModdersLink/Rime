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
using RimeLib.Serialization.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Flags: 137, Size: 4  )]
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
