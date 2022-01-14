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
	[ContainerType(16, 160)]
	public class AlternateCameraViewData :
		DataContainer
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public Vec3 MeshOffset { get; set; } = new();

		[ContainerField(32), JsonProperty(Order = 32)]
		public HudData Hud { get; set; } = new();

		[ContainerField(100), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
		public float FieldOfView { get; set; }

		[ContainerField(104), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
		public float WorldSpaceLockEfficiency { get; set; }

		[ContainerField(108), JsonProperty(Order = 108)]
		public CtrRef<RigidMeshAsset> Mesh { get; set; } = new();

		[ContainerField(112), JsonProperty(Order = 112)]
		public CtrRef<ObjectBlueprint> MaskMeshBlueprint { get; set; } = new();

		[ContainerField(116), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
		public float FadeInDuration { get; set; }

		[ContainerField(120), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
		public float FovTransitionTime { get; set; }

		[ContainerField(124), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
		public float BlackDuration { get; set; }

		[ContainerField(128), JsonProperty(Order = 128)]
		public InputSuppressionData InputSuppression { get; set; } = new();

		[ContainerField(132), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
		public float ScreenExposureAreaScale { get; set; }

		[ContainerField(136), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
		public float FadeOutDuration { get; set; }

		[ContainerField(140), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
		public bool AllowFieldOfViewScaling { get; set; }

		[ContainerField(141), LayoutImmutable, Blittable, JsonProperty(Order = 141)]
		public bool LockMeshToRenderView { get; set; }

		[ContainerField(142), LayoutImmutable, Blittable, JsonProperty(Order = 142)]
		public bool ToggleViewChange { get; set; }

		[ContainerField(143), LayoutImmutable, Blittable, JsonProperty(Order = 143)]
		public bool UseProfileOptionForToggleViewChange { get; set; }

		[ContainerField(144), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
		public bool FLIREnabled { get; set; }

		[ContainerField(145), LayoutImmutable, Blittable, JsonProperty(Order = 145)]
		public bool FadeToBlack { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(8);
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
