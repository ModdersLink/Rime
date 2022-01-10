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
	public class PhysicsEntityData : 
		EntityData
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 InertiaModifier { get; set; } = new();

		[ContainerField(32)]
		public List<CtrRef<HavokAsset>> ScaledAssets { get; set; } = new();

		[ContainerField(36)]
		public List<CtrRef<RigidBodyData>> RigidBodies { get; set; } = new();

		[ContainerField(40)]
		public CtrRef<HavokAsset> Asset { get; set; } = new();

		[ContainerField(44)]
		public CtrRef<FloatPhysicsData> FloatPhysics { get; set; } = new();

		[ContainerField(48), LayoutImmutable, Blittable]
		public float Mass { get; set; }

		[ContainerField(52), LayoutImmutable, Blittable]
		public float Restitution { get; set; }

		[ContainerField(56), LayoutImmutable, Blittable]
		public float Friction { get; set; }

		[ContainerField(60), LayoutImmutable, Blittable]
		public float LinearVelocityDamping { get; set; }

		[ContainerField(64), LayoutImmutable, Blittable]
		public float AngularVelocityDamping { get; set; }

		[ContainerField(68)]
		public CtrRef<ProximityData> Proximity { get; set; } = new();

		[ContainerField(72)]
		public List<CtrRef<RigidBodyConstraintData>> Constraints { get; set; } = new();

		[ContainerField(76), LayoutImmutable, Blittable]
		public bool EncapsulatePartsInLists { get; set; }

		[ContainerField(77), LayoutImmutable, Blittable]
		public bool MovableParts { get; set; }

		public static void Deserialize(PhysicsEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Reader.Seek(4, SeekOrigin.Current);
			fb.Vec3.Deserialize(p_Instance.InertiaModifier, p_Reader, p_Parser);
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.ScaledAssets.Clear();
			(RimeReader Reader, uint Count) s_ScaledAssets = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_ScaledAssets.Count; ++i)
			{
				var s_CtrRef = new CtrRef<HavokAsset>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_ScaledAssets.Reader.ReadUInt32()));
				p_Instance.ScaledAssets.Add(s_CtrRef);
			}
			
			s_ScaledAssets.Reader.Dispose();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.RigidBodies.Clear();
			(RimeReader Reader, uint Count) s_RigidBodies = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_RigidBodies.Count; ++i)
			{
				var s_CtrRef = new CtrRef<RigidBodyData>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_RigidBodies.Reader.ReadUInt32()));
				p_Instance.RigidBodies.Add(s_CtrRef);
			}
			
			s_RigidBodies.Reader.Dispose();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.Asset.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.FloatPhysics.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.Mass = p_Reader.ReadSingle();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.Restitution = p_Reader.ReadSingle();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.Friction = p_Reader.ReadSingle();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.LinearVelocityDamping = p_Reader.ReadSingle();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.AngularVelocityDamping = p_Reader.ReadSingle();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.Proximity.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.Constraints.Clear();
			(RimeReader Reader, uint Count) s_Constraints = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Constraints.Count; ++i)
			{
				var s_CtrRef = new CtrRef<RigidBodyConstraintData>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_Constraints.Reader.ReadUInt32()));
				p_Instance.Constraints.Add(s_CtrRef);
			}
			
			s_Constraints.Reader.Dispose();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.EncapsulatePartsInLists = p_Reader.ReadBool();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.MovableParts = p_Reader.ReadBool();
			p_Reader.Seek(6, SeekOrigin.Current);
		}

	}
}
