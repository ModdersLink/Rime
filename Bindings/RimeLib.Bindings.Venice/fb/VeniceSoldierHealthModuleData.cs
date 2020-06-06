///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class VeniceSoldierHealthModuleData : 
		SoldierHealthModuleData
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public float TimeForCorpse { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public float PostReviveResponseTime { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float InteractiveManDownThreshold { get; set; } // 0x10 (16)
		
		[ContainerField(20)]
		public PoseConstraintsData InteractiveManDownPoseConstraints { get; set; } = new PoseConstraintsData(); // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public float ManDownStateTime { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public float ManDownStateHealthPoints { get; set; } // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public float ImmortalTimeAfterSpawn { get; set; } // 0x20 (32)
		
		[ContainerField(36)]
		public List<EntryInputActionEnum> AbortSpawnImmortalityInputs { get; set; } = new List<EntryInputActionEnum>(); // 0x24 (36)
		
		[ContainerField(40), LayoutImmutable, Blittable]
		public float PostReviveHealth { get; set; } // 0x28 (40)
		
		[ContainerField(44), LayoutImmutable, Blittable]
		public float CriticalFakeImmortalTime { get; set; } // 0x2C (44)
		
		[ContainerField(48), LayoutImmutable, Blittable]
		public float RegenerationDelay { get; set; } // 0x30 (48)
		
		[ContainerField(52), LayoutImmutable, Blittable]
		public float RegenerationRate { get; set; } // 0x34 (52)
		
		[ContainerField(56)]
		public SoldierHealthModuleBinding Binding { get; set; } = new SoldierHealthModuleBinding(); // 0x38 (56)
		
		[ContainerField(148), LayoutImmutable, Blittable]
		public float SprintDisabledWhenDamagedTime { get; set; } // 0x94 (148)
		
		[ContainerField(152), LayoutImmutable, Blittable]
		public float SprintDisabledDamageThreshold { get; set; } // 0x98 (152)
		
		[ContainerField(156)]
		public RotateToHitData ManDownRotate { get; set; } = new RotateToHitData(); // 0x9C (156)
		
		[ContainerField(160), LayoutImmutable, Blittable]
		public bool InteractiveManDown { get; set; } // 0xA0 (160)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 418744275:
					TimeForCorpse = (float) p_Value;
					break;

				case 3260283824:
					PostReviveResponseTime = (float) p_Value;
					break;

				case 1025820778:
					InteractiveManDownThreshold = (float) p_Value;
					break;

				case 815478402:
					InteractiveManDownPoseConstraints = (PoseConstraintsData) p_Value;
					break;

				case 1512464055:
					ManDownStateTime = (float) p_Value;
					break;

				case 213646753:
					ManDownStateHealthPoints = (float) p_Value;
					break;

				case 3806880002:
					ImmortalTimeAfterSpawn = (float) p_Value;
					break;

				case 1625311224:
					if (p_Value.GetType() == typeof (List<uint>))
						AbortSpawnImmortalityInputs = ((List<uint>) p_Value).Select(x => (EntryInputActionEnum) Enum.ToObject(typeof(EntryInputActionEnum), x)).ToList();
					else
						AbortSpawnImmortalityInputs = (List<EntryInputActionEnum>) p_Value;
					break;

				case 690951482:
					PostReviveHealth = (float) p_Value;
					break;

				case 1400664383:
					CriticalFakeImmortalTime = (float) p_Value;
					break;

				case 778753505:
					RegenerationDelay = (float) p_Value;
					break;

				case 3407288278:
					RegenerationRate = (float) p_Value;
					break;

				case 2590060228:
					Binding = (SoldierHealthModuleBinding) p_Value;
					break;

				case 261615897:
					SprintDisabledWhenDamagedTime = (float) p_Value;
					break;

				case 2813834027:
					SprintDisabledDamageThreshold = (float) p_Value;
					break;

				case 2801100780:
					ManDownRotate = (RotateToHitData) p_Value;
					break;

				case 701073533:
					InteractiveManDown = (bool) p_Value;
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
				case 418744275:
					return TimeForCorpse;

				case 3260283824:
					return PostReviveResponseTime;

				case 1025820778:
					return InteractiveManDownThreshold;

				case 815478402:
					return InteractiveManDownPoseConstraints;

				case 1512464055:
					return ManDownStateTime;

				case 213646753:
					return ManDownStateHealthPoints;

				case 3806880002:
					return ImmortalTimeAfterSpawn;

				case 1625311224:
					return AbortSpawnImmortalityInputs;

				case 690951482:
					return PostReviveHealth;

				case 1400664383:
					return CriticalFakeImmortalTime;

				case 778753505:
					return RegenerationDelay;

				case 3407288278:
					return RegenerationRate;

				case 2590060228:
					return Binding;

				case 261615897:
					return SprintDisabledWhenDamagedTime;

				case 2813834027:
					return SprintDisabledDamageThreshold;

				case 2801100780:
					return ManDownRotate;

				case 701073533:
					return InteractiveManDown;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 418744275:
					return typeof(VeniceSoldierHealthModuleData).GetProperty(nameof(TimeForCorpse));

				case 3260283824:
					return typeof(VeniceSoldierHealthModuleData).GetProperty(nameof(PostReviveResponseTime));

				case 1025820778:
					return typeof(VeniceSoldierHealthModuleData).GetProperty(nameof(InteractiveManDownThreshold));

				case 815478402:
					return typeof(VeniceSoldierHealthModuleData).GetProperty(nameof(InteractiveManDownPoseConstraints));

				case 1512464055:
					return typeof(VeniceSoldierHealthModuleData).GetProperty(nameof(ManDownStateTime));

				case 213646753:
					return typeof(VeniceSoldierHealthModuleData).GetProperty(nameof(ManDownStateHealthPoints));

				case 3806880002:
					return typeof(VeniceSoldierHealthModuleData).GetProperty(nameof(ImmortalTimeAfterSpawn));

				case 1625311224:
					return typeof(VeniceSoldierHealthModuleData).GetProperty(nameof(AbortSpawnImmortalityInputs));

				case 690951482:
					return typeof(VeniceSoldierHealthModuleData).GetProperty(nameof(PostReviveHealth));

				case 1400664383:
					return typeof(VeniceSoldierHealthModuleData).GetProperty(nameof(CriticalFakeImmortalTime));

				case 778753505:
					return typeof(VeniceSoldierHealthModuleData).GetProperty(nameof(RegenerationDelay));

				case 3407288278:
					return typeof(VeniceSoldierHealthModuleData).GetProperty(nameof(RegenerationRate));

				case 2590060228:
					return typeof(VeniceSoldierHealthModuleData).GetProperty(nameof(Binding));

				case 261615897:
					return typeof(VeniceSoldierHealthModuleData).GetProperty(nameof(SprintDisabledWhenDamagedTime));

				case 2813834027:
					return typeof(VeniceSoldierHealthModuleData).GetProperty(nameof(SprintDisabledDamageThreshold));

				case 2801100780:
					return typeof(VeniceSoldierHealthModuleData).GetProperty(nameof(ManDownRotate));

				case 701073533:
					return typeof(VeniceSoldierHealthModuleData).GetProperty(nameof(InteractiveManDown));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
