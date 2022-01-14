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
	[ContainerType(4, 60)]
	public class UIWeaponDescription :
		UIItemDescription
	{
		[ContainerField(16), LayoutImmutable, JsonProperty(Order = 16)]
		public string Name { get; set; } = string.Empty;

		[ContainerField(20), LayoutImmutable, JsonProperty(Order = 20)]
		public string UnlockName { get; set; } = string.Empty;

		[ContainerField(24), LayoutImmutable, JsonProperty(Order = 24)]
		public string Description { get; set; } = string.Empty;

		[ContainerField(28), LayoutImmutable, JsonProperty(Order = 28)]
		public string Category { get; set; } = string.Empty;

		[ContainerField(32), LayoutImmutable, JsonProperty(Order = 32)]
		public string TexturePath { get; set; } = string.Empty;

		[ContainerField(36), LayoutImmutable, JsonProperty(Order = 36)]
		public string IconTexturePath { get; set; } = string.Empty;

		[ContainerField(40), LayoutImmutable, JsonProperty(Order = 40)]
		public string UnlockTexturePath { get; set; } = string.Empty;

		[ContainerField(44), LayoutImmutable, JsonProperty(Order = 44)]
		public string Ammo { get; set; } = string.Empty;

		[ContainerField(48), LayoutImmutable, JsonProperty(Order = 48)]
		public string RateOfFire { get; set; } = string.Empty;

		[ContainerField(52), LayoutImmutable, JsonProperty(Order = 52)]
		public string Range { get; set; } = string.Empty;

		[ContainerField(56), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
		public bool FireModeSingle { get; set; }

		[ContainerField(57), LayoutImmutable, Blittable, JsonProperty(Order = 57)]
		public bool FireModeBurst { get; set; }

		[ContainerField(58), LayoutImmutable, Blittable, JsonProperty(Order = 58)]
		public bool FireModeAuto { get; set; }

		[ContainerField(59), LayoutImmutable, Blittable, JsonProperty(Order = 59)]
		public bool HiddenInProgression { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteString(Name));
			p_Writer.Write(p_EbxWriter.WriteString(UnlockName));
			p_Writer.Write(p_EbxWriter.WriteString(Description));
			p_Writer.Write(p_EbxWriter.WriteString(Category));
			p_Writer.Write(p_EbxWriter.WriteString(TexturePath));
			p_Writer.Write(p_EbxWriter.WriteString(IconTexturePath));
			p_Writer.Write(p_EbxWriter.WriteString(UnlockTexturePath));
			p_Writer.Write(p_EbxWriter.WriteString(Ammo));
			p_Writer.Write(p_EbxWriter.WriteString(RateOfFire));
			p_Writer.Write(p_EbxWriter.WriteString(Range));
			p_Writer.Write(FireModeSingle);
			p_Writer.Write(FireModeBurst);
			p_Writer.Write(FireModeAuto);
			p_Writer.Write(HiddenInProgression);
		}
	}
}
