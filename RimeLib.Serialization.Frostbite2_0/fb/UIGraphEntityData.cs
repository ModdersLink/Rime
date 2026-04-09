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
	public partial class UIGraphEntityData :
		EntityData
	{
		[ObservableProperty]
		[property: ContainerField(12), JsonProperty(Order = 12)]
		private List<EventSpec> _Events = new();

		[ObservableProperty]
		[property: ContainerField(16), JsonProperty(Order = 16)]
		private CtrRef<UIGraphAsset> _GraphAsset = new();

		[ObservableProperty]
		[property: ContainerField(20), JsonProperty(Order = 20)]
		private UIGraphPriority _GraphPriority = new();

		[ObservableProperty]
		[property: ContainerField(24), JsonProperty(Order = 24)]
		private UIState _State = new();

		[ObservableProperty]
		[property: ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		private bool _PopPreviousGraph;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_Events = p_EbxWriter.GetArrayWriter(Events.GetType(), Events.Count);
			p_Writer.Write(s_Events.ArrayIndex);
			foreach (var s_Entry in Events)
			{
				s_Entry.Serialize(s_Events.Writer, p_EbxWriter);
			}
			p_Writer.Write(p_EbxWriter.WriteImport(GraphAsset));
			p_Writer.Write((int) GraphPriority);
			p_Writer.Write((int) State);
			p_Writer.Write(PopPreviousGraph);
			p_Writer.WriteNullBytes(3);
		}
	}
}
