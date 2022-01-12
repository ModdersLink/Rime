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
	public class SoundGraphLinkedPluginAttribute
	{
		[ContainerField(0)]
		public SoundGraphPluginRef Plugin { get; set; } = new();
		
		[ContainerField(4)]
		public CtrRef<AudioGraphNodeData> Node { get; set; } = new();
		
		[ContainerField(8)]
		public AudioGraphNodePort Port { get; set; } = new();
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public sbyte AttributeIndex { get; set; }
		
		[ContainerField(17), LayoutImmutable, Blittable]
		public bool AllowExtremeValues { get; set; }
		
	}
}
