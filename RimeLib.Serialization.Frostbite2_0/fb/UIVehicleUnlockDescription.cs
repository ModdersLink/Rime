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
	[ContainerType(4, 44)]
	public class UIVehicleUnlockDescription :
		UIItemDescription
	{
		[ContainerField(16), LayoutImmutable, JsonProperty(Order = 16)]
		public string Name { get; set; } = string.Empty;

		[ContainerField(20), LayoutImmutable, JsonProperty(Order = 20)]
		public string Description { get; set; } = string.Empty;

		[ContainerField(24), LayoutImmutable, JsonProperty(Order = 24)]
		public string Category { get; set; } = string.Empty;

		[ContainerField(28), LayoutImmutable, JsonProperty(Order = 28)]
		public string TexturePath { get; set; } = string.Empty;

		[ContainerField(32), LayoutImmutable, JsonProperty(Order = 32)]
		public string IconTexturePath { get; set; } = string.Empty;

		[ContainerField(36), LayoutImmutable, JsonProperty(Order = 36)]
		public string UnlockTexturePath { get; set; } = string.Empty;

		[ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		public bool HiddenInProgression { get; set; }

		[ContainerField(41), LayoutImmutable, Blittable, JsonProperty(Order = 41)]
		public bool NotExplicitelySelectable { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteString(Name));
			p_Writer.Write(p_EbxWriter.WriteString(Description));
			p_Writer.Write(p_EbxWriter.WriteString(Category));
			p_Writer.Write(p_EbxWriter.WriteString(TexturePath));
			p_Writer.Write(p_EbxWriter.WriteString(IconTexturePath));
			p_Writer.Write(p_EbxWriter.WriteString(UnlockTexturePath));
			p_Writer.Write(HiddenInProgression);
			p_Writer.Write(NotExplicitelySelectable);
			p_Writer.WriteNullBytes(2);
		}
	}
}
