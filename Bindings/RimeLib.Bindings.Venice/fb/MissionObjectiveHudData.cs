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
	[ContainerType(16, 64)]
	public class MissionObjectiveHudData : 
		DataContainer
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 CameraPosition { get; set; } = new();

		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable]
		public Vec2 HorizontalBoundaries { get; set; } = new();

		[ContainerField(40), Homogeneous, LayoutImmutable, Blittable]
		public Vec2 VerticalBoundaries { get; set; } = new();

		[ContainerField(48), LayoutImmutable, Blittable]
		public float CameraRotation { get; set; }

		[ContainerField(52), LayoutImmutable, Blittable]
		public float CameraFov { get; set; }

		[ContainerField(56), LayoutImmutable, Blittable]
		public float CameraLookDistance { get; set; }

		[ContainerField(60), LayoutImmutable, Blittable]
		public float CameraDistance { get; set; }

		public static void Deserialize(MissionObjectiveHudData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Reader.Seek(8, SeekOrigin.Current);
			fb.Vec3.Deserialize(p_Instance.CameraPosition, p_Reader, p_Parser);
			p_Reader.Seek(8, SeekOrigin.Current);
			fb.Vec2.Deserialize(p_Instance.HorizontalBoundaries, p_Reader, p_Parser);
			p_Reader.Seek(8, SeekOrigin.Current);
			fb.Vec2.Deserialize(p_Instance.VerticalBoundaries, p_Reader, p_Parser);
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.CameraRotation = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.CameraFov = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.CameraLookDistance = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.CameraDistance = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
		}

	}
}
