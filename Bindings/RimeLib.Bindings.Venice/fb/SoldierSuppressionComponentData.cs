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
	public class SoldierSuppressionComponentData : 
		ComponentData
	{
		[ContainerField(96)]
		public SuppressionReactionData ReactionToSuppression { get; set; } = new SuppressionReactionData(); // 0x60 (96)
		
		[ContainerField(108), LayoutImmutable, Blittable]
		public float SuppressionResistModifier { get; set; } // 0x6C (108)
		
		[ContainerField(112), LayoutImmutable, Blittable]
		public float SuppressionBoostModifier { get; set; } // 0x70 (112)
		
		[ContainerField(116), LayoutImmutable, Blittable]
		public float SuppressionDecay { get; set; } // 0x74 (116)
		
		[ContainerField(120), LayoutImmutable, Blittable]
		public float SuppressionSphereRadius { get; set; } // 0x78 (120)
		
		[ContainerField(124), LayoutImmutable, Blittable]
		public float FallOffDelay { get; set; } // 0x7C (124)
		
		[ContainerField(128), LayoutImmutable, Blittable]
		public float FallOffMultiplier { get; set; } // 0x80 (128)
		
		[ContainerField(132), LayoutImmutable, Blittable]
		public bool SuppressionAbortsHealthRegeneration { get; set; } // 0x84 (132)
		
		[ContainerField(133), LayoutImmutable, Blittable]
		public bool CheckLineOfSight { get; set; } // 0x85 (133)
		
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
