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
using RimeLib.Serialization.Ebx;
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(16, 112)]
	public class MinimapData :
		EbxSerializable
	{
		[ContainerField(0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 0)]
		public Vec2 Position { get; set; } = new();
		
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public Vec3 CameraPosition { get; set; } = new();
		
		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public Vec2 Size { get; set; } = new();
		
		[ContainerField(48), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		public Vec3 OverlayColor { get; set; } = new();
		
		[ContainerField(64), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		public float AnchorPosVertical { get; set; }
		
		[ContainerField(68), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
		public float AnchorPosHorizontal { get; set; }
		
		[ContainerField(72), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
		public float CameraLookDistance { get; set; }
		
		[ContainerField(76), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
		public float CameraDistance { get; set; }
		
		[ContainerField(80), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
		public float CameraFov { get; set; }
		
		[ContainerField(84), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
		public float OverlayAlpha { get; set; }
		
		[ContainerField(88), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
		public float CameraRotation { get; set; }
		
		[ContainerField(92), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
		public int StartZoomLevel { get; set; }
		
		[ContainerField(96), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		public int InnerZoomFactor { get; set; }
		
		[ContainerField(100), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
		public int MaxZoomLevels { get; set; }
		
		[ContainerField(104), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
		public bool CenterOnCombatArea { get; set; }
		
		[ContainerField(105), LayoutImmutable, Blittable, JsonProperty(Order = 105)]
		public bool RotationFromPlayer { get; set; }
		
		[ContainerField(106), LayoutImmutable, Blittable, JsonProperty(Order = 106)]
		public bool PositionFromPlayer { get; set; }
		
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
