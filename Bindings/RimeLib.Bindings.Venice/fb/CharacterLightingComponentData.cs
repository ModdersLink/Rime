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
	[ContainerType(16, 160)]
	public class CharacterLightingComponentData : 
		ComponentData
	{
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 BottomLight { get; set; } = new();

		[ContainerField(112), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 TopLight { get; set; } = new();

		[ContainerField(128)]
		public CharacterLightingMode CharacterLightingMode { get; set; } = new();

		[ContainerField(132), LayoutImmutable, Blittable]
		public float CameraUpRotation { get; set; }

		[ContainerField(136), LayoutImmutable, Blittable]
		public float TopLightDirY { get; set; }

		[ContainerField(140), LayoutImmutable, Blittable]
		public float BlendFactor { get; set; }

		[ContainerField(144), LayoutImmutable, Blittable]
		public float TopLightDirX { get; set; }

		[ContainerField(148), LayoutImmutable, Blittable]
		public bool LockToCameraDirection { get; set; }

		[ContainerField(149), LayoutImmutable, Blittable]
		public bool FirstPersonEnable { get; set; }

		[ContainerField(150), LayoutImmutable, Blittable]
		public bool CharacterLightEnable { get; set; }

		public static void Deserialize(CharacterLightingComponentData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.Vec3.Deserialize(p_Instance.BottomLight, p_Reader, p_Parser);
			fb.Vec3.Deserialize(p_Instance.TopLight, p_Reader, p_Parser);
			p_Instance.CharacterLightingMode = (CharacterLightingMode) p_Reader.ReadInt32();
			p_Instance.CameraUpRotation = p_Reader.ReadSingle();
			p_Instance.TopLightDirY = p_Reader.ReadSingle();
			p_Instance.BlendFactor = p_Reader.ReadSingle();
			p_Instance.TopLightDirX = p_Reader.ReadSingle();
			p_Instance.LockToCameraDirection = p_Reader.ReadBool();
			p_Instance.FirstPersonEnable = p_Reader.ReadBool();
			p_Instance.CharacterLightEnable = p_Reader.ReadBool();
			p_Reader.Seek(9, SeekOrigin.Current);
		}

	}
}
