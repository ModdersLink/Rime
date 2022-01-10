///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(16, 160)]
	public class AlternateCameraViewData : 
		DataContainer
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 MeshOffset { get; set; } = new();

		[ContainerField(32)]
		public HudData Hud { get; set; } = new();

		[ContainerField(100), LayoutImmutable, Blittable]
		public float FieldOfView { get; set; }

		[ContainerField(104), LayoutImmutable, Blittable]
		public float WorldSpaceLockEfficiency { get; set; }

		[ContainerField(108)]
		public CtrRef<RigidMeshAsset> Mesh { get; set; } = new();

		[ContainerField(112)]
		public CtrRef<ObjectBlueprint> MaskMeshBlueprint { get; set; } = new();

		[ContainerField(116), LayoutImmutable, Blittable]
		public float FadeInDuration { get; set; }

		[ContainerField(120), LayoutImmutable, Blittable]
		public float FovTransitionTime { get; set; }

		[ContainerField(124), LayoutImmutable, Blittable]
		public float BlackDuration { get; set; }

		[ContainerField(128)]
		public InputSuppressionData InputSuppression { get; set; } = new();

		[ContainerField(132), LayoutImmutable, Blittable]
		public float ScreenExposureAreaScale { get; set; }

		[ContainerField(136), LayoutImmutable, Blittable]
		public float FadeOutDuration { get; set; }

		[ContainerField(140), LayoutImmutable, Blittable]
		public bool AllowFieldOfViewScaling { get; set; }

		[ContainerField(141), LayoutImmutable, Blittable]
		public bool LockMeshToRenderView { get; set; }

		[ContainerField(142), LayoutImmutable, Blittable]
		public bool ToggleViewChange { get; set; }

		[ContainerField(143), LayoutImmutable, Blittable]
		public bool UseProfileOptionForToggleViewChange { get; set; }

		[ContainerField(144), LayoutImmutable, Blittable]
		public bool FLIREnabled { get; set; }

		[ContainerField(145), LayoutImmutable, Blittable]
		public bool FadeToBlack { get; set; }

		public static void Deserialize(AlternateCameraViewData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Reader.Seek(8, SeekOrigin.Current);
			fb.Vec3.Deserialize(p_Instance.MeshOffset, p_Reader, p_Parser);
			p_Reader.Seek(8, SeekOrigin.Current);
			fb.HudData.Deserialize(p_Instance.Hud, p_Reader, p_Parser);
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.FieldOfView = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.WorldSpaceLockEfficiency = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.Mesh.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.MaskMeshBlueprint.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.FadeInDuration = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.FovTransitionTime = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.BlackDuration = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			fb.InputSuppressionData.Deserialize(p_Instance.InputSuppression, p_Reader, p_Parser);
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.ScreenExposureAreaScale = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.FadeOutDuration = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.AllowFieldOfViewScaling = p_Reader.ReadBool();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.LockMeshToRenderView = p_Reader.ReadBool();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.ToggleViewChange = p_Reader.ReadBool();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.UseProfileOptionForToggleViewChange = p_Reader.ReadBool();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.FLIREnabled = p_Reader.ReadBool();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.FadeToBlack = p_Reader.ReadBool();
			p_Reader.Seek(22, SeekOrigin.Current);
		}

	}
}
