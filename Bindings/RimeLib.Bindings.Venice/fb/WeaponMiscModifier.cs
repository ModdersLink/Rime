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
	public class WeaponMiscModifier : 
		WeaponModifierBase
	{
		protected bool m_EnableBreathControl = new bool();
		[ContainerField(8), LayoutImmutable, Blittable, ContainerFieldNameHash(613505579)]
		public bool EnableBreathControl { get { return m_EnableBreathControl; } set { if (OnPropertyChanging("WeaponMiscModifier." + nameof(EnableBreathControl), this, m_EnableBreathControl, value)) m_EnableBreathControl = value; } } // 0x8 (8)
		
		protected bool m_CanBeInSupportedShooting = new bool();
		[ContainerField(9), LayoutImmutable, Blittable, ContainerFieldNameHash(2187452328)]
		public bool CanBeInSupportedShooting { get { return m_CanBeInSupportedShooting; } set { if (OnPropertyChanging("WeaponMiscModifier." + nameof(CanBeInSupportedShooting), this, m_CanBeInSupportedShooting, value)) m_CanBeInSupportedShooting = value; } } // 0x9 (9)
		
		protected bool m_UnZoomOnBoltAction = new bool();
		[ContainerField(10), LayoutImmutable, Blittable, ContainerFieldNameHash(1438634691)]
		public bool UnZoomOnBoltAction { get { return m_UnZoomOnBoltAction; } set { if (OnPropertyChanging("WeaponMiscModifier." + nameof(UnZoomOnBoltAction), this, m_UnZoomOnBoltAction, value)) m_UnZoomOnBoltAction = value; } } // 0xA (10)
		
		protected bool m_HoldBoltActionUntilZoomRelease = new bool();
		[ContainerField(11), LayoutImmutable, Blittable, ContainerFieldNameHash(3133940949)]
		public bool HoldBoltActionUntilZoomRelease { get { return m_HoldBoltActionUntilZoomRelease; } set { if (OnPropertyChanging("WeaponMiscModifier." + nameof(HoldBoltActionUntilZoomRelease), this, m_HoldBoltActionUntilZoomRelease, value)) m_HoldBoltActionUntilZoomRelease = value; } } // 0xB (11)
		
		protected bool m_IsSilenced = new bool();
		[ContainerField(12), LayoutImmutable, Blittable, ContainerFieldNameHash(1644964768)]
		public bool IsSilenced { get { return m_IsSilenced; } set { if (OnPropertyChanging("WeaponMiscModifier." + nameof(IsSilenced), this, m_IsSilenced, value)) m_IsSilenced = value; } } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 613505579:
					EnableBreathControl = (bool) p_Value;
					break;

				case 2187452328:
					CanBeInSupportedShooting = (bool) p_Value;
					break;

				case 1438634691:
					UnZoomOnBoltAction = (bool) p_Value;
					break;

				case 3133940949:
					HoldBoltActionUntilZoomRelease = (bool) p_Value;
					break;

				case 1644964768:
					IsSilenced = (bool) p_Value;
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
				case 613505579:
					return EnableBreathControl;

				case 2187452328:
					return CanBeInSupportedShooting;

				case 1438634691:
					return UnZoomOnBoltAction;

				case 3133940949:
					return HoldBoltActionUntilZoomRelease;

				case 1644964768:
					return IsSilenced;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 613505579:
					return typeof(WeaponMiscModifier).GetProperty(nameof(EnableBreathControl));

				case 2187452328:
					return typeof(WeaponMiscModifier).GetProperty(nameof(CanBeInSupportedShooting));

				case 1438634691:
					return typeof(WeaponMiscModifier).GetProperty(nameof(UnZoomOnBoltAction));

				case 3133940949:
					return typeof(WeaponMiscModifier).GetProperty(nameof(HoldBoltActionUntilZoomRelease));

				case 1644964768:
					return typeof(WeaponMiscModifier).GetProperty(nameof(IsSilenced));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
