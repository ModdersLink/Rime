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
	[ContainerType(16, 256)]
	public partial class UIMinimapData :
		EbxSerializable
	{
		[ObservableProperty]
		[property: ContainerField(0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 0)]
		private Vec2 _WorldCenter = new();
		
		[ObservableProperty]
		[property: ContainerField(16), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private Vec4 _CombatAreaColor = new();
		
		[ObservableProperty]
		[property: ContainerField(32), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		private Vec4 _DetailTextureTint = new();
		
		[ObservableProperty]
		[property: ContainerField(48), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		private Vec2 _CombatAreaMultiplyWrapAmount = new();
		
		[ObservableProperty]
		[property: ContainerField(64), JsonProperty(Order = 64)]
		private UIMinimapDistanceFieldParams _Vegetation = new();
		
		[ObservableProperty]
		[property: ContainerField(128), JsonProperty(Order = 128)]
		private CtrRef<TextureAsset> _FadeTexture = new();
		
		[ObservableProperty]
		[property: ContainerField(132), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
		private float _StreamingMinimapDelay;
		
		[ObservableProperty]
		[property: ContainerField(136), JsonProperty(Order = 136)]
		private CtrRef<TextureAsset> _AirRadarFadeTexture = new();
		
		[ObservableProperty]
		[property: ContainerField(140), JsonProperty(Order = 140)]
		private CtrRef<TextureAsset> _DetailTexture = new();
		
		[ObservableProperty]
		[property: ContainerField(144), JsonProperty(Order = 144)]
		private UIMinimapDistanceFieldParams _Detail = new();
		
		[ObservableProperty]
		[property: ContainerField(208), LayoutImmutable, Blittable, JsonProperty(Order = 208)]
		private float _StreamingMinimapTransitionSpeed;
		
		[ObservableProperty]
		[property: ContainerField(212), LayoutImmutable, Blittable, JsonProperty(Order = 212)]
		private float _WorldRotation;
		
		[ObservableProperty]
		[property: ContainerField(216), LayoutImmutable, Blittable, JsonProperty(Order = 216)]
		private float _WorldRange;
		
		[ObservableProperty]
		[property: ContainerField(220), LayoutImmutable, Blittable, JsonProperty(Order = 220)]
		private float _CombatAreaDistanceScale;
		
		[ObservableProperty]
		[property: ContainerField(224), LayoutImmutable, Blittable, JsonProperty(Order = 224)]
		private float _CombatAreaFadeSpeed;
		
		[ObservableProperty]
		[property: ContainerField(228), LayoutImmutable, Blittable, JsonProperty(Order = 228)]
		private float _CombatAreaAlphaThreshold;
		
		[ObservableProperty]
		[property: ContainerField(232), JsonProperty(Order = 232)]
		private CtrRef<TextureAsset> _CombatAreaMultiplyTexture = new();
		
		[ObservableProperty]
		[property: ContainerField(236), LayoutImmutable, Blittable, JsonProperty(Order = 236)]
		private float _WorldSize;
		
		[ObservableProperty]
		[property: ContainerField(240), LayoutImmutable, Blittable, JsonProperty(Order = 240)]
		private float _AirRadarRange;
		
		[ObservableProperty]
		[property: ContainerField(244), LayoutImmutable, Blittable, JsonProperty(Order = 244)]
		private float _CombatAreaScale;
		
		[ObservableProperty]
		[property: ContainerField(248), LayoutImmutable, Blittable, JsonProperty(Order = 248)]
		private bool _UseStreamingMinimap;
		
		[ObservableProperty]
		[property: ContainerField(249), LayoutImmutable, Blittable, JsonProperty(Order = 249)]
		private bool _UseCombatAreaTexture;
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			WorldCenter.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(8);
			CombatAreaColor.Serialize(p_Writer, p_EbxWriter);
			DetailTextureTint.Serialize(p_Writer, p_EbxWriter);
			CombatAreaMultiplyWrapAmount.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(8);
			Vegetation.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(FadeTexture));
			p_Writer.Write(StreamingMinimapDelay);
			p_Writer.Write(p_EbxWriter.WriteImport(AirRadarFadeTexture));
			p_Writer.Write(p_EbxWriter.WriteImport(DetailTexture));
			Detail.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(StreamingMinimapTransitionSpeed);
			p_Writer.Write(WorldRotation);
			p_Writer.Write(WorldRange);
			p_Writer.Write(CombatAreaDistanceScale);
			p_Writer.Write(CombatAreaFadeSpeed);
			p_Writer.Write(CombatAreaAlphaThreshold);
			p_Writer.Write(p_EbxWriter.WriteImport(CombatAreaMultiplyTexture));
			p_Writer.Write(WorldSize);
			p_Writer.Write(AirRadarRange);
			p_Writer.Write(CombatAreaScale);
			p_Writer.Write(UseStreamingMinimap);
			p_Writer.Write(UseCombatAreaTexture);
			p_Writer.WriteNullBytes(6);
		}
	}
}
