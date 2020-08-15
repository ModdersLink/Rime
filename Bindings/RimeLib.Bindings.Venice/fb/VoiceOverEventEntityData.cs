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
	public class VoiceOverEventEntityData : 
		EntityData
	{
		protected CtrRef<VoiceOverNamedValue> m_EventPlayer = new CtrRef<VoiceOverNamedValue>();
		[ContainerField(12), ContainerFieldNameHash(4041067226)]
		public CtrRef<VoiceOverNamedValue> EventPlayer { get { return m_EventPlayer; } set { if (OnPropertyChanging("VoiceOverEventEntityData." + nameof(EventPlayer), this, m_EventPlayer, value)) m_EventPlayer = value; } } // 0xC (12)
		
		protected CtrRef<VoiceOverEvent> m_VoEvent = new CtrRef<VoiceOverEvent>();
		[ContainerField(16), ContainerFieldNameHash(1188417264)]
		public CtrRef<VoiceOverEvent> VoEvent { get { return m_VoEvent; } set { if (OnPropertyChanging("VoiceOverEventEntityData." + nameof(VoEvent), this, m_VoEvent, value)) m_VoEvent = value; } } // 0x10 (16)
		
		protected float m_FinishedDelay = new float();
		[ContainerField(20), LayoutImmutable, Blittable, ContainerFieldNameHash(2930042562)]
		public float FinishedDelay { get { return m_FinishedDelay; } set { if (OnPropertyChanging("VoiceOverEventEntityData." + nameof(FinishedDelay), this, m_FinishedDelay, value)) m_FinishedDelay = value; } } // 0x14 (20)
		
		protected CtrRef<VoiceOverNamedValue> m_ExtraEventPlayer = new CtrRef<VoiceOverNamedValue>();
		[ContainerField(24), ContainerFieldNameHash(1270251872)]
		public CtrRef<VoiceOverNamedValue> ExtraEventPlayer { get { return m_ExtraEventPlayer; } set { if (OnPropertyChanging("VoiceOverEventEntityData." + nameof(ExtraEventPlayer), this, m_ExtraEventPlayer, value)) m_ExtraEventPlayer = value; } } // 0x18 (24)
		
		protected float m_TriggerDelay = new float();
		[ContainerField(28), LayoutImmutable, Blittable, ContainerFieldNameHash(3587015816)]
		public float TriggerDelay { get { return m_TriggerDelay; } set { if (OnPropertyChanging("VoiceOverEventEntityData." + nameof(TriggerDelay), this, m_TriggerDelay, value)) m_TriggerDelay = value; } } // 0x1C (28)
		
		protected bool m_RunOnce = new bool();
		[ContainerField(32), LayoutImmutable, Blittable, ContainerFieldNameHash(709901739)]
		public bool RunOnce { get { return m_RunOnce; } set { if (OnPropertyChanging("VoiceOverEventEntityData." + nameof(RunOnce), this, m_RunOnce, value)) m_RunOnce = value; } } // 0x20 (32)
		
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
