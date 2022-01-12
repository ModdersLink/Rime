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
	[ContainerType(4, 152)]
	public class GunSwayCrouchProneData
	{
		[ContainerField(0)]
		public GunSwayBaseMoveData NoZoom { get; set; } = new();
		
		[ContainerField(76)]
		public GunSwayBaseMoveData Zoom { get; set; } = new();
		
	}
}
