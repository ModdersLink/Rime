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
	public class AIDifficultyData : 
		GameAIDifficultyData
	{
		[ContainerField(8), LayoutImmutable]
		public string Name { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public float AccuracyIncreaseTimeModifier { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float StartAccuracyModifierStanding { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float StartAccuracyModifierCrouching { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public float FinalAccuracyModifierStanding { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public float FinalAccuracyModifierCrouching { get; set; } // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public float ReadinessReactionTimeMultiplier { get; set; } // 0x20 (32)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2088949890:
					Name = (string) p_Value;
					break;

				case 3502722014:
					AccuracyIncreaseTimeModifier = (float) p_Value;
					break;

				case 2363771747:
					StartAccuracyModifierStanding = (float) p_Value;
					break;

				case 1049658063:
					StartAccuracyModifierCrouching = (float) p_Value;
					break;

				case 604575407:
					FinalAccuracyModifierStanding = (float) p_Value;
					break;

				case 746968067:
					FinalAccuracyModifierCrouching = (float) p_Value;
					break;

				case 2192704706:
					ReadinessReactionTimeMultiplier = (float) p_Value;
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
				case 2088949890:
					return Name;

				case 3502722014:
					return AccuracyIncreaseTimeModifier;

				case 2363771747:
					return StartAccuracyModifierStanding;

				case 1049658063:
					return StartAccuracyModifierCrouching;

				case 604575407:
					return FinalAccuracyModifierStanding;

				case 746968067:
					return FinalAccuracyModifierCrouching;

				case 2192704706:
					return ReadinessReactionTimeMultiplier;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2088949890:
					return typeof(AIDifficultyData).GetProperty(nameof(Name));

				case 3502722014:
					return typeof(AIDifficultyData).GetProperty(nameof(AccuracyIncreaseTimeModifier));

				case 2363771747:
					return typeof(AIDifficultyData).GetProperty(nameof(StartAccuracyModifierStanding));

				case 1049658063:
					return typeof(AIDifficultyData).GetProperty(nameof(StartAccuracyModifierCrouching));

				case 604575407:
					return typeof(AIDifficultyData).GetProperty(nameof(FinalAccuracyModifierStanding));

				case 746968067:
					return typeof(AIDifficultyData).GetProperty(nameof(FinalAccuracyModifierCrouching));

				case 2192704706:
					return typeof(AIDifficultyData).GetProperty(nameof(ReadinessReactionTimeMultiplier));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
