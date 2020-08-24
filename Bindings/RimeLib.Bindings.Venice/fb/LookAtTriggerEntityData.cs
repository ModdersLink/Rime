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
	[ContainerType(16), MemberInfoFlag(53), ContainerClass]
	public class LookAtTriggerEntityData : 
		TriggerEventEntityData
	{
		protected float m_FOV = new float();
		[ContainerField(112), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(193442778)]
		public float FOV { get { return m_FOV; } set { if (OnPropertyChanging("LookAtTriggerEntityData." + nameof(FOV), this, m_FOV, value)) m_FOV = value; } } // 0x70 (112)
		
		protected CtrRef<SoldierWeaponBlueprint> m_Weapon = new CtrRef<SoldierWeaponBlueprint>();
		[ContainerField(116), MemberInfoFlag(53), ContainerFieldNameHash(3190562823), ContainerCtrRef]
		public CtrRef<SoldierWeaponBlueprint> Weapon { get { return m_Weapon; } set { if (OnPropertyChanging("LookAtTriggerEntityData." + nameof(Weapon), this, m_Weapon, value)) m_Weapon = value; } } // 0x74 (116)
		
		protected uint m_ZoomLevel = new uint();
		[ContainerField(120), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(3650803780)]
		public uint ZoomLevel { get { return m_ZoomLevel; } set { if (OnPropertyChanging("LookAtTriggerEntityData." + nameof(ZoomLevel), this, m_ZoomLevel, value)) m_ZoomLevel = value; } } // 0x78 (120)
		
		protected float m_MinDistanceToObject = new float();
		[ContainerField(124), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3463845186)]
		public float MinDistanceToObject { get { return m_MinDistanceToObject; } set { if (OnPropertyChanging("LookAtTriggerEntityData." + nameof(MinDistanceToObject), this, m_MinDistanceToObject, value)) m_MinDistanceToObject = value; } } // 0x7C (124)
		
		protected float m_MaxDistanceToObject = new float();
		[ContainerField(128), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(954132188)]
		public float MaxDistanceToObject { get { return m_MaxDistanceToObject; } set { if (OnPropertyChanging("LookAtTriggerEntityData." + nameof(MaxDistanceToObject), this, m_MaxDistanceToObject, value)) m_MaxDistanceToObject = value; } } // 0x80 (128)
		
		protected bool m_StartTriggerLookingAt = new bool();
		[ContainerField(132), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2703714543)]
		public bool StartTriggerLookingAt { get { return m_StartTriggerLookingAt; } set { if (OnPropertyChanging("LookAtTriggerEntityData." + nameof(StartTriggerLookingAt), this, m_StartTriggerLookingAt, value)) m_StartTriggerLookingAt = value; } } // 0x84 (132)
		
		protected bool m_CheckOcclusion = new bool();
		[ContainerField(133), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3588432334)]
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
