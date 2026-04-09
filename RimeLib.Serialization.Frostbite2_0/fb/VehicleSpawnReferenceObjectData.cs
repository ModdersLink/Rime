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
	[ContainerType(16, 512)]
	public partial class VehicleSpawnReferenceObjectData :
		SpawnReferenceObjectData
	{
		[ObservableProperty]
		[property: ContainerField(384), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 384)]
		private LinearTransform _AirDropCarrierTransform = new();

		[ObservableProperty]
		[property: ContainerField(448), LayoutImmutable, Blittable, JsonProperty(Order = 448)]
		private float _TimeUntilAbandoned;

		[ObservableProperty]
		[property: ContainerField(452), LayoutImmutable, Blittable, JsonProperty(Order = 452)]
		private float _TimeUntilAbandonedIsDestroyed;

		[ObservableProperty]
		[property: ContainerField(456), JsonProperty(Order = 456)]
		private EntryEnterRestriction _EnterRestriction = new();

		[ObservableProperty]
		[property: ContainerField(460), LayoutImmutable, Blittable, JsonProperty(Order = 460)]
		private float _BotBailWhenHealthBelow;

		[ObservableProperty]
		[property: ContainerField(464), LayoutImmutable, Blittable, JsonProperty(Order = 464)]
		private float _BotBailOutDelay;

		[ObservableProperty]
		[property: ContainerField(468), LayoutImmutable, Blittable, JsonProperty(Order = 468)]
		private float _WreckDuration;

		[ObservableProperty]
		[property: ContainerField(472), LayoutImmutable, Blittable, JsonProperty(Order = 472)]
		private float _RespawnRange;

		[ObservableProperty]
		[property: ContainerField(476), LayoutImmutable, Blittable, JsonProperty(Order = 476)]
		private int _ActiveStanceEntryIndex;

		[ObservableProperty]
		[property: ContainerField(480), LayoutImmutable, Blittable, JsonProperty(Order = 480)]
		private int _ActiveStance;

		[ObservableProperty]
		[property: ContainerField(484), LayoutImmutable, Blittable, JsonProperty(Order = 484)]
		private float _KeepAliveRadius;

		[ObservableProperty]
		[property: ContainerField(488), LayoutImmutable, Blittable, JsonProperty(Order = 488)]
		private float _VehicleIsNearDistance;

		[ObservableProperty]
		[property: ContainerField(492), LayoutImmutable, Blittable, JsonProperty(Order = 492)]
		private bool _SetTeamOnSpawn;

		[ObservableProperty]
		[property: ContainerField(493), LayoutImmutable, Blittable, JsonProperty(Order = 493)]
		private bool _ApplyDamageToAbandonedVehicles;

		[ObservableProperty]
		[property: ContainerField(494), LayoutImmutable, Blittable, JsonProperty(Order = 494)]
		private bool _EnableAvailableSeatOutput;

		[ObservableProperty]
		[property: ContainerField(495), LayoutImmutable, Blittable, JsonProperty(Order = 495)]
		private bool _DisregardSpawnAllowedSetting;

		[ObservableProperty]
		[property: ContainerField(496), LayoutImmutable, Blittable, JsonProperty(Order = 496)]
		private bool _AffectedByImpulse;

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
