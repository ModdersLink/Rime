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
	[ContainerType(16, 224)]
	public partial class FPSCameraData :
		TargetCameraData
	{
		[ObservableProperty]
		[property: ContainerField(160), JsonProperty(Order = 160)]
		private TurnEffectData _TurnEffectSettings = new();

		[ObservableProperty]
		[property: ContainerField(192), JsonProperty(Order = 192)]
		private BlurEffectData _BlurEffectSettings = new();

		[ObservableProperty]
		[property: ContainerField(216), LayoutImmutable, Blittable, JsonProperty(Order = 216)]
		private float _FOV;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			TurnEffectSettings.Serialize(p_Writer, p_EbxWriter);
			BlurEffectSettings.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(FOV);
			p_Writer.WriteNullBytes(4);
		}
	}
}
