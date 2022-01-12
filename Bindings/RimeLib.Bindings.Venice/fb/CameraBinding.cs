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
	[ContainerType(4, 8)]
	public class CameraBinding
	{
		[ContainerField(0)]
		public AntRef Render1pInBackground { get; set; } = new();
		
		[ContainerField(4)]
		public AntRef ForceRender1pInForeground { get; set; } = new();
		
	}
}
