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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 160)]
	public class AlternateCameraViewData : 
		DataContainer
	{
		protected Vec3 m_MeshOffset = new Vec3();
		[ContainerField(Name: "MeshOffset", Offset: 16, NameHash: 775818267, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 MeshOffset { get { return m_MeshOffset; } set { if (OnPropertyChanging("AlternateCameraViewData." + nameof(MeshOffset), this, m_MeshOffset, value)) m_MeshOffset = value; } } // 0x10 (16)
		
		protected HudData m_Hud = new HudData();
		[ContainerField(Name: "Hud", Offset: 32, NameHash: 193458844, Flags: 41)]
		public HudData Hud { get { return m_Hud; } set { if (OnPropertyChanging("AlternateCameraViewData." + nameof(Hud), this, m_Hud, value)) m_Hud = value; } } // 0x20 (32)
		
		protected float m_FieldOfView = new float();
		[ContainerField(Name: "FieldOfView", Offset: 100, NameHash: 2227716035, Flags: 49469), LayoutImmutable, Blittable]
		public float FieldOfView { get { return m_FieldOfView; } set { if (OnPropertyChanging("AlternateCameraViewData." + nameof(FieldOfView), this, m_FieldOfView, value)) m_FieldOfView = value; } } // 0x64 (100)
		
		protected float m_WorldSpaceLockEfficiency = new float();
		[ContainerField(Name: "WorldSpaceLockEfficiency", Offset: 104, NameHash: 4063999679, Flags: 49469), LayoutImmutable, Blittable]
		public float WorldSpaceLockEfficiency { get { return m_WorldSpaceLockEfficiency; } set { if (OnPropertyChanging("AlternateCameraViewData." + nameof(WorldSpaceLockEfficiency), this, m_WorldSpaceLockEfficiency, value)) m_WorldSpaceLockEfficiency = value; } } // 0x68 (104)
		
		protected CtrRef<RigidMeshAsset> m_Mesh = new CtrRef<RigidMeshAsset>();
		[ContainerField(Name: "Mesh", Offset: 108, NameHash: 2088783990, Flags: 53)]
		public CtrRef<RigidMeshAsset> Mesh { get { return m_Mesh; } set { if (OnPropertyChanging("AlternateCameraViewData." + nameof(Mesh), this, m_Mesh, value)) m_Mesh = value; } } // 0x6C (108)
		
		protected CtrRef<ObjectBlueprint> m_MaskMeshBlueprint = new CtrRef<ObjectBlueprint>();
		[ContainerField(Name: "MaskMeshBlueprint", Offset: 112, NameHash: 775268525, Flags: 53)]
		public CtrRef<ObjectBlueprint> MaskMeshBlueprint { get { return m_MaskMeshBlueprint; } set { if (OnPropertyChanging("AlternateCameraViewData." + nameof(MaskMeshBlueprint), this, m_MaskMeshBlueprint, value)) m_MaskMeshBlueprint = value; } } // 0x70 (112)
		
		protected float m_FadeInDuration = new float();
		[ContainerField(Name: "FadeInDuration", Offset: 116, NameHash: 2433887354, Flags: 49469), LayoutImmutable, Blittable]
		public float FadeInDuration { get { return m_FadeInDuration; } set { if (OnPropertyChanging("AlternateCameraViewData." + nameof(FadeInDuration), this, m_FadeInDuration, value)) m_FadeInDuration = value; } } // 0x74 (116)
		
		protected float m_FovTransitionTime = new float();
		[ContainerField(Name: "FovTransitionTime", Offset: 120, NameHash: 1751899392, Flags: 49469), LayoutImmutable, Blittable]
		public float FovTransitionTime { get { return m_FovTransitionTime; } set { if (OnPropertyChanging("AlternateCameraViewData." + nameof(FovTransitionTime), this, m_FovTransitionTime, value)) m_FovTransitionTime = value; } } // 0x78 (120)
		
		protected float m_BlackDuration = new float();
		[ContainerField(Name: "BlackDuration", Offset: 124, NameHash: 1274814300, Flags: 49469), LayoutImmutable, Blittable]
		public float BlackDuration { get { return m_BlackDuration; } set { if (OnPropertyChanging("AlternateCameraViewData." + nameof(BlackDuration), this, m_BlackDuration, value)) m_BlackDuration = value; } } // 0x7C (124)
		
		protected InputSuppressionData m_InputSuppression = new InputSuppressionData();
		[ContainerField(Name: "InputSuppression", Offset: 128, NameHash: 2197295466, Flags: 41)]
		public InputSuppressionData InputSuppression { get { return m_InputSuppression; } set { if (OnPropertyChanging("AlternateCameraViewData." + nameof(InputSuppression), this, m_InputSuppression, value)) m_InputSuppression = value; } } // 0x80 (128)
		
		protected float m_ScreenExposureAreaScale = new float();
		[ContainerField(Name: "ScreenExposureAreaScale", Offset: 132, NameHash: 2151479797, Flags: 49469), LayoutImmutable, Blittable]
		public float ScreenExposureAreaScale { get { return m_ScreenExposureAreaScale; } set { if (OnPropertyChanging("AlternateCameraViewData." + nameof(ScreenExposureAreaScale), this, m_ScreenExposureAreaScale, value)) m_ScreenExposureAreaScale = value; } } // 0x84 (132)
		
		protected float m_FadeOutDuration = new float();
		[ContainerField(Name: "FadeOutDuration", Offset: 136, NameHash: 556400947, Flags: 49469), LayoutImmutable, Blittable]
		public float FadeOutDuration { get { return m_FadeOutDuration; } set { if (OnPropertyChanging("AlternateCameraViewData." + nameof(FadeOutDuration), this, m_FadeOutDuration, value)) m_FadeOutDuration = value; } } // 0x88 (136)
		
		protected bool m_AllowFieldOfViewScaling = new bool();
		[ContainerField(Name: "AllowFieldOfViewScaling", Offset: 140, NameHash: 899159559, Flags: 49325), LayoutImmutable, Blittable]
		public bool AllowFieldOfViewScaling { get { return m_AllowFieldOfViewScaling; } set { if (OnPropertyChanging("AlternateCameraViewData." + nameof(AllowFieldOfViewScaling), this, m_AllowFieldOfViewScaling, value)) m_AllowFieldOfViewScaling = value; } } // 0x8C (140)
		
		protected bool m_LockMeshToRenderView = new bool();
		[ContainerField(Name: "LockMeshToRenderView", Offset: 141, NameHash: 3810317313, Flags: 49325), LayoutImmutable, Blittable]
		public bool LockMeshToRenderView { get { return m_LockMeshToRenderView; } set { if (OnPropertyChanging("AlternateCameraViewData." + nameof(LockMeshToRenderView), this, m_LockMeshToRenderView, value)) m_LockMeshToRenderView = value; } } // 0x8D (141)
		
		protected bool m_ToggleViewChange = new bool();
		[ContainerField(Name: "ToggleViewChange", Offset: 142, NameHash: 4173306524, Flags: 49325), LayoutImmutable, Blittable]
		public bool ToggleViewChange { get { return m_ToggleViewChange; } set { if (OnPropertyChanging("AlternateCameraViewData." + nameof(ToggleViewChange), this, m_ToggleViewChange, value)) m_ToggleViewChange = value; } } // 0x8E (142)
		
		protected bool m_UseProfileOptionForToggleViewChange = new bool();
		[ContainerField(Name: "UseProfileOptionForToggleViewChange", Offset: 143, NameHash: 731278668, Flags: 49325), LayoutImmutable, Blittable]
		public bool UseProfileOptionForToggleViewChange { get { return m_UseProfileOptionForToggleViewChange; } set { if (OnPropertyChanging("AlternateCameraViewData." + nameof(UseProfileOptionForToggleViewChange), this, m_UseProfileOptionForToggleViewChange, value)) m_UseProfileOptionForToggleViewChange = value; } } // 0x8F (143)
		
		protected bool m_FLIREnabled = new bool();
		[ContainerField(Name: "FLIREnabled", Offset: 144, NameHash: 1594804433, Flags: 49325), LayoutImmutable, Blittable]
		public bool FLIREnabled { get { return m_FLIREnabled; } set { if (OnPropertyChanging("AlternateCameraViewData." + nameof(FLIREnabled), this, m_FLIREnabled, value)) m_FLIREnabled = value; } } // 0x90 (144)
		
		protected bool m_FadeToBlack = new bool();
		[ContainerField(Name: "FadeToBlack", Offset: 145, NameHash: 325525503, Flags: 49325), LayoutImmutable, Blittable]
		public bool FadeToBlack { get { return m_FadeToBlack; } set { if (OnPropertyChanging("AlternateCameraViewData." + nameof(FadeToBlack), this, m_FadeToBlack, value)) m_FadeToBlack = value; } } // 0x91 (145)
		
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
