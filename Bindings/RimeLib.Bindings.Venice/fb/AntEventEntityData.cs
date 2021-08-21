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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 112)]
	public class AntEventEntityData : 
		GameEntityData
	{
		protected List<AntEventData> m_OnEnterEvents = new List<AntEventData>();
		[ContainerField(Name: "OnEnterEvents", Offset: 96, NameHash: 3335046611, Flags: 65)]
		public List<AntEventData> OnEnterEvents { get { return m_OnEnterEvents; } set { if (OnPropertyChanging("AntEventEntityData." + nameof(OnEnterEvents), this, m_OnEnterEvents, value)) m_OnEnterEvents = value; } } // 0x60 (96)
		
		protected List<AntEventData> m_OnUpdateEvents = new List<AntEventData>();
		[ContainerField(Name: "OnUpdateEvents", Offset: 100, NameHash: 1556391722, Flags: 65)]
		public List<AntEventData> OnUpdateEvents { get { return m_OnUpdateEvents; } set { if (OnPropertyChanging("AntEventEntityData." + nameof(OnUpdateEvents), this, m_OnUpdateEvents, value)) m_OnUpdateEvents = value; } } // 0x64 (100)
		
		protected List<AntEventData> m_OnLeaveEvents = new List<AntEventData>();
		[ContainerField(Name: "OnLeaveEvents", Offset: 104, NameHash: 514519232, Flags: 65)]
		public List<AntEventData> OnLeaveEvents { get { return m_OnLeaveEvents; } set { if (OnPropertyChanging("AntEventEntityData." + nameof(OnLeaveEvents), this, m_OnLeaveEvents, value)) m_OnLeaveEvents = value; } } // 0x68 (104)
		
		protected bool m_SendAsPlayerEvent = new bool();
		[ContainerField(Name: "SendAsPlayerEvent", Offset: 108, NameHash: 2177775476, Flags: 49325), LayoutImmutable, Blittable]
		public bool SendAsPlayerEvent { get { return m_SendAsPlayerEvent; } set { if (OnPropertyChanging("AntEventEntityData." + nameof(SendAsPlayerEvent), this, m_SendAsPlayerEvent, value)) m_SendAsPlayerEvent = value; } } // 0x6C (108)
		
		protected bool m_AutoActivate = new bool();
		[ContainerField(Name: "AutoActivate", Offset: 109, NameHash: 778899923, Flags: 49325), LayoutImmutable, Blittable]
		public bool AutoActivate { get { return m_AutoActivate; } set { if (OnPropertyChanging("AntEventEntityData." + nameof(AutoActivate), this, m_AutoActivate, value)) m_AutoActivate = value; } } // 0x6D (109)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3335046611:
					OnEnterEvents = (List<AntEventData>) p_Value;
					break;

				case 1556391722:
					OnUpdateEvents = (List<AntEventData>) p_Value;
					break;

				case 514519232:
					OnLeaveEvents = (List<AntEventData>) p_Value;
					break;

				case 2177775476:
					SendAsPlayerEvent = (bool) p_Value;
					break;

				case 778899923:
					AutoActivate = (bool) p_Value;
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
				case 3335046611:
					return OnEnterEvents;

				case 1556391722:
					return OnUpdateEvents;

				case 514519232:
					return OnLeaveEvents;

				case 2177775476:
					return SendAsPlayerEvent;

				case 778899923:
					return AutoActivate;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3335046611:
					return typeof(AntEventEntityData).GetProperty(nameof(OnEnterEvents));

				case 1556391722:
					return typeof(AntEventEntityData).GetProperty(nameof(OnUpdateEvents));

				case 514519232:
					return typeof(AntEventEntityData).GetProperty(nameof(OnLeaveEvents));

				case 2177775476:
					return typeof(AntEventEntityData).GetProperty(nameof(SendAsPlayerEvent));

				case 778899923:
					return typeof(AntEventEntityData).GetProperty(nameof(AutoActivate));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
