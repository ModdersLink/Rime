///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class MeshProjectileEntityData : 
		ProjectileEntityData
	{
		[ContainerField(160), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 InitialAngularVelocity { get; set; } = new Vec3(); // 0xA0 (160)
		
		[ContainerField(176)]
		public CtrRef<EffectBlueprint> TrailEffect { get; set; } = new CtrRef<EffectBlueprint>(); // 0xB0 (176)
		
		[ContainerField(180)]
		public CtrRef<MeshAsset> Mesh { get; set; } = new CtrRef<MeshAsset>(); // 0xB4 (180)
		
		[ContainerField(184), LayoutImmutable, Blittable]
		public float MaxAttachableInclination { get; set; } // 0xB8 (184)
		
		[ContainerField(188), LayoutImmutable, Blittable]
		public bool ExtraDamping { get; set; } // 0xBC (188)
		
		[ContainerField(189), LayoutImmutable, Blittable]
		public bool IsAttachable { get; set; } // 0xBD (189)
		
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
