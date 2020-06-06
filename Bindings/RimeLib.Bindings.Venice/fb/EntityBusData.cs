///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Collections.Generic;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class EntityBusData : 
		DataBusData
	{
		[ContainerField(20)]
		public List<EventConnection> EventConnections { get; set; } = new List<EventConnection>(); // 0x14 (20)
		
		[ContainerField(24)]
		public CtrRef<InterfaceDescriptorData> Descriptor { get; set; } = new CtrRef<InterfaceDescriptorData>(); // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public bool NeedNetworkId { get; set; } // 0x1C (28)
		
		[ContainerField(29), LayoutImmutable, Blittable]
		public bool InterfaceHasConnections { get; set; } // 0x1D (29)
		
		[ContainerField(30), LayoutImmutable, Blittable]
		public bool AlwaysCreateEntityBusClient { get; set; } // 0x1E (30)
		
		[ContainerField(31), LayoutImmutable, Blittable]
		public bool AlwaysCreateEntityBusServer { get; set; } // 0x1F (31)
		
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
