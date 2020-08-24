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
	public class UICustomizationCompData : 
		UIComponentData
	{
		protected Vec3 m_SoldierOffset = new Vec3();
		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(1109239746)]
		public Vec3 SoldierOffset { get { return m_SoldierOffset; } set { if (OnPropertyChanging("UICustomizationCompData." + nameof(SoldierOffset), this, m_SoldierOffset, value)) m_SoldierOffset = value; } } // 0x20 (32)
		
		protected Vec3 m_SoldierRotation = new Vec3();
		[ContainerField(48), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(853309051)]
		public Vec3 SoldierRotation { get { return m_SoldierRotation; } set { if (OnPropertyChanging("UICustomizationCompData." + nameof(SoldierRotation), this, m_SoldierRotation, value)) m_SoldierRotation = value; } } // 0x30 (48)
		
		protected Vec3 m_VehicleRotation = new Vec3();
		[ContainerField(64), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(7325673)]
		public Vec3 VehicleRotation { get { return m_VehicleRotation; } set { if (OnPropertyChanging("UICustomizationCompData." + nameof(VehicleRotation), this, m_VehicleRotation, value)) m_VehicleRotation = value; } } // 0x40 (64)
		
		protected float m_NetworkThrottleTimer = new float();
		[ContainerField(80), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(441904308)]
		public float NetworkThrottleTimer { get { return m_NetworkThrottleTimer; } set { if (OnPropertyChanging("UICustomizationCompData." + nameof(NetworkThrottleTimer), this, m_NetworkThrottleTimer, value)) m_NetworkThrottleTimer = value; } } // 0x50 (80)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1109239746:
					SoldierOffset = (Vec3) p_Value;
					break;

				case 853309051:
					SoldierRotation = (Vec3) p_Value;
					break;

				case 7325673:
					VehicleRotation = (Vec3) p_Value;
					break;

				case 441904308:
					NetworkThrottleTimer = (float) p_Value;
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
				case 1109239746:
					return SoldierOffset;

				case 853309051:
					return SoldierRotation;

				case 7325673:
					return VehicleRotation;

				case 441904308:
					return NetworkThrottleTimer;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1109239746:
					return typeof(UICustomizationCompData).GetProperty(nameof(SoldierOffset));

				case 853309051:
					return typeof(UICustomizationCompData).GetProperty(nameof(SoldierRotation));

				case 7325673:
					return typeof(UICustomizationCompData).GetProperty(nameof(VehicleRotation));

				case 441904308:
					return typeof(UICustomizationCompData).GetProperty(nameof(NetworkThrottleTimer));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
