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
	public class SoldierSprintSettingsData : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public float Fov { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public float FovInDelay { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float FovInTime { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float FovOutDelay { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public float FovOutTime { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public float RecoverTime { get; set; } // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public float SprintToProneRecoverTime { get; set; } // 0x20 (32)
		
		[ContainerField(36)]
		public List<EntryInputActionEnum> InterruptingActions { get; set; } = new List<EntryInputActionEnum>(); // 0x24 (36)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 193443802:
					Fov = (float) p_Value;
					break;

				case 2914334632:
					FovInDelay = (float) p_Value;
					break;

				case 1259080584:
					FovInTime = (float) p_Value;
					break;

				case 401599137:
					FovOutDelay = (float) p_Value;
					break;

				case 3785964001:
					FovOutTime = (float) p_Value;
					break;

				case 3786458634:
					RecoverTime = (float) p_Value;
					break;

				case 498825685:
					SprintToProneRecoverTime = (float) p_Value;
					break;

				case 1860467119:
					if (p_Value.GetType() == typeof (List<uint>))
						InterruptingActions = ((List<uint>) p_Value).Select(x => (EntryInputActionEnum) Enum.ToObject(typeof(EntryInputActionEnum), x)).ToList();
					else
						InterruptingActions = (List<EntryInputActionEnum>) p_Value;
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
				case 193443802:
					return Fov;

				case 2914334632:
					return FovInDelay;

				case 1259080584:
					return FovInTime;

				case 401599137:
					return FovOutDelay;

				case 3785964001:
					return FovOutTime;

				case 3786458634:
					return RecoverTime;

				case 498825685:
					return SprintToProneRecoverTime;

				case 1860467119:
					return InterruptingActions;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 193443802:
					return typeof(SoldierSprintSettingsData).GetProperty(nameof(Fov));

				case 2914334632:
					return typeof(SoldierSprintSettingsData).GetProperty(nameof(FovInDelay));

				case 1259080584:
					return typeof(SoldierSprintSettingsData).GetProperty(nameof(FovInTime));

				case 401599137:
					return typeof(SoldierSprintSettingsData).GetProperty(nameof(FovOutDelay));

				case 3785964001:
					return typeof(SoldierSprintSettingsData).GetProperty(nameof(FovOutTime));

				case 3786458634:
					return typeof(SoldierSprintSettingsData).GetProperty(nameof(RecoverTime));

				case 498825685:
					return typeof(SoldierSprintSettingsData).GetProperty(nameof(SprintToProneRecoverTime));

				case 1860467119:
					return typeof(SoldierSprintSettingsData).GetProperty(nameof(InterruptingActions));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
