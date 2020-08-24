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
	[ContainerType(4), MemberInfoFlag(53), ContainerClass]
	public class VoiceOverTriggerParameter : 
		DataContainer
	{
		protected CtrRef<VoiceOverValueConnection> m_Source = new CtrRef<VoiceOverValueConnection>();
		[ContainerField(8), MemberInfoFlag(53), ContainerFieldNameHash(3339738264), ContainerCtrRef]
		public CtrRef<VoiceOverValueConnection> Source { get { return m_Source; } set { if (OnPropertyChanging("VoiceOverTriggerParameter." + nameof(Source), this, m_Source, value)) m_Source = value; } } // 0x8 (8)
		
		protected CtrRef<VoiceOverNamedValue> m_EventParameter = new CtrRef<VoiceOverNamedValue>();
		[ContainerField(12), MemberInfoFlag(53), ContainerFieldNameHash(1445570624), ContainerCtrRef]
		public CtrRef<VoiceOverNamedValue> EventParameter { get { return m_EventParameter; } set { if (OnPropertyChanging("VoiceOverTriggerParameter." + nameof(EventParameter), this, m_EventParameter, value)) m_EventParameter = value; } } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3339738264:
					Source = (CtrRef<VoiceOverValueConnection>) p_Value;
					break;

				case 1445570624:
					EventParameter = (CtrRef<VoiceOverNamedValue>) p_Value;
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
				case 3339738264:
					return Source;

				case 1445570624:
					return EventParameter;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3339738264:
					return typeof(VoiceOverTriggerParameter).GetProperty(nameof(Source));

				case 1445570624:
					return typeof(VoiceOverTriggerParameter).GetProperty(nameof(EventParameter));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
