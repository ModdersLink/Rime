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
	[ContainerType(16, 160)]
	public class VehicleStateTriggerEntityData :
		TriggerEntityData
	{
		[ContainerField(112), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		public float LockAmount { get; set; }

		[ContainerField(116), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
		public uint BulletCount { get; set; }

		[ContainerField(120), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
		public uint HealthToSet { get; set; }

		[ContainerField(124), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
		public uint SeatSpecificIndexForHuman { get; set; }

		[ContainerField(128), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		public uint SeatSpecificIndexForAi { get; set; }

		[ContainerField(132), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
		public float DestructionRadius { get; set; }

		[ContainerField(136), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
		public uint HealthToCheck { get; set; }

		[ContainerField(140), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
		public bool AllowHumanToEnterAllSeats { get; set; }

		[ContainerField(141), LayoutImmutable, Blittable, JsonProperty(Order = 141)]
		public bool AllowAiToEnterAllSeats { get; set; }

		[ContainerField(142), LayoutImmutable, Blittable, JsonProperty(Order = 142)]
		public bool BanAiFromSpecificSeat { get; set; }

		[ContainerField(143), LayoutImmutable, Blittable, JsonProperty(Order = 143)]
		public bool TriggerCriticalOnHealthSet { get; set; }

		[ContainerField(144), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
		public bool CheckHealthGreaterOrEqual { get; set; }

		[ContainerField(145), LayoutImmutable, Blittable, JsonProperty(Order = 145)]
		public bool RestrictHumanToSpecificSeat { get; set; }

		[ContainerField(146), LayoutImmutable, Blittable, JsonProperty(Order = 146)]
		public bool ShouldDestroyVehicles { get; set; }

		[ContainerField(147), LayoutImmutable, Blittable, JsonProperty(Order = 147)]
		public bool ShouldDestroyBangers { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(LockAmount);
			p_Writer.Write(BulletCount);
			p_Writer.Write(HealthToSet);
			p_Writer.Write(SeatSpecificIndexForHuman);
			p_Writer.Write(SeatSpecificIndexForAi);
			p_Writer.Write(DestructionRadius);
			p_Writer.Write(HealthToCheck);
			p_Writer.Write(AllowHumanToEnterAllSeats);
			p_Writer.Write(AllowAiToEnterAllSeats);
			p_Writer.Write(BanAiFromSpecificSeat);
			p_Writer.Write(TriggerCriticalOnHealthSet);
			p_Writer.Write(CheckHealthGreaterOrEqual);
			p_Writer.Write(RestrictHumanToSpecificSeat);
			p_Writer.Write(ShouldDestroyVehicles);
			p_Writer.Write(ShouldDestroyBangers);
			p_Writer.WriteNullBytes(12);
		}
	}
}
