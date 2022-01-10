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
	[ContainerType(4, 40)]
	public class FakePhysicsData : 
		DataContainer
	{
		[ContainerField(8)]
		public CtrRef<FakePhysicsData> ChildFakePhysics { get; set; } = new();

		[ContainerField(12), LayoutImmutable, Blittable]
		public float StartSpeed { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable]
		public float GravityModifier { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public float StartDampening { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public float EndDampening { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable]
		public float MinSpeed { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable]
		public float MaxSpeed { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable]
		public float Mass { get; set; }

		public static void Deserialize(FakePhysicsData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.ChildFakePhysics.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.StartSpeed = p_Reader.ReadSingle();
			p_Instance.GravityModifier = p_Reader.ReadSingle();
			p_Instance.StartDampening = p_Reader.ReadSingle();
			p_Instance.EndDampening = p_Reader.ReadSingle();
			p_Instance.MinSpeed = p_Reader.ReadSingle();
			p_Instance.MaxSpeed = p_Reader.ReadSingle();
			p_Instance.Mass = p_Reader.ReadSingle();
		}

	}
}
