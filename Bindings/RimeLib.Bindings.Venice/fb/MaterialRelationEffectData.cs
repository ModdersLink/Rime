///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class MaterialRelationEffectData : 
		PhysicsMaterialRelationPropertyData
	{
		[ContainerField(8)]
		public RefArray<EffectBlueprint> ImpactEffects { get; set; } = new RefArray<EffectBlueprint>(); // 0x8 (8)
		
		[ContainerField(12)]
		public RefArray<ObjectBlueprint> ImpactDebris { get; set; } = new RefArray<ObjectBlueprint>(); // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float ImpactEffectMaxSpreadAngle { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public bool MirrorImpactDirection { get; set; } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2149182307:
					ImpactEffects = (RefArray<EffectBlueprint>) p_Value;
					break;

				case 2118798188:
					ImpactDebris = (RefArray<ObjectBlueprint>) p_Value;
					break;

				case 3809186484:
					ImpactEffectMaxSpreadAngle = (float) p_Value;
					break;

				case 559662331:
					MirrorImpactDirection = (bool) p_Value;
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
				case 2149182307:
					return ImpactEffects;

				case 2118798188:
					return ImpactDebris;

				case 3809186484:
					return ImpactEffectMaxSpreadAngle;

				case 559662331:
					return MirrorImpactDirection;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2149182307:
					return typeof(MaterialRelationEffectData).GetProperty(nameof(ImpactEffects));

				case 2118798188:
					return typeof(MaterialRelationEffectData).GetProperty(nameof(ImpactDebris));

				case 3809186484:
					return typeof(MaterialRelationEffectData).GetProperty(nameof(ImpactEffectMaxSpreadAngle));

				case 559662331:
					return typeof(MaterialRelationEffectData).GetProperty(nameof(MirrorImpactDirection));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
