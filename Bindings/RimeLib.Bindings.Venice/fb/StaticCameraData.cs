///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class StaticCameraData : 
		TargetCameraData
	{
		[ContainerField(160)]
		public List<Vec3> LeftCurve { get; set; } = new List<Vec3>(); // 0xA0 (160)
		
		[ContainerField(164)]
		public List<Vec3> RightCurve { get; set; } = new List<Vec3>(); // 0xA4 (164)
		
		[ContainerField(168)]
		public List<Vec3> UpCurve { get; set; } = new List<Vec3>(); // 0xA8 (168)
		
		[ContainerField(172)]
		public List<Vec3> DownCurve { get; set; } = new List<Vec3>(); // 0xAC (172)
		
		[ContainerField(176), LayoutImmutable, Blittable]
		public float UpPitchAngle { get; set; } // 0xB0 (176)
		
		[ContainerField(180)]
		public EntryInputActionEnum YawInputAction { get; set; } = new EntryInputActionEnum(); // 0xB4 (180)
		
		[ContainerField(184)]
		public RefArray<CameraLoosePartPhysicsData> LoosePartPhysics { get; set; } = new RefArray<CameraLoosePartPhysicsData>(); // 0xB8 (184)
		
		[ContainerField(188), LayoutImmutable, Blittable]
		public float LeftYawAngle { get; set; } // 0xBC (188)
		
		[ContainerField(192), LayoutImmutable, Blittable]
		public float RightYawAngle { get; set; } // 0xC0 (192)
		
		[ContainerField(196), LayoutImmutable, Blittable]
		public float PitchSensitivityZoomed { get; set; } // 0xC4 (196)
		
		[ContainerField(200), LayoutImmutable, Blittable]
		public float DownPitchAngle { get; set; } // 0xC8 (200)
		
		[ContainerField(204), LayoutImmutable, Blittable]
		public int AverageFilterFrames { get; set; } // 0xCC (204)
		
		[ContainerField(208)]
		public EntryInputActionEnum PitchInputAction { get; set; } = new EntryInputActionEnum(); // 0xD0 (208)
		
		[ContainerField(212), LayoutImmutable, Blittable]
		public float YawSensitivityZoomed { get; set; } // 0xD4 (212)
		
		[ContainerField(216), LayoutImmutable, Blittable]
		public float PitchSensitivityNonZoomed { get; set; } // 0xD8 (216)
		
		[ContainerField(220), LayoutImmutable, Blittable]
		public float YawSensitivityNonZoomed { get; set; } // 0xDC (220)
		
		[ContainerField(224), LayoutImmutable, Blittable]
		public bool ResetAccumulatedInputOnViewChange { get; set; } // 0xE0 (224)
		
		[ContainerField(225), LayoutImmutable, Blittable]
		public bool MirrorHorizontalCurves { get; set; } // 0xE1 (225)
		
		[ContainerField(226), LayoutImmutable, Blittable]
		public bool AccumulateInput { get; set; } // 0xE2 (226)
		
		[ContainerField(227), LayoutImmutable, Blittable]
		public bool MirrorVerticalCurves { get; set; } // 0xE3 (227)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2820820617:
					LeftCurve = (List<Vec3>) p_Value;
					break;

				case 724171666:
					RightCurve = (List<Vec3>) p_Value;
					break;

				case 2426881463:
					UpCurve = (List<Vec3>) p_Value;
					break;

				case 3691425472:
					DownCurve = (List<Vec3>) p_Value;
					break;

				case 1050781767:
					UpPitchAngle = (float) p_Value;
					break;

				case 1432982466:
					YawInputAction = (EntryInputActionEnum) Enum.ToObject(typeof(EntryInputActionEnum), p_Value);
					break;

				case 4017113603:
					LoosePartPhysics = (RefArray<CameraLoosePartPhysicsData>) p_Value;
					break;

				case 2425251312:
					LeftYawAngle = (float) p_Value;
					break;

				case 2366463371:
					RightYawAngle = (float) p_Value;
					break;

				case 1497662520:
					PitchSensitivityZoomed = (float) p_Value;
					break;

				case 2129496336:
					DownPitchAngle = (float) p_Value;
					break;

				case 2544157096:
					AverageFilterFrames = (int) p_Value;
					break;

				case 4136660683:
					PitchInputAction = (EntryInputActionEnum) Enum.ToObject(typeof(EntryInputActionEnum), p_Value);
					break;

				case 682537073:
					YawSensitivityZoomed = (float) p_Value;
					break;

				case 508245719:
					PitchSensitivityNonZoomed = (float) p_Value;
					break;

				case 4254658238:
					YawSensitivityNonZoomed = (float) p_Value;
					break;

				case 986552120:
					ResetAccumulatedInputOnViewChange = (bool) p_Value;
					break;

				case 3434506758:
					MirrorHorizontalCurves = (bool) p_Value;
					break;

				case 922985347:
					AccumulateInput = (bool) p_Value;
					break;

				case 529936810:
					MirrorVerticalCurves = (bool) p_Value;
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
				case 2820820617:
					return LeftCurve;

				case 724171666:
					return RightCurve;

				case 2426881463:
					return UpCurve;

				case 3691425472:
					return DownCurve;

				case 1050781767:
					return UpPitchAngle;

				case 1432982466:
					return YawInputAction;

				case 4017113603:
					return LoosePartPhysics;

				case 2425251312:
					return LeftYawAngle;

				case 2366463371:
					return RightYawAngle;

				case 1497662520:
					return PitchSensitivityZoomed;

				case 2129496336:
					return DownPitchAngle;

				case 2544157096:
					return AverageFilterFrames;

				case 4136660683:
					return PitchInputAction;

				case 682537073:
					return YawSensitivityZoomed;

				case 508245719:
					return PitchSensitivityNonZoomed;

				case 4254658238:
					return YawSensitivityNonZoomed;

				case 986552120:
					return ResetAccumulatedInputOnViewChange;

				case 3434506758:
					return MirrorHorizontalCurves;

				case 922985347:
					return AccumulateInput;

				case 529936810:
					return MirrorVerticalCurves;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2820820617:
					return typeof(StaticCameraData).GetProperty(nameof(LeftCurve));

				case 724171666:
					return typeof(StaticCameraData).GetProperty(nameof(RightCurve));

				case 2426881463:
					return typeof(StaticCameraData).GetProperty(nameof(UpCurve));

				case 3691425472:
					return typeof(StaticCameraData).GetProperty(nameof(DownCurve));

				case 1050781767:
					return typeof(StaticCameraData).GetProperty(nameof(UpPitchAngle));

				case 1432982466:
					return typeof(StaticCameraData).GetProperty(nameof(YawInputAction));

				case 4017113603:
					return typeof(StaticCameraData).GetProperty(nameof(LoosePartPhysics));

				case 2425251312:
					return typeof(StaticCameraData).GetProperty(nameof(LeftYawAngle));

				case 2366463371:
					return typeof(StaticCameraData).GetProperty(nameof(RightYawAngle));

				case 1497662520:
					return typeof(StaticCameraData).GetProperty(nameof(PitchSensitivityZoomed));

				case 2129496336:
					return typeof(StaticCameraData).GetProperty(nameof(DownPitchAngle));

				case 2544157096:
					return typeof(StaticCameraData).GetProperty(nameof(AverageFilterFrames));

				case 4136660683:
					return typeof(StaticCameraData).GetProperty(nameof(PitchInputAction));

				case 682537073:
					return typeof(StaticCameraData).GetProperty(nameof(YawSensitivityZoomed));

				case 508245719:
					return typeof(StaticCameraData).GetProperty(nameof(PitchSensitivityNonZoomed));

				case 4254658238:
					return typeof(StaticCameraData).GetProperty(nameof(YawSensitivityNonZoomed));

				case 986552120:
					return typeof(StaticCameraData).GetProperty(nameof(ResetAccumulatedInputOnViewChange));

				case 3434506758:
					return typeof(StaticCameraData).GetProperty(nameof(MirrorHorizontalCurves));

				case 922985347:
					return typeof(StaticCameraData).GetProperty(nameof(AccumulateInput));

				case 529936810:
					return typeof(StaticCameraData).GetProperty(nameof(MirrorVerticalCurves));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
