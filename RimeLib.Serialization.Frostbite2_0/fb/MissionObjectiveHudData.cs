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
	[ContainerType(16, 64)]
	public partial class MissionObjectiveHudData :
		DataContainer
	{
		[ObservableProperty]
		[property: ContainerField(16), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private Vec3 _CameraPosition = new();

		[ObservableProperty]
		[property: ContainerField(32), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		private Vec2 _HorizontalBoundaries = new();

		[ObservableProperty]
		[property: ContainerField(40), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		private Vec2 _VerticalBoundaries = new();

		[ObservableProperty]
		[property: ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		private float _CameraRotation;

		[ObservableProperty]
		[property: ContainerField(52), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
		private float _CameraFov;

		[ObservableProperty]
		[property: ContainerField(56), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
		private float _CameraLookDistance;

		[ObservableProperty]
		[property: ContainerField(60), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
		private float _CameraDistance;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(16);
			CameraPosition.Serialize(p_Writer, p_EbxWriter);
			HorizontalBoundaries.Serialize(p_Writer, p_EbxWriter);
			VerticalBoundaries.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(CameraRotation);
			p_Writer.Write(CameraFov);
			p_Writer.Write(CameraLookDistance);
			p_Writer.Write(CameraDistance);
		}
	}
}
