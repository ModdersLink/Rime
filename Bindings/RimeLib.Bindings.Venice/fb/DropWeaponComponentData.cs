///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(16, 128)]
	public class DropWeaponComponentData : 
		ComponentData
	{
		[ContainerField(96)]
		public CtrRef<PickupEntityAsset> DeathPickup { get; set; } = new();

		[ContainerField(100)]
		public EntryInputActionEnum ActionIdentifier { get; set; } = new();

		[ContainerField(104), LayoutImmutable, Blittable]
		public float DropWeaponAfterTime { get; set; }

		[ContainerField(108)]
		public CtrRef<PickupEntityAsset> Pickup { get; set; } = new();

		[ContainerField(112)]
		public List<WeaponSlot> ExcludedWeaponSlots { get; set; } = new();

		[ContainerField(116), LayoutImmutable, Blittable]
		public float WeaponDropTime { get; set; }

		[ContainerField(120), LayoutImmutable, Blittable]
		public bool ListenToAnimationWeaponDropSignal { get; set; }

		[ContainerField(121), LayoutImmutable, Blittable]
		public bool AllowDropWeaponOnAction { get; set; }

		[ContainerField(122), LayoutImmutable, Blittable]
		public bool RequireWeaponSlotEmpty { get; set; }

		public static void Deserialize(DropWeaponComponentData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.DeathPickup.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.ActionIdentifier = (EntryInputActionEnum) p_Reader.ReadInt32();
			p_Instance.DropWeaponAfterTime = p_Reader.ReadSingle();
			p_Instance.Pickup.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.ExcludedWeaponSlots.Clear();
			(RimeReader Reader, uint Count) s_ExcludedWeaponSlots = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_ExcludedWeaponSlots.Count; ++i)
			{
				var s_Value = (WeaponSlot) s_ExcludedWeaponSlots.Reader.ReadInt32();
				p_Instance.ExcludedWeaponSlots.Add(s_Value);
			}
			
			s_ExcludedWeaponSlots.Reader.Dispose();
			p_Instance.WeaponDropTime = p_Reader.ReadSingle();
			p_Instance.ListenToAnimationWeaponDropSignal = p_Reader.ReadBool();
			p_Instance.AllowDropWeaponOnAction = p_Reader.ReadBool();
			p_Instance.RequireWeaponSlotEmpty = p_Reader.ReadBool();
			p_Reader.Seek(5, SeekOrigin.Current);
		}

	}
}
