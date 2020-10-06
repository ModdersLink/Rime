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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(32), ContainerClass]
	public class EntityBusData : 
		DataBusData
	{
		protected List<EventConnection> m_EventConnections = new List<EventConnection>();
		[ContainerField(20), MemberInfoFlag(65), ContainerFieldNameHash(2156913324), ContainerArray]
		public List<EventConnection> EventConnections { get { return m_EventConnections; } set { if (OnPropertyChanging("EntityBusData." + nameof(EventConnections), this, m_EventConnections, value)) m_EventConnections = value; } } // 0x14 (20)
		
		protected CtrRef<InterfaceDescriptorData> m_Descriptor = new CtrRef<InterfaceDescriptorData>();
		[ContainerField(24), MemberInfoFlag(53), ContainerFieldNameHash(570198198), ContainerCtrRef]
		public CtrRef<InterfaceDescriptorData> Descriptor { get { return m_Descriptor; } set { if (OnPropertyChanging("EntityBusData." + nameof(Descriptor), this, m_Descriptor, value)) m_Descriptor = value; } } // 0x18 (24)
		
		protected bool m_NeedNetworkId = new bool();
		[ContainerField(28), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(795823100)]
		public bool NeedNetworkId { get { return m_NeedNetworkId; } set { if (OnPropertyChanging("EntityBusData." + nameof(NeedNetworkId), this, m_NeedNetworkId, value)) m_NeedNetworkId = value; } } // 0x1C (28)
		
		protected bool m_InterfaceHasConnections = new bool();
		[ContainerField(29), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2720026687)]
		public bool InterfaceHasConnections { get { return m_InterfaceHasConnections; } set { if (OnPropertyChanging("EntityBusData." + nameof(InterfaceHasConnections), this, m_InterfaceHasConnections, value)) m_InterfaceHasConnections = value; } } // 0x1D (29)
		
		protected bool m_AlwaysCreateEntityBusClient = new bool();
		[ContainerField(30), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2906839318)]
		public bool AlwaysCreateEntityBusClient { get { return m_AlwaysCreateEntityBusClient; } set { if (OnPropertyChanging("EntityBusData." + nameof(AlwaysCreateEntityBusClient), this, m_AlwaysCreateEntityBusClient, value)) m_AlwaysCreateEntityBusClient = value; } } // 0x1E (30)
		
		protected bool m_AlwaysCreateEntityBusServer = new bool();
		[ContainerField(31), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3549699146)]
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
