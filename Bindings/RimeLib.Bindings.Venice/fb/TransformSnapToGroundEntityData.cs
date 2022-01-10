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
	[ContainerType(16, 112)]
	public class TransformSnapToGroundEntityData : 
		EntityData
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public LinearTransform In { get; set; } = new();

		[ContainerField(80)]
		public Realm Realm { get; set; } = new();

		[ContainerField(84), LayoutImmutable, Blittable]
		public float DistanceToGround { get; set; }

		[ContainerField(88), LayoutImmutable, Blittable]
		public float RayCastLength { get; set; }

		[ContainerField(92), LayoutImmutable, Blittable]
		public float RayCastUpOffset { get; set; }

		[ContainerField(96), LayoutImmutable, Blittable]
		public bool AlignWithGroundNormal { get; set; }

		public static void Deserialize(TransformSnapToGroundEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Reader.Seek(4, SeekOrigin.Current);
			fb.LinearTransform.Deserialize(p_Instance.In, p_Reader, p_Parser);
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.Realm = (Realm) p_Reader.ReadInt32();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.DistanceToGround = p_Reader.ReadSingle();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.RayCastLength = p_Reader.ReadSingle();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.RayCastUpOffset = p_Reader.ReadSingle();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.AlignWithGroundNormal = p_Reader.ReadBool();
			p_Reader.Seek(19, SeekOrigin.Current);
		}

	}
}
