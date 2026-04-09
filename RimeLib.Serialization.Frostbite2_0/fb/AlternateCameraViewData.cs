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
	public partial class AlternateCameraViewData :
		DataContainer
	{
		[ObservableProperty]
		[property: ContainerField(16), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private Vec3 _MeshOffset = new();

		[ObservableProperty]
		[property: ContainerField(32), JsonProperty(Order = 32)]
		private HudData _Hud = new();

		[ObservableProperty]
		[property: ContainerField(100), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
		private float _FieldOfView;

		[ObservableProperty]
		[property: ContainerField(104), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
		private float _WorldSpaceLockEfficiency;

		[ObservableProperty]
		[property: ContainerField(108), JsonProperty(Order = 108)]
		private CtrRef<RigidMeshAsset> _Mesh = new();

		[ObservableProperty]
		[property: ContainerField(112), JsonProperty(Order = 112)]
		private CtrRef<ObjectBlueprint> _MaskMeshBlueprint = new();

		[ObservableProperty]
		[property: ContainerField(116), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
		private float _FadeInDuration;

		[ObservableProperty]
		[property: ContainerField(120), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
		private float _FovTransitionTime;

		[ObservableProperty]
		[property: ContainerField(124), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
		private float _BlackDuration;

		[ObservableProperty]
		[property: ContainerField(128), JsonProperty(Order = 128)]
		private InputSuppressionData _InputSuppression = new();

		[ObservableProperty]
		[property: ContainerField(132), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
		private float _ScreenExposureAreaScale;

		[ObservableProperty]
		[property: ContainerField(136), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
		private float _FadeOutDuration;

		[ObservableProperty]
		[property: ContainerField(140), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
		private bool _AllowFieldOfViewScaling;

		[ObservableProperty]
		[property: ContainerField(141), LayoutImmutable, Blittable, JsonProperty(Order = 141)]
		private bool _LockMeshToRenderView;

		[ObservableProperty]
		[property: ContainerField(142), LayoutImmutable, Blittable, JsonProperty(Order = 142)]
		private bool _ToggleViewChange;

		[ObservableProperty]
		[property: ContainerField(143), LayoutImmutable, Blittable, JsonProperty(Order = 143)]
		private bool _UseProfileOptionForToggleViewChange;

		[ObservableProperty]
		[property: ContainerField(144), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
		private bool _FLIREnabled;

		[ObservableProperty]
		[property: ContainerField(145), LayoutImmutable, Blittable, JsonProperty(Order = 145)]
		private bool _FadeToBlack;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(16);
			MeshOffset.Serialize(p_Writer, p_EbxWriter);
			Hud.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(FieldOfView);
			p_Writer.Write(WorldSpaceLockEfficiency);
			p_Writer.Write(p_EbxWriter.WriteImport(Mesh));
			p_Writer.Write(p_EbxWriter.WriteImport(MaskMeshBlueprint));
			p_Writer.Write(FadeInDuration);
			p_Writer.Write(FovTransitionTime);
			p_Writer.Write(BlackDuration);
			InputSuppression.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(ScreenExposureAreaScale);
			p_Writer.Write(FadeOutDuration);
			p_Writer.Write(AllowFieldOfViewScaling);
			p_Writer.Write(LockMeshToRenderView);
			p_Writer.Write(ToggleViewChange);
			p_Writer.Write(UseProfileOptionForToggleViewChange);
			p_Writer.Write(FLIREnabled);
			p_Writer.Write(FadeToBlack);
			p_Writer.WriteNullBytes(14);
		}
	}
}
