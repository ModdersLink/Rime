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
	public class RigidBodyData : 
		DataContainer
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 InertiaModifier { get; set; } = new();

		[ContainerField(32)]
		public RigidBodyType RigidBodyType { get; set; } = new();

		[ContainerField(36), LayoutImmutable, Blittable]
		public float Mass { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable]
		public float Restitution { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable]
		public float Friction { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable]
		public float AngularVelocityDamping { get; set; }

		[ContainerField(52), LayoutImmutable, Blittable]
		public float LinearVelocityDamping { get; set; }

		[ContainerField(56), LayoutImmutable, Blittable]
		public uint InteractionToolkitCollisionVolumeId { get; set; }

		[ContainerField(60)]
		public RigidBodyMotionType MotionType { get; set; } = new();

		[ContainerField(64)]
		public RigidBodyQualityType QualityType { get; set; } = new();

		[ContainerField(68)]
		public RigidBodyCollisionLayer CollisionLayer { get; set; } = new();

		[ContainerField(72)]
		public CtrRef<FloatPhysicsData> FloatPhysics { get; set; } = new();

		[ContainerField(76)]
		public List<CtrRef<RigidBodyConstraintData>> Constraints { get; set; } = new();

		public static void Deserialize(RigidBodyData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Reader.Seek(8, SeekOrigin.Current);
			fb.Vec3.Deserialize(p_Instance.InertiaModifier, p_Reader, p_Parser);
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.RigidBodyType = (RigidBodyType) p_Reader.ReadInt32();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.Mass = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.Restitution = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.Friction = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.AngularVelocityDamping = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.LinearVelocityDamping = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.InteractionToolkitCollisionVolumeId = p_Reader.ReadUInt32();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.MotionType = (RigidBodyMotionType) p_Reader.ReadInt32();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.QualityType = (RigidBodyQualityType) p_Reader.ReadInt32();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.CollisionLayer = (RigidBodyCollisionLayer) p_Reader.ReadInt32();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.FloatPhysics.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.Constraints.Clear();
			(RimeReader Reader, uint Count) s_Constraints = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Constraints.Count; ++i)
			{
				var s_CtrRef = new CtrRef<RigidBodyConstraintData>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_Constraints.Reader.ReadUInt32()));
				p_Instance.Constraints.Add(s_CtrRef);
			}
			
			s_Constraints.Reader.Dispose();
			p_Reader.Seek(8, SeekOrigin.Current);
		}

	}
}
