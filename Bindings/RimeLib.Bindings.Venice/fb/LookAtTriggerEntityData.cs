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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 144)]
	public class LookAtTriggerEntityData : 
		TriggerEventEntityData
	{
		protected float m_FOV = new float();
		[ContainerField(Name: "FOV", Offset: 112, NameHash: 193442778, Flags: 49469), LayoutImmutable, Blittable]
		public float FOV { get { return m_FOV; } set { if (OnPropertyChanging("LookAtTriggerEntityData." + nameof(FOV), this, m_FOV, value)) m_FOV = value; } } // 0x70 (112)
		
		protected CtrRef<SoldierWeaponBlueprint> m_Weapon = new CtrRef<SoldierWeaponBlueprint>();
		[ContainerField(Name: "Weapon", Offset: 116, NameHash: 3190562823, Flags: 53)]
		public CtrRef<SoldierWeaponBlueprint> Weapon { get { return m_Weapon; } set { if (OnPropertyChanging("LookAtTriggerEntityData." + nameof(Weapon), this, m_Weapon, value)) m_Weapon = value; } } // 0x74 (116)
		
		protected uint m_ZoomLevel = new uint();
		[ContainerField(Name: "ZoomLevel", Offset: 120, NameHash: 3650803780, Flags: 49421), LayoutImmutable, Blittable]
		public uint ZoomLevel { get { return m_ZoomLevel; } set { if (OnPropertyChanging("LookAtTriggerEntityData." + nameof(ZoomLevel), this, m_ZoomLevel, value)) m_ZoomLevel = value; } } // 0x78 (120)
		
		protected float m_MinDistanceToObject = new float();
		[ContainerField(Name: "MinDistanceToObject", Offset: 124, NameHash: 3463845186, Flags: 49469), LayoutImmutable, Blittable]
		public float MinDistanceToObject { get { return m_MinDistanceToObject; } set { if (OnPropertyChanging("LookAtTriggerEntityData." + nameof(MinDistanceToObject), this, m_MinDistanceToObject, value)) m_MinDistanceToObject = value; } } // 0x7C (124)
		
		protected float m_MaxDistanceToObject = new float();
		[ContainerField(Name: "MaxDistanceToObject", Offset: 128, NameHash: 954132188, Flags: 49469), LayoutImmutable, Blittable]
		public float MaxDistanceToObject { get { return m_MaxDistanceToObject; } set { if (OnPropertyChanging("LookAtTriggerEntityData." + nameof(MaxDistanceToObject), this, m_MaxDistanceToObject, value)) m_MaxDistanceToObject = value; } } // 0x80 (128)
		
		protected bool m_StartTriggerLookingAt = new bool();
		[ContainerField(Name: "StartTriggerLookingAt", Offset: 132, NameHash: 2703714543, Flags: 49325), LayoutImmutable, Blittable]
		public bool StartTriggerLookingAt { get { return m_StartTriggerLookingAt; } set { if (OnPropertyChanging("LookAtTriggerEntityData." + nameof(StartTriggerLookingAt), this, m_StartTriggerLookingAt, value)) m_StartTriggerLookingAt = value; } } // 0x84 (132)
		
		protected bool m_CheckOcclusion = new bool();
		[ContainerField(Name: "CheckOcclusion", Offset: 133, NameHash: 3588432334, Flags: 49325), LayoutImmutable, Blittable]
		public bool CheckOcclusion { get { return m_CheckOcclusion; } set { if (OnPropertyChanging("LookAtTriggerEntityData." + nameof(CheckOcclusion), this, m_CheckOcclusion, value)) m_CheckOcclusion = value; } } // 0x85 (133)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 193442778:
					FOV = (float) p_Value;
					break;

				case 3190562823:
					Weapon = (CtrRef<SoldierWeaponBlueprint>) p_Value;
					break;

				case 3650803780:
					ZoomLevel = (uint) p_Value;
					break;

				case 3463845186:
					MinDistanceToObject = (float) p_Value;
					break;

				case 954132188:
					MaxDistanceToObject = (float) p_Value;
					break;

				case 2703714543:
					StartTriggerLookingAt = (bool) p_Value;
					break;

				case 3588432334:
					CheckOcclusion = (bool) p_Value;
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
				case 193442778:
					return FOV;

				case 3190562823:
					return Weapon;

				case 3650803780:
					return ZoomLevel;

				case 3463845186:
					return MinDistanceToObject;

				case 954132188:
					return MaxDistanceToObject;

				case 2703714543:
					return StartTriggerLookingAt;

				case 3588432334:
					return CheckOcclusion;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 193442778:
					return typeof(LookAtTriggerEntityData).GetProperty(nameof(FOV));

				case 3190562823:
					return typeof(LookAtTriggerEntityData).GetProperty(nameof(Weapon));

				case 3650803780:
					return typeof(LookAtTriggerEntityData).GetProperty(nameof(ZoomLevel));

				case 3463845186:
					return typeof(LookAtTriggerEntityData).GetProperty(nameof(MinDistanceToObject));

				case 954132188:
					return typeof(LookAtTriggerEntityData).GetProperty(nameof(MaxDistanceToObject));

				case 2703714543:
					return typeof(LookAtTriggerEntityData).GetProperty(nameof(StartTriggerLookingAt));

				case 3588432334:
					return typeof(LookAtTriggerEntityData).GetProperty(nameof(CheckOcclusion));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
