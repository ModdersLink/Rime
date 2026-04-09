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
	public partial class SpottingComponentData :
		ComponentData
	{
		[ObservableProperty]
		[property: ContainerField(96), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		private float _SpottingFov;

		[ObservableProperty]
		[property: ContainerField(100), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
		private float _TeamOrderFov;

		[ObservableProperty]
		[property: ContainerField(104), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
		private float _SpottingDistance;

		[ObservableProperty]
		[property: ContainerField(108), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
		private float _PassiveSpottingTimeInterval;

		[ObservableProperty]
		[property: ContainerField(112), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		private float _TimeRequiredToPassiveSpot;

		[ObservableProperty]
		[property: ContainerField(116), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
		private float _OrderNeedAmmoPercentage;

		[ObservableProperty]
		[property: ContainerField(120), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
		private float _OrderHealPercentage;

		[ObservableProperty]
		[property: ContainerField(124), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
		private float _OrderRepairPercentage;

		[ObservableProperty]
		[property: ContainerField(128), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		private float _PickupOrderDistance;

		[ObservableProperty]
		[property: ContainerField(132), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
		private float _HealOrderDistance;

		[ObservableProperty]
		[property: ContainerField(136), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
		private float _AmmoOrderDistance;

		[ObservableProperty]
		[property: ContainerField(140), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
		private float _RepairOrderDistance;

		[ObservableProperty]
		[property: ContainerField(144), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
		private float _CoolDownHistoryTime;

		[ObservableProperty]
		[property: ContainerField(148), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
		private int _CoolDownAllowedSpotsWithinHistory;

		[ObservableProperty]
		[property: ContainerField(152), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
		private bool _OnlyAllowedToHaveOneSpottedPlayer;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(SpottingFov);
			p_Writer.Write(TeamOrderFov);
			p_Writer.Write(SpottingDistance);
			p_Writer.Write(PassiveSpottingTimeInterval);
			p_Writer.Write(TimeRequiredToPassiveSpot);
			p_Writer.Write(OrderNeedAmmoPercentage);
			p_Writer.Write(OrderHealPercentage);
			p_Writer.Write(OrderRepairPercentage);
			p_Writer.Write(PickupOrderDistance);
			p_Writer.Write(HealOrderDistance);
			p_Writer.Write(AmmoOrderDistance);
			p_Writer.Write(RepairOrderDistance);
			p_Writer.Write(CoolDownHistoryTime);
			p_Writer.Write(CoolDownAllowedSpotsWithinHistory);
			p_Writer.Write(OnlyAllowedToHaveOneSpottedPlayer);
			p_Writer.WriteNullBytes(7);
		}
	}
}
