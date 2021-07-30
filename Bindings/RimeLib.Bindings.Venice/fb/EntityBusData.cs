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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 32)]
	public class EntityBusData : 
		DataBusData
	{
		protected List<EventConnection> m_EventConnections = new List<EventConnection>();
		[ContainerField(Name: "EventConnections", Offset: 20, NameHash: 2156913324, Flags: 65)]
		public List<EventConnection> EventConnections { get { return m_EventConnections; } set { if (OnPropertyChanging("EntityBusData." + nameof(EventConnections), this, m_EventConnections, value)) m_EventConnections = value; } } // 0x14 (20)
		
		protected CtrRef<InterfaceDescriptorData> m_Descriptor = new CtrRef<InterfaceDescriptorData>();
		[ContainerField(Name: "Descriptor", Offset: 24, NameHash: 570198198, Flags: 53)]
		public CtrRef<InterfaceDescriptorData> Descriptor { get { return m_Descriptor; } set { if (OnPropertyChanging("EntityBusData." + nameof(Descriptor), this, m_Descriptor, value)) m_Descriptor = value; } } // 0x18 (24)
		
		protected bool m_NeedNetworkId = new bool();
		[ContainerField(Name: "NeedNetworkId", Offset: 28, NameHash: 795823100, Flags: 49325), LayoutImmutable, Blittable]
		public bool NeedNetworkId { get { return m_NeedNetworkId; } set { if (OnPropertyChanging("EntityBusData." + nameof(NeedNetworkId), this, m_NeedNetworkId, value)) m_NeedNetworkId = value; } } // 0x1C (28)
		
		protected bool m_InterfaceHasConnections = new bool();
		[ContainerField(Name: "InterfaceHasConnections", Offset: 29, NameHash: 2720026687, Flags: 49325), LayoutImmutable, Blittable]
		public bool InterfaceHasConnections { get { return m_InterfaceHasConnections; } set { if (OnPropertyChanging("EntityBusData." + nameof(InterfaceHasConnections), this, m_InterfaceHasConnections, value)) m_InterfaceHasConnections = value; } } // 0x1D (29)
		
		protected bool m_AlwaysCreateEntityBusClient = new bool();
		[ContainerField(Name: "AlwaysCreateEntityBusClient", Offset: 30, NameHash: 2906839318, Flags: 49325), LayoutImmutable, Blittable]
		public bool AlwaysCreateEntityBusClient { get { return m_AlwaysCreateEntityBusClient; } set { if (OnPropertyChanging("EntityBusData." + nameof(AlwaysCreateEntityBusClient), this, m_AlwaysCreateEntityBusClient, value)) m_AlwaysCreateEntityBusClient = value; } } // 0x1E (30)
		
		protected bool m_AlwaysCreateEntityBusServer = new bool();
		[ContainerField(Name: "AlwaysCreateEntityBusServer", Offset: 31, NameHash: 3549699146, Flags: 49325), LayoutImmutable, Blittable]
		public bool AlwaysCreateEntityBusServer { get { return m_AlwaysCreateEntityBusServer; } set { if (OnPropertyChanging("EntityBusData." + nameof(AlwaysCreateEntityBusServer), this, m_AlwaysCreateEntityBusServer, value)) m_AlwaysCreateEntityBusServer = value; } } // 0x1F (31)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2156913324:
					EventConnections = (List<EventConnection>) p_Value;
					break;

				case 570198198:
					Descriptor = (CtrRef<InterfaceDescriptorData>) p_Value;
					break;

				case 795823100:
					NeedNetworkId = (bool) p_Value;
					break;

				case 2720026687:
					InterfaceHasConnections = (bool) p_Value;
					break;

				case 2906839318:
					AlwaysCreateEntityBusClient = (bool) p_Value;
					break;

				case 3549699146:
					AlwaysCreateEntityBusServer = (bool) p_Value;
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
				case 2156913324:
					return EventConnections;

				case 570198198:
					return Descriptor;

				case 795823100:
					return NeedNetworkId;

				case 2720026687:
					return InterfaceHasConnections;

				case 2906839318:
					return AlwaysCreateEntityBusClient;

				case 3549699146:
					return AlwaysCreateEntityBusServer;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2156913324:
					return typeof(EntityBusData).GetProperty(nameof(EventConnections));

				case 570198198:
					return typeof(EntityBusData).GetProperty(nameof(Descriptor));

				case 795823100:
					return typeof(EntityBusData).GetProperty(nameof(NeedNetworkId));

				case 2720026687:
					return typeof(EntityBusData).GetProperty(nameof(InterfaceHasConnections));

				case 2906839318:
					return typeof(EntityBusData).GetProperty(nameof(AlwaysCreateEntityBusClient));

				case 3549699146:
					return typeof(EntityBusData).GetProperty(nameof(AlwaysCreateEntityBusServer));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
