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
	[ContainerType(1, 5)]
	public class WeaponMiscModifierSettings :
		EbxSerializable
	{
		[ContainerField(0), LayoutImmutable, Blittable, JsonProperty(Order = 0)]
		public bool EnableBreathControl { get; set; }
		
		[ContainerField(1), LayoutImmutable, Blittable, JsonProperty(Order = 1)]
		public bool CanBeInSupportedShooting { get; set; }
		
		[ContainerField(2), LayoutImmutable, Blittable, JsonProperty(Order = 2)]
		public bool UnZoomOnBoltAction { get; set; }
		
		[ContainerField(3), LayoutImmutable, Blittable, JsonProperty(Order = 3)]
		public bool HoldBoltActionUntilZoomRelease { get; set; }
		
		[ContainerField(4), LayoutImmutable, Blittable, JsonProperty(Order = 4)]
		public bool IsSilenced { get; set; }
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(EnableBreathControl);
			p_Writer.Write(CanBeInSupportedShooting);
			p_Writer.Write(UnZoomOnBoltAction);
			p_Writer.Write(HoldBoltActionUntilZoomRelease);
			p_Writer.Write(IsSilenced);
		}
	}
}
