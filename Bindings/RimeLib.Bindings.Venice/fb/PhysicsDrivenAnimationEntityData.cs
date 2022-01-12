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
	[ContainerType(4, 136)]
	public class PhysicsDrivenAnimationEntityData : 
		EntityData
	{
		[ContainerField(12)]
		public Realm Realm { get; set; } = new();

		[ContainerField(16)]
		public PhysicsDrivenAnimationEntityBinding Binding { get; set; } = new();

		[ContainerField(132), LayoutImmutable, Blittable]
		public int AnimationEntitySpacePriority { get; set; }

	}
}
