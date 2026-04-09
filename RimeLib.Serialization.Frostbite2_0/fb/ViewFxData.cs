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
	[ContainerType(16, 112)]
	public partial class ViewFxData :
		DataContainer
	{
		[ObservableProperty]
		[property: ContainerField(8), JsonProperty(Order = 8)]
		private PoissonRadialBlurData _PoissonRadialBlur = new();

		[ObservableProperty]
		[property: ContainerField(32), JsonProperty(Order = 32)]
		private ColorTintData _ColorTint = new();

		[ObservableProperty]
		[property: ContainerField(96), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		private float _BlurAdd;

		[ObservableProperty]
		[property: ContainerField(100), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
		private bool _ColorTintEnable;

		[ObservableProperty]
		[property: ContainerField(101), LayoutImmutable, Blittable, JsonProperty(Order = 101)]
		private bool _PoissonRadialBlurEnable;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(8);
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
