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
using RimeLib.Serialization.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(16)]
	public class UavCameraData : 
		TargetCameraData
	{
		protected float m_ViewDistance = new float();
		[ContainerField(160), LayoutImmutable, Blittable, ContainerFieldNameHash(2201945291)]
		public float ViewDistance { get { return m_ViewDistance; } set { if (OnPropertyChanging("UavCameraData." + nameof(ViewDistance), this, m_ViewDistance, value)) m_ViewDistance = value; } } // 0xA0 (160)
		
		protected List<CameraSineCurveData> m_ViewDistanceCurve = new List<CameraSineCurveData>();
		[ContainerField(164), ContainerFieldNameHash(2498741148)]
		public List<CameraSineCurveData> ViewDistanceCurve { get { return m_ViewDistanceCurve; } set { if (OnPropertyChanging("UavCameraData." + nameof(ViewDistanceCurve), this, m_ViewDistanceCurve, value)) m_ViewDistanceCurve = value; } } // 0xA4 (164)
		
		protected float m_ViewAngle = new float();
		[ContainerField(168), LayoutImmutable, Blittable, ContainerFieldNameHash(4017129097)]
		public float ViewAngle { get { return m_ViewAngle; } set { if (OnPropertyChanging("UavCameraData." + nameof(ViewAngle), this, m_ViewAngle, value)) m_ViewAngle = value; } } // 0xA8 (168)
		
		protected List<CameraSineCurveData> m_ViewAngleCurve = new List<CameraSineCurveData>();
		[ContainerField(172), ContainerFieldNameHash(3975970206)]
		public List<CameraSineCurveData> ViewAngleCurve { get { return m_ViewAngleCurve; } set { if (OnPropertyChanging("UavCameraData." + nameof(ViewAngleCurve), this, m_ViewAngleCurve, value)) m_ViewAngleCurve = value; } } // 0xAC (172)
		
		protected float m_RotationSpeed = new float();
		[ContainerField(176), LayoutImmutable, Blittable, ContainerFieldNameHash(802351446)]
		public float RotationSpeed { get { return m_RotationSpeed; } set { if (OnPropertyChanging("UavCameraData." + nameof(RotationSpeed), this, m_RotationSpeed, value)) m_RotationSpeed = value; } } // 0xB0 (176)
		
		protected List<CameraSineCurveData> m_RotationSpeedCurve = new List<CameraSineCurveData>();
		[ContainerField(180), ContainerFieldNameHash(836629921)]
		public List<CameraSineCurveData> RotationSpeedCurve { get { return m_RotationSpeedCurve; } set { if (OnPropertyChanging("UavCameraData." + nameof(RotationSpeedCurve), this, m_RotationSpeedCurve, value)) m_RotationSpeedCurve = value; } } // 0xB4 (180)
		
		protected float m_ZoomFov = new float();
		[ContainerField(184), LayoutImmutable, Blittable, ContainerFieldNameHash(2842985581)]
		public float ZoomFov { get { return m_ZoomFov; } set { if (OnPropertyChanging("UavCameraData." + nameof(ZoomFov), this, m_ZoomFov, value)) m_ZoomFov = value; } } // 0xB8 (184)
		
		protected float m_ZoomDelay = new float();
		[ContainerField(188), LayoutImmutable, Blittable, ContainerFieldNameHash(3641349063)]
		public float ZoomDelay { get { return m_ZoomDelay; } set { if (OnPropertyChanging("UavCameraData." + nameof(ZoomDelay), this, m_ZoomDelay, value)) m_ZoomDelay = value; } } // 0xBC (188)
		
		protected float m_ZoomTransitionTime = new float();
		[ContainerField(192), LayoutImmutable, Blittable, ContainerFieldNameHash(1414605576)]
		public float ZoomTransitionTime { get { return m_ZoomTransitionTime; } set { if (OnPropertyChanging("UavCameraData." + nameof(ZoomTransitionTime), this, m_ZoomTransitionTime, value)) m_ZoomTransitionTime = value; } } // 0xC0 (192)
		
		protected float m_Fov = new float();
		[ContainerField(196), LayoutImmutable, Blittable, ContainerFieldNameHash(193443802)]
		public float Fov { get { return m_Fov; } set { if (OnPropertyChanging("UavCameraData." + nameof(Fov), this, m_Fov, value)) m_Fov = value; } } // 0xC4 (196)
		
		protected UavCameraPointData m_FocusPoint = new UavCameraPointData();
		[ContainerField(200), ContainerFieldNameHash(2983182053)]
		public UavCameraPointData FocusPoint { get { return m_FocusPoint; } set { if (OnPropertyChanging("UavCameraData." + nameof(FocusPoint), this, m_FocusPoint, value)) m_FocusPoint = value; } } // 0xC8 (200)
		
		protected UavCameraPointData m_CenterPoint = new UavCameraPointData();
		[ContainerField(216), ContainerFieldNameHash(3946853250)]
		public UavCameraPointData CenterPoint { get { return m_CenterPoint; } set { if (OnPropertyChanging("UavCameraData." + nameof(CenterPoint), this, m_CenterPoint, value)) m_CenterPoint = value; } } // 0xD8 (216)
		
		protected float m_UpWeightDistance = new float();
		[ContainerField(232), LayoutImmutable, Blittable, ContainerFieldNameHash(427137187)]
		public float UpWeightDistance { get { return m_UpWeightDistance; } set { if (OnPropertyChanging("UavCameraData." + nameof(UpWeightDistance), this, m_UpWeightDistance, value)) m_UpWeightDistance = value; } } // 0xE8 (232)
		
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
