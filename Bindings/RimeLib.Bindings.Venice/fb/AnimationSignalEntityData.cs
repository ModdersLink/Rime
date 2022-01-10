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
	public class AnimationSignalEntityData : 
		EntityData
	{
		[ContainerField(12)]
		public Realm Realm { get; set; } = new();

		[ContainerField(16)]
		public AntRef Signal { get; set; } = new();

		[ContainerField(20)]
		public AntRef IntGameState { get; set; } = new();

		[ContainerField(24)]
		public AntRef FloatGameState { get; set; } = new();

		[ContainerField(28), LayoutImmutable, Blittable]
		public int ValueInt { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable]
		public float ValueFloat { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable]
		public bool Reset { get; set; }

		[ContainerField(37), LayoutImmutable, Blittable]
		public bool Continuous { get; set; }

		public static void Deserialize(AnimationSignalEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Realm = (Realm) p_Reader.ReadInt32();
			fb.AntRef.Deserialize(p_Instance.Signal, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.IntGameState, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.FloatGameState, p_Reader, p_Parser);
			p_Instance.ValueInt = p_Reader.ReadInt32();
			p_Instance.ValueFloat = p_Reader.ReadSingle();
			p_Instance.Reset = p_Reader.ReadBool();
			p_Instance.Continuous = p_Reader.ReadBool();
			p_Reader.Seek(2, SeekOrigin.Current);
		}

	}
}
