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
	[ContainerType(16, 416)]
	public partial class CharacterSpawnReferenceObjectData :
		SpawnReferenceObjectData
	{
		[ObservableProperty]
		[property: ContainerField(384), JsonProperty(Order = 384)]
		private PlayerSpawnType _PlayerType = new();

		[ObservableProperty]
		[property: ContainerField(388), LayoutImmutable, Blittable, JsonProperty(Order = 388)]
		private uint _VehicleEntryIndex;

		[ObservableProperty]
		[property: ContainerField(392), JsonProperty(Order = 392)]
		private CtrRef<SoldierSpawnTemplateData> _Template = new();

		[ObservableProperty]
		[property: ContainerField(396), LayoutImmutable, Blittable, JsonProperty(Order = 396)]
		private float _HumanTargetPreference;

		[ObservableProperty]
		[property: ContainerField(400), JsonProperty(Order = 400)]
		private UIHudIcon _MinimapIcon = new();

		[ObservableProperty]
		[property: ContainerField(404), LayoutImmutable, Blittable, JsonProperty(Order = 404)]
		private bool _AllowFallbackOnNextAvailabeVehicleEntry;

		[ObservableProperty]
		[property: ContainerField(405), LayoutImmutable, Blittable, JsonProperty(Order = 405)]
		private bool _CheckMaxPlayersInVehicle;

		[ObservableProperty]
		[property: ContainerField(406), LayoutImmutable, Blittable, JsonProperty(Order = 406)]
		private bool _AffectMinimapPosition;

		[ObservableProperty]
		[property: ContainerField(407), LayoutImmutable, Blittable, JsonProperty(Order = 407)]
		private bool _IsTarget;

		[ObservableProperty]
		[property: ContainerField(408), LayoutImmutable, Blittable, JsonProperty(Order = 408)]
		private bool _IgnoreVehicleIcon;

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
