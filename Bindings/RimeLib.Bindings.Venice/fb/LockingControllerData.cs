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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(64), ContainerClass]
	public class LockingControllerData : 
		DataContainer
	{
		protected List<ZoomLevelLockData> m_ZoomLevelLock = new List<ZoomLevelLockData>();
		[ContainerField(8), MemberInfoFlag(65), ContainerFieldNameHash(1609958223), ContainerArray]
		public List<ZoomLevelLockData> ZoomLevelLock { get { return m_ZoomLevelLock; } set { if (OnPropertyChanging("LockingControllerData." + nameof(ZoomLevelLock), this, m_ZoomLevelLock, value)) m_ZoomLevelLock = value; } } // 0x8 (8)
		
		protected float m_LockTime = new float();
		[ContainerField(12), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1982096347)]
		public float LockTime { get { return m_LockTime; } set { if (OnPropertyChanging("LockingControllerData." + nameof(LockTime), this, m_LockTime, value)) m_LockTime = value; } } // 0xC (12)
		
		protected float m_ReleaseTime = new float();
		[ContainerField(16), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(892319833)]
		public float ReleaseTime { get { return m_ReleaseTime; } set { if (OnPropertyChanging("LockingControllerData." + nameof(ReleaseTime), this, m_ReleaseTime, value)) m_ReleaseTime = value; } } // 0x10 (16)
		
		protected float m_ReleaseOnNewTargetTime = new float();
		[ContainerField(20), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(133838421)]
		public float ReleaseOnNewTargetTime { get { return m_ReleaseOnNewTargetTime; } set { if (OnPropertyChanging("LockingControllerData." + nameof(ReleaseOnNewTargetTime), this, m_ReleaseOnNewTargetTime, value)) m_ReleaseOnNewTargetTime = value; } } // 0x14 (20)
		
		protected float m_SampleRate = new float();
		[ContainerField(24), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(604757697)]
		public float SampleRate { get { return m_SampleRate; } set { if (OnPropertyChanging("LockingControllerData." + nameof(SampleRate), this, m_SampleRate, value)) m_SampleRate = value; } } // 0x18 (24)
		
		protected float m_HoldStillThreshold = new float();
		[ContainerField(28), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3981331987)]
		public float HoldStillThreshold { get { return m_HoldStillThreshold; } set { if (OnPropertyChanging("LockingControllerData." + nameof(HoldStillThreshold), this, m_HoldStillThreshold, value)) m_HoldStillThreshold = value; } } // 0x1C (28)
		
		protected float m_RayLength = new float();
		[ContainerField(32), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(714575027)]
		public float RayLength { get { return m_RayLength; } set { if (OnPropertyChanging("LockingControllerData." + nameof(RayLength), this, m_RayLength, value)) m_RayLength = value; } } // 0x20 (32)
		
		protected float m_AcceptanceAngle = new float();
		[ContainerField(36), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(66845485)]
		public float AcceptanceAngle { get { return m_AcceptanceAngle; } set { if (OnPropertyChanging("LockingControllerData." + nameof(AcceptanceAngle), this, m_AcceptanceAngle, value)) m_AcceptanceAngle = value; } } // 0x24 (36)
		
		protected float m_MinimumLockTime = new float();
		[ContainerField(40), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1585650381)]
		public float MinimumLockTime { get { return m_MinimumLockTime; } set { if (OnPropertyChanging("LockingControllerData." + nameof(MinimumLockTime), this, m_MinimumLockTime, value)) m_MinimumLockTime = value; } } // 0x28 (40)
		
		protected float m_Sensitivity = new float();
		[ContainerField(44), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2124383208)]
		public float Sensitivity { get { return m_Sensitivity; } set { if (OnPropertyChanging("LockingControllerData." + nameof(Sensitivity), this, m_Sensitivity, value)) m_Sensitivity = value; } } // 0x2C (44)
		
		protected float m_AngleConstant = new float();
		[ContainerField(48), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2438038842)]
		public float AngleConstant { get { return m_AngleConstant; } set { if (OnPropertyChanging("LockingControllerData." + nameof(AngleConstant), this, m_AngleConstant, value)) m_AngleConstant = value; } } // 0x30 (48)
		
		protected float m_DistanceConstant = new float();
		[ContainerField(52), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1734890008)]
		public float DistanceConstant { get { return m_DistanceConstant; } set { if (OnPropertyChanging("LockingControllerData." + nameof(DistanceConstant), this, m_DistanceConstant, value)) m_DistanceConstant = value; } } // 0x34 (52)
		
		protected bool m_LockOnWorldSpacePos = new bool();
		[ContainerField(56), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2930832517)]
		public bool LockOnWorldSpacePos { get { return m_LockOnWorldSpacePos; } set { if (OnPropertyChanging("LockingControllerData." + nameof(LockOnWorldSpacePos), this, m_LockOnWorldSpacePos, value)) m_LockOnWorldSpacePos = value; } } // 0x38 (56)
		
		protected bool m_LockOnVisibleTargetsOnly = new bool();
		[ContainerField(57), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1817419671)]
		public bool LockOnVisibleTargetsOnly { get { return m_LockOnVisibleTargetsOnly; } set { if (OnPropertyChanging("LockingControllerData." + nameof(LockOnVisibleTargetsOnly), this, m_LockOnVisibleTargetsOnly, value)) m_LockOnVisibleTargetsOnly = value; } } // 0x39 (57)
		
		protected bool m_PositionOnly = new bool();
		[ContainerField(58), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3572870760)]
		public bool PositionOnly { get { return m_PositionOnly; } set { if (OnPropertyChanging("LockingControllerData." + nameof(PositionOnly), this, m_PositionOnly, value)) m_PositionOnly = value; } } // 0x3A (58)
		
		protected bool m_LockOnEmptyVehicles = new bool();
		[ContainerField(59), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(633097329)]
		public bool LockOnEmptyVehicles { get { return m_LockOnEmptyVehicles; } set { if (OnPropertyChanging("LockingControllerData." + nameof(LockOnEmptyVehicles), this, m_LockOnEmptyVehicles, value)) m_LockOnEmptyVehicles = value; } } // 0x3B (59)
		
		protected bool m_IgnoreHeigthLockDistance = new bool();
		[ContainerField(60), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1465082762)]
		public bool IgnoreHeigthLockDistance { get { return m_IgnoreHeigthLockDistance; } set { if (OnPropertyChanging("LockingControllerData." + nameof(IgnoreHeigthLockDistance), this, m_IgnoreHeigthLockDistance, value)) m_IgnoreHeigthLockDistance = value; } } // 0x3C (60)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1609958223:
					ZoomLevelLock = (List<ZoomLevelLockData>) p_Value;
					break;

				case 1982096347:
					LockTime = (float) p_Value;
					break;

				case 892319833:
					ReleaseTime = (float) p_Value;
					break;

				case 133838421:
					ReleaseOnNewTargetTime = (float) p_Value;
					break;

				case 604757697:
					SampleRate = (float) p_Value;
					break;

				case 3981331987:
					HoldStillThreshold = (float) p_Value;
					break;

				case 714575027:
					RayLength = (float) p_Value;
					break;

				case 66845485:
					AcceptanceAngle = (float) p_Value;
					break;

				case 1585650381:
					MinimumLockTime = (float) p_Value;
					break;

				case 2124383208:
					Sensitivity = (float) p_Value;
					break;

				case 2438038842:
					AngleConstant = (float) p_Value;
					break;

				case 1734890008:
					DistanceConstant = (float) p_Value;
					break;

				case 2930832517:
					LockOnWorldSpacePos = (bool) p_Value;
					break;

				case 1817419671:
					LockOnVisibleTargetsOnly = (bool) p_Value;
					break;

				case 3572870760:
					PositionOnly = (bool) p_Value;
					break;

				case 633097329:
					LockOnEmptyVehicles = (bool) p_Value;
					break;

				case 1465082762:
					IgnoreHeigthLockDistance = (bool) p_Value;
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
				case 1609958223:
					return ZoomLevelLock;

				case 1982096347:
					return LockTime;

				case 892319833:
					return ReleaseTime;

				case 133838421:
					return ReleaseOnNewTargetTime;

				case 604757697:
					return SampleRate;

				case 3981331987:
					return HoldStillThreshold;

				case 714575027:
					return RayLength;

				case 66845485:
					return AcceptanceAngle;

				case 1585650381:
					return MinimumLockTime;

				case 2124383208:
					return Sensitivity;

				case 2438038842:
					return AngleConstant;

				case 1734890008:
					return DistanceConstant;

				case 2930832517:
					return LockOnWorldSpacePos;

				case 1817419671:
					return LockOnVisibleTargetsOnly;

				case 3572870760:
					return PositionOnly;

				case 633097329:
					return LockOnEmptyVehicles;

				case 1465082762:
					return IgnoreHeigthLockDistance;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1609958223:
					return typeof(LockingControllerData).GetProperty(nameof(ZoomLevelLock));

				case 1982096347:
					return typeof(LockingControllerData).GetProperty(nameof(LockTime));

				case 892319833:
					return typeof(LockingControllerData).GetProperty(nameof(ReleaseTime));

				case 133838421:
					return typeof(LockingControllerData).GetProperty(nameof(ReleaseOnNewTargetTime));

				case 604757697:
					return typeof(LockingControllerData).GetProperty(nameof(SampleRate));

				case 3981331987:
					return typeof(LockingControllerData).GetProperty(nameof(HoldStillThreshold));

				case 714575027:
					return typeof(LockingControllerData).GetProperty(nameof(RayLength));

				case 66845485:
					return typeof(LockingControllerData).GetProperty(nameof(AcceptanceAngle));

				case 1585650381:
					return typeof(LockingControllerData).GetProperty(nameof(MinimumLockTime));

				case 2124383208:
					return typeof(LockingControllerData).GetProperty(nameof(Sensitivity));

				case 2438038842:
					return typeof(LockingControllerData).GetProperty(nameof(AngleConstant));

				case 1734890008:
					return typeof(LockingControllerData).GetProperty(nameof(DistanceConstant));

				case 2930832517:
					return typeof(LockingControllerData).GetProperty(nameof(LockOnWorldSpacePos));

				case 1817419671:
					return typeof(LockingControllerData).GetProperty(nameof(LockOnVisibleTargetsOnly));

				case 3572870760:
					return typeof(LockingControllerData).GetProperty(nameof(PositionOnly));

				case 633097329:
					return typeof(LockingControllerData).GetProperty(nameof(LockOnEmptyVehicles));

				case 1465082762:
					return typeof(LockingControllerData).GetProperty(nameof(IgnoreHeigthLockDistance));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
