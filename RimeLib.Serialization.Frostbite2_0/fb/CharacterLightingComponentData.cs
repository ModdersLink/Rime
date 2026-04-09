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
	[ContainerType(16, 160)]
	public partial class CharacterLightingComponentData :
		ComponentData
	{
		[ObservableProperty]
		[property: ContainerField(96), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		private Vec3 _BottomLight = new();

		[ObservableProperty]
		[property: ContainerField(112), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		private Vec3 _TopLight = new();

		[ObservableProperty]
		[property: ContainerField(128), JsonProperty(Order = 128)]
		private CharacterLightingMode _CharacterLightingMode = new();

		[ObservableProperty]
		[property: ContainerField(132), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
		private float _CameraUpRotation;

		[ObservableProperty]
		[property: ContainerField(136), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
		private float _TopLightDirY;

		[ObservableProperty]
		[property: ContainerField(140), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
		private float _BlendFactor;

		[ObservableProperty]
		[property: ContainerField(144), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
		private float _TopLightDirX;

		[ObservableProperty]
		[property: ContainerField(148), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
		private bool _LockToCameraDirection;

		[ObservableProperty]
		[property: ContainerField(149), LayoutImmutable, Blittable, JsonProperty(Order = 149)]
		private bool _FirstPersonEnable;

		[ObservableProperty]
		[property: ContainerField(150), LayoutImmutable, Blittable, JsonProperty(Order = 150)]
		private bool _CharacterLightEnable;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			BottomLight.Serialize(p_Writer, p_EbxWriter);
			TopLight.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write((int) CharacterLightingMode);
			p_Writer.Write(CameraUpRotation);
			p_Writer.Write(TopLightDirY);
			p_Writer.Write(BlendFactor);
			p_Writer.Write(TopLightDirX);
			p_Writer.Write(LockToCameraDirection);
			p_Writer.Write(FirstPersonEnable);
			p_Writer.Write(CharacterLightEnable);
			p_Writer.WriteNullBytes(9);
		}
	}
}
