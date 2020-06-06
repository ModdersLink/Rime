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
    [ContainerType(4)]
	public class LockingControllerData : 
		DataContainer
	{
		[ContainerField(8)]
		public List<ZoomLevelLockData> ZoomLevelLock { get; set; } = new List<ZoomLevelLockData>(); // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public float LockTime { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float ReleaseTime { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float ReleaseOnNewTargetTime { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public float SampleRate { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public float HoldStillThreshold { get; set; } // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public float RayLength { get; set; } // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public float AcceptanceAngle { get; set; } // 0x24 (36)
		
		[ContainerField(40), LayoutImmutable, Blittable]
		public float MinimumLockTime { get; set; } // 0x28 (40)
		
		[ContainerField(44), LayoutImmutable, Blittable]
		public float Sensitivity { get; set; } // 0x2C (44)
		
		[ContainerField(48), LayoutImmutable, Blittable]
		public float AngleConstant { get; set; } // 0x30 (48)
		
		[ContainerField(52), LayoutImmutable, Blittable]
		public float DistanceConstant { get; set; } // 0x34 (52)
		
		[ContainerField(56), LayoutImmutable, Blittable]
		public bool LockOnWorldSpacePos { get; set; } // 0x38 (56)
		
		[ContainerField(57), LayoutImmutable, Blittable]
		public bool LockOnVisibleTargetsOnly { get; set; } // 0x39 (57)
		
		[ContainerField(58), LayoutImmutable, Blittable]
		public bool PositionOnly { get; set; } // 0x3A (58)
		
		[ContainerField(59), LayoutImmutable, Blittable]
		public bool LockOnEmptyVehicles { get; set; } // 0x3B (59)
		
		[ContainerField(60), LayoutImmutable, Blittable]
		public bool IgnoreHeigthLockDistance { get; set; } // 0x3C (60)
		
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
