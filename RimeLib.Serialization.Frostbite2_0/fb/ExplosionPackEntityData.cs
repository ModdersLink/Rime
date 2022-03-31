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
	[ContainerType(16, 256)]
	public class ExplosionPackEntityData :
		MeshProjectileEntityData
	{
		[ContainerField(192), LayoutImmutable, Blittable, JsonProperty(Order = 192)]
		public float TimeToLiveOnPlayerDeath { get; set; }

		[ContainerField(196), JsonProperty(Order = 196)]
		public SoldierDetonationData SoldierDetonationData { get; set; } = new();

		[ContainerField(216), LayoutImmutable, Blittable, JsonProperty(Order = 216)]
		public float VehicleDetonationActivationDelay { get; set; }

		[ContainerField(220), LayoutImmutable, Blittable, JsonProperty(Order = 220)]
		public float VehicleDetonationRadius { get; set; }

		[ContainerField(224), JsonProperty(Order = 224)]
		public UIHudIcon Icon { get; set; } = new();

		[ContainerField(228), LayoutImmutable, Blittable, JsonProperty(Order = 228)]
		public float SpottedTime { get; set; }

		[ContainerField(232), LayoutImmutable, Blittable, JsonProperty(Order = 232)]
		public float DefuseRadius { get; set; }

		[ContainerField(236), LayoutImmutable, Blittable, JsonProperty(Order = 236)]
		public float Health { get; set; }

		[ContainerField(240), LayoutImmutable, Blittable, JsonProperty(Order = 240)]
		public bool HasRemoteDetonator { get; set; }

		[ContainerField(241), LayoutImmutable, Blittable, JsonProperty(Order = 241)]
		public bool IsDestructible { get; set; }

		[ContainerField(242), LayoutImmutable, Blittable, JsonProperty(Order = 242)]
		public bool HasVehicleDetonation { get; set; }

		[ContainerField(243), LayoutImmutable, Blittable, JsonProperty(Order = 243)]
		public bool ReceivesExplosionDamage { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(TimeToLiveOnPlayerDeath);
			SoldierDetonationData.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(VehicleDetonationActivationDelay);
			p_Writer.Write(VehicleDetonationRadius);
			p_Writer.Write((int) Icon);
			p_Writer.Write(SpottedTime);
			p_Writer.Write(DefuseRadius);
			p_Writer.Write(Health);
			p_Writer.Write(HasRemoteDetonator);
			p_Writer.Write(IsDestructible);
			p_Writer.Write(HasVehicleDetonation);
			p_Writer.Write(ReceivesExplosionDamage);
			p_Writer.WriteNullBytes(12);
		}
	}
}
