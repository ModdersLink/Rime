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
	public class DynamicAvoidanceEntityData : 
		EntityData
	{
		[ContainerField(12)]
		public DynamicAvoidanceMode RepelOthers { get; set; } = new();

		[ContainerField(16)]
		public DynamicAvoidanceMode ReportPredictedCollision { get; set; } = new();

		[ContainerField(20), LayoutImmutable, Blittable]
		public float CollisionRadius { get; set; }

		[ContainerField(24)]
		public Realm Realm { get; set; } = new();

		[ContainerField(28)]
		public AntDynamicAvoidanceBinding AntBinding { get; set; } = new();

		[ContainerField(44), LayoutImmutable, Blittable]
		public bool AffectedByRepellingForce { get; set; }

		[ContainerField(45), LayoutImmutable, Blittable]
		public bool PredictedByOthers { get; set; }

	}
}
