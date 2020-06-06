///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class VoiceOverEventEntityData : 
		EntityData
	{
		[ContainerField(12)]
		public CtrRef<VoiceOverNamedValue> EventPlayer { get; set; } = new CtrRef<VoiceOverNamedValue>(); // 0xC (12)
		
		[ContainerField(16)]
		public CtrRef<VoiceOverEvent> VoEvent { get; set; } = new CtrRef<VoiceOverEvent>(); // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float FinishedDelay { get; set; } // 0x14 (20)
		
		[ContainerField(24)]
		public CtrRef<VoiceOverNamedValue> ExtraEventPlayer { get; set; } = new CtrRef<VoiceOverNamedValue>(); // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public float TriggerDelay { get; set; } // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public bool RunOnce { get; set; } // 0x20 (32)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 4041067226:
					EventPlayer = (CtrRef<VoiceOverNamedValue>) p_Value;
					break;

				case 1188417264:
					VoEvent = (CtrRef<VoiceOverEvent>) p_Value;
					break;

				case 2930042562:
					FinishedDelay = (float) p_Value;
					break;

				case 1270251872:
					ExtraEventPlayer = (CtrRef<VoiceOverNamedValue>) p_Value;
					break;

				case 3587015816:
					TriggerDelay = (float) p_Value;
					break;

				case 709901739:
					RunOnce = (bool) p_Value;
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
				case 4041067226:
					return EventPlayer;

				case 1188417264:
					return VoEvent;

				case 2930042562:
					return FinishedDelay;

				case 1270251872:
					return ExtraEventPlayer;

				case 3587015816:
					return TriggerDelay;

				case 709901739:
					return RunOnce;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 4041067226:
					return typeof(VoiceOverEventEntityData).GetProperty(nameof(EventPlayer));

				case 1188417264:
					return typeof(VoiceOverEventEntityData).GetProperty(nameof(VoEvent));

				case 2930042562:
					return typeof(VoiceOverEventEntityData).GetProperty(nameof(FinishedDelay));

				case 1270251872:
					return typeof(VoiceOverEventEntityData).GetProperty(nameof(ExtraEventPlayer));

				case 3587015816:
					return typeof(VoiceOverEventEntityData).GetProperty(nameof(TriggerDelay));

				case 709901739:
					return typeof(VoiceOverEventEntityData).GetProperty(nameof(RunOnce));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
