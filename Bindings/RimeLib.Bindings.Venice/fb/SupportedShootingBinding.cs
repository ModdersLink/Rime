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
	[ContainerType(4, 36)]
	public class SupportedShootingBinding
	{
		[ContainerField(0)]
		public AntRef Supported { get; set; } = new();
		
		[ContainerField(4)]
		public AntRef SupportedPos { get; set; } = new();
		
		[ContainerField(8)]
		public AntRef ForwardVector { get; set; } = new();
		
		[ContainerField(12)]
		public AntRef Yaw { get; set; } = new();
		
		[ContainerField(16)]
		public AntRef Pitch { get; set; } = new();
		
		[ContainerField(20)]
		public AntRef DistToObject { get; set; } = new();
		
		[ContainerField(24)]
		public AntRef HeightOfObject { get; set; } = new();
		
		[ContainerField(28)]
		public AntRef Undeploying { get; set; } = new();
		
		[ContainerField(32)]
		public AntRef AnimatedCamera { get; set; } = new();
		
	}
}
