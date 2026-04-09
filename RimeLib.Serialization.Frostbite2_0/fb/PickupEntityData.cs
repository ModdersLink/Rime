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
	[ContainerType(16, 176)]
	public partial class PickupEntityData :
		GamePhysicsEntityData
	{
		[ObservableProperty]
		[property: ContainerField(112), JsonProperty(Order = 112)]
		private PickupPlayerEnum _RandomizeAmmoOnDropForPlayer = new();

		[ObservableProperty]
		[property: ContainerField(116), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
		private int _MinRandomClipAmmoPercent;

		[ObservableProperty]
		[property: ContainerField(120), JsonProperty(Order = 120)]
		private CtrRef<ObjectBlueprint> _PhysicsBlueprint = new();

		[ObservableProperty]
		[property: ContainerField(124), JsonProperty(Order = 124)]
		private CtrRef<MeshAsset> _Mesh = new();

		[ObservableProperty]
		[property: ContainerField(128), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		private int _MaxRandomClipAmmoPercent;

		[ObservableProperty]
		[property: ContainerField(132), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
		private uint _PreferredWeaponSlot;

		[ObservableProperty]
		[property: ContainerField(136), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
		private float _TimeToLive;

		[ObservableProperty]
		[property: ContainerField(140), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
		private int _MinRandomSpareAmmoPercent;

		[ObservableProperty]
		[property: ContainerField(144), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
		private float _InteractionRadius;

		[ObservableProperty]
		[property: ContainerField(148), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
		private int _MaxRandomSpareAmmoPercent;

		[ObservableProperty]
		[property: ContainerField(152), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
		private bool _UnspawnOnPickup;

		[ObservableProperty]
		[property: ContainerField(153), LayoutImmutable, Blittable, JsonProperty(Order = 153)]
		private bool _UnspawnOnAmmoPickup;

		[ObservableProperty]
		[property: ContainerField(154), LayoutImmutable, Blittable, JsonProperty(Order = 154)]
		private bool _ForceWeaponSlotSelection;

		[ObservableProperty]
		[property: ContainerField(155), LayoutImmutable, Blittable, JsonProperty(Order = 155)]
		private bool _DisplayInMiniMap;

		[ObservableProperty]
		[property: ContainerField(156), LayoutImmutable, Blittable, JsonProperty(Order = 156)]
		private bool _HasAutomaticAmmoPickup;

		[ObservableProperty]
		[property: ContainerField(157), LayoutImmutable, Blittable, JsonProperty(Order = 157)]
		private bool _UseWeaponMesh;

		[ObservableProperty]
		[property: ContainerField(158), LayoutImmutable, Blittable, JsonProperty(Order = 158)]
		private bool _AllowPickup;

		[ObservableProperty]
		[property: ContainerField(159), LayoutImmutable, Blittable, JsonProperty(Order = 159)]
		private bool _ContentIsStatic;

		[ObservableProperty]
		[property: ContainerField(160), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
		private bool _PositionIsStatic;

		[ObservableProperty]
		[property: ContainerField(161), LayoutImmutable, Blittable, JsonProperty(Order = 161)]
		private bool _IgnoreNullWeaponSlots;

		[ObservableProperty]
		[property: ContainerField(162), LayoutImmutable, Blittable, JsonProperty(Order = 162)]
		private bool _ReplaceAllContent;

		[ObservableProperty]
		[property: ContainerField(163), LayoutImmutable, Blittable, JsonProperty(Order = 163)]
		private bool _RemoveWeaponOnDrop;

		[ObservableProperty]
		[property: ContainerField(164), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
		private bool _SendPlayerInEventOnPickup;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write((int) RandomizeAmmoOnDropForPlayer);
			p_Writer.Write(MinRandomClipAmmoPercent);
			p_Writer.Write(p_EbxWriter.WriteImport(PhysicsBlueprint));
			p_Writer.Write(p_EbxWriter.WriteImport(Mesh));
			p_Writer.Write(MaxRandomClipAmmoPercent);
			p_Writer.Write(PreferredWeaponSlot);
			p_Writer.Write(TimeToLive);
			p_Writer.Write(MinRandomSpareAmmoPercent);
			p_Writer.Write(InteractionRadius);
			p_Writer.Write(MaxRandomSpareAmmoPercent);
			p_Writer.Write(UnspawnOnPickup);
			p_Writer.Write(UnspawnOnAmmoPickup);
			p_Writer.Write(ForceWeaponSlotSelection);
			p_Writer.Write(DisplayInMiniMap);
			p_Writer.Write(HasAutomaticAmmoPickup);
			p_Writer.Write(UseWeaponMesh);
			p_Writer.Write(AllowPickup);
			p_Writer.Write(ContentIsStatic);
			p_Writer.Write(PositionIsStatic);
			p_Writer.Write(IgnoreNullWeaponSlots);
			p_Writer.Write(ReplaceAllContent);
			p_Writer.Write(RemoveWeaponOnDrop);
			p_Writer.Write(SendPlayerInEventOnPickup);
			p_Writer.WriteNullBytes(11);
		}
	}
}
