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
	[ContainerType(16, 240)]
	public class UINametagCompData :
		UI3dIconCompData
	{
		[ContainerField(160), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 160)]
		public Vec4 SquadTint { get; set; } = new();

		[ContainerField(176), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 176)]
		public Vec4 EnemyTint { get; set; } = new();

		[ContainerField(192), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 192)]
		public Vec4 FriendlyTint { get; set; } = new();

		[ContainerField(208), LayoutImmutable, Blittable, JsonProperty(Order = 208)]
		public int OrderCooldown { get; set; }

		[ContainerField(212), LayoutImmutable, Blittable, JsonProperty(Order = 212)]
		public int TooltipCooldown { get; set; }

		[ContainerField(216), LayoutImmutable, Blittable, JsonProperty(Order = 216)]
		public float HealthBarSize { get; set; }

		[ContainerField(220), LayoutImmutable, Blittable, JsonProperty(Order = 220)]
		public float NameFontSize { get; set; }

		[ContainerField(224), LayoutImmutable, Blittable, JsonProperty(Order = 224)]
		public float NameGlowSize { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			SquadTint.Serialize(p_Writer, p_EbxWriter);
			EnemyTint.Serialize(p_Writer, p_EbxWriter);
			FriendlyTint.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(OrderCooldown);
			p_Writer.Write(TooltipCooldown);
			p_Writer.Write(HealthBarSize);
			p_Writer.Write(NameFontSize);
			p_Writer.Write(NameGlowSize);
			p_Writer.WriteNullBytes(12);
		}
	}
}
