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
	[ContainerType(4, 16)]
	public class CollisionData : 
		DataContainer
	{
		[ContainerField(8)]
		public List<ValueAtX> DamageAtVerticalVelocity { get; set; } = new();

		[ContainerField(12)]
		public List<ValueAtX> DamageAtHorizVelocity { get; set; } = new();

	}
}
