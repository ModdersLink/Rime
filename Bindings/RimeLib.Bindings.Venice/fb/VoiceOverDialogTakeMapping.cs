///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4, 12)]
	public class VoiceOverDialogTakeMapping
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public float TakeControlMin { get; set; }
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public float TakeControlMax { get; set; }
		
		[ContainerField(8), LayoutImmutable, Blittable]
		public sbyte TakeIndex { get; set; }
		
	}
}
