///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4, 32)]
	public class EntityBusData : 
		DataBusData
	{
		[ContainerField(20)]
		public List<EventConnection> EventConnections { get; set; } = new();

		[ContainerField(24)]
		public CtrRef<InterfaceDescriptorData> Descriptor { get; set; } = new();

		[ContainerField(28), LayoutImmutable, Blittable]
		public bool NeedNetworkId { get; set; }

		[ContainerField(29), LayoutImmutable, Blittable]
		public bool InterfaceHasConnections { get; set; }

		[ContainerField(30), LayoutImmutable, Blittable]
		public bool AlwaysCreateEntityBusClient { get; set; }

		[ContainerField(31), LayoutImmutable, Blittable]
		public bool AlwaysCreateEntityBusServer { get; set; }

		public static void Deserialize(EntityBusData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.EventConnections.Clear();
			(RimeReader Reader, uint Count) s_EventConnections = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_EventConnections.Count; ++i)
			{
				var s_Value = new EventConnection();
				fb.EventConnection.Deserialize(s_Value, s_EventConnections.Reader, p_Parser);
				p_Instance.EventConnections.Add(s_Value);
			}
			
			s_EventConnections.Reader.Dispose();
			p_Instance.Descriptor.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.NeedNetworkId = p_Reader.ReadBool();
			p_Instance.InterfaceHasConnections = p_Reader.ReadBool();
			p_Instance.AlwaysCreateEntityBusClient = p_Reader.ReadBool();
			p_Instance.AlwaysCreateEntityBusServer = p_Reader.ReadBool();
		}

	}
}
