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
	[ContainerType(4, 16)]
	public class WeaponMiscModifier :
		WeaponModifierBase
	{
		[ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		public bool EnableBreathControl { get; set; }

		[ContainerField(9), LayoutImmutable, Blittable, JsonProperty(Order = 9)]
		public bool CanBeInSupportedShooting { get; set; }

		[ContainerField(10), LayoutImmutable, Blittable, JsonProperty(Order = 10)]
		public bool UnZoomOnBoltAction { get; set; }

		[ContainerField(11), LayoutImmutable, Blittable, JsonProperty(Order = 11)]
		public bool HoldBoltActionUntilZoomRelease { get; set; }

		[ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		public bool IsSilenced { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(EnableBreathControl);
			p_Writer.Write(CanBeInSupportedShooting);
			p_Writer.Write(UnZoomOnBoltAction);
			p_Writer.Write(HoldBoltActionUntilZoomRelease);
			p_Writer.Write(IsSilenced);
			p_Writer.WriteNullBytes(3);
		}
	}
}
