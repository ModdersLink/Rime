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
	[ContainerType(16, 224)]
	public class PlayerEntryComponentData : 
		EntryComponentData
	{
		[ContainerField(192), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 AnimationAccelerationMultiplier { get; set; } = new();

		[ContainerField(208)]
		public AntEntryIdEnum AntEntryId { get; set; } = new();

		[ContainerField(212), LayoutImmutable]
		public string AntEntryID { get; set; } = string.Empty;

		[ContainerField(216)]
		public CtrRef<AntEnumeration> AntEntryEnumeration { get; set; } = new();

		[ContainerField(220), LayoutImmutable, Blittable]
		public float ShieldedTransitionExitTime { get; set; }

	}
}
