///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Collections.Generic;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class UavCameraData : 
		TargetCameraData
	{
		[ContainerField(160), LayoutImmutable, Blittable]
		public float ViewDistance { get; set; } // 0xA0 (160)
		
		[ContainerField(164)]
		public List<CameraSineCurveData> ViewDistanceCurve { get; set; } = new List<CameraSineCurveData>(); // 0xA4 (164)
		
		[ContainerField(168), LayoutImmutable, Blittable]
		public float ViewAngle { get; set; } // 0xA8 (168)
		
		[ContainerField(172)]
		public List<CameraSineCurveData> ViewAngleCurve { get; set; } = new List<CameraSineCurveData>(); // 0xAC (172)
		
		[ContainerField(176), LayoutImmutable, Blittable]
		public float RotationSpeed { get; set; } // 0xB0 (176)
		
		[ContainerField(180)]
		public List<CameraSineCurveData> RotationSpeedCurve { get; set; } = new List<CameraSineCurveData>(); // 0xB4 (180)
		
		[ContainerField(184), LayoutImmutable, Blittable]
		public float ZoomFov { get; set; } // 0xB8 (184)
		
		[ContainerField(188), LayoutImmutable, Blittable]
		public float ZoomDelay { get; set; } // 0xBC (188)
		
		[ContainerField(192), LayoutImmutable, Blittable]
		public float ZoomTransitionTime { get; set; } // 0xC0 (192)
		
		[ContainerField(196), LayoutImmutable, Blittable]
		public float Fov { get; set; } // 0xC4 (196)
		
		[ContainerField(200)]
		public UavCameraPointData FocusPoint { get; set; } = new UavCameraPointData(); // 0xC8 (200)
		
		[ContainerField(216)]
		public UavCameraPointData CenterPoint { get; set; } = new UavCameraPointData(); // 0xD8 (216)
		
		[ContainerField(232), LayoutImmutable, Blittable]
		public float UpWeightDistance { get; set; } // 0xE8 (232)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2201945291:
					ViewDistance = (float) p_Value;
					break;

				case 2498741148:
					ViewDistanceCurve = (List<CameraSineCurveData>) p_Value;
					break;

				case 4017129097:
					ViewAngle = (float) p_Value;
					break;

				case 3975970206:
					ViewAngleCurve = (List<CameraSineCurveData>) p_Value;
					break;

				case 802351446:
					RotationSpeed = (float) p_Value;
					break;

				case 836629921:
					RotationSpeedCurve = (List<CameraSineCurveData>) p_Value;
					break;

				case 2842985581:
					ZoomFov = (float) p_Value;
					break;

				case 3641349063:
					ZoomDelay = (float) p_Value;
					break;

				case 1414605576:
					ZoomTransitionTime = (float) p_Value;
					break;

				case 193443802:
					Fov = (float) p_Value;
					break;

				case 2983182053:
					FocusPoint = (UavCameraPointData) p_Value;
					break;

				case 3946853250:
					CenterPoint = (UavCameraPointData) p_Value;
					break;

				case 427137187:
					UpWeightDistance = (float) p_Value;
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
				case 2201945291:
					return ViewDistance;

				case 2498741148:
					return ViewDistanceCurve;

				case 4017129097:
					return ViewAngle;

				case 3975970206:
					return ViewAngleCurve;

				case 802351446:
					return RotationSpeed;

				case 836629921:
					return RotationSpeedCurve;

				case 2842985581:
					return ZoomFov;

				case 3641349063:
					return ZoomDelay;

				case 1414605576:
					return ZoomTransitionTime;

				case 193443802:
					return Fov;

				case 2983182053:
					return FocusPoint;

				case 3946853250:
					return CenterPoint;

				case 427137187:
					return UpWeightDistance;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2201945291:
					return typeof(UavCameraData).GetProperty(nameof(ViewDistance));

				case 2498741148:
					return typeof(UavCameraData).GetProperty(nameof(ViewDistanceCurve));

				case 4017129097:
					return typeof(UavCameraData).GetProperty(nameof(ViewAngle));

				case 3975970206:
					return typeof(UavCameraData).GetProperty(nameof(ViewAngleCurve));

				case 802351446:
					return typeof(UavCameraData).GetProperty(nameof(RotationSpeed));

				case 836629921:
					return typeof(UavCameraData).GetProperty(nameof(RotationSpeedCurve));

				case 2842985581:
					return typeof(UavCameraData).GetProperty(nameof(ZoomFov));

				case 3641349063:
					return typeof(UavCameraData).GetProperty(nameof(ZoomDelay));

				case 1414605576:
					return typeof(UavCameraData).GetProperty(nameof(ZoomTransitionTime));

				case 193443802:
					return typeof(UavCameraData).GetProperty(nameof(Fov));

				case 2983182053:
					return typeof(UavCameraData).GetProperty(nameof(FocusPoint));

				case 3946853250:
					return typeof(UavCameraData).GetProperty(nameof(CenterPoint));

				case 427137187:
					return typeof(UavCameraData).GetProperty(nameof(UpWeightDistance));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
