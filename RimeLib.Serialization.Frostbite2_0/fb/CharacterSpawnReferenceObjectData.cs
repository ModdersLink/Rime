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
	[ContainerType(16, 416)]
	public class CharacterSpawnReferenceObjectData :
		SpawnReferenceObjectData
	{
		[ContainerField(384), JsonProperty(Order = 384)]
		public PlayerSpawnType PlayerType { get; set; } = new();

		[ContainerField(388), LayoutImmutable, Blittable, JsonProperty(Order = 388)]
		public uint VehicleEntryIndex { get; set; }

		[ContainerField(392), JsonProperty(Order = 392)]
		public CtrRef<SoldierSpawnTemplateData> Template { get; set; } = new();

		[ContainerField(396), LayoutImmutable, Blittable, JsonProperty(Order = 396)]
		public float HumanTargetPreference { get; set; }

		[ContainerField(400), JsonProperty(Order = 400)]
		public UIHudIcon MinimapIcon { get; set; } = new();

		[ContainerField(404), LayoutImmutable, Blittable, JsonProperty(Order = 404)]
		public bool AllowFallbackOnNextAvailabeVehicleEntry { get; set; }

		[ContainerField(405), LayoutImmutable, Blittable, JsonProperty(Order = 405)]
		public bool CheckMaxPlayersInVehicle { get; set; }

		[ContainerField(406), LayoutImmutable, Blittable, JsonProperty(Order = 406)]
		public bool AffectMinimapPosition { get; set; }

		[ContainerField(407), LayoutImmutable, Blittable, JsonProperty(Order = 407)]
		public bool IsTarget { get; set; }

		[ContainerField(408), LayoutImmutable, Blittable, JsonProperty(Order = 408)]
		public bool IgnoreVehicleIcon { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write((int) PlayerType);
			p_Writer.Write(VehicleEntryIndex);
			p_Writer.Write(p_EbxWriter.WriteImport(Template));
			p_Writer.Write(HumanTargetPreference);
			p_Writer.Write((int) MinimapIcon);
			p_Writer.Write(AllowFallbackOnNextAvailabeVehicleEntry);
			p_Writer.Write(CheckMaxPlayersInVehicle);
			p_Writer.Write(AffectMinimapPosition);
			p_Writer.Write(IsTarget);
			p_Writer.Write(IgnoreVehicleIcon);
			p_Writer.WriteNullBytes(7);
		}
	}
}
