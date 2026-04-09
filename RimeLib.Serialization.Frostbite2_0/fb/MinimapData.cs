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
	public partial class MinimapData :
		EbxSerializable
	{
		[ObservableProperty]
		[property: ContainerField(0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 0)]
		private Vec2 _Position = new();
		
		[ObservableProperty]
		[property: ContainerField(16), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private Vec3 _CameraPosition = new();
		
		[ObservableProperty]
		[property: ContainerField(32), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		private Vec2 _Size = new();
		
		[ObservableProperty]
		[property: ContainerField(48), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		private Vec3 _OverlayColor = new();
		
		[ObservableProperty]
		[property: ContainerField(64), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		private float _AnchorPosVertical;
		
		[ObservableProperty]
		[property: ContainerField(68), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
		private float _AnchorPosHorizontal;
		
		[ObservableProperty]
		[property: ContainerField(72), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
		private float _CameraLookDistance;
		
		[ObservableProperty]
		[property: ContainerField(76), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
		private float _CameraDistance;
		
		[ObservableProperty]
		[property: ContainerField(80), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
		private float _CameraFov;
		
		[ObservableProperty]
		[property: ContainerField(84), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
		private float _OverlayAlpha;
		
		[ObservableProperty]
		[property: ContainerField(88), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
		private float _CameraRotation;
		
		[ObservableProperty]
		[property: ContainerField(92), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
		private int _StartZoomLevel;
		
		[ObservableProperty]
		[property: ContainerField(96), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		private int _InnerZoomFactor;
		
		[ObservableProperty]
		[property: ContainerField(100), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
		private int _MaxZoomLevels;
		
		[ObservableProperty]
		[property: ContainerField(104), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
		private bool _CenterOnCombatArea;
		
		[ObservableProperty]
		[property: ContainerField(105), LayoutImmutable, Blittable, JsonProperty(Order = 105)]
		private bool _RotationFromPlayer;
		
		[ObservableProperty]
		[property: ContainerField(106), LayoutImmutable, Blittable, JsonProperty(Order = 106)]
		private bool _PositionFromPlayer;
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			Position.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(8);
			CameraPosition.Serialize(p_Writer, p_EbxWriter);
			Size.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(8);
			OverlayColor.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(AnchorPosVertical);
			p_Writer.Write(AnchorPosHorizontal);
			p_Writer.Write(CameraLookDistance);
			p_Writer.Write(CameraDistance);
			p_Writer.Write(CameraFov);
			p_Writer.Write(OverlayAlpha);
			p_Writer.Write(CameraRotation);
			p_Writer.Write(StartZoomLevel);
			p_Writer.Write(InnerZoomFactor);
			p_Writer.Write(MaxZoomLevels);
			p_Writer.Write(CenterOnCombatArea);
			p_Writer.Write(RotationFromPlayer);
			p_Writer.Write(PositionFromPlayer);
			p_Writer.WriteNullBytes(5);
		}
	}
}
