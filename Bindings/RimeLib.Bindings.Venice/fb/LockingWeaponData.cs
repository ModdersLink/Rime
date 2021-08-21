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
using RimeLib.Frostbite.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 4,  Flags: 53, Size: 32)]
	public class LockingWeaponData : 
		WeaponData
	{
		protected CtrRef<LockingControllerData> m_LockingController = new CtrRef<LockingControllerData>();
		[ContainerField(Name: "LockingController", Offset: 16, NameHash: 1783566994, Flags: 53)]
		public CtrRef<LockingControllerData> LockingController { get { return m_LockingController; } set { if (OnPropertyChanging("LockingWeaponData." + nameof(LockingController), this, m_LockingController, value)) m_LockingController = value; } } // 0x10 (16)
		
		protected CtrRef<LockingControllerData> m_SecondaryLockingController = new CtrRef<LockingControllerData>();
		[ContainerField(Name: "SecondaryLockingController", Offset: 20, NameHash: 212156840, Flags: 53)]
		public CtrRef<LockingControllerData> SecondaryLockingController { get { return m_SecondaryLockingController; } set { if (OnPropertyChanging("LockingWeaponData." + nameof(SecondaryLockingController), this, m_SecondaryLockingController, value)) m_SecondaryLockingController = value; } } // 0x14 (20)
		
		protected WarnTarget m_WarnLock = new WarnTarget();
		[ContainerField(Name: "WarnLock", Offset: 24, NameHash: 2457242500, Flags: 137)]
		public WarnTarget WarnLock { get { return m_WarnLock; } set { if (OnPropertyChanging("LockingWeaponData." + nameof(WarnLock), this, m_WarnLock, value)) m_WarnLock = value; } } // 0x18 (24)
		
		protected bool m_IsHoming = new bool();
		[ContainerField(Name: "IsHoming", Offset: 28, NameHash: 962805909, Flags: 49325), LayoutImmutable, Blittable]
		public bool IsHoming { get { return m_IsHoming; } set { if (OnPropertyChanging("LockingWeaponData." + nameof(IsHoming), this, m_IsHoming, value)) m_IsHoming = value; } } // 0x1C (28)
		
		protected bool m_IsGuidedWhenZoomed = new bool();
		[ContainerField(Name: "IsGuidedWhenZoomed", Offset: 29, NameHash: 951364163, Flags: 49325), LayoutImmutable, Blittable]
		public bool IsGuidedWhenZoomed { get { return m_IsGuidedWhenZoomed; } set { if (OnPropertyChanging("LockingWeaponData." + nameof(IsGuidedWhenZoomed), this, m_IsGuidedWhenZoomed, value)) m_IsGuidedWhenZoomed = value; } } // 0x1D (29)
		
		protected bool m_FireOnlyWhenLockedOn = new bool();
		[ContainerField(Name: "FireOnlyWhenLockedOn", Offset: 30, NameHash: 708469046, Flags: 49325), LayoutImmutable, Blittable]
		public bool FireOnlyWhenLockedOn { get { return m_FireOnlyWhenLockedOn; } set { if (OnPropertyChanging("LockingWeaponData." + nameof(FireOnlyWhenLockedOn), this, m_FireOnlyWhenLockedOn, value)) m_FireOnlyWhenLockedOn = value; } } // 0x1E (30)
		
		protected bool m_IsGuided = new bool();
		[ContainerField(Name: "IsGuided", Offset: 31, NameHash: 911651905, Flags: 49325), LayoutImmutable, Blittable]
		public bool IsGuided { get { return m_IsGuided; } set { if (OnPropertyChanging("LockingWeaponData." + nameof(IsGuided), this, m_IsGuided, value)) m_IsGuided = value; } } // 0x1F (31)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1783566994:
					LockingController = (CtrRef<LockingControllerData>) p_Value;
					break;

				case 212156840:
					SecondaryLockingController = (CtrRef<LockingControllerData>) p_Value;
					break;

				case 2457242500:
					WarnLock = (WarnTarget) Enum.ToObject(typeof(WarnTarget), p_Value);
					break;

				case 962805909:
					IsHoming = (bool) p_Value;
					break;

				case 951364163:
					IsGuidedWhenZoomed = (bool) p_Value;
					break;

				case 708469046:
					FireOnlyWhenLockedOn = (bool) p_Value;
					break;

				case 911651905:
					IsGuided = (bool) p_Value;
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
				case 1783566994:
					return LockingController;

				case 212156840:
					return SecondaryLockingController;

				case 2457242500:
					return WarnLock;

				case 962805909:
					return IsHoming;

				case 951364163:
					return IsGuidedWhenZoomed;

				case 708469046:
					return FireOnlyWhenLockedOn;

				case 911651905:
					return IsGuided;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1783566994:
					return typeof(LockingWeaponData).GetProperty(nameof(LockingController));

				case 212156840:
					return typeof(LockingWeaponData).GetProperty(nameof(SecondaryLockingController));

				case 2457242500:
					return typeof(LockingWeaponData).GetProperty(nameof(WarnLock));

				case 962805909:
					return typeof(LockingWeaponData).GetProperty(nameof(IsHoming));

				case 951364163:
					return typeof(LockingWeaponData).GetProperty(nameof(IsGuidedWhenZoomed));

				case 708469046:
					return typeof(LockingWeaponData).GetProperty(nameof(FireOnlyWhenLockedOn));

				case 911651905:
					return typeof(LockingWeaponData).GetProperty(nameof(IsGuided));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
