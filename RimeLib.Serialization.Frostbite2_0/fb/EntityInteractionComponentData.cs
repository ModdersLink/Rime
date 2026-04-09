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
	[ContainerType(16, 144)]
	public partial class EntityInteractionComponentData :
		ComponentData
	{
		[ObservableProperty]
		[property: ContainerField(96), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		private float _PickupRadius;

		[ObservableProperty]
		[property: ContainerField(100), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
		private float _MaxAmmoPickupTimer;

		[ObservableProperty]
		[property: ContainerField(104), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
		private float _MaxAmmoCrateTimer;

		[ObservableProperty]
		[property: ContainerField(108), JsonProperty(Order = 108)]
		private InteractionTypesData _InteractWithTypes = new();

		[ObservableProperty]
		[property: ContainerField(116), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
		private float _MaxLookAtAngle;

		[ObservableProperty]
		[property: ContainerField(120), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
		private float _SoldierInteractRadius;

		[ObservableProperty]
		[property: ContainerField(124), JsonProperty(Order = 124)]
		private EntryInputActionEnum _SoldierInteractInputAction = new();

		[ObservableProperty]
		[property: ContainerField(128), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		private bool _AllowInteractionWithSoldiers;

		[ObservableProperty]
		[property: ContainerField(129), LayoutImmutable, Blittable, JsonProperty(Order = 129)]
		private bool _OnlyAllowInteractionWithManDownSoldiers;

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
