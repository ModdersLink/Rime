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
using RimeLib.Serialization.Ebx;
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(4, 16)]
	public class WeaponSwitchingMapData :
		EbxSerializable
	{
		[ContainerField(0), JsonProperty(Order = 0)]
		public WeaponSwitchingEnum FromWeapon { get; set; } = new();
		
		[ContainerField(4), JsonProperty(Order = 4)]
		public EntryInputActionEnum Action { get; set; } = new();
		
		[ContainerField(8), JsonProperty(Order = 8)]
		public List<WeaponSwitchingEnum> ToWeapon { get; set; } = new();
		
		[ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		public bool FireAndSwitchBackToPrev { get; set; }
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write((int) FromWeapon);
			p_Writer.Write((int) Action);
			(RimeWriter Writer, uint ArrayIndex) s_ToWeapon = p_EbxWriter.GetArrayWriter(ToWeapon.GetType(), ToWeapon.Count);
			p_Writer.Write(s_ToWeapon.ArrayIndex);
			foreach (var s_Entry in ToWeapon)
			{
				s_ToWeapon.Writer.Write((int) s_Entry);
			}
			p_Writer.Write(FireAndSwitchBackToPrev);
			p_Writer.WriteNullBytes(3);
		}
	}
}
