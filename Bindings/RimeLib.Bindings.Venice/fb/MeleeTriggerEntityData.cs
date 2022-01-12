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
	[ContainerType(16, 96)]
	public class MeleeTriggerEntityData : 
		EntityData
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public LinearTransform ConnectTransform { get; set; } = new();

		[ContainerField(80)]
		public CtrRef<AntEnumeration> MeleeType { get; set; } = new();

		[ContainerField(84), LayoutImmutable, Blittable]
		public bool MeleeEnabled { get; set; }

	}
}
