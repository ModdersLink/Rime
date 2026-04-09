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
using CommunityToolkit.Mvvm.ComponentModel;

namespace fb
{
	[ContainerType(4, 36)]
	public partial class PadInputActionData :
		AxesInputActionData
	{
		[ObservableProperty]
		[property: ContainerField(20), JsonProperty(Order = 20)]
		private InputDevicePadButtons _Button = new();

		[ObservableProperty]
		[property: ContainerField(24), JsonProperty(Order = 24)]
		private InputDevicePOVs _Pov = new();

		[ObservableProperty]
		[property: ContainerField(28), JsonProperty(Order = 28)]
		private InputDevicePadButtons _PS3AlternativeButton = new();

		[ObservableProperty]
		[property: ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		private bool _UseSquareInput;

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
