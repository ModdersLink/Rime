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
	public class VehicleCameraData : 
		TargetCameraData
	{
		protected Vec3 m_MoveToPosition = new Vec3();
		[ContainerField(160), Homogeneous, LayoutImmutable, Blittable, ContainerFieldNameHash(2255519254)]
		public Vec3 MoveToPosition { get { return m_MoveToPosition; } set { if (OnPropertyChanging("VehicleCameraData." + nameof(MoveToPosition), this, m_MoveToPosition, value)) m_MoveToPosition = value; } } // 0xA0 (160)
		
		protected Vec3 m_MoveToPositionSlopeFactor = new Vec3();
		[ContainerField(176), Homogeneous, LayoutImmutable, Blittable, ContainerFieldNameHash(3566386494)]
		public Vec3 MoveToPositionSlopeFactor { get { return m_MoveToPositionSlopeFactor; } set { if (OnPropertyChanging("VehicleCameraData." + nameof(MoveToPositionSlopeFactor), this, m_MoveToPositionSlopeFactor, value)) m_MoveToPositionSlopeFactor = value; } } // 0xB0 (176)
		
		protected Vec3 m_TargetOffset = new Vec3();
		[ContainerField(192), Homogeneous, LayoutImmutable, Blittable, ContainerFieldNameHash(1634518457)]
		public Vec3 TargetOffset { get { return m_TargetOffset; } set { if (OnPropertyChanging("VehicleCameraData." + nameof(TargetOffset), this, m_TargetOffset, value)) m_TargetOffset = value; } } // 0xC0 (192)
		
		protected Vec3 m_TargetOffsetSlopeFactor = new Vec3();
		[ContainerField(208), Homogeneous, LayoutImmutable, Blittable, ContainerFieldNameHash(2939212273)]
		public Vec3 TargetOffsetSlopeFactor { get { return m_TargetOffsetSlopeFactor; } set { if (OnPropertyChanging("VehicleCameraData." + nameof(TargetOffsetSlopeFactor), this, m_TargetOffsetSlopeFactor, value)) m_TargetOffsetSlopeFactor = value; } } // 0xD0 (208)
		
		protected Vec3 m_RotationFactor = new Vec3();
		[ContainerField(224), Homogeneous, LayoutImmutable, Blittable, ContainerFieldNameHash(1739032700)]
		public Vec3 RotationFactor { get { return m_RotationFactor; } set { if (OnPropertyChanging("VehicleCameraData." + nameof(RotationFactor), this, m_RotationFactor, value)) m_RotationFactor = value; } } // 0xE0 (224)
		
		protected float m_PositionFactor = new float();
		[ContainerField(240), LayoutImmutable, Blittable, ContainerFieldNameHash(3939849105)]
		public float PositionFactor { get { return m_PositionFactor; } set { if (OnPropertyChanging("VehicleCameraData." + nameof(PositionFactor), this, m_PositionFactor, value)) m_PositionFactor = value; } } // 0xF0 (240)
		
		protected float m_ResetDistance = new float();
		[ContainerField(244), LayoutImmutable, Blittable, ContainerFieldNameHash(601574707)]
		public float ResetDistance { get { return m_ResetDistance; } set { if (OnPropertyChanging("VehicleCameraData." + nameof(ResetDistance), this, m_ResetDistance, value)) m_ResetDistance = value; } } // 0xF4 (244)
		
		protected bool m_FixedPosition = new bool();
		[ContainerField(248), LayoutImmutable, Blittable, ContainerFieldNameHash(2172041354)]
		public bool FixedPosition { get { return m_FixedPosition; } set { if (OnPropertyChanging("VehicleCameraData." + nameof(FixedPosition), this, m_FixedPosition, value)) m_FixedPosition = value; } } // 0xF8 (248)
		
		protected bool m_FixedAngleZ = new bool();
		[ContainerField(249), LayoutImmutable, Blittable, ContainerFieldNameHash(3991869768)]
		public bool FixedAngleZ { get { return m_FixedAngleZ; } set { if (OnPropertyChanging("VehicleCameraData." + nameof(FixedAngleZ), this, m_FixedAngleZ, value)) m_FixedAngleZ = value; } } // 0xF9 (249)
		
		protected bool m_UseTerrainAdjustment = new bool();
		[ContainerField(250), LayoutImmutable, Blittable, ContainerFieldNameHash(3333670366)]
		public bool UseTerrainAdjustment { get { return m_UseTerrainAdjustment; } set { if (OnPropertyChanging("VehicleCameraData." + nameof(UseTerrainAdjustment), this, m_UseTerrainAdjustment, value)) m_UseTerrainAdjustment = value; } } // 0xFA (250)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2255519254:
					MoveToPosition = (Vec3) p_Value;
					break;

				case 3566386494:
					MoveToPositionSlopeFactor = (Vec3) p_Value;
					break;

				case 1634518457:
					TargetOffset = (Vec3) p_Value;
					break;

				case 2939212273:
					TargetOffsetSlopeFactor = (Vec3) p_Value;
					break;

				case 1739032700:
					RotationFactor = (Vec3) p_Value;
					break;

				case 3939849105:
					PositionFactor = (float) p_Value;
					break;

				case 601574707:
					ResetDistance = (float) p_Value;
					break;

				case 2172041354:
					FixedPosition = (bool) p_Value;
					break;

				case 3991869768:
					FixedAngleZ = (bool) p_Value;
					break;

				case 3333670366:
					UseTerrainAdjustment = (bool) p_Value;
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
				case 2255519254:
					return MoveToPosition;

				case 3566386494:
					return MoveToPositionSlopeFactor;

				case 1634518457:
					return TargetOffset;

				case 2939212273:
					return TargetOffsetSlopeFactor;

				case 1739032700:
					return RotationFactor;

				case 3939849105:
					return PositionFactor;

				case 601574707:
					return ResetDistance;

				case 2172041354:
					return FixedPosition;

				case 3991869768:
					return FixedAngleZ;

				case 3333670366:
					return UseTerrainAdjustment;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2255519254:
					return typeof(VehicleCameraData).GetProperty(nameof(MoveToPosition));

				case 3566386494:
					return typeof(VehicleCameraData).GetProperty(nameof(MoveToPositionSlopeFactor));

				case 1634518457:
					return typeof(VehicleCameraData).GetProperty(nameof(TargetOffset));

				case 2939212273:
					return typeof(VehicleCameraData).GetProperty(nameof(TargetOffsetSlopeFactor));

				case 1739032700:
					return typeof(VehicleCameraData).GetProperty(nameof(RotationFactor));

				case 3939849105:
					return typeof(VehicleCameraData).GetProperty(nameof(PositionFactor));

				case 601574707:
					return typeof(VehicleCameraData).GetProperty(nameof(ResetDistance));

				case 2172041354:
					return typeof(VehicleCameraData).GetProperty(nameof(FixedPosition));

				case 3991869768:
					return typeof(VehicleCameraData).GetProperty(nameof(FixedAngleZ));

				case 3333670366:
					return typeof(VehicleCameraData).GetProperty(nameof(UseTerrainAdjustment));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
