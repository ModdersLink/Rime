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
	[ContainerType(4, 48)]
	public class FollowPlayerOrderEntityData : 
		BFOrderEntityData
	{
		[ContainerField(40)]
		public CtrRef<FormationData> Formation { get; set; } = new();

		[ContainerField(44), LayoutImmutable, Blittable]
		public bool CombatForbidden { get; set; }

	}
}
