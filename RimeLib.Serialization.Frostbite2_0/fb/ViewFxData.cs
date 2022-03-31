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
	[ContainerType(16, 112)]
	public class ViewFxData :
		DataContainer
	{
		[ContainerField(8), JsonProperty(Order = 8)]
		public PoissonRadialBlurData PoissonRadialBlur { get; set; } = new();

		[ContainerField(32), JsonProperty(Order = 32)]
		public ColorTintData ColorTint { get; set; } = new();

		[ContainerField(96), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		public float BlurAdd { get; set; }

		[ContainerField(100), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
		public bool ColorTintEnable { get; set; }

		[ContainerField(101), LayoutImmutable, Blittable, JsonProperty(Order = 101)]
		public bool PoissonRadialBlurEnable { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			PoissonRadialBlur.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(4);
			ColorTint.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(BlurAdd);
			p_Writer.Write(ColorTintEnable);
			p_Writer.Write(PoissonRadialBlurEnable);
			p_Writer.WriteNullBytes(10);
		}
	}
}
