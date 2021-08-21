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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 16)]
	public class VoiceOverConversationGroupEntityData : 
		EntityData
	{
		protected CtrRef<VoiceOverConversationQueueGroup> m_QueueGroup = new CtrRef<VoiceOverConversationQueueGroup>();
		[ContainerField(Name: "QueueGroup", Offset: 12, NameHash: 2016027659, Flags: 53)]
		public CtrRef<VoiceOverConversationQueueGroup> QueueGroup { get { return m_QueueGroup; } set { if (OnPropertyChanging("VoiceOverConversationGroupEntityData." + nameof(QueueGroup), this, m_QueueGroup, value)) m_QueueGroup = value; } } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2016027659:
					QueueGroup = (CtrRef<VoiceOverConversationQueueGroup>) p_Value;
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
				case 2016027659:
					return QueueGroup;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2016027659:
					return typeof(VoiceOverConversationGroupEntityData).GetProperty(nameof(QueueGroup));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
