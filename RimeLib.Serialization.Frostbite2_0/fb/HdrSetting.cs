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
	[ContainerType(4, 68)]
	public partial class HdrSetting :
		DataContainer
	{
		[ObservableProperty]
		[property: ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		private float _WindowMinTop;

		[ObservableProperty]
		[property: ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		private float _WindowMinBottom;

		[ObservableProperty]
		[property: ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private float _WindowTopMinReleaseTime;

		[ObservableProperty]
		[property: ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		private float _WindowTopMaxReleaseTime;

		[ObservableProperty]
		[property: ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		private float _WindowTopAttackTime;

		[ObservableProperty]
		[property: ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		private float _WindowBottomReleaseTime;

		[ObservableProperty]
		[property: ContainerField(32), JsonProperty(Order = 32)]
		private AudioCurve _WindowTopReleaseTimeCurve = new();

		[ObservableProperty]
		[property: ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		private float _DischargeFactor;

		[ObservableProperty]
		[property: ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		private float _MaxAllowedEnergy;

		[ObservableProperty]
		[property: ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		private float _WindowBottomAttackTime;

		[ObservableProperty]
		[property: ContainerField(52), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
		private float _WindowSize;

		[ObservableProperty]
		[property: ContainerField(56), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
		private float _CompressFactor;

		[ObservableProperty]
		[property: ContainerField(60), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
		private float _Headroom;

		[ObservableProperty]
		[property: ContainerField(64), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		private float _AllowedOvershoot;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(8);
			p_Writer.Write(WindowMinTop);
			p_Writer.Write(WindowMinBottom);
			p_Writer.Write(WindowTopMinReleaseTime);
			p_Writer.Write(WindowTopMaxReleaseTime);
			p_Writer.Write(WindowTopAttackTime);
			p_Writer.Write(WindowBottomReleaseTime);
			WindowTopReleaseTimeCurve.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(DischargeFactor);
			p_Writer.Write(MaxAllowedEnergy);
			p_Writer.Write(WindowBottomAttackTime);
			p_Writer.Write(WindowSize);
			p_Writer.Write(CompressFactor);
			p_Writer.Write(Headroom);
			p_Writer.Write(AllowedOvershoot);
		}
	}
}
