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
	[ContainerType(4, 16)]
	public class WeaponSwitchingMapData
	{
		[ContainerField(0)]
		public WeaponSwitchingEnum FromWeapon { get; set; } = new();
		
		[ContainerField(4)]
		public EntryInputActionEnum Action { get; set; } = new();
		
		[ContainerField(8)]
		public List<WeaponSwitchingEnum> ToWeapon { get; set; } = new();
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public bool FireAndSwitchBackToPrev { get; set; }
		
		public static void Deserialize(WeaponSwitchingMapData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.FromWeapon = (WeaponSwitchingEnum) p_Reader.ReadInt32();
			p_Instance.Action = (EntryInputActionEnum) p_Reader.ReadInt32();
			p_Instance.ToWeapon.Clear();
			(RimeReader Reader, uint Count) s_ToWeapon = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_ToWeapon.Count; ++i)
			{
				var s_Value = (WeaponSwitchingEnum) s_ToWeapon.Reader.ReadInt32();
				p_Instance.ToWeapon.Add(s_Value);
			}
			
			s_ToWeapon.Reader.Dispose();
			p_Instance.FireAndSwitchBackToPrev = p_Reader.ReadBool();
			p_Reader.Seek(3, SeekOrigin.Current);
		}
	}
}
