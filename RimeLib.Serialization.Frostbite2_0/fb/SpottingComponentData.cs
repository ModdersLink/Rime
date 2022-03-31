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

namespace fb
{
	[ContainerType(16, 160)]
	public class SpottingComponentData :
		ComponentData
	{
		[ContainerField(96), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		public float SpottingFov { get; set; }

		[ContainerField(100), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
		public float TeamOrderFov { get; set; }

		[ContainerField(104), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
		public float SpottingDistance { get; set; }

		[ContainerField(108), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
		public float PassiveSpottingTimeInterval { get; set; }

		[ContainerField(112), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		public float TimeRequiredToPassiveSpot { get; set; }

		[ContainerField(116), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
		public float OrderNeedAmmoPercentage { get; set; }

		[ContainerField(120), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
		public float OrderHealPercentage { get; set; }

		[ContainerField(124), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
		public float OrderRepairPercentage { get; set; }

		[ContainerField(128), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		public float PickupOrderDistance { get; set; }

		[ContainerField(132), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
		public float HealOrderDistance { get; set; }

		[ContainerField(136), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
		public float AmmoOrderDistance { get; set; }

		[ContainerField(140), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
		public float RepairOrderDistance { get; set; }

		[ContainerField(144), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
		public float CoolDownHistoryTime { get; set; }

		[ContainerField(148), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
		public int CoolDownAllowedSpotsWithinHistory { get; set; }

		[ContainerField(152), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
		public bool OnlyAllowedToHaveOneSpottedPlayer { get; set; }

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
