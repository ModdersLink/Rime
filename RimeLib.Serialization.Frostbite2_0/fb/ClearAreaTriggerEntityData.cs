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
	[ContainerType(16, 128)]
	public class ClearAreaTriggerEntityData :
		TriggerEntityData
	{
		[ContainerField(112), JsonProperty(Order = 112)]
		public TeamId TeamOfImmortalSoldiers { get; set; } = new();

		[ContainerField(116), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
		public bool RemoveBangers { get; set; }

		[ContainerField(117), LayoutImmutable, Blittable, JsonProperty(Order = 117)]
		public bool RemoveVehicles { get; set; }

		[ContainerField(118), LayoutImmutable, Blittable, JsonProperty(Order = 118)]
		public bool RemoveEffects { get; set; }

		[ContainerField(119), LayoutImmutable, Blittable, JsonProperty(Order = 119)]
		public bool RemoveStaticModels { get; set; }

		[ContainerField(120), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
		public bool RemoveDebrisClusters { get; set; }

		[ContainerField(121), LayoutImmutable, Blittable, JsonProperty(Order = 121)]
		public bool ExcludeImmortalSoldiersInTeam { get; set; }

		[ContainerField(122), LayoutImmutable, Blittable, JsonProperty(Order = 122)]
		public bool RemoveMeshProxies { get; set; }

		[ContainerField(123), LayoutImmutable, Blittable, JsonProperty(Order = 123)]
		public bool RemoveSoldiers { get; set; }

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
