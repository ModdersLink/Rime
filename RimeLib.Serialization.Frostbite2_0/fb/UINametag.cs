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
	[ContainerType(16, 80)]
	public partial class UINametag :
		DataContainer
	{
		[ObservableProperty]
		[property: ContainerField(16), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private Vec3 _TextColor = new();

		[ObservableProperty]
		[property: ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		private float _IconFadeDistance;

		[ObservableProperty]
		[property: ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		private float _IconMaxDistance;

		[ObservableProperty]
		[property: ContainerField(40), JsonProperty(Order = 40)]
		private UIHudIcon _Icon = new();

		[ObservableProperty]
		[property: ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		private float _TextFadeDistance;

		[ObservableProperty]
		[property: ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		private float _HealthFadeDistance;

		[ObservableProperty]
		[property: ContainerField(52), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
		private float _HealthMaxDistance;

		[ObservableProperty]
		[property: ContainerField(56), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
		private float _TextMaxDistance;

		[ObservableProperty]
		[property: ContainerField(60), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
		private float _TargetInTimer;

		[ObservableProperty]
		[property: ContainerField(64), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		private float _TargetOutTimer;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(16);
			TextColor.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(IconFadeDistance);
			p_Writer.Write(IconMaxDistance);
			p_Writer.Write((int) Icon);
			p_Writer.Write(TextFadeDistance);
			p_Writer.Write(HealthFadeDistance);
			p_Writer.Write(HealthMaxDistance);
			p_Writer.Write(TextMaxDistance);
			p_Writer.Write(TargetInTimer);
			p_Writer.Write(TargetOutTimer);
			p_Writer.WriteNullBytes(12);
		}
	}
}
