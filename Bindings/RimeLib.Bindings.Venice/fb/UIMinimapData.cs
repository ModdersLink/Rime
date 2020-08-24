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
	[ContainerType(16), MemberInfoFlag(41), ContainerStruct]
	public class UIMinimapData : FrostbiteContainer
	{
		[ContainerField(0), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289)]
		public Vec2 WorldCenter { get; set; } = new Vec2(); // 0x0 (0)
		
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289)]
		public Vec4 CombatAreaColor { get; set; } = new Vec4(); // 0x10 (16)
		
		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289)]
		public Vec4 DetailTextureTint { get; set; } = new Vec4(); // 0x20 (32)
		
		[ContainerField(48), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289)]
		public Vec2 CombatAreaMultiplyWrapAmount { get; set; } = new Vec2(); // 0x30 (48)
		
		[ContainerField(64), MemberInfoFlag(41)]
		public UIMinimapDistanceFieldParams Vegetation { get; set; } = new UIMinimapDistanceFieldParams(); // 0x40 (64)
		
		[ContainerField(128), MemberInfoFlag(53), ContainerCtrRef]
		public CtrRef<TextureAsset> FadeTexture { get; set; } = new CtrRef<TextureAsset>(); // 0x80 (128)
		
		[ContainerField(132), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float StreamingMinimapDelay { get; set; } // 0x84 (132)
		
		[ContainerField(136), MemberInfoFlag(53), ContainerCtrRef]
		public CtrRef<TextureAsset> AirRadarFadeTexture { get; set; } = new CtrRef<TextureAsset>(); // 0x88 (136)
		
		[ContainerField(140), MemberInfoFlag(53), ContainerCtrRef]
		public CtrRef<TextureAsset> DetailTexture { get; set; } = new CtrRef<TextureAsset>(); // 0x8C (140)
		
		[ContainerField(144), MemberInfoFlag(41)]
		public UIMinimapDistanceFieldParams Detail { get; set; } = new UIMinimapDistanceFieldParams(); // 0x90 (144)
		
		[ContainerField(208), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float StreamingMinimapTransitionSpeed { get; set; } // 0xD0 (208)
		
		[ContainerField(212), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float WorldRotation { get; set; } // 0xD4 (212)
		
		[ContainerField(216), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float WorldRange { get; set; } // 0xD8 (216)
		
		[ContainerField(220), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float CombatAreaDistanceScale { get; set; } // 0xDC (220)
		
		[ContainerField(224), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float CombatAreaFadeSpeed { get; set; } // 0xE0 (224)
		
		[ContainerField(228), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float CombatAreaAlphaThreshold { get; set; } // 0xE4 (228)
		
		[ContainerField(232), MemberInfoFlag(53), ContainerCtrRef]
		public CtrRef<TextureAsset> CombatAreaMultiplyTexture { get; set; } = new CtrRef<TextureAsset>(); // 0xE8 (232)
		
		[ContainerField(236), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float WorldSize { get; set; } // 0xEC (236)
		
		[ContainerField(240), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float AirRadarRange { get; set; } // 0xF0 (240)
		
		[ContainerField(244), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float CombatAreaScale { get; set; } // 0xF4 (244)
		
		[ContainerField(248), LayoutImmutable, Blittable, MemberInfoFlag(49325)]
		public bool UseStreamingMinimap { get; set; } // 0xF8 (248)
		
		[ContainerField(249), LayoutImmutable, Blittable, MemberInfoFlag(49325)]
		public bool UseCombatAreaTexture { get; set; } // 0xF9 (249)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3095082540:
					WorldCenter = (Vec2) p_Value;
					break;

				case 2802183289:
					CombatAreaColor = (Vec4) p_Value;
					break;

				case 1882981836:
					DetailTextureTint = (Vec4) p_Value;
					break;

				case 2245266640:
					CombatAreaMultiplyWrapAmount = (Vec2) p_Value;
					break;

				case 401242109:
					Vegetation = (UIMinimapDistanceFieldParams) p_Value;
					break;

				case 271953596:
					FadeTexture = (CtrRef<TextureAsset>) p_Value;
					break;

				case 2094736499:
					StreamingMinimapDelay = (float) p_Value;
					break;

				case 1937895042:
					AirRadarFadeTexture = (CtrRef<TextureAsset>) p_Value;
					break;

				case 1252535147:
					DetailTexture = (CtrRef<TextureAsset>) p_Value;
					break;

				case 2594676244:
					Detail = (UIMinimapDistanceFieldParams) p_Value;
					break;

				case 1234371502:
					StreamingMinimapTransitionSpeed = (float) p_Value;
					break;

				case 1699385299:
					WorldRotation = (float) p_Value;
					break;

				case 632461944:
					WorldRange = (float) p_Value;
					break;

				case 872842751:
					CombatAreaDistanceScale = (float) p_Value;
					break;

				case 23124261:
					CombatAreaFadeSpeed = (float) p_Value;
					break;

				case 209656199:
					CombatAreaAlphaThreshold = (float) p_Value;
					break;

				case 164838455:
					CombatAreaMultiplyTexture = (CtrRef<TextureAsset>) p_Value;
					break;

				case 2492064770:
					WorldSize = (float) p_Value;
					break;

				case 941873092:
					AirRadarRange = (float) p_Value;
					break;

				case 2821017436:
					CombatAreaScale = (float) p_Value;
					break;

				case 2317986661:
					UseStreamingMinimap = (bool) p_Value;
					break;

				case 800543224:
					UseCombatAreaTexture = (bool) p_Value;
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
				case 3095082540:
					return WorldCenter;

				case 2802183289:
					return CombatAreaColor;

				case 1882981836:
					return DetailTextureTint;

				case 2245266640:
					return CombatAreaMultiplyWrapAmount;

				case 401242109:
					return Vegetation;

				case 271953596:
					return FadeTexture;

				case 2094736499:
					return StreamingMinimapDelay;

				case 1937895042:
					return AirRadarFadeTexture;

				case 1252535147:
					return DetailTexture;

				case 2594676244:
					return Detail;

				case 1234371502:
					return StreamingMinimapTransitionSpeed;

				case 1699385299:
					return WorldRotation;

				case 632461944:
					return WorldRange;

				case 872842751:
					return CombatAreaDistanceScale;

				case 23124261:
					return CombatAreaFadeSpeed;

				case 209656199:
					return CombatAreaAlphaThreshold;

				case 164838455:
					return CombatAreaMultiplyTexture;

				case 2492064770:
					return WorldSize;

				case 941873092:
					return AirRadarRange;

				case 2821017436:
					return CombatAreaScale;

				case 2317986661:
					return UseStreamingMinimap;

				case 800543224:
					return UseCombatAreaTexture;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3095082540:
					return typeof(UIMinimapData).GetProperty(nameof(WorldCenter));

				case 2802183289:
					return typeof(UIMinimapData).GetProperty(nameof(CombatAreaColor));

				case 1882981836:
					return typeof(UIMinimapData).GetProperty(nameof(DetailTextureTint));

				case 2245266640:
					return typeof(UIMinimapData).GetProperty(nameof(CombatAreaMultiplyWrapAmount));

				case 401242109:
					return typeof(UIMinimapData).GetProperty(nameof(Vegetation));

				case 271953596:
					return typeof(UIMinimapData).GetProperty(nameof(FadeTexture));

				case 2094736499:
					return typeof(UIMinimapData).GetProperty(nameof(StreamingMinimapDelay));

				case 1937895042:
					return typeof(UIMinimapData).GetProperty(nameof(AirRadarFadeTexture));

				case 1252535147:
					return typeof(UIMinimapData).GetProperty(nameof(DetailTexture));

				case 2594676244:
					return typeof(UIMinimapData).GetProperty(nameof(Detail));

				case 1234371502:
					return typeof(UIMinimapData).GetProperty(nameof(StreamingMinimapTransitionSpeed));

				case 1699385299:
					return typeof(UIMinimapData).GetProperty(nameof(WorldRotation));

				case 632461944:
					return typeof(UIMinimapData).GetProperty(nameof(WorldRange));

				case 872842751:
					return typeof(UIMinimapData).GetProperty(nameof(CombatAreaDistanceScale));

				case 23124261:
					return typeof(UIMinimapData).GetProperty(nameof(CombatAreaFadeSpeed));

				case 209656199:
					return typeof(UIMinimapData).GetProperty(nameof(CombatAreaAlphaThreshold));

				case 164838455:
					return typeof(UIMinimapData).GetProperty(nameof(CombatAreaMultiplyTexture));

				case 2492064770:
					return typeof(UIMinimapData).GetProperty(nameof(WorldSize));

				case 941873092:
					return typeof(UIMinimapData).GetProperty(nameof(AirRadarRange));

				case 2821017436:
					return typeof(UIMinimapData).GetProperty(nameof(CombatAreaScale));

				case 2317986661:
					return typeof(UIMinimapData).GetProperty(nameof(UseStreamingMinimap));

				case 800543224:
					return typeof(UIMinimapData).GetProperty(nameof(UseCombatAreaTexture));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
