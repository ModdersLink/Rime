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
	[ContainerType(16, 48)]
	public class DebrisClusterPartInfoData
	{
		[ContainerField(0), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 AngularVelocity { get; set; } = new();
		
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 LinearVelocity { get; set; } = new();
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public int NumberOfChildren { get; set; }
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public int PartIndex { get; set; }
		
		[ContainerField(40), LayoutImmutable, Blittable]
		public float SplitSpeedThreshold { get; set; }
		
		[ContainerField(44), LayoutImmutable, Blittable]
		public bool InEffectWorldOnly { get; set; }
		
		[ContainerField(45), LayoutImmutable, Blittable]
		public bool SyncRestPosition { get; set; }
		
		[ContainerField(46), LayoutImmutable, Blittable]
		public bool SyncContinous { get; set; }
		
		public static void Deserialize(DebrisClusterPartInfoData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.Vec3.Deserialize(p_Instance.AngularVelocity, p_Reader, p_Parser);
			fb.Vec3.Deserialize(p_Instance.LinearVelocity, p_Reader, p_Parser);
			p_Instance.NumberOfChildren = p_Reader.ReadInt32();
			p_Instance.PartIndex = p_Reader.ReadInt32();
			p_Instance.SplitSpeedThreshold = p_Reader.ReadSingle();
			p_Instance.InEffectWorldOnly = p_Reader.ReadBool();
			p_Instance.SyncRestPosition = p_Reader.ReadBool();
			p_Instance.SyncContinous = p_Reader.ReadBool();
			p_Reader.Seek(1, SeekOrigin.Current);
		}
	}
}
