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
	public partial class DropWeaponComponentData :
		ComponentData
	{
		[ObservableProperty]
		[property: ContainerField(96), JsonProperty(Order = 96)]
		private CtrRef<PickupEntityAsset> _DeathPickup = new();

		[ObservableProperty]
		[property: ContainerField(100), JsonProperty(Order = 100)]
		private EntryInputActionEnum _ActionIdentifier = new();

		[ObservableProperty]
		[property: ContainerField(104), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
		private float _DropWeaponAfterTime;

		[ObservableProperty]
		[property: ContainerField(108), JsonProperty(Order = 108)]
		private CtrRef<PickupEntityAsset> _Pickup = new();

		[ObservableProperty]
		[property: ContainerField(112), JsonProperty(Order = 112)]
		private List<WeaponSlot> _ExcludedWeaponSlots = new();

		[ObservableProperty]
		[property: ContainerField(116), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
		private float _WeaponDropTime;

		[ObservableProperty]
		[property: ContainerField(120), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
		private bool _ListenToAnimationWeaponDropSignal;

		[ObservableProperty]
		[property: ContainerField(121), LayoutImmutable, Blittable, JsonProperty(Order = 121)]
		private bool _AllowDropWeaponOnAction;

		[ObservableProperty]
		[property: ContainerField(122), LayoutImmutable, Blittable, JsonProperty(Order = 122)]
		private bool _RequireWeaponSlotEmpty;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(DeathPickup));
			p_Writer.Write((int) ActionIdentifier);
			p_Writer.Write(DropWeaponAfterTime);
			p_Writer.Write(p_EbxWriter.WriteImport(Pickup));
			(RimeWriter Writer, uint ArrayIndex) s_ExcludedWeaponSlots = p_EbxWriter.GetArrayWriter(ExcludedWeaponSlots.GetType(), ExcludedWeaponSlots.Count);
			p_Writer.Write(s_ExcludedWeaponSlots.ArrayIndex);
			foreach (var s_Entry in ExcludedWeaponSlots)
			{
				s_ExcludedWeaponSlots.Writer.Write((int) s_Entry);
			}
			p_Writer.Write(WeaponDropTime);
			p_Writer.Write(ListenToAnimationWeaponDropSignal);
			p_Writer.Write(AllowDropWeaponOnAction);
			p_Writer.Write(RequireWeaponSlotEmpty);
			p_Writer.WriteNullBytes(5);
		}
	}
}
