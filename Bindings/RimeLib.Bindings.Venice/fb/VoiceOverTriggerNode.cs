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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 24)]
	public class VoiceOverTriggerNode : 
		VoiceOverStructureNode
	{
		protected RefArray<VoiceOverTriggerParameter> m_Parameters = new RefArray<VoiceOverTriggerParameter>();
		[ContainerField(Name: "Parameters", Offset: 12, NameHash: 3325515039, Flags: 65)]
		public RefArray<VoiceOverTriggerParameter> Parameters { get { return m_Parameters; } set { if (OnPropertyChanging("VoiceOverTriggerNode." + nameof(Parameters), this, m_Parameters, value)) m_Parameters = value; } } // 0xC (12)
		
		protected float m_Delay = new float();
		[ContainerField(Name: "Delay", Offset: 16, NameHash: 208768368, Flags: 49469), LayoutImmutable, Blittable]
		public float Delay { get { return m_Delay; } set { if (OnPropertyChanging("VoiceOverTriggerNode." + nameof(Delay), this, m_Delay, value)) m_Delay = value; } } // 0x10 (16)
		
		protected CtrRef<VoiceOverEvent> m_Event = new CtrRef<VoiceOverEvent>();
		[ContainerField(Name: "Event", Offset: 20, NameHash: 201427689, Flags: 53)]
		public CtrRef<VoiceOverEvent> Event { get { return m_Event; } set { if (OnPropertyChanging("VoiceOverTriggerNode." + nameof(Event), this, m_Event, value)) m_Event = value; } } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3325515039:
					Parameters = (RefArray<VoiceOverTriggerParameter>) p_Value;
					break;

				case 208768368:
					Delay = (float) p_Value;
					break;

				case 201427689:
					Event = (CtrRef<VoiceOverEvent>) p_Value;
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
				case 3325515039:
					return Parameters;

				case 208768368:
					return Delay;

				case 201427689:
					return Event;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3325515039:
					return typeof(VoiceOverTriggerNode).GetProperty(nameof(Parameters));

				case 208768368:
					return typeof(VoiceOverTriggerNode).GetProperty(nameof(Delay));

				case 201427689:
					return typeof(VoiceOverTriggerNode).GetProperty(nameof(Event));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
