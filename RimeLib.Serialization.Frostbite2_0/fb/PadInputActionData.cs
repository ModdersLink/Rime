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
	[ContainerType(4, 36)]
	public class PadInputActionData :
		AxesInputActionData
	{
		[ContainerField(20), JsonProperty(Order = 20)]
		public InputDevicePadButtons Button { get; set; } = new();

		[ContainerField(24), JsonProperty(Order = 24)]
		public InputDevicePOVs Pov { get; set; } = new();

		[ContainerField(28), JsonProperty(Order = 28)]
		public InputDevicePadButtons PS3AlternativeButton { get; set; } = new();

		[ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public bool UseSquareInput { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write((int) Button);
			p_Writer.Write((int) Pov);
			p_Writer.Write((int) PS3AlternativeButton);
			p_Writer.Write(UseSquareInput);
			p_Writer.WriteNullBytes(3);
		}
	}
}
