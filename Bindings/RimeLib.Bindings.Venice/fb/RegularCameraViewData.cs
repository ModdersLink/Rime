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
	[ContainerType(16, 48)]
	public class RegularCameraViewData
	{
		[ContainerField(0), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 MeshOffset { get; set; } = new();
		
		[ContainerField(16)]
		public InputSuppressionData InputSuppression { get; set; } = new();
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float FieldOfView { get; set; }
		
		[ContainerField(24)]
		public CtrRef<RigidMeshAsset> Mesh { get; set; } = new();
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public float ScreenExposureAreaScale { get; set; }
		
		[ContainerField(32)]
		public CtrRef<ObjectBlueprint> MaskMeshBlueprint { get; set; } = new();
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public bool LockMeshToRenderView { get; set; }
		
		[ContainerField(37), LayoutImmutable, Blittable]
		public bool AllowFieldOfViewScaling { get; set; }
		
		[ContainerField(38), LayoutImmutable, Blittable]
		public bool FLIREnabled { get; set; }
		
		public static void Deserialize(RegularCameraViewData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.Vec3.Deserialize(p_Instance.MeshOffset, p_Reader, p_Parser);
			fb.InputSuppressionData.Deserialize(p_Instance.InputSuppression, p_Reader, p_Parser);
			p_Instance.FieldOfView = p_Reader.ReadSingle();
			p_Instance.Mesh.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.ScreenExposureAreaScale = p_Reader.ReadSingle();
			p_Instance.MaskMeshBlueprint.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.LockMeshToRenderView = p_Reader.ReadBool();
			p_Instance.AllowFieldOfViewScaling = p_Reader.ReadBool();
			p_Instance.FLIREnabled = p_Reader.ReadBool();
			p_Reader.Seek(9, SeekOrigin.Current);
		}
	}
}
