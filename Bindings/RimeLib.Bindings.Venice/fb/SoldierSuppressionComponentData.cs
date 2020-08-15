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
	[ContainerType(16)]
	public class SoldierSuppressionComponentData : 
		ComponentData
	{
		protected SuppressionReactionData m_ReactionToSuppression = new SuppressionReactionData();
		[ContainerField(96), ContainerFieldNameHash(1036156078)]
		public SuppressionReactionData ReactionToSuppression { get { return m_ReactionToSuppression; } set { if (OnPropertyChanging("SoldierSuppressionComponentData." + nameof(ReactionToSuppression), this, m_ReactionToSuppression, value)) m_ReactionToSuppression = value; } } // 0x60 (96)
		
		protected float m_SuppressionResistModifier = new float();
		[ContainerField(108), LayoutImmutable, Blittable, ContainerFieldNameHash(3461455905)]
		public float SuppressionResistModifier { get { return m_SuppressionResistModifier; } set { if (OnPropertyChanging("SoldierSuppressionComponentData." + nameof(SuppressionResistModifier), this, m_SuppressionResistModifier, value)) m_SuppressionResistModifier = value; } } // 0x6C (108)
		
		protected float m_SuppressionBoostModifier = new float();
		[ContainerField(112), LayoutImmutable, Blittable, ContainerFieldNameHash(4083978446)]
		public float SuppressionBoostModifier { get { return m_SuppressionBoostModifier; } set { if (OnPropertyChanging("SoldierSuppressionComponentData." + nameof(SuppressionBoostModifier), this, m_SuppressionBoostModifier, value)) m_SuppressionBoostModifier = value; } } // 0x70 (112)
		
		protected float m_SuppressionDecay = new float();
		[ContainerField(116), LayoutImmutable, Blittable, ContainerFieldNameHash(1965339558)]
		public float SuppressionDecay { get { return m_SuppressionDecay; } set { if (OnPropertyChanging("SoldierSuppressionComponentData." + nameof(SuppressionDecay), this, m_SuppressionDecay, value)) m_SuppressionDecay = value; } } // 0x74 (116)
		
		protected float m_SuppressionSphereRadius = new float();
		[ContainerField(120), LayoutImmutable, Blittable, ContainerFieldNameHash(3282495357)]
		public float SuppressionSphereRadius { get { return m_SuppressionSphereRadius; } set { if (OnPropertyChanging("SoldierSuppressionComponentData." + nameof(SuppressionSphereRadius), this, m_SuppressionSphereRadius, value)) m_SuppressionSphereRadius = value; } } // 0x78 (120)
		
		protected float m_FallOffDelay = new float();
		[ContainerField(124), LayoutImmutable, Blittable, ContainerFieldNameHash(1871543128)]
		public float FallOffDelay { get { return m_FallOffDelay; } set { if (OnPropertyChanging("SoldierSuppressionComponentData." + nameof(FallOffDelay), this, m_FallOffDelay, value)) m_FallOffDelay = value; } } // 0x7C (124)
		
		protected float m_FallOffMultiplier = new float();
		[ContainerField(128), LayoutImmutable, Blittable, ContainerFieldNameHash(795394662)]
		public float FallOffMultiplier { get { return m_FallOffMultiplier; } set { if (OnPropertyChanging("SoldierSuppressionComponentData." + nameof(FallOffMultiplier), this, m_FallOffMultiplier, value)) m_FallOffMultiplier = value; } } // 0x80 (128)
		
		protected bool m_SuppressionAbortsHealthRegeneration = new bool();
		[ContainerField(132), LayoutImmutable, Blittable, ContainerFieldNameHash(1157044392)]
		public bool SuppressionAbortsHealthRegeneration { get { return m_SuppressionAbortsHealthRegeneration; } set { if (OnPropertyChanging("SoldierSuppressionComponentData." + nameof(SuppressionAbortsHealthRegeneration), this, m_SuppressionAbortsHealthRegeneration, value)) m_SuppressionAbortsHealthRegeneration = value; } } // 0x84 (132)
		
		protected bool m_CheckLineOfSight = new bool();
		[ContainerField(133), LayoutImmutable, Blittable, ContainerFieldNameHash(1677951557)]
		public bool CheckLineOfSight { get { return m_CheckLineOfSight; } set { if (OnPropertyChanging("SoldierSuppressionComponentData." + nameof(CheckLineOfSight), this, m_CheckLineOfSight, value)) m_CheckLineOfSight = value; } } // 0x85 (133)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1036156078:
					ReactionToSuppression = (SuppressionReactionData) p_Value;
					break;

				case 3461455905:
					SuppressionResistModifier = (float) p_Value;
					break;

				case 4083978446:
					SuppressionBoostModifier = (float) p_Value;
					break;

				case 1965339558:
					SuppressionDecay = (float) p_Value;
					break;

				case 3282495357:
					SuppressionSphereRadius = (float) p_Value;
					break;

				case 1871543128:
					FallOffDelay = (float) p_Value;
					break;

				case 795394662:
					FallOffMultiplier = (float) p_Value;
					break;

				case 1157044392:
					SuppressionAbortsHealthRegeneration = (bool) p_Value;
					break;

				case 1677951557:
					CheckLineOfSight = (bool) p_Value;
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
				case 1036156078:
					return ReactionToSuppression;

				case 3461455905:
					return SuppressionResistModifier;

				case 4083978446:
					return SuppressionBoostModifier;

				case 1965339558:
					return SuppressionDecay;

				case 3282495357:
					return SuppressionSphereRadius;

				case 1871543128:
					return FallOffDelay;

				case 795394662:
					return FallOffMultiplier;

				case 1157044392:
					return SuppressionAbortsHealthRegeneration;

				case 1677951557:
					return CheckLineOfSight;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1036156078:
					return typeof(SoldierSuppressionComponentData).GetProperty(nameof(ReactionToSuppression));

				case 3461455905:
					return typeof(SoldierSuppressionComponentData).GetProperty(nameof(SuppressionResistModifier));

				case 4083978446:
					return typeof(SoldierSuppressionComponentData).GetProperty(nameof(SuppressionBoostModifier));

				case 1965339558:
					return typeof(SoldierSuppressionComponentData).GetProperty(nameof(SuppressionDecay));

				case 3282495357:
					return typeof(SoldierSuppressionComponentData).GetProperty(nameof(SuppressionSphereRadius));

				case 1871543128:
					return typeof(SoldierSuppressionComponentData).GetProperty(nameof(FallOffDelay));

				case 795394662:
					return typeof(SoldierSuppressionComponentData).GetProperty(nameof(FallOffMultiplier));

				case 1157044392:
					return typeof(SoldierSuppressionComponentData).GetProperty(nameof(SuppressionAbortsHealthRegeneration));

				case 1677951557:
					return typeof(SoldierSuppressionComponentData).GetProperty(nameof(CheckLineOfSight));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
