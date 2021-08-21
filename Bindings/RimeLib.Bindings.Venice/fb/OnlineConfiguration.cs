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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 28)]
	public class OnlineConfiguration : 
		Asset
	{
		protected BackendType m_Backend = new BackendType();
		[ContainerField(Name: "Backend", Offset: 12, NameHash: 2290467745, Flags: 137)]
		public BackendType Backend { get { return m_Backend; } set { if (OnPropertyChanging("OnlineConfiguration." + nameof(Backend), this, m_Backend, value)) m_Backend = value; } } // 0xC (12)
		
		protected CtrRef<OnlineProviderAsset> m_Provider = new CtrRef<OnlineProviderAsset>();
		[ContainerField(Name: "Provider", Offset: 16, NameHash: 3021915972, Flags: 53)]
		public CtrRef<OnlineProviderAsset> Provider { get { return m_Provider; } set { if (OnPropertyChanging("OnlineConfiguration." + nameof(Provider), this, m_Provider, value)) m_Provider = value; } } // 0x10 (16)
		
		protected CtrRef<RichPresenceData> m_RichPresence = new CtrRef<RichPresenceData>();
		[ContainerField(Name: "RichPresence", Offset: 20, NameHash: 789861132, Flags: 53)]
		public CtrRef<RichPresenceData> RichPresence { get { return m_RichPresence; } set { if (OnPropertyChanging("OnlineConfiguration." + nameof(RichPresence), this, m_RichPresence, value)) m_RichPresence = value; } } // 0x14 (20)
		
		protected CtrRef<ChatSettings> m_Chat = new CtrRef<ChatSettings>();
		[ContainerField(Name: "Chat", Offset: 24, NameHash: 2088856251, Flags: 53)]
		public CtrRef<ChatSettings> Chat { get { return m_Chat; } set { if (OnPropertyChanging("OnlineConfiguration." + nameof(Chat), this, m_Chat, value)) m_Chat = value; } } // 0x18 (24)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2290467745:
					Backend = (BackendType) Enum.ToObject(typeof(BackendType), p_Value);
					break;

				case 3021915972:
					Provider = (CtrRef<OnlineProviderAsset>) p_Value;
					break;

				case 789861132:
					RichPresence = (CtrRef<RichPresenceData>) p_Value;
					break;

				case 2088856251:
					Chat = (CtrRef<ChatSettings>) p_Value;
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
				case 2290467745:
					return Backend;

				case 3021915972:
					return Provider;

				case 789861132:
					return RichPresence;

				case 2088856251:
					return Chat;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2290467745:
					return typeof(OnlineConfiguration).GetProperty(nameof(Backend));

				case 3021915972:
					return typeof(OnlineConfiguration).GetProperty(nameof(Provider));

				case 789861132:
					return typeof(OnlineConfiguration).GetProperty(nameof(RichPresence));

				case 2088856251:
					return typeof(OnlineConfiguration).GetProperty(nameof(Chat));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
