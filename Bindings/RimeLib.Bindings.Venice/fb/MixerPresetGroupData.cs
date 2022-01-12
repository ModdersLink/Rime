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
	[ContainerType(4, 24)]
	public class MixerPresetGroupData
	{
		[ContainerField(0)]
		public CtrRef<MixGroup> Group { get; set; } = new();
		
		[ContainerField(4)]
		public MixGroupState State { get; set; } = new();
		
		[ContainerField(8), LayoutImmutable, Blittable]
		public float AttackTime { get; set; }
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public float ReleaseTime { get; set; }
		
		[ContainerField(16)]
		public List<MixGroupPropertyValue> Properties { get; set; } = new();
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public bool IsDominant { get; set; }
		
	}
}
