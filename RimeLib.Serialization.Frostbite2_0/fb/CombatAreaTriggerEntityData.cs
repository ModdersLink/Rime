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
	[ContainerType(16, 128)]
	public partial class CombatAreaTriggerEntityData :
		GameEntityData
	{
		[ObservableProperty]
		[property: ContainerField(96), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		private float _MaxRandomSpawnHeight;

		[ObservableProperty]
		[property: ContainerField(100), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
		private float _SpawnHeight;

		[ObservableProperty]
		[property: ContainerField(104), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
		private uint _TimeToReturn;

		[ObservableProperty]
		[property: ContainerField(108), JsonProperty(Order = 108)]
		private CtrRef<BulletEntityData> _DeserterProjectile = new();

		[ObservableProperty]
		[property: ContainerField(112), JsonProperty(Order = 112)]
		private TeamId _Team = new();

		[ObservableProperty]
		[property: ContainerField(116), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
		private float _StrikeRadius;

		[ObservableProperty]
		[property: ContainerField(120), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
		private float _InitalSpeed;

		[ObservableProperty]
		[property: ContainerField(124), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
		private bool _IsAiAllowedOutside;

		[ObservableProperty]
		[property: ContainerField(125), LayoutImmutable, Blittable, JsonProperty(Order = 125)]
		private bool _IsTeamSpecific;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(MaxRandomSpawnHeight);
			p_Writer.Write(SpawnHeight);
			p_Writer.Write(TimeToReturn);
			p_Writer.Write(p_EbxWriter.WriteImport(DeserterProjectile));
			p_Writer.Write((int) Team);
			p_Writer.Write(StrikeRadius);
			p_Writer.Write(InitalSpeed);
			p_Writer.Write(IsAiAllowedOutside);
			p_Writer.Write(IsTeamSpecific);
			p_Writer.WriteNullBytes(2);
		}
	}
}
