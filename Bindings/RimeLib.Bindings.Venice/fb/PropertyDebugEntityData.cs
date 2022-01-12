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
	[ContainerType(16, 176)]
	public class PropertyDebugEntityData : 
		EntityData
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 Vec3Value { get; set; } = new();

		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 TextColor { get; set; } = new();

		[ContainerField(48), Homogeneous, LayoutImmutable, Blittable]
		public Vec2 ScreenPosition { get; set; } = new();

		[ContainerField(64), Homogeneous, LayoutImmutable, Blittable]
		public LinearTransform TransformValue { get; set; } = new();

		[ContainerField(128), Homogeneous, LayoutImmutable, Blittable]
		public Vec2 Vec2Value { get; set; } = new();

		[ContainerField(136), LayoutImmutable]
		public string ValuePrefix { get; set; } = string.Empty;

		[ContainerField(140)]
		public Realm Realm { get; set; } = new();

		[ContainerField(144), LayoutImmutable, Blittable]
		public float FloatValue { get; set; }

		[ContainerField(148), LayoutImmutable, Blittable]
		public int IntValue { get; set; }

		[ContainerField(152), LayoutImmutable, Blittable]
		public float TextScale { get; set; }

		[ContainerField(156), LayoutImmutable]
		public string StringValue { get; set; } = string.Empty;

		[ContainerField(160), LayoutImmutable, Blittable]
		public bool DefaultVisible { get; set; }

		[ContainerField(161), LayoutImmutable, Blittable]
		public bool BoolValue { get; set; }

		[ContainerField(162), LayoutImmutable, Blittable]
		public bool Multiline { get; set; }

	}
}
