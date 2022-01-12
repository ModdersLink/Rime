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
	[ContainerType(4, 16)]
	public class Animated1pOnlyWeaponBinding
	{
		[ContainerField(0)]
		public AntRef UndeployFinished { get; set; } = new();
		
		[ContainerField(4)]
		public AntRef CameraFreeWeight { get; set; } = new();
		
		[ContainerField(8)]
		public AntRef Deploy1P { get; set; } = new();
		
		[ContainerField(12)]
		public AntRef HideWeapon1p { get; set; } = new();
		
	}
}
