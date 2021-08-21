///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using RimeLib.IO;
using RimeLib.Frostbite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Reflection;
using RimeLib.Serialization.Attributes;
using RimeLib.Frostbite.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 16,  Flags: 53, Size: 192)]
	public class MeshProjectileEntityData : 
		ProjectileEntityData
	{
		protected Vec3 m_InitialAngularVelocity = new Vec3();
		[ContainerField(Name: "InitialAngularVelocity", Offset: 160, NameHash: 2385892654, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 InitialAngularVelocity { get { return m_InitialAngularVelocity; } set { if (OnPropertyChanging("MeshProjectileEntityData." + nameof(InitialAngularVelocity), this, m_InitialAngularVelocity, value)) m_InitialAngularVelocity = value; } } // 0xA0 (160)
		
		protected CtrRef<EffectBlueprint> m_TrailEffect = new CtrRef<EffectBlueprint>();
		[ContainerField(Name: "TrailEffect", Offset: 176, NameHash: 3334711472, Flags: 53)]
		public CtrRef<EffectBlueprint> TrailEffect { get { return m_TrailEffect; } set { if (OnPropertyChanging("MeshProjectileEntityData." + nameof(TrailEffect), this, m_TrailEffect, value)) m_TrailEffect = value; } } // 0xB0 (176)
		
		protected CtrRef<MeshAsset> m_Mesh = new CtrRef<MeshAsset>();
		[ContainerField(Name: "Mesh", Offset: 180, NameHash: 2088783990, Flags: 53)]
		public CtrRef<MeshAsset> Mesh { get { return m_Mesh; } set { if (OnPropertyChanging("MeshProjectileEntityData." + nameof(Mesh), this, m_Mesh, value)) m_Mesh = value; } } // 0xB4 (180)
		
		protected float m_MaxAttachableInclination = new float();
		[ContainerField(Name: "MaxAttachableInclination", Offset: 184, NameHash: 39813154, Flags: 49469), LayoutImmutable, Blittable]
		public float MaxAttachableInclination { get { return m_MaxAttachableInclination; } set { if (OnPropertyChanging("MeshProjectileEntityData." + nameof(MaxAttachableInclination), this, m_MaxAttachableInclination, value)) m_MaxAttachableInclination = value; } } // 0xB8 (184)
		
		protected bool m_ExtraDamping = new bool();
		[ContainerField(Name: "ExtraDamping", Offset: 188, NameHash: 2980785831, Flags: 49325), LayoutImmutable, Blittable]
		public bool ExtraDamping { get { return m_ExtraDamping; } set { if (OnPropertyChanging("MeshProjectileEntityData." + nameof(ExtraDamping), this, m_ExtraDamping, value)) m_ExtraDamping = value; } } // 0xBC (188)
		
		protected bool m_IsAttachable = new bool();
		[ContainerField(Name: "IsAttachable", Offset: 189, NameHash: 2068890974, Flags: 49325), LayoutImmutable, Blittable]
		public bool IsAttachable { get { return m_IsAttachable; } set { if (OnPropertyChanging("MeshProjectileEntityData." + nameof(IsAttachable), this, m_IsAttachable, value)) m_IsAttachable = value; } } // 0xBD (189)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2385892654:
					InitialAngularVelocity = (Vec3) p_Value;
					break;

				case 3334711472:
					TrailEffect = (CtrRef<EffectBlueprint>) p_Value;
					break;

				case 2088783990:
					Mesh = (CtrRef<MeshAsset>) p_Value;
					break;

				case 39813154:
					MaxAttachableInclination = (float) p_Value;
					break;

				case 2980785831:
					ExtraDamping = (bool) p_Value;
					break;

				case 2068890974:
					IsAttachable = (bool) p_Value;
					break;

				default:
					base.Bind(p_Descriptor, p_Value);
					break;
			}
		}

		public override object GetFieldValueByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2385892654:
					return InitialAngularVelocity;

				case 3334711472:
					return TrailEffect;

				case 2088783990:
					return Mesh;

				case 39813154:
					return MaxAttachableInclination;

				case 2980785831:
					return ExtraDamping;

				case 2068890974:
					return IsAttachable;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2385892654:
					return typeof(MeshProjectileEntityData).GetProperty(nameof(InitialAngularVelocity));

				case 3334711472:
					return typeof(MeshProjectileEntityData).GetProperty(nameof(TrailEffect));

				case 2088783990:
					return typeof(MeshProjectileEntityData).GetProperty(nameof(Mesh));

				case 39813154:
					return typeof(MeshProjectileEntityData).GetProperty(nameof(MaxAttachableInclination));

				case 2980785831:
					return typeof(MeshProjectileEntityData).GetProperty(nameof(ExtraDamping));

				case 2068890974:
					return typeof(MeshProjectileEntityData).GetProperty(nameof(IsAttachable));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
