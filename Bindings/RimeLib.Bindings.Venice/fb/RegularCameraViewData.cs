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
using RimeLib.Frostbite.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 16,  Flags: 41, Size: 48)]
	public class RegularCameraViewData : FrostbiteContainer
	{
		[ContainerField(Name: "MeshOffset", Offset: 0, NameHash: 775818267, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 MeshOffset { get; set; } = new Vec3(); // 0x0 (0)
		
		[ContainerField(Name: "InputSuppression", Offset: 16, NameHash: 2197295466, Flags: 41)]
		public InputSuppressionData InputSuppression { get; set; } = new InputSuppressionData(); // 0x10 (16)
		
		[ContainerField(Name: "FieldOfView", Offset: 20, NameHash: 2227716035, Flags: 49469), LayoutImmutable, Blittable]
		public float FieldOfView { get; set; } // 0x14 (20)
		
		[ContainerField(Name: "Mesh", Offset: 24, NameHash: 2088783990, Flags: 53)]
		public CtrRef<RigidMeshAsset> Mesh { get; set; } = new CtrRef<RigidMeshAsset>(); // 0x18 (24)
		
		[ContainerField(Name: "ScreenExposureAreaScale", Offset: 28, NameHash: 2151479797, Flags: 49469), LayoutImmutable, Blittable]
		public float ScreenExposureAreaScale { get; set; } // 0x1C (28)
		
		[ContainerField(Name: "MaskMeshBlueprint", Offset: 32, NameHash: 775268525, Flags: 53)]
		public CtrRef<ObjectBlueprint> MaskMeshBlueprint { get; set; } = new CtrRef<ObjectBlueprint>(); // 0x20 (32)
		
		[ContainerField(Name: "LockMeshToRenderView", Offset: 36, NameHash: 3810317313, Flags: 49325), LayoutImmutable, Blittable]
		public bool LockMeshToRenderView { get; set; } // 0x24 (36)
		
		[ContainerField(Name: "AllowFieldOfViewScaling", Offset: 37, NameHash: 899159559, Flags: 49325), LayoutImmutable, Blittable]
		public bool AllowFieldOfViewScaling { get; set; } // 0x25 (37)
		
		[ContainerField(Name: "FLIREnabled", Offset: 38, NameHash: 1594804433, Flags: 49325), LayoutImmutable, Blittable]
		public bool FLIREnabled { get; set; } // 0x26 (38)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 775818267:
					MeshOffset = (Vec3) p_Value;
					break;

				case 2197295466:
					InputSuppression = (InputSuppressionData) p_Value;
					break;

				case 2227716035:
					FieldOfView = (float) p_Value;
					break;

				case 2088783990:
					Mesh = (CtrRef<RigidMeshAsset>) p_Value;
					break;

				case 2151479797:
					ScreenExposureAreaScale = (float) p_Value;
					break;

				case 775268525:
					MaskMeshBlueprint = (CtrRef<ObjectBlueprint>) p_Value;
					break;

				case 3810317313:
					LockMeshToRenderView = (bool) p_Value;
					break;

				case 899159559:
					AllowFieldOfViewScaling = (bool) p_Value;
					break;

				case 1594804433:
					FLIREnabled = (bool) p_Value;
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
				case 775818267:
					return MeshOffset;

				case 2197295466:
					return InputSuppression;

				case 2227716035:
					return FieldOfView;

				case 2088783990:
					return Mesh;

				case 2151479797:
					return ScreenExposureAreaScale;

				case 775268525:
					return MaskMeshBlueprint;

				case 3810317313:
					return LockMeshToRenderView;

				case 899159559:
					return AllowFieldOfViewScaling;

				case 1594804433:
					return FLIREnabled;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 775818267:
					return typeof(RegularCameraViewData).GetProperty(nameof(MeshOffset));

				case 2197295466:
					return typeof(RegularCameraViewData).GetProperty(nameof(InputSuppression));

				case 2227716035:
					return typeof(RegularCameraViewData).GetProperty(nameof(FieldOfView));

				case 2088783990:
					return typeof(RegularCameraViewData).GetProperty(nameof(Mesh));

				case 2151479797:
					return typeof(RegularCameraViewData).GetProperty(nameof(ScreenExposureAreaScale));

				case 775268525:
					return typeof(RegularCameraViewData).GetProperty(nameof(MaskMeshBlueprint));

				case 3810317313:
					return typeof(RegularCameraViewData).GetProperty(nameof(LockMeshToRenderView));

				case 899159559:
					return typeof(RegularCameraViewData).GetProperty(nameof(AllowFieldOfViewScaling));

				case 1594804433:
					return typeof(RegularCameraViewData).GetProperty(nameof(FLIREnabled));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
