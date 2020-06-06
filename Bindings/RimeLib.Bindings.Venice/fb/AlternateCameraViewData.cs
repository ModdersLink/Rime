///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class AlternateCameraViewData : 
		DataContainer
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 MeshOffset { get; set; } = new Vec3(); // 0x10 (16)
		
		[ContainerField(32)]
		public HudData Hud { get; set; } = new HudData(); // 0x20 (32)
		
		[ContainerField(100), LayoutImmutable, Blittable]
		public float FieldOfView { get; set; } // 0x64 (100)
		
		[ContainerField(104), LayoutImmutable, Blittable]
		public float WorldSpaceLockEfficiency { get; set; } // 0x68 (104)
		
		[ContainerField(108)]
		public CtrRef<RigidMeshAsset> Mesh { get; set; } = new CtrRef<RigidMeshAsset>(); // 0x6C (108)
		
		[ContainerField(112)]
		public CtrRef<ObjectBlueprint> MaskMeshBlueprint { get; set; } = new CtrRef<ObjectBlueprint>(); // 0x70 (112)
		
		[ContainerField(116), LayoutImmutable, Blittable]
		public float FadeInDuration { get; set; } // 0x74 (116)
		
		[ContainerField(120), LayoutImmutable, Blittable]
		public float FovTransitionTime { get; set; } // 0x78 (120)
		
		[ContainerField(124), LayoutImmutable, Blittable]
		public float BlackDuration { get; set; } // 0x7C (124)
		
		[ContainerField(128)]
		public InputSuppressionData InputSuppression { get; set; } = new InputSuppressionData(); // 0x80 (128)
		
		[ContainerField(132), LayoutImmutable, Blittable]
		public float ScreenExposureAreaScale { get; set; } // 0x84 (132)
		
		[ContainerField(136), LayoutImmutable, Blittable]
		public float FadeOutDuration { get; set; } // 0x88 (136)
		
		[ContainerField(140), LayoutImmutable, Blittable]
		public bool AllowFieldOfViewScaling { get; set; } // 0x8C (140)
		
		[ContainerField(141), LayoutImmutable, Blittable]
		public bool LockMeshToRenderView { get; set; } // 0x8D (141)
		
		[ContainerField(142), LayoutImmutable, Blittable]
		public bool ToggleViewChange { get; set; } // 0x8E (142)
		
		[ContainerField(143), LayoutImmutable, Blittable]
		public bool UseProfileOptionForToggleViewChange { get; set; } // 0x8F (143)
		
		[ContainerField(144), LayoutImmutable, Blittable]
		public bool FLIREnabled { get; set; } // 0x90 (144)
		
		[ContainerField(145), LayoutImmutable, Blittable]
		public bool FadeToBlack { get; set; } // 0x91 (145)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 775818267:
					MeshOffset = (Vec3) p_Value;
					break;

				case 193458844:
					Hud = (HudData) p_Value;
					break;

				case 2227716035:
					FieldOfView = (float) p_Value;
					break;

				case 4063999679:
					WorldSpaceLockEfficiency = (float) p_Value;
					break;

				case 2088783990:
					Mesh = (CtrRef<RigidMeshAsset>) p_Value;
					break;

				case 775268525:
					MaskMeshBlueprint = (CtrRef<ObjectBlueprint>) p_Value;
					break;

				case 2433887354:
					FadeInDuration = (float) p_Value;
					break;

				case 1751899392:
					FovTransitionTime = (float) p_Value;
					break;

				case 1274814300:
					BlackDuration = (float) p_Value;
					break;

				case 2197295466:
					InputSuppression = (InputSuppressionData) p_Value;
					break;

				case 2151479797:
					ScreenExposureAreaScale = (float) p_Value;
					break;

				case 556400947:
					FadeOutDuration = (float) p_Value;
					break;

				case 899159559:
					AllowFieldOfViewScaling = (bool) p_Value;
					break;

				case 3810317313:
					LockMeshToRenderView = (bool) p_Value;
					break;

				case 4173306524:
					ToggleViewChange = (bool) p_Value;
					break;

				case 731278668:
					UseProfileOptionForToggleViewChange = (bool) p_Value;
					break;

				case 1594804433:
					FLIREnabled = (bool) p_Value;
					break;

				case 325525503:
					FadeToBlack = (bool) p_Value;
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

				case 193458844:
					return Hud;

				case 2227716035:
					return FieldOfView;

				case 4063999679:
					return WorldSpaceLockEfficiency;

				case 2088783990:
					return Mesh;

				case 775268525:
					return MaskMeshBlueprint;

				case 2433887354:
					return FadeInDuration;

				case 1751899392:
					return FovTransitionTime;

				case 1274814300:
					return BlackDuration;

				case 2197295466:
					return InputSuppression;

				case 2151479797:
					return ScreenExposureAreaScale;

				case 556400947:
					return FadeOutDuration;

				case 899159559:
					return AllowFieldOfViewScaling;

				case 3810317313:
					return LockMeshToRenderView;

				case 4173306524:
					return ToggleViewChange;

				case 731278668:
					return UseProfileOptionForToggleViewChange;

				case 1594804433:
					return FLIREnabled;

				case 325525503:
					return FadeToBlack;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 775818267:
					return typeof(AlternateCameraViewData).GetProperty(nameof(MeshOffset));

				case 193458844:
					return typeof(AlternateCameraViewData).GetProperty(nameof(Hud));

				case 2227716035:
					return typeof(AlternateCameraViewData).GetProperty(nameof(FieldOfView));

				case 4063999679:
					return typeof(AlternateCameraViewData).GetProperty(nameof(WorldSpaceLockEfficiency));

				case 2088783990:
					return typeof(AlternateCameraViewData).GetProperty(nameof(Mesh));

				case 775268525:
					return typeof(AlternateCameraViewData).GetProperty(nameof(MaskMeshBlueprint));

				case 2433887354:
					return typeof(AlternateCameraViewData).GetProperty(nameof(FadeInDuration));

				case 1751899392:
					return typeof(AlternateCameraViewData).GetProperty(nameof(FovTransitionTime));

				case 1274814300:
					return typeof(AlternateCameraViewData).GetProperty(nameof(BlackDuration));

				case 2197295466:
					return typeof(AlternateCameraViewData).GetProperty(nameof(InputSuppression));

				case 2151479797:
					return typeof(AlternateCameraViewData).GetProperty(nameof(ScreenExposureAreaScale));

				case 556400947:
					return typeof(AlternateCameraViewData).GetProperty(nameof(FadeOutDuration));

				case 899159559:
					return typeof(AlternateCameraViewData).GetProperty(nameof(AllowFieldOfViewScaling));

				case 3810317313:
					return typeof(AlternateCameraViewData).GetProperty(nameof(LockMeshToRenderView));

				case 4173306524:
					return typeof(AlternateCameraViewData).GetProperty(nameof(ToggleViewChange));

				case 731278668:
					return typeof(AlternateCameraViewData).GetProperty(nameof(UseProfileOptionForToggleViewChange));

				case 1594804433:
					return typeof(AlternateCameraViewData).GetProperty(nameof(FLIREnabled));

				case 325525503:
					return typeof(AlternateCameraViewData).GetProperty(nameof(FadeToBlack));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
