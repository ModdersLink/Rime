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
	[ContainerType(16), MemberInfoFlag(53), ContainerSize(240), ContainerClass]
	public class StaticCameraData : 
		TargetCameraData
	{
		protected List<Vec3> m_LeftCurve = new List<Vec3>();
		[ContainerField(160), MemberInfoFlag(65), ContainerFieldNameHash(2820820617), ContainerArray]
		public List<Vec3> LeftCurve { get { return m_LeftCurve; } set { if (OnPropertyChanging("StaticCameraData." + nameof(LeftCurve), this, m_LeftCurve, value)) m_LeftCurve = value; } } // 0xA0 (160)
		
		protected List<Vec3> m_RightCurve = new List<Vec3>();
		[ContainerField(164), MemberInfoFlag(65), ContainerFieldNameHash(724171666), ContainerArray]
		public List<Vec3> RightCurve { get { return m_RightCurve; } set { if (OnPropertyChanging("StaticCameraData." + nameof(RightCurve), this, m_RightCurve, value)) m_RightCurve = value; } } // 0xA4 (164)
		
		protected List<Vec3> m_UpCurve = new List<Vec3>();
		[ContainerField(168), MemberInfoFlag(65), ContainerFieldNameHash(2426881463), ContainerArray]
		public List<Vec3> UpCurve { get { return m_UpCurve; } set { if (OnPropertyChanging("StaticCameraData." + nameof(UpCurve), this, m_UpCurve, value)) m_UpCurve = value; } } // 0xA8 (168)
		
		protected List<Vec3> m_DownCurve = new List<Vec3>();
		[ContainerField(172), MemberInfoFlag(65), ContainerFieldNameHash(3691425472), ContainerArray]
		public List<Vec3> DownCurve { get { return m_DownCurve; } set { if (OnPropertyChanging("StaticCameraData." + nameof(DownCurve), this, m_DownCurve, value)) m_DownCurve = value; } } // 0xAC (172)
		
		protected float m_UpPitchAngle = new float();
		[ContainerField(176), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1050781767)]
		public float UpPitchAngle { get { return m_UpPitchAngle; } set { if (OnPropertyChanging("StaticCameraData." + nameof(UpPitchAngle), this, m_UpPitchAngle, value)) m_UpPitchAngle = value; } } // 0xB0 (176)
		
		protected EntryInputActionEnum m_YawInputAction = new EntryInputActionEnum();
		[ContainerField(180), MemberInfoFlag(137), ContainerFieldNameHash(1432982466)]
		public EntryInputActionEnum YawInputAction { get { return m_YawInputAction; } set { if (OnPropertyChanging("StaticCameraData." + nameof(YawInputAction), this, m_YawInputAction, value)) m_YawInputAction = value; } } // 0xB4 (180)
		
		protected RefArray<CameraLoosePartPhysicsData> m_LoosePartPhysics = new RefArray<CameraLoosePartPhysicsData>();
		[ContainerField(184), MemberInfoFlag(65), ContainerFieldNameHash(4017113603), ContainerRefArray]
		public RefArray<CameraLoosePartPhysicsData> LoosePartPhysics { get { return m_LoosePartPhysics; } set { if (OnPropertyChanging("StaticCameraData." + nameof(LoosePartPhysics), this, m_LoosePartPhysics, value)) m_LoosePartPhysics = value; } } // 0xB8 (184)
		
		protected float m_LeftYawAngle = new float();
		[ContainerField(188), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2425251312)]
		public float LeftYawAngle { get { return m_LeftYawAngle; } set { if (OnPropertyChanging("StaticCameraData." + nameof(LeftYawAngle), this, m_LeftYawAngle, value)) m_LeftYawAngle = value; } } // 0xBC (188)
		
		protected float m_RightYawAngle = new float();
		[ContainerField(192), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2366463371)]
		public float RightYawAngle { get { return m_RightYawAngle; } set { if (OnPropertyChanging("StaticCameraData." + nameof(RightYawAngle), this, m_RightYawAngle, value)) m_RightYawAngle = value; } } // 0xC0 (192)
		
		protected float m_PitchSensitivityZoomed = new float();
		[ContainerField(196), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1497662520)]
		public float PitchSensitivityZoomed { get { return m_PitchSensitivityZoomed; } set { if (OnPropertyChanging("StaticCameraData." + nameof(PitchSensitivityZoomed), this, m_PitchSensitivityZoomed, value)) m_PitchSensitivityZoomed = value; } } // 0xC4 (196)
		
		protected float m_DownPitchAngle = new float();
		[ContainerField(200), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2129496336)]
		public float DownPitchAngle { get { return m_DownPitchAngle; } set { if (OnPropertyChanging("StaticCameraData." + nameof(DownPitchAngle), this, m_DownPitchAngle, value)) m_DownPitchAngle = value; } } // 0xC8 (200)
		
		protected int m_AverageFilterFrames = new int();
		[ContainerField(204), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(2544157096)]
		public int AverageFilterFrames { get { return m_AverageFilterFrames; } set { if (OnPropertyChanging("StaticCameraData." + nameof(AverageFilterFrames), this, m_AverageFilterFrames, value)) m_AverageFilterFrames = value; } } // 0xCC (204)
		
		protected EntryInputActionEnum m_PitchInputAction = new EntryInputActionEnum();
		[ContainerField(208), MemberInfoFlag(137), ContainerFieldNameHash(4136660683)]
		public EntryInputActionEnum PitchInputAction { get { return m_PitchInputAction; } set { if (OnPropertyChanging("StaticCameraData." + nameof(PitchInputAction), this, m_PitchInputAction, value)) m_PitchInputAction = value; } } // 0xD0 (208)
		
		protected float m_YawSensitivityZoomed = new float();
		[ContainerField(212), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(682537073)]
		public float YawSensitivityZoomed { get { return m_YawSensitivityZoomed; } set { if (OnPropertyChanging("StaticCameraData." + nameof(YawSensitivityZoomed), this, m_YawSensitivityZoomed, value)) m_YawSensitivityZoomed = value; } } // 0xD4 (212)
		
		protected float m_PitchSensitivityNonZoomed = new float();
		[ContainerField(216), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(508245719)]
		public float PitchSensitivityNonZoomed { get { return m_PitchSensitivityNonZoomed; } set { if (OnPropertyChanging("StaticCameraData." + nameof(PitchSensitivityNonZoomed), this, m_PitchSensitivityNonZoomed, value)) m_PitchSensitivityNonZoomed = value; } } // 0xD8 (216)
		
		protected float m_YawSensitivityNonZoomed = new float();
		[ContainerField(220), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(4254658238)]
		public float YawSensitivityNonZoomed { get { return m_YawSensitivityNonZoomed; } set { if (OnPropertyChanging("StaticCameraData." + nameof(YawSensitivityNonZoomed), this, m_YawSensitivityNonZoomed, value)) m_YawSensitivityNonZoomed = value; } } // 0xDC (220)
		
		protected bool m_ResetAccumulatedInputOnViewChange = new bool();
		[ContainerField(224), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(986552120)]
		public bool ResetAccumulatedInputOnViewChange { get { return m_ResetAccumulatedInputOnViewChange; } set { if (OnPropertyChanging("StaticCameraData." + nameof(ResetAccumulatedInputOnViewChange), this, m_ResetAccumulatedInputOnViewChange, value)) m_ResetAccumulatedInputOnViewChange = value; } } // 0xE0 (224)
		
		protected bool m_MirrorHorizontalCurves = new bool();
		[ContainerField(225), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3434506758)]
		public bool MirrorHorizontalCurves { get { return m_MirrorHorizontalCurves; } set { if (OnPropertyChanging("StaticCameraData." + nameof(MirrorHorizontalCurves), this, m_MirrorHorizontalCurves, value)) m_MirrorHorizontalCurves = value; } } // 0xE1 (225)
		
		protected bool m_AccumulateInput = new bool();
		[ContainerField(226), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(922985347)]
		public bool AccumulateInput { get { return m_AccumulateInput; } set { if (OnPropertyChanging("StaticCameraData." + nameof(AccumulateInput), this, m_AccumulateInput, value)) m_AccumulateInput = value; } } // 0xE2 (226)
		
		protected bool m_MirrorVerticalCurves = new bool();
		[ContainerField(227), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(529936810)]
		public bool MirrorVerticalCurves { get { return m_MirrorVerticalCurves; } set { if (OnPropertyChanging("StaticCameraData." + nameof(MirrorVerticalCurves), this, m_MirrorVerticalCurves, value)) m_MirrorVerticalCurves = value; } } // 0xE3 (227)
		
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
