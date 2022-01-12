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
	[ContainerType(16, 240)]
	public class UINametagCompData : 
		UI3dIconCompData
	{
		[ContainerField(160), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 SquadTint { get; set; } = new();

		[ContainerField(176), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 EnemyTint { get; set; } = new();

		[ContainerField(192), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 FriendlyTint { get; set; } = new();

		[ContainerField(208), LayoutImmutable, Blittable]
		public int OrderCooldown { get; set; }

		[ContainerField(212), LayoutImmutable, Blittable]
		public int TooltipCooldown { get; set; }

		[ContainerField(216), LayoutImmutable, Blittable]
		public float HealthBarSize { get; set; }

		[ContainerField(220), LayoutImmutable, Blittable]
		public float NameFontSize { get; set; }

		[ContainerField(224), LayoutImmutable, Blittable]
		public float NameGlowSize { get; set; }

	}
}
