///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using RimeLib.IO;
using RimeLib.Frostbite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Reflection;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 16,  Flags: 41, Size: 112)]
	public class MinimapData : FrostbiteContainer
	{
		[ContainerField(Name: "Position", Offset: 0, NameHash: 3402582524, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec2 Position { get; set; } = new Vec2(); // 0x0 (0)
		
		[ContainerField(Name: "CameraPosition", Offset: 16, NameHash: 1421454469, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 CameraPosition { get; set; } = new Vec3(); // 0x10 (16)
		
		[ContainerField(Name: "Size", Offset: 32, NameHash: 2089429248, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec2 Size { get; set; } = new Vec2(); // 0x20 (32)
		
		[ContainerField(Name: "OverlayColor", Offset: 48, NameHash: 1805748258, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 OverlayColor { get; set; } = new Vec3(); // 0x30 (48)
		
		[ContainerField(Name: "AnchorPosVertical", Offset: 64, NameHash: 2529064194, Flags: 49469), LayoutImmutable, Blittable]
		public float AnchorPosVertical { get; set; } // 0x40 (64)
		
		[ContainerField(Name: "AnchorPosHorizontal", Offset: 68, NameHash: 1148668334, Flags: 49469), LayoutImmutable, Blittable]
		public float AnchorPosHorizontal { get; set; } // 0x44 (68)
		
		[ContainerField(Name: "CameraLookDistance", Offset: 72, NameHash: 3115939832, Flags: 49469), LayoutImmutable, Blittable]
		public float CameraLookDistance { get; set; } // 0x48 (72)
		
		[ContainerField(Name: "CameraDistance", Offset: 76, NameHash: 3954324415, Flags: 49469), LayoutImmutable, Blittable]
		public float CameraDistance { get; set; } // 0x4C (76)
		
		[ContainerField(Name: "CameraFov", Offset: 80, NameHash: 1789541379, Flags: 49469), LayoutImmutable, Blittable]
		public float CameraFov { get; set; } // 0x50 (80)
		
		[ContainerField(Name: "OverlayAlpha", Offset: 84, NameHash: 1803308715, Flags: 49469), LayoutImmutable, Blittable]
		public float OverlayAlpha { get; set; } // 0x54 (84)
		
		[ContainerField(Name: "CameraRotation", Offset: 88, NameHash: 2168484520, Flags: 49469), LayoutImmutable, Blittable]
		public float CameraRotation { get; set; } // 0x58 (88)
		
		[ContainerField(Name: "StartZoomLevel", Offset: 92, NameHash: 917267620, Flags: 49405), LayoutImmutable, Blittable]
		public int StartZoomLevel { get; set; } // 0x5C (92)
		
		[ContainerField(Name: "InnerZoomFactor", Offset: 96, NameHash: 429772065, Flags: 49405), LayoutImmutable, Blittable]
		public int InnerZoomFactor { get; set; } // 0x60 (96)
		
		[ContainerField(Name: "MaxZoomLevels", Offset: 100, NameHash: 875018595, Flags: 49405), LayoutImmutable, Blittable]
		public int MaxZoomLevels { get; set; } // 0x64 (100)
		
		[ContainerField(Name: "CenterOnCombatArea", Offset: 104, NameHash: 1758109518, Flags: 49325), LayoutImmutable, Blittable]
		public bool CenterOnCombatArea { get; set; } // 0x68 (104)
		
		[ContainerField(Name: "RotationFromPlayer", Offset: 105, NameHash: 1216356340, Flags: 49325), LayoutImmutable, Blittable]
		public bool RotationFromPlayer { get; set; } // 0x69 (105)
		
		[ContainerField(Name: "PositionFromPlayer", Offset: 106, NameHash: 593075033, Flags: 49325), LayoutImmutable, Blittable]
		public bool PositionFromPlayer { get; set; } // 0x6A (106)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3402582524:
					Position = (Vec2) p_Value;
					break;

				case 1421454469:
					CameraPosition = (Vec3) p_Value;
					break;

				case 2089429248:
					Size = (Vec2) p_Value;
					break;

				case 1805748258:
					OverlayColor = (Vec3) p_Value;
					break;

				case 2529064194:
					AnchorPosVertical = (float) p_Value;
					break;

				case 1148668334:
					AnchorPosHorizontal = (float) p_Value;
					break;

				case 3115939832:
					CameraLookDistance = (float) p_Value;
					break;

				case 3954324415:
					CameraDistance = (float) p_Value;
					break;

				case 1789541379:
					CameraFov = (float) p_Value;
					break;

				case 1803308715:
					OverlayAlpha = (float) p_Value;
					break;

				case 2168484520:
					CameraRotation = (float) p_Value;
					break;

				case 917267620:
					StartZoomLevel = (int) p_Value;
					break;

				case 429772065:
					InnerZoomFactor = (int) p_Value;
					break;

				case 875018595:
					MaxZoomLevels = (int) p_Value;
					break;

				case 1758109518:
					CenterOnCombatArea = (bool) p_Value;
					break;

				case 1216356340:
					RotationFromPlayer = (bool) p_Value;
					break;

				case 593075033:
					PositionFromPlayer = (bool) p_Value;
					break;

				default:
					base.Bind(p_Descriptor, p_Value);
					break;
			}
		}

		public override object GetFieldValueByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3402582524:
					return Position;

				case 1421454469:
					return CameraPosition;

				case 2089429248:
					return Size;

				case 1805748258:
					return OverlayColor;

				case 2529064194:
					return AnchorPosVertical;

				case 1148668334:
					return AnchorPosHorizontal;

				case 3115939832:
					return CameraLookDistance;

				case 3954324415:
					return CameraDistance;

				case 1789541379:
					return CameraFov;

				case 1803308715:
					return OverlayAlpha;

				case 2168484520:
					return CameraRotation;

				case 917267620:
					return StartZoomLevel;

				case 429772065:
					return InnerZoomFactor;

				case 875018595:
					return MaxZoomLevels;

				case 1758109518:
					return CenterOnCombatArea;

				case 1216356340:
					return RotationFromPlayer;

				case 593075033:
					return PositionFromPlayer;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3402582524:
					return typeof(MinimapData).GetProperty(nameof(Position));

				case 1421454469:
					return typeof(MinimapData).GetProperty(nameof(CameraPosition));

				case 2089429248:
					return typeof(MinimapData).GetProperty(nameof(Size));

				case 1805748258:
					return typeof(MinimapData).GetProperty(nameof(OverlayColor));

				case 2529064194:
					return typeof(MinimapData).GetProperty(nameof(AnchorPosVertical));

				case 1148668334:
					return typeof(MinimapData).GetProperty(nameof(AnchorPosHorizontal));

				case 3115939832:
					return typeof(MinimapData).GetProperty(nameof(CameraLookDistance));

				case 3954324415:
					return typeof(MinimapData).GetProperty(nameof(CameraDistance));

				case 1789541379:
					return typeof(MinimapData).GetProperty(nameof(CameraFov));

				case 1803308715:
					return typeof(MinimapData).GetProperty(nameof(OverlayAlpha));

				case 2168484520:
					return typeof(MinimapData).GetProperty(nameof(CameraRotation));

				case 917267620:
					return typeof(MinimapData).GetProperty(nameof(StartZoomLevel));

				case 429772065:
					return typeof(MinimapData).GetProperty(nameof(InnerZoomFactor));

				case 875018595:
					return typeof(MinimapData).GetProperty(nameof(MaxZoomLevels));

				case 1758109518:
					return typeof(MinimapData).GetProperty(nameof(CenterOnCombatArea));

				case 1216356340:
					return typeof(MinimapData).GetProperty(nameof(RotationFromPlayer));

				case 593075033:
					return typeof(MinimapData).GetProperty(nameof(PositionFromPlayer));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
