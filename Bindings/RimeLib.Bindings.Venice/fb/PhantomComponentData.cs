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
	public class PhantomComponentData : 
		ComponentData
	{
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 BoxSize { get; set; } = new();

		[ContainerField(112)]
		public AntRef AsyncQueryPointerAsset { get; set; } = new();

		[ContainerField(116)]
		public AntRef EnableTrajectoryOverride { get; set; } = new();

		[ContainerField(120)]
		public AntRef TrajectoryOverride { get; set; } = new();

		public static void Deserialize(PhantomComponentData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.Vec3.Deserialize(p_Instance.BoxSize, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.AsyncQueryPointerAsset, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.EnableTrajectoryOverride, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.TrajectoryOverride, p_Reader, p_Parser);
			p_Reader.Seek(4, SeekOrigin.Current);
		}

	}
}
