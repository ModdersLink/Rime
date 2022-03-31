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
	public class DropWeaponComponentData :
		ComponentData
	{
		[ContainerField(96), JsonProperty(Order = 96)]
		public CtrRef<PickupEntityAsset> DeathPickup { get; set; } = new();

		[ContainerField(100), JsonProperty(Order = 100)]
		public EntryInputActionEnum ActionIdentifier { get; set; } = new();

		[ContainerField(104), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
		public float DropWeaponAfterTime { get; set; }

		[ContainerField(108), JsonProperty(Order = 108)]
		public CtrRef<PickupEntityAsset> Pickup { get; set; } = new();

		[ContainerField(112), JsonProperty(Order = 112)]
		public List<WeaponSlot> ExcludedWeaponSlots { get; set; } = new();

		[ContainerField(116), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
		public float WeaponDropTime { get; set; }

		[ContainerField(120), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
		public bool ListenToAnimationWeaponDropSignal { get; set; }

		[ContainerField(121), LayoutImmutable, Blittable, JsonProperty(Order = 121)]
		public bool AllowDropWeaponOnAction { get; set; }

		[ContainerField(122), LayoutImmutable, Blittable, JsonProperty(Order = 122)]
		public bool RequireWeaponSlotEmpty { get; set; }

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
