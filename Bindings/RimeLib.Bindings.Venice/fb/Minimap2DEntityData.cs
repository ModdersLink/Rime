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
	[ContainerType(16, 144)]
	public class Minimap2DEntityData : 
		GameEntityData
	{
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 CameraTransform { get; set; } = new();

		[ContainerField(112), LayoutImmutable, Blittable]
		public uint ImageHeight { get; set; }

		[ContainerField(116), LayoutImmutable, Blittable]
		public uint ImageWidth { get; set; }

		[ContainerField(120), LayoutImmutable, Blittable]
		public uint AntialiasMultiplier { get; set; }

		[ContainerField(124), LayoutImmutable, Blittable]
		public uint TerrainHeight { get; set; }

		[ContainerField(128), LayoutImmutable, Blittable]
		public uint Fov { get; set; }

		public static void Deserialize(Minimap2DEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.Vec3.Deserialize(p_Instance.CameraTransform, p_Reader, p_Parser);
			p_Instance.ImageHeight = p_Reader.ReadUInt32();
			p_Instance.ImageWidth = p_Reader.ReadUInt32();
			p_Instance.AntialiasMultiplier = p_Reader.ReadUInt32();
			p_Instance.TerrainHeight = p_Reader.ReadUInt32();
			p_Instance.Fov = p_Reader.ReadUInt32();
			p_Reader.Seek(12, SeekOrigin.Current);
		}

	}
}
