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
	[ContainerType(16, 192)]
	public class MeshProjectileEntityData : 
		ProjectileEntityData
	{
		[ContainerField(160), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 InitialAngularVelocity { get; set; } = new();

		[ContainerField(176)]
		public CtrRef<EffectBlueprint> TrailEffect { get; set; } = new();

		[ContainerField(180)]
		public CtrRef<MeshAsset> Mesh { get; set; } = new();

		[ContainerField(184), LayoutImmutable, Blittable]
		public float MaxAttachableInclination { get; set; }

		[ContainerField(188), LayoutImmutable, Blittable]
		public bool ExtraDamping { get; set; }

		[ContainerField(189), LayoutImmutable, Blittable]
		public bool IsAttachable { get; set; }

		public static void Deserialize(MeshProjectileEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.Vec3.Deserialize(p_Instance.InitialAngularVelocity, p_Reader, p_Parser);
			p_Instance.TrailEffect.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.Mesh.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.MaxAttachableInclination = p_Reader.ReadSingle();
			p_Instance.ExtraDamping = p_Reader.ReadBool();
			p_Instance.IsAttachable = p_Reader.ReadBool();
			p_Reader.Seek(2, SeekOrigin.Current);
		}

	}
}
