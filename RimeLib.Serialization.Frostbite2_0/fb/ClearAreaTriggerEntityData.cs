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
	public partial class ClearAreaTriggerEntityData :
		TriggerEntityData
	{
		[ObservableProperty]
		[property: ContainerField(112), JsonProperty(Order = 112)]
		private TeamId _TeamOfImmortalSoldiers = new();

		[ObservableProperty]
		[property: ContainerField(116), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
		private bool _RemoveBangers;

		[ObservableProperty]
		[property: ContainerField(117), LayoutImmutable, Blittable, JsonProperty(Order = 117)]
		private bool _RemoveVehicles;

		[ObservableProperty]
		[property: ContainerField(118), LayoutImmutable, Blittable, JsonProperty(Order = 118)]
		private bool _RemoveEffects;

		[ObservableProperty]
		[property: ContainerField(119), LayoutImmutable, Blittable, JsonProperty(Order = 119)]
		private bool _RemoveStaticModels;

		[ObservableProperty]
		[property: ContainerField(120), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
		private bool _RemoveDebrisClusters;

		[ObservableProperty]
		[property: ContainerField(121), LayoutImmutable, Blittable, JsonProperty(Order = 121)]
		private bool _ExcludeImmortalSoldiersInTeam;

		[ObservableProperty]
		[property: ContainerField(122), LayoutImmutable, Blittable, JsonProperty(Order = 122)]
		private bool _RemoveMeshProxies;

		[ObservableProperty]
		[property: ContainerField(123), LayoutImmutable, Blittable, JsonProperty(Order = 123)]
		private bool _RemoveSoldiers;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write((int) TeamOfImmortalSoldiers);
			p_Writer.Write(RemoveBangers);
			p_Writer.Write(RemoveVehicles);
			p_Writer.Write(RemoveEffects);
			p_Writer.Write(RemoveStaticModels);
			p_Writer.Write(RemoveDebrisClusters);
			p_Writer.Write(ExcludeImmortalSoldiersInTeam);
			p_Writer.Write(RemoveMeshProxies);
			p_Writer.Write(RemoveSoldiers);
			p_Writer.WriteNullBytes(4);
		}
	}
}
