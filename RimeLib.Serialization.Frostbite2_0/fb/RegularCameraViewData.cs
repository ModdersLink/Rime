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
	[ContainerType(16, 48)]
	public partial class RegularCameraViewData :
		EbxSerializable
	{
		[ObservableProperty]
		[property: ContainerField(0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 0)]
		private Vec3 _MeshOffset = new();
		
		[ObservableProperty]
		[property: ContainerField(16), JsonProperty(Order = 16)]
		private InputSuppressionData _InputSuppression = new();
		
		[ObservableProperty]
		[property: ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		private float _FieldOfView;
		
		[ObservableProperty]
		[property: ContainerField(24), JsonProperty(Order = 24)]
		private CtrRef<RigidMeshAsset> _Mesh = new();
		
		[ObservableProperty]
		[property: ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		private float _ScreenExposureAreaScale;
		
		[ObservableProperty]
		[property: ContainerField(32), JsonProperty(Order = 32)]
		private CtrRef<ObjectBlueprint> _MaskMeshBlueprint = new();
		
		[ObservableProperty]
		[property: ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		private bool _LockMeshToRenderView;
		
		[ObservableProperty]
		[property: ContainerField(37), LayoutImmutable, Blittable, JsonProperty(Order = 37)]
		private bool _AllowFieldOfViewScaling;
		
		[ObservableProperty]
		[property: ContainerField(38), LayoutImmutable, Blittable, JsonProperty(Order = 38)]
		private bool _FLIREnabled;
		
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
