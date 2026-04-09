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
	[ContainerType(16, 160)]
	public partial class VehicleStateTriggerEntityData :
		TriggerEntityData
	{
		[ObservableProperty]
		[property: ContainerField(112), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		private float _LockAmount;

		[ObservableProperty]
		[property: ContainerField(116), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
		private uint _BulletCount;

		[ObservableProperty]
		[property: ContainerField(120), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
		private uint _HealthToSet;

		[ObservableProperty]
		[property: ContainerField(124), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
		private uint _SeatSpecificIndexForHuman;

		[ObservableProperty]
		[property: ContainerField(128), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		private uint _SeatSpecificIndexForAi;

		[ObservableProperty]
		[property: ContainerField(132), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
		private float _DestructionRadius;

		[ObservableProperty]
		[property: ContainerField(136), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
		private uint _HealthToCheck;

		[ObservableProperty]
		[property: ContainerField(140), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
		private bool _AllowHumanToEnterAllSeats;

		[ObservableProperty]
		[property: ContainerField(141), LayoutImmutable, Blittable, JsonProperty(Order = 141)]
		private bool _AllowAiToEnterAllSeats;

		[ObservableProperty]
		[property: ContainerField(142), LayoutImmutable, Blittable, JsonProperty(Order = 142)]
		private bool _BanAiFromSpecificSeat;

		[ObservableProperty]
		[property: ContainerField(143), LayoutImmutable, Blittable, JsonProperty(Order = 143)]
		private bool _TriggerCriticalOnHealthSet;

		[ObservableProperty]
		[property: ContainerField(144), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
		private bool _CheckHealthGreaterOrEqual;

		[ObservableProperty]
		[property: ContainerField(145), LayoutImmutable, Blittable, JsonProperty(Order = 145)]
		private bool _RestrictHumanToSpecificSeat;

		[ObservableProperty]
		[property: ContainerField(146), LayoutImmutable, Blittable, JsonProperty(Order = 146)]
		private bool _ShouldDestroyVehicles;

		[ObservableProperty]
		[property: ContainerField(147), LayoutImmutable, Blittable, JsonProperty(Order = 147)]
		private bool _ShouldDestroyBangers;

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
