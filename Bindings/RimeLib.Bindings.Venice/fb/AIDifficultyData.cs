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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 36)]
	public class AIDifficultyData : 
		GameAIDifficultyData
	{
		protected string m_Name = string.Empty;
		[ContainerField(Name: "Name", Offset: 8, NameHash: 2088949890, Flags: 16509), LayoutImmutable]
		public string Name { get { return m_Name; } set { if (OnPropertyChanging("AIDifficultyData." + nameof(Name), this, m_Name, value)) m_Name = value; } } // 0x8 (8)
		
		protected float m_AccuracyIncreaseTimeModifier = new float();
		[ContainerField(Name: "AccuracyIncreaseTimeModifier", Offset: 12, NameHash: 3502722014, Flags: 49469), LayoutImmutable, Blittable]
		public float AccuracyIncreaseTimeModifier { get { return m_AccuracyIncreaseTimeModifier; } set { if (OnPropertyChanging("AIDifficultyData." + nameof(AccuracyIncreaseTimeModifier), this, m_AccuracyIncreaseTimeModifier, value)) m_AccuracyIncreaseTimeModifier = value; } } // 0xC (12)
		
		protected float m_StartAccuracyModifierStanding = new float();
		[ContainerField(Name: "StartAccuracyModifierStanding", Offset: 16, NameHash: 2363771747, Flags: 49469), LayoutImmutable, Blittable]
		public float StartAccuracyModifierStanding { get { return m_StartAccuracyModifierStanding; } set { if (OnPropertyChanging("AIDifficultyData." + nameof(StartAccuracyModifierStanding), this, m_StartAccuracyModifierStanding, value)) m_StartAccuracyModifierStanding = value; } } // 0x10 (16)
		
		protected float m_StartAccuracyModifierCrouching = new float();
		[ContainerField(Name: "StartAccuracyModifierCrouching", Offset: 20, NameHash: 1049658063, Flags: 49469), LayoutImmutable, Blittable]
		public float StartAccuracyModifierCrouching { get { return m_StartAccuracyModifierCrouching; } set { if (OnPropertyChanging("AIDifficultyData." + nameof(StartAccuracyModifierCrouching), this, m_StartAccuracyModifierCrouching, value)) m_StartAccuracyModifierCrouching = value; } } // 0x14 (20)
		
		protected float m_FinalAccuracyModifierStanding = new float();
		[ContainerField(Name: "FinalAccuracyModifierStanding", Offset: 24, NameHash: 604575407, Flags: 49469), LayoutImmutable, Blittable]
		public float FinalAccuracyModifierStanding { get { return m_FinalAccuracyModifierStanding; } set { if (OnPropertyChanging("AIDifficultyData." + nameof(FinalAccuracyModifierStanding), this, m_FinalAccuracyModifierStanding, value)) m_FinalAccuracyModifierStanding = value; } } // 0x18 (24)
		
		protected float m_FinalAccuracyModifierCrouching = new float();
		[ContainerField(Name: "FinalAccuracyModifierCrouching", Offset: 28, NameHash: 746968067, Flags: 49469), LayoutImmutable, Blittable]
		public float FinalAccuracyModifierCrouching { get { return m_FinalAccuracyModifierCrouching; } set { if (OnPropertyChanging("AIDifficultyData." + nameof(FinalAccuracyModifierCrouching), this, m_FinalAccuracyModifierCrouching, value)) m_FinalAccuracyModifierCrouching = value; } } // 0x1C (28)
		
		protected float m_ReadinessReactionTimeMultiplier = new float();
		[ContainerField(Name: "ReadinessReactionTimeMultiplier", Offset: 32, NameHash: 2192704706, Flags: 49469), LayoutImmutable, Blittable]
		public float ReadinessReactionTimeMultiplier { get { return m_ReadinessReactionTimeMultiplier; } set { if (OnPropertyChanging("AIDifficultyData." + nameof(ReadinessReactionTimeMultiplier), this, m_ReadinessReactionTimeMultiplier, value)) m_ReadinessReactionTimeMultiplier = value; } } // 0x20 (32)
		
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
