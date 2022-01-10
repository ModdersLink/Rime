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
	[ContainerType(16, 128)]
	public class FakeHingeData : 
		FakePhysicsData
	{
		[ContainerField(48), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 Pivot { get; set; } = new();

		[ContainerField(64), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 RotationAxis { get; set; } = new();

		[ContainerField(80), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 ExtensionAxis { get; set; } = new();

		[ContainerField(96), LayoutImmutable, Blittable]
		public float MinAngle { get; set; }

		[ContainerField(100), LayoutImmutable, Blittable]
		public float MaxAngle { get; set; }

		[ContainerField(104), LayoutImmutable, Blittable]
		public float AngularDampening { get; set; }

		[ContainerField(108), LayoutImmutable, Blittable]
		public float PullbackAcceleration { get; set; }

		[ContainerField(112), LayoutImmutable, Blittable]
		public float ProgressiveExponent { get; set; }

		[ContainerField(116), LayoutImmutable, Blittable]
		public float InertiaModifier { get; set; }

		public static void Deserialize(FakeHingeData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Reader.Seek(8, SeekOrigin.Current);
			fb.Vec3.Deserialize(p_Instance.Pivot, p_Reader, p_Parser);
			p_Reader.Seek(8, SeekOrigin.Current);
			fb.Vec3.Deserialize(p_Instance.RotationAxis, p_Reader, p_Parser);
			p_Reader.Seek(8, SeekOrigin.Current);
			fb.Vec3.Deserialize(p_Instance.ExtensionAxis, p_Reader, p_Parser);
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.MinAngle = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.MaxAngle = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.AngularDampening = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.PullbackAcceleration = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.ProgressiveExponent = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.InertiaModifier = p_Reader.ReadSingle();
			p_Reader.Seek(16, SeekOrigin.Current);
		}

	}
}
