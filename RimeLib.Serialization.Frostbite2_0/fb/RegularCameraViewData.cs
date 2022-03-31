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

namespace fb
{
	[ContainerType(16, 48)]
	public class RegularCameraViewData :
		EbxSerializable
	{
		[ContainerField(0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 0)]
		public Vec3 MeshOffset { get; set; } = new();
		
		[ContainerField(16), JsonProperty(Order = 16)]
		public InputSuppressionData InputSuppression { get; set; } = new();
		
		[ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		public float FieldOfView { get; set; }
		
		[ContainerField(24), JsonProperty(Order = 24)]
		public CtrRef<RigidMeshAsset> Mesh { get; set; } = new();
		
		[ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		public float ScreenExposureAreaScale { get; set; }
		
		[ContainerField(32), JsonProperty(Order = 32)]
		public CtrRef<ObjectBlueprint> MaskMeshBlueprint { get; set; } = new();
		
		[ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		public bool LockMeshToRenderView { get; set; }
		
		[ContainerField(37), LayoutImmutable, Blittable, JsonProperty(Order = 37)]
		public bool AllowFieldOfViewScaling { get; set; }
		
		[ContainerField(38), LayoutImmutable, Blittable, JsonProperty(Order = 38)]
		public bool FLIREnabled { get; set; }
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			MeshOffset.Serialize(p_Writer, p_EbxWriter);
			InputSuppression.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(FieldOfView);
			p_Writer.Write(p_EbxWriter.WriteImport(Mesh));
			p_Writer.Write(ScreenExposureAreaScale);
			p_Writer.Write(p_EbxWriter.WriteImport(MaskMeshBlueprint));
			p_Writer.Write(LockMeshToRenderView);
			p_Writer.Write(AllowFieldOfViewScaling);
			p_Writer.Write(FLIREnabled);
			p_Writer.WriteNullBytes(9);
		}
	}
}
