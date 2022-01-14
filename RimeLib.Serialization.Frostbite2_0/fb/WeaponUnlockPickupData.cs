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
	[ContainerType(4, 32)]
	public class WeaponUnlockPickupData :
		EbxSerializable
	{
		[ContainerField(0), JsonProperty(Order = 0)]
		public UnlockWeaponAndSlot UnlockWeaponAndSlot { get; set; } = new();
		
		[ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		public int AltWeaponSlot { get; set; }
		
		[ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public int LinkedToWeaponSlot { get; set; }
		
		[ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		public uint MinAmmo { get; set; }
		
		[ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		public uint MaxAmmo { get; set; }
		
		[ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		public bool DefaultToFullAmmo { get; set; }
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			UnlockWeaponAndSlot.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(AltWeaponSlot);
			p_Writer.Write(LinkedToWeaponSlot);
			p_Writer.Write(MinAmmo);
			p_Writer.Write(MaxAmmo);
			p_Writer.Write(DefaultToFullAmmo);
			p_Writer.WriteNullBytes(3);
		}
	}
}
