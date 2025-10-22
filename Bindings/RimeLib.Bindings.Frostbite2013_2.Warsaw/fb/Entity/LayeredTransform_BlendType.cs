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


namespace fb.Entity;

[ContainerType(1, 4)]
public enum LayeredTransform_BlendType : int
{
	LayeredTransform_BlendType_WorldOverride = 0,
	LayeredTransform_BlendType_WorldAdditive = 1,
	LayeredTransform_BlendType_WorldTranslationLocalRotationAdditive = 2,
	LayeredTransform_BlendType_LocalAdditive = 3,
	LayeredTransform_BlendType_Special = 4,
}

