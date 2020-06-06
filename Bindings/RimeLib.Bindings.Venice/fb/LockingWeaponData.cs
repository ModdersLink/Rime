///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class LockingWeaponData : 
		WeaponData
	{
		[ContainerField(16)]
		public CtrRef<LockingControllerData> LockingController { get; set; } = new CtrRef<LockingControllerData>(); // 0x10 (16)
		
		[ContainerField(20)]
		public CtrRef<LockingControllerData> SecondaryLockingController { get; set; } = new CtrRef<LockingControllerData>(); // 0x14 (20)
		
		[ContainerField(24)]
		public WarnTarget WarnLock { get; set; } = new WarnTarget(); // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public bool IsHoming { get; set; } // 0x1C (28)
		
		[ContainerField(29), LayoutImmutable, Blittable]
		public bool IsGuidedWhenZoomed { get; set; } // 0x1D (29)
		
		[ContainerField(30), LayoutImmutable, Blittable]
		public bool FireOnlyWhenLockedOn { get; set; } // 0x1E (30)
		
		[ContainerField(31), LayoutImmutable, Blittable]
		public bool IsGuided { get; set; } // 0x1F (31)
		
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
