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
	public class BasicUnlockInfo
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public GUID UnlockGuid { get; set; }
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public uint Identifier { get; set; }
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public uint UnlockScore { get; set; }
		
		[ContainerField(24)]
		public List<string> Licenses { get; set; } = new();
		
		[ContainerField(28)]
		public List<string> AdditionalLicenses { get; set; } = new();
		
		[ContainerField(32), LayoutImmutable]
		public string StringId { get; set; } = string.Empty;
		
	}
}
