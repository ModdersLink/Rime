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
	// NOTE (2026-07-14, hand-corrected): the generator emitted this struct with the game's
	// SECONDARY (64-bit) offsets - MinUv@0, MaxUv@8, TextureName@16 - but the real Win32 layout
	// (per the game's own EBX descriptors) is TextureName@0, MinUv@4, MaxUv@12. The engine
	// memory-maps this, so the wrong order produced silently-garbled atlas UV data.
	[ContainerType(4, 20)]
	public class EmitterTextureAtlasInfo :
		EbxSerializable
	{
		[ContainerField(0), LayoutImmutable, JsonProperty(Order = 0)]
		public string TextureName { get; set; } = string.Empty;

		[ContainerField(4), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 4)]
		public Vec2 MinUv { get; set; } = new();

		[ContainerField(12), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		public Vec2 MaxUv { get; set; } = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteString(TextureName));
			MinUv.Serialize(p_Writer, p_EbxWriter);
			MaxUv.Serialize(p_Writer, p_EbxWriter);
		}
	}
}
