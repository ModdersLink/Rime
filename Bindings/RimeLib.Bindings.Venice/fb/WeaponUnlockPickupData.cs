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
	[ContainerType(4, 32)]
	public class WeaponUnlockPickupData
	{
		[ContainerField(0)]
		public UnlockWeaponAndSlot UnlockWeaponAndSlot { get; set; } = new();
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public int AltWeaponSlot { get; set; }
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public int LinkedToWeaponSlot { get; set; }
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public uint MinAmmo { get; set; }
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public uint MaxAmmo { get; set; }
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public bool DefaultToFullAmmo { get; set; }
		
		public static void Deserialize(WeaponUnlockPickupData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.UnlockWeaponAndSlot.Deserialize(p_Instance.UnlockWeaponAndSlot, p_Reader, p_Parser);
			p_Instance.AltWeaponSlot = p_Reader.ReadInt32();
			p_Instance.LinkedToWeaponSlot = p_Reader.ReadInt32();
			p_Instance.MinAmmo = p_Reader.ReadUInt32();
			p_Instance.MaxAmmo = p_Reader.ReadUInt32();
			p_Instance.DefaultToFullAmmo = p_Reader.ReadBool();
			p_Reader.Seek(3, SeekOrigin.Current);
		}
	}
}
