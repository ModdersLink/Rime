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
	[ContainerType(16, 544)]
	public class TransformHubEntityData : 
		EntityData
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public LinearTransform In4 { get; set; } = new();

		[ContainerField(80), Homogeneous, LayoutImmutable, Blittable]
		public LinearTransform In1 { get; set; } = new();

		[ContainerField(144), Homogeneous, LayoutImmutable, Blittable]
		public LinearTransform In2 { get; set; } = new();

		[ContainerField(208), Homogeneous, LayoutImmutable, Blittable]
		public LinearTransform In3 { get; set; } = new();

		[ContainerField(272), Homogeneous, LayoutImmutable, Blittable]
		public LinearTransform In8 { get; set; } = new();

		[ContainerField(336), Homogeneous, LayoutImmutable, Blittable]
		public LinearTransform In5 { get; set; } = new();

		[ContainerField(400), Homogeneous, LayoutImmutable, Blittable]
		public LinearTransform In6 { get; set; } = new();

		[ContainerField(464), Homogeneous, LayoutImmutable, Blittable]
		public LinearTransform In7 { get; set; } = new();

		[ContainerField(528)]
		public Realm Realm { get; set; } = new();

		public static void Deserialize(TransformHubEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Reader.Seek(4, SeekOrigin.Current);
			fb.LinearTransform.Deserialize(p_Instance.In4, p_Reader, p_Parser);
			p_Reader.Seek(4, SeekOrigin.Current);
			fb.LinearTransform.Deserialize(p_Instance.In1, p_Reader, p_Parser);
			p_Reader.Seek(4, SeekOrigin.Current);
			fb.LinearTransform.Deserialize(p_Instance.In2, p_Reader, p_Parser);
			p_Reader.Seek(4, SeekOrigin.Current);
			fb.LinearTransform.Deserialize(p_Instance.In3, p_Reader, p_Parser);
			p_Reader.Seek(4, SeekOrigin.Current);
			fb.LinearTransform.Deserialize(p_Instance.In8, p_Reader, p_Parser);
			p_Reader.Seek(4, SeekOrigin.Current);
			fb.LinearTransform.Deserialize(p_Instance.In5, p_Reader, p_Parser);
			p_Reader.Seek(4, SeekOrigin.Current);
			fb.LinearTransform.Deserialize(p_Instance.In6, p_Reader, p_Parser);
			p_Reader.Seek(4, SeekOrigin.Current);
			fb.LinearTransform.Deserialize(p_Instance.In7, p_Reader, p_Parser);
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.Realm = (Realm) p_Reader.ReadInt32();
			p_Reader.Seek(16, SeekOrigin.Current);
		}

	}
}
