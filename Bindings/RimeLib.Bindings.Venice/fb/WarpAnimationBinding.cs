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
	[ContainerType(4, 20)]
	public class WarpAnimationBinding
	{
		[ContainerField(0)]
		public AntRef ConnectJointGroup { get; set; } = new();
		
		[ContainerField(4)]
		public AntRef ConnectJointWeight { get; set; } = new();
		
		[ContainerField(8)]
		public AntRef EnableAlign { get; set; } = new();
		
		[ContainerField(12)]
		public AntRef DisableCulling { get; set; } = new();
		
		[ContainerField(16)]
		public AntRef TranslationYWarpTolerance { get; set; } = new();
		
	}
}
