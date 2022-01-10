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
	[ContainerType(16, 96)]
	public class TransformSplitterEntityData : 
		EntityData
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public LinearTransform Transform { get; set; } = new();

		[ContainerField(80)]
		public Realm Realm { get; set; } = new();

		public static void Deserialize(TransformSplitterEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Reader.Seek(4, SeekOrigin.Current);
			fb.LinearTransform.Deserialize(p_Instance.Transform, p_Reader, p_Parser);
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.Realm = (Realm) p_Reader.ReadInt32();
			p_Reader.Seek(16, SeekOrigin.Current);
		}

	}
}
