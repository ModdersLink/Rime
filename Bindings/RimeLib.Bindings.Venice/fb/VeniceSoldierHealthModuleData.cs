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
	[ContainerType(4)]
	public class VeniceSoldierHealthModuleData : 
		SoldierHealthModuleData
	{
		protected float m_TimeForCorpse = new float();
		[ContainerField(8), LayoutImmutable, Blittable, ContainerFieldNameHash(418744275)]
		public float TimeForCorpse { get { return m_TimeForCorpse; } set { if (OnPropertyChanging("VeniceSoldierHealthModuleData." + nameof(TimeForCorpse), this, m_TimeForCorpse, value)) m_TimeForCorpse = value; } } // 0x8 (8)
		
		protected float m_PostReviveResponseTime = new float();
		[ContainerField(12), LayoutImmutable, Blittable, ContainerFieldNameHash(3260283824)]
		public float PostReviveResponseTime { get { return m_PostReviveResponseTime; } set { if (OnPropertyChanging("VeniceSoldierHealthModuleData." + nameof(PostReviveResponseTime), this, m_PostReviveResponseTime, value)) m_PostReviveResponseTime = value; } } // 0xC (12)
		
		protected float m_InteractiveManDownThreshold = new float();
		[ContainerField(16), LayoutImmutable, Blittable, ContainerFieldNameHash(1025820778)]
		public float InteractiveManDownThreshold { get { return m_InteractiveManDownThreshold; } set { if (OnPropertyChanging("VeniceSoldierHealthModuleData." + nameof(InteractiveManDownThreshold), this, m_InteractiveManDownThreshold, value)) m_InteractiveManDownThreshold = value; } } // 0x10 (16)
		
		protected PoseConstraintsData m_InteractiveManDownPoseConstraints = new PoseConstraintsData();
		[ContainerField(20), ContainerFieldNameHash(815478402)]
		public PoseConstraintsData InteractiveManDownPoseConstraints { get { return m_InteractiveManDownPoseConstraints; } set { if (OnPropertyChanging("VeniceSoldierHealthModuleData." + nameof(InteractiveManDownPoseConstraints), this, m_InteractiveManDownPoseConstraints, value)) m_InteractiveManDownPoseConstraints = value; } } // 0x14 (20)
		
		protected float m_ManDownStateTime = new float();
		[ContainerField(24), LayoutImmutable, Blittable, ContainerFieldNameHash(1512464055)]
		public float ManDownStateTime { get { return m_ManDownStateTime; } set { if (OnPropertyChanging("VeniceSoldierHealthModuleData." + nameof(ManDownStateTime), this, m_ManDownStateTime, value)) m_ManDownStateTime = value; } } // 0x18 (24)
		
		protected float m_ManDownStateHealthPoints = new float();
		[ContainerField(28), LayoutImmutable, Blittable, ContainerFieldNameHash(213646753)]
		public float ManDownStateHealthPoints { get { return m_ManDownStateHealthPoints; } set { if (OnPropertyChanging("VeniceSoldierHealthModuleData." + nameof(ManDownStateHealthPoints), this, m_ManDownStateHealthPoints, value)) m_ManDownStateHealthPoints = value; } } // 0x1C (28)
		
		protected float m_ImmortalTimeAfterSpawn = new float();
		[ContainerField(32), LayoutImmutable, Blittable, ContainerFieldNameHash(3806880002)]
		public float ImmortalTimeAfterSpawn { get { return m_ImmortalTimeAfterSpawn; } set { if (OnPropertyChanging("VeniceSoldierHealthModuleData." + nameof(ImmortalTimeAfterSpawn), this, m_ImmortalTimeAfterSpawn, value)) m_ImmortalTimeAfterSpawn = value; } } // 0x20 (32)
		
		protected List<EntryInputActionEnum> m_AbortSpawnImmortalityInputs = new List<EntryInputActionEnum>();
		[ContainerField(36), ContainerFieldNameHash(1625311224)]
		public List<EntryInputActionEnum> AbortSpawnImmortalityInputs { get { return m_AbortSpawnImmortalityInputs; } set { if (OnPropertyChanging("VeniceSoldierHealthModuleData." + nameof(AbortSpawnImmortalityInputs), this, m_AbortSpawnImmortalityInputs, value)) m_AbortSpawnImmortalityInputs = value; } } // 0x24 (36)
		
		protected float m_PostReviveHealth = new float();
		[ContainerField(40), LayoutImmutable, Blittable, ContainerFieldNameHash(690951482)]
		public float PostReviveHealth { get { return m_PostReviveHealth; } set { if (OnPropertyChanging("VeniceSoldierHealthModuleData." + nameof(PostReviveHealth), this, m_PostReviveHealth, value)) m_PostReviveHealth = value; } } // 0x28 (40)
		
		protected float m_CriticalFakeImmortalTime = new float();
		[ContainerField(44), LayoutImmutable, Blittable, ContainerFieldNameHash(1400664383)]
		public float CriticalFakeImmortalTime { get { return m_CriticalFakeImmortalTime; } set { if (OnPropertyChanging("VeniceSoldierHealthModuleData." + nameof(CriticalFakeImmortalTime), this, m_CriticalFakeImmortalTime, value)) m_CriticalFakeImmortalTime = value; } } // 0x2C (44)
		
		protected float m_RegenerationDelay = new float();
		[ContainerField(48), LayoutImmutable, Blittable, ContainerFieldNameHash(778753505)]
		public float RegenerationDelay { get { return m_RegenerationDelay; } set { if (OnPropertyChanging("VeniceSoldierHealthModuleData." + nameof(RegenerationDelay), this, m_RegenerationDelay, value)) m_RegenerationDelay = value; } } // 0x30 (48)
		
		protected float m_RegenerationRate = new float();
		[ContainerField(52), LayoutImmutable, Blittable, ContainerFieldNameHash(3407288278)]
		public float RegenerationRate { get { return m_RegenerationRate; } set { if (OnPropertyChanging("VeniceSoldierHealthModuleData." + nameof(RegenerationRate), this, m_RegenerationRate, value)) m_RegenerationRate = value; } } // 0x34 (52)
		
		protected SoldierHealthModuleBinding m_Binding = new SoldierHealthModuleBinding();
		[ContainerField(56), ContainerFieldNameHash(2590060228)]
		public SoldierHealthModuleBinding Binding { get { return m_Binding; } set { if (OnPropertyChanging("VeniceSoldierHealthModuleData." + nameof(Binding), this, m_Binding, value)) m_Binding = value; } } // 0x38 (56)
		
		protected float m_SprintDisabledWhenDamagedTime = new float();
		[ContainerField(148), LayoutImmutable, Blittable, ContainerFieldNameHash(261615897)]
		public float SprintDisabledWhenDamagedTime { get { return m_SprintDisabledWhenDamagedTime; } set { if (OnPropertyChanging("VeniceSoldierHealthModuleData." + nameof(SprintDisabledWhenDamagedTime), this, m_SprintDisabledWhenDamagedTime, value)) m_SprintDisabledWhenDamagedTime = value; } } // 0x94 (148)
		
		protected float m_SprintDisabledDamageThreshold = new float();
		[ContainerField(152), LayoutImmutable, Blittable, ContainerFieldNameHash(2813834027)]
		public float SprintDisabledDamageThreshold { get { return m_SprintDisabledDamageThreshold; } set { if (OnPropertyChanging("VeniceSoldierHealthModuleData." + nameof(SprintDisabledDamageThreshold), this, m_SprintDisabledDamageThreshold, value)) m_SprintDisabledDamageThreshold = value; } } // 0x98 (152)
		
		protected RotateToHitData m_ManDownRotate = new RotateToHitData();
		[ContainerField(156), ContainerFieldNameHash(2801100780)]
		public RotateToHitData ManDownRotate { get { return m_ManDownRotate; } set { if (OnPropertyChanging("VeniceSoldierHealthModuleData." + nameof(ManDownRotate), this, m_ManDownRotate, value)) m_ManDownRotate = value; } } // 0x9C (156)
		
		protected bool m_InteractiveManDown = new bool();
		[ContainerField(160), LayoutImmutable, Blittable, ContainerFieldNameHash(701073533)]
		public bool InteractiveManDown { get { return m_InteractiveManDown; } set { if (OnPropertyChanging("VeniceSoldierHealthModuleData." + nameof(InteractiveManDown), this, m_InteractiveManDown, value)) m_InteractiveManDown = value; } } // 0xA0 (160)
		
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
