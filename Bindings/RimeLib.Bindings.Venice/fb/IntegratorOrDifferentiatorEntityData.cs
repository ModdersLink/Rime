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
	public class IntegratorOrDifferentiatorEntityData : 
		EntityData
	{
		[ContainerField(12)]
		public Realm Realm { get; set; } = new();

		[ContainerField(16)]
		public EntityUpdateOrder UpdatePass { get; set; } = new();

		[ContainerField(20), LayoutImmutable, Blittable]
		public float StartValue { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public float Input { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable]
		public float MaxValue { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable]
		public float MinValue { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable]
		public bool Bounded { get; set; }

		public static void Deserialize(IntegratorOrDifferentiatorEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Realm = (Realm) p_Reader.ReadInt32();
			p_Instance.UpdatePass = (EntityUpdateOrder) p_Reader.ReadInt32();
			p_Instance.StartValue = p_Reader.ReadSingle();
			p_Instance.Input = p_Reader.ReadSingle();
			p_Instance.MaxValue = p_Reader.ReadSingle();
			p_Instance.MinValue = p_Reader.ReadSingle();
			p_Instance.Bounded = p_Reader.ReadBool();
			p_Reader.Seek(3, SeekOrigin.Current);
		}

	}
}
