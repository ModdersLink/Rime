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
using RimeLib.Serialization.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 4,  Flags: 53, Size: 24)]
	public class MaterialRelationEffectData : 
		PhysicsMaterialRelationPropertyData
	{
		protected RefArray<EffectBlueprint> m_ImpactEffects = new RefArray<EffectBlueprint>();
		[ContainerField(Name: "ImpactEffects", Offset: 8, NameHash: 2149182307, Flags: 65)]
		public RefArray<EffectBlueprint> ImpactEffects { get { return m_ImpactEffects; } set { if (OnPropertyChanging("MaterialRelationEffectData." + nameof(ImpactEffects), this, m_ImpactEffects, value)) m_ImpactEffects = value; } } // 0x8 (8)
		
		protected RefArray<ObjectBlueprint> m_ImpactDebris = new RefArray<ObjectBlueprint>();
		[ContainerField(Name: "ImpactDebris", Offset: 12, NameHash: 2118798188, Flags: 65)]
		public RefArray<ObjectBlueprint> ImpactDebris { get { return m_ImpactDebris; } set { if (OnPropertyChanging("MaterialRelationEffectData." + nameof(ImpactDebris), this, m_ImpactDebris, value)) m_ImpactDebris = value; } } // 0xC (12)
		
		protected float m_ImpactEffectMaxSpreadAngle = new float();
		[ContainerField(Name: "ImpactEffectMaxSpreadAngle", Offset: 16, NameHash: 3809186484, Flags: 49469), LayoutImmutable, Blittable]
		public float ImpactEffectMaxSpreadAngle { get { return m_ImpactEffectMaxSpreadAngle; } set { if (OnPropertyChanging("MaterialRelationEffectData." + nameof(ImpactEffectMaxSpreadAngle), this, m_ImpactEffectMaxSpreadAngle, value)) m_ImpactEffectMaxSpreadAngle = value; } } // 0x10 (16)
		
		protected bool m_MirrorImpactDirection = new bool();
		[ContainerField(Name: "MirrorImpactDirection", Offset: 20, NameHash: 559662331, Flags: 49325), LayoutImmutable, Blittable]
		public bool MirrorImpactDirection { get { return m_MirrorImpactDirection; } set { if (OnPropertyChanging("MaterialRelationEffectData." + nameof(MirrorImpactDirection), this, m_MirrorImpactDirection, value)) m_MirrorImpactDirection = value; } } // 0x14 (20)
		
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
