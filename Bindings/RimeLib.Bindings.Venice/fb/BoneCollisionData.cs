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
	public class BoneCollisionData
	{
		[ContainerField(0), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 DebugDrawColor { get; set; } = new();
		
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 CapsuleOffset { get; set; } = new();
		
		[ContainerField(32), LayoutImmutable]
		public string BoneName { get; set; } = string.Empty;
		
		[ContainerField(36)]
		public HitReactionType AnimationHitReactionType { get; set; } = new();
		
		[ContainerField(40)]
		public CtrRef<MaterialContainerPair> MaterialPair { get; set; } = new();
		
		[ContainerField(44), LayoutImmutable, Blittable]
		public int BoneAxis { get; set; }
		
		[ContainerField(48), LayoutImmutable, Blittable]
		public float CapsuleLength { get; set; }
		
		[ContainerField(52), LayoutImmutable, Blittable]
		public float CapsuleRadius { get; set; }
		
		[ContainerField(64)]
		public PitchModifier MinPitch { get; set; } = new();
		
		[ContainerField(96)]
		public PitchModifier MaxPitch { get; set; } = new();
		
		[ContainerField(128), LayoutImmutable, Blittable]
		public bool ValidInHiLod { get; set; }
		
		[ContainerField(129), LayoutImmutable, Blittable]
		public bool ValidInLowLod { get; set; }
		
		[ContainerField(130), LayoutImmutable, Blittable]
		public bool UsePhysicsRotation { get; set; }
		
		[ContainerField(131), LayoutImmutable, Blittable]
		public bool DeactivateIfBehindWall { get; set; }
		
		public static void Deserialize(BoneCollisionData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.Vec4.Deserialize(p_Instance.DebugDrawColor, p_Reader, p_Parser);
			fb.Vec3.Deserialize(p_Instance.CapsuleOffset, p_Reader, p_Parser);
			p_Instance.BoneName = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.AnimationHitReactionType = (HitReactionType) p_Reader.ReadInt32();
			p_Instance.MaterialPair.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.BoneAxis = p_Reader.ReadInt32();
			p_Instance.CapsuleLength = p_Reader.ReadSingle();
			p_Instance.CapsuleRadius = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			fb.PitchModifier.Deserialize(p_Instance.MinPitch, p_Reader, p_Parser);
			p_Reader.Seek(8, SeekOrigin.Current);
			fb.PitchModifier.Deserialize(p_Instance.MaxPitch, p_Reader, p_Parser);
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.ValidInHiLod = p_Reader.ReadBool();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.ValidInLowLod = p_Reader.ReadBool();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.UsePhysicsRotation = p_Reader.ReadBool();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.DeactivateIfBehindWall = p_Reader.ReadBool();
			p_Reader.Seek(20, SeekOrigin.Current);
		}
	}
}
