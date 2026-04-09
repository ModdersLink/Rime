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
	[ContainerType(16, 144)]
	public partial class TicketCounterEntityData :
		GameEntityData
	{
		[ObservableProperty]
		[property: ContainerField(96), JsonProperty(Order = 96)]
		private List<TicketCountPercentage> _TicketPercentages = new();

		[ObservableProperty]
		[property: ContainerField(100), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
		private int _TicketLossPerMin;

		[ObservableProperty]
		[property: ContainerField(104), JsonProperty(Order = 104)]
		private TicketDecreaseType _DecreaseTickets = new();

		[ObservableProperty]
		[property: ContainerField(108), JsonProperty(Order = 108)]
		private TeamId _TeamId = new();

		[ObservableProperty]
		[property: ContainerField(112), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		private int _TicketLossWhenLostAll;

		[ObservableProperty]
		[property: ContainerField(116), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
		private int _TicketLossWhenLostAllControlsPoint;

		[ObservableProperty]
		[property: ContainerField(120), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
		private int _InitialTicketCount;

		[ObservableProperty]
		[property: ContainerField(124), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
		private int _TicketLossStart;

		[ObservableProperty]
		[property: ContainerField(128), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		private bool _SetBestSquadSpawner;

		[ObservableProperty]
		[property: ContainerField(129), LayoutImmutable, Blittable, JsonProperty(Order = 129)]
		private bool _HaltTicketLossOnEqualPointCount;

		[ObservableProperty]
		[property: ContainerField(130), LayoutImmutable, Blittable, JsonProperty(Order = 130)]
		private bool _ResetCapturePointsOnReset;

		[ObservableProperty]
		[property: ContainerField(131), LayoutImmutable, Blittable, JsonProperty(Order = 131)]
		private bool _SpawnAlwaysAllowed;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_TicketPercentages = p_EbxWriter.GetArrayWriter(TicketPercentages.GetType(), TicketPercentages.Count);
			p_Writer.Write(s_TicketPercentages.ArrayIndex);
			foreach (var s_Entry in TicketPercentages)
			{
				s_Entry.Serialize(s_TicketPercentages.Writer, p_EbxWriter);
			}
			p_Writer.Write(TicketLossPerMin);
			p_Writer.Write((int) DecreaseTickets);
			p_Writer.Write((int) TeamId);
			p_Writer.Write(TicketLossWhenLostAll);
			p_Writer.Write(TicketLossWhenLostAllControlsPoint);
			p_Writer.Write(InitialTicketCount);
			p_Writer.Write(TicketLossStart);
			p_Writer.Write(SetBestSquadSpawner);
			p_Writer.Write(HaltTicketLossOnEqualPointCount);
			p_Writer.Write(ResetCapturePointsOnReset);
			p_Writer.Write(SpawnAlwaysAllowed);
			p_Writer.WriteNullBytes(12);
		}
	}
}
