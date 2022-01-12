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
	[ContainerType(4, 80)]
	public class AdvancedDogTagData : 
		DogTagData
	{
		[ContainerField(68), LayoutImmutable]
		public string StatCode { get; set; } = string.Empty;

		[ContainerField(72), LayoutImmutable]
		public string StatSID { get; set; } = string.Empty;

		[ContainerField(76), LayoutImmutable, Blittable]
		public bool IsStatMeasuredInTime { get; set; }

	}
}
