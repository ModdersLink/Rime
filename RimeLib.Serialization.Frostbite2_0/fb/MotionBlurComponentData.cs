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
	public partial class MotionBlurComponentData :
		ComponentData
	{
		[ObservableProperty]
		[property: ContainerField(96), JsonProperty(Order = 96)]
		private Realm _Realm = new();

		[ObservableProperty]
		[property: ContainerField(100), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
		private float _CutoffGradientScale;

		[ObservableProperty]
		[property: ContainerField(104), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
		private float _MotionBlurCutoffRadius;

		[ObservableProperty]
		[property: ContainerField(108), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
		private bool _MotionBlurEnable;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write((int) Realm);
			p_Writer.Write(CutoffGradientScale);
			p_Writer.Write(MotionBlurCutoffRadius);
			p_Writer.Write(MotionBlurEnable);
			p_Writer.WriteNullBytes(3);
		}
	}
}
