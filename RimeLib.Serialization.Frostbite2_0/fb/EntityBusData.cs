///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Frostbite2_0.Ebx;
using CommunityToolkit.Mvvm.ComponentModel;

namespace fb
{
	[ContainerType(4, 32)]
	public partial class EntityBusData :
		DataBusData
	{
		[ObservableProperty]
		[property: ContainerField(20), JsonProperty(Order = 20)]
		private List<EventConnection> _EventConnections = new();

		[ObservableProperty]
		[property: ContainerField(24), JsonProperty(Order = 24)]
		private CtrRef<InterfaceDescriptorData> _Descriptor = new();

		[ObservableProperty]
		[property: ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		private bool _NeedNetworkId;

		[ObservableProperty]
		[property: ContainerField(29), LayoutImmutable, Blittable, JsonProperty(Order = 29)]
		private bool _InterfaceHasConnections;

		[ObservableProperty]
		[property: ContainerField(30), LayoutImmutable, Blittable, JsonProperty(Order = 30)]
		private bool _AlwaysCreateEntityBusClient;

		[ObservableProperty]
		[property: ContainerField(31), LayoutImmutable, Blittable, JsonProperty(Order = 31)]
		private bool _AlwaysCreateEntityBusServer;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_EventConnections = p_EbxWriter.GetArrayWriter(EventConnections.GetType(), EventConnections.Count);
			p_Writer.Write(s_EventConnections.ArrayIndex);
			foreach (var s_Entry in EventConnections)
			{
				s_Entry.Serialize(s_EventConnections.Writer, p_EbxWriter);
			}
			p_Writer.Write(p_EbxWriter.WriteImport(Descriptor));
			p_Writer.Write(NeedNetworkId);
			p_Writer.Write(InterfaceHasConnections);
			p_Writer.Write(AlwaysCreateEntityBusClient);
			p_Writer.Write(AlwaysCreateEntityBusServer);
		}
	}
}
