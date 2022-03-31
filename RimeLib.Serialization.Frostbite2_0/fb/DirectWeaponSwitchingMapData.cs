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
	[ContainerType(4, 20)]
	public class DirectWeaponSwitchingMapData :
		EbxSerializable
	{
		[ContainerField(0), JsonProperty(Order = 0)]
		public EntryInputActionEnum Action { get; set; } = new();
		
		[ContainerField(4), JsonProperty(Order = 4)]
		public WeaponSwitchingEnum ToWeapon { get; set; } = new();
		
		[ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		public float PreventMeleeRepeatTime { get; set; }
		
		[ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		public float SwitchBackToPrevMaxTimePressed { get; set; }
		
		[ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public bool UseQuickSwitch { get; set; }
		
		[ContainerField(17), LayoutImmutable, Blittable, JsonProperty(Order = 17)]
		public bool FireAndSwitchBackToPrev { get; set; }
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write((int) Action);
			p_Writer.Write((int) ToWeapon);
			p_Writer.Write(PreventMeleeRepeatTime);
			p_Writer.Write(SwitchBackToPrevMaxTimePressed);
			p_Writer.Write(UseQuickSwitch);
			p_Writer.Write(FireAndSwitchBackToPrev);
			p_Writer.WriteNullBytes(2);
		}
	}
}
