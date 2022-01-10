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
	[ContainerType(16, 64)]
	public class VehicleSpawnStateEntityData : 
		EntityData
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 InitialVelocity { get; set; } = new();

		[ContainerField(32), LayoutImmutable, Blittable]
		public float StartupDelayModifier { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable]
		public float InitialThrottle { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable]
		public uint EngineIndex { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable]
		public float InitialRpmModifier { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable]
		public float HeightOffset { get; set; }

		[ContainerField(52), LayoutImmutable, Blittable]
		public float Radius { get; set; }

		public static void Deserialize(VehicleSpawnStateEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Reader.Seek(4, SeekOrigin.Current);
			fb.Vec3.Deserialize(p_Instance.InitialVelocity, p_Reader, p_Parser);
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.StartupDelayModifier = p_Reader.ReadSingle();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.InitialThrottle = p_Reader.ReadSingle();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.EngineIndex = p_Reader.ReadUInt32();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.InitialRpmModifier = p_Reader.ReadSingle();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.HeightOffset = p_Reader.ReadSingle();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.Radius = p_Reader.ReadSingle();
			p_Reader.Seek(12, SeekOrigin.Current);
		}

	}
}
