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
using RimeLib.Serialization.Ebx;
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(16, 144)]
	public class TicketCounterEntityData :
		GameEntityData
	{
		[ContainerField(96), JsonProperty(Order = 96)]
		public List<TicketCountPercentage> TicketPercentages { get; set; } = new();

		[ContainerField(100), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
		public int TicketLossPerMin { get; set; }

		[ContainerField(104), JsonProperty(Order = 104)]
		public TicketDecreaseType DecreaseTickets { get; set; } = new();

		[ContainerField(108), JsonProperty(Order = 108)]
		public TeamId TeamId { get; set; } = new();

		[ContainerField(112), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		public int TicketLossWhenLostAll { get; set; }

		[ContainerField(116), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
		public int TicketLossWhenLostAllControlsPoint { get; set; }

		[ContainerField(120), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
		public int InitialTicketCount { get; set; }

		[ContainerField(124), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
		public int TicketLossStart { get; set; }

		[ContainerField(128), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		public bool SetBestSquadSpawner { get; set; }

		[ContainerField(129), LayoutImmutable, Blittable, JsonProperty(Order = 129)]
		public bool HaltTicketLossOnEqualPointCount { get; set; }

		[ContainerField(130), LayoutImmutable, Blittable, JsonProperty(Order = 130)]
		public bool ResetCapturePointsOnReset { get; set; }

		[ContainerField(131), LayoutImmutable, Blittable, JsonProperty(Order = 131)]
		public bool SpawnAlwaysAllowed { get; set; }

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
