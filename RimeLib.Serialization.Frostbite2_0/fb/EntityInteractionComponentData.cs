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
	[ContainerType(16, 144)]
	public class EntityInteractionComponentData :
		ComponentData
	{
		[ContainerField(96), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		public float PickupRadius { get; set; }

		[ContainerField(100), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
		public float MaxAmmoPickupTimer { get; set; }

		[ContainerField(104), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
		public float MaxAmmoCrateTimer { get; set; }

		[ContainerField(108), JsonProperty(Order = 108)]
		public InteractionTypesData InteractWithTypes { get; set; } = new();

		[ContainerField(116), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
		public float MaxLookAtAngle { get; set; }

		[ContainerField(120), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
		public float SoldierInteractRadius { get; set; }

		[ContainerField(124), JsonProperty(Order = 124)]
		public EntryInputActionEnum SoldierInteractInputAction { get; set; } = new();

		[ContainerField(128), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		public bool AllowInteractionWithSoldiers { get; set; }

		[ContainerField(129), LayoutImmutable, Blittable, JsonProperty(Order = 129)]
		public bool OnlyAllowInteractionWithManDownSoldiers { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(PickupRadius);
			p_Writer.Write(MaxAmmoPickupTimer);
			p_Writer.Write(MaxAmmoCrateTimer);
			InteractWithTypes.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(2);
			p_Writer.Write(MaxLookAtAngle);
			p_Writer.Write(SoldierInteractRadius);
			p_Writer.Write((int) SoldierInteractInputAction);
			p_Writer.Write(AllowInteractionWithSoldiers);
			p_Writer.Write(OnlyAllowInteractionWithManDownSoldiers);
			p_Writer.WriteNullBytes(14);
		}
	}
}
