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
	[ContainerType(4, 20)]
	public class DirectWeaponSwitchingMapData
	{
		[ContainerField(0)]
		public EntryInputActionEnum Action { get; set; } = new();
		
		[ContainerField(4)]
		public WeaponSwitchingEnum ToWeapon { get; set; } = new();
		
		[ContainerField(8), LayoutImmutable, Blittable]
		public float PreventMeleeRepeatTime { get; set; }
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public float SwitchBackToPrevMaxTimePressed { get; set; }
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public bool UseQuickSwitch { get; set; }
		
		[ContainerField(17), LayoutImmutable, Blittable]
		public bool FireAndSwitchBackToPrev { get; set; }
		
		public static void Deserialize(DirectWeaponSwitchingMapData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Action = (EntryInputActionEnum) p_Reader.ReadInt32();
			p_Instance.ToWeapon = (WeaponSwitchingEnum) p_Reader.ReadInt32();
			p_Instance.PreventMeleeRepeatTime = p_Reader.ReadSingle();
			p_Instance.SwitchBackToPrevMaxTimePressed = p_Reader.ReadSingle();
			p_Instance.UseQuickSwitch = p_Reader.ReadBool();
			p_Instance.FireAndSwitchBackToPrev = p_Reader.ReadBool();
			p_Reader.Seek(2, SeekOrigin.Current);
		}
	}
}
