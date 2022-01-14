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
	[ContainerType(16, 512)]
	public class VehicleSpawnReferenceObjectData :
		SpawnReferenceObjectData
	{
		[ContainerField(384), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 384)]
		public LinearTransform AirDropCarrierTransform { get; set; } = new();

		[ContainerField(448), LayoutImmutable, Blittable, JsonProperty(Order = 448)]
		public float TimeUntilAbandoned { get; set; }

		[ContainerField(452), LayoutImmutable, Blittable, JsonProperty(Order = 452)]
		public float TimeUntilAbandonedIsDestroyed { get; set; }

		[ContainerField(456), JsonProperty(Order = 456)]
		public EntryEnterRestriction EnterRestriction { get; set; } = new();

		[ContainerField(460), LayoutImmutable, Blittable, JsonProperty(Order = 460)]
		public float BotBailWhenHealthBelow { get; set; }

		[ContainerField(464), LayoutImmutable, Blittable, JsonProperty(Order = 464)]
		public float BotBailOutDelay { get; set; }

		[ContainerField(468), LayoutImmutable, Blittable, JsonProperty(Order = 468)]
		public float WreckDuration { get; set; }

		[ContainerField(472), LayoutImmutable, Blittable, JsonProperty(Order = 472)]
		public float RespawnRange { get; set; }

		[ContainerField(476), LayoutImmutable, Blittable, JsonProperty(Order = 476)]
		public int ActiveStanceEntryIndex { get; set; }

		[ContainerField(480), LayoutImmutable, Blittable, JsonProperty(Order = 480)]
		public int ActiveStance { get; set; }

		[ContainerField(484), LayoutImmutable, Blittable, JsonProperty(Order = 484)]
		public float KeepAliveRadius { get; set; }

		[ContainerField(488), LayoutImmutable, Blittable, JsonProperty(Order = 488)]
		public float VehicleIsNearDistance { get; set; }

		[ContainerField(492), LayoutImmutable, Blittable, JsonProperty(Order = 492)]
		public bool SetTeamOnSpawn { get; set; }

		[ContainerField(493), LayoutImmutable, Blittable, JsonProperty(Order = 493)]
		public bool ApplyDamageToAbandonedVehicles { get; set; }

		[ContainerField(494), LayoutImmutable, Blittable, JsonProperty(Order = 494)]
		public bool EnableAvailableSeatOutput { get; set; }

		[ContainerField(495), LayoutImmutable, Blittable, JsonProperty(Order = 495)]
		public bool DisregardSpawnAllowedSetting { get; set; }

		[ContainerField(496), LayoutImmutable, Blittable, JsonProperty(Order = 496)]
		public bool AffectedByImpulse { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			AirDropCarrierTransform.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(TimeUntilAbandoned);
			p_Writer.Write(TimeUntilAbandonedIsDestroyed);
			p_Writer.Write((int) EnterRestriction);
			p_Writer.Write(BotBailWhenHealthBelow);
			p_Writer.Write(BotBailOutDelay);
			p_Writer.Write(WreckDuration);
			p_Writer.Write(RespawnRange);
			p_Writer.Write(ActiveStanceEntryIndex);
			p_Writer.Write(ActiveStance);
			p_Writer.Write(KeepAliveRadius);
			p_Writer.Write(VehicleIsNearDistance);
			p_Writer.Write(SetTeamOnSpawn);
			p_Writer.Write(ApplyDamageToAbandonedVehicles);
			p_Writer.Write(EnableAvailableSeatOutput);
			p_Writer.Write(DisregardSpawnAllowedSetting);
			p_Writer.Write(AffectedByImpulse);
			p_Writer.WriteNullBytes(15);
		}
	}
}
