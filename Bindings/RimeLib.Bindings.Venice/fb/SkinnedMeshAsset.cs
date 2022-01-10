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
	[ContainerType(16, 80)]
	public class SkinnedMeshAsset : 
		MeshAsset
	{
		[ContainerField(48), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 BoundingBoxPositionOffset { get; set; } = new();

		[ContainerField(64), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 BoundingBoxSizeOffset { get; set; } = new();

		public static void Deserialize(SkinnedMeshAsset p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Reader.Seek(8, SeekOrigin.Current);
			fb.Vec3.Deserialize(p_Instance.BoundingBoxPositionOffset, p_Reader, p_Parser);
			p_Reader.Seek(8, SeekOrigin.Current);
			fb.Vec3.Deserialize(p_Instance.BoundingBoxSizeOffset, p_Reader, p_Parser);
			p_Reader.Seek(8, SeekOrigin.Current);
		}

	}
}
