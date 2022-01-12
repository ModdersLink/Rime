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
	public class ServerBackendAttributeMapping
	{
		[ContainerField(0)]
		public ServerBackendAttribute Attribute { get; set; } = new();
		
		[ContainerField(4), LayoutImmutable]
		public string Setting { get; set; } = string.Empty;
		
		[ContainerField(8), LayoutImmutable]
		public string DefaultValue { get; set; } = string.Empty;
		
	}
}
