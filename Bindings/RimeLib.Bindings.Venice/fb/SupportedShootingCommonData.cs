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
	public class SupportedShootingCommonData : 
		Asset
	{
		[ContainerField(12)]
		public AimingConstraintsData AimingConstraints { get; set; } = new AimingConstraintsData(); // 0xC (12)
		
		[ContainerField(28)]
		public EntryInputActionEnum EnterSupportedShootingAction { get; set; } = new EntryInputActionEnum(); // 0x1C (28)
		
		[ContainerField(32)]
		public SupportedShootingBinding Binding { get; set; } = new SupportedShootingBinding(); // 0x20 (32)
		
		[ContainerField(68)]
		public SupportedShootingProximityChecking Stand { get; set; } = new SupportedShootingProximityChecking(); // 0x44 (68)
		
		[ContainerField(84)]
		public SupportedShootingProximityChecking Crouch { get; set; } = new SupportedShootingProximityChecking(); // 0x54 (84)
		
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
