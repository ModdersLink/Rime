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
	public class SupportedShootingCommonData : 
		Asset
	{
		protected AimingConstraintsData m_AimingConstraints = new AimingConstraintsData();
		[ContainerField(12), ContainerFieldNameHash(1523178198)]
		public AimingConstraintsData AimingConstraints { get { return m_AimingConstraints; } set { if (OnPropertyChanging("SupportedShootingCommonData." + nameof(AimingConstraints), this, m_AimingConstraints, value)) m_AimingConstraints = value; } } // 0xC (12)
		
		protected EntryInputActionEnum m_EnterSupportedShootingAction = new EntryInputActionEnum();
		[ContainerField(28), ContainerFieldNameHash(3674101426)]
		public EntryInputActionEnum EnterSupportedShootingAction { get { return m_EnterSupportedShootingAction; } set { if (OnPropertyChanging("SupportedShootingCommonData." + nameof(EnterSupportedShootingAction), this, m_EnterSupportedShootingAction, value)) m_EnterSupportedShootingAction = value; } } // 0x1C (28)
		
		protected SupportedShootingBinding m_Binding = new SupportedShootingBinding();
		[ContainerField(32), ContainerFieldNameHash(2590060228)]
		public SupportedShootingBinding Binding { get { return m_Binding; } set { if (OnPropertyChanging("SupportedShootingCommonData." + nameof(Binding), this, m_Binding, value)) m_Binding = value; } } // 0x20 (32)
		
		protected SupportedShootingProximityChecking m_Stand = new SupportedShootingProximityChecking();
		[ContainerField(68), ContainerFieldNameHash(230747945)]
		public SupportedShootingProximityChecking Stand { get { return m_Stand; } set { if (OnPropertyChanging("SupportedShootingCommonData." + nameof(Stand), this, m_Stand, value)) m_Stand = value; } } // 0x44 (68)
		
		protected SupportedShootingProximityChecking m_Crouch = new SupportedShootingProximityChecking();
		[ContainerField(84), ContainerFieldNameHash(2729602053)]
		public SupportedShootingProximityChecking Crouch { get { return m_Crouch; } set { if (OnPropertyChanging("SupportedShootingCommonData." + nameof(Crouch), this, m_Crouch, value)) m_Crouch = value; } } // 0x54 (84)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1523178198:
					AimingConstraints = (AimingConstraintsData) p_Value;
					break;

				case 3674101426:
					EnterSupportedShootingAction = (EntryInputActionEnum) Enum.ToObject(typeof(EntryInputActionEnum), p_Value);
					break;

				case 2590060228:
					Binding = (SupportedShootingBinding) p_Value;
					break;

				case 230747945:
					Stand = (SupportedShootingProximityChecking) p_Value;
					break;

				case 2729602053:
					Crouch = (SupportedShootingProximityChecking) p_Value;
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
				case 1523178198:
					return AimingConstraints;

				case 3674101426:
					return EnterSupportedShootingAction;

				case 2590060228:
					return Binding;

				case 230747945:
					return Stand;

				case 2729602053:
					return Crouch;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1523178198:
					return typeof(SupportedShootingCommonData).GetProperty(nameof(AimingConstraints));

				case 3674101426:
					return typeof(SupportedShootingCommonData).GetProperty(nameof(EnterSupportedShootingAction));

				case 2590060228:
					return typeof(SupportedShootingCommonData).GetProperty(nameof(Binding));

				case 230747945:
					return typeof(SupportedShootingCommonData).GetProperty(nameof(Stand));

				case 2729602053:
					return typeof(SupportedShootingCommonData).GetProperty(nameof(Crouch));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
