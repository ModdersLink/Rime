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
	public class VehicleCameraData : 
		TargetCameraData
	{
		[ContainerField(160), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 MoveToPosition { get; set; } = new Vec3(); // 0xA0 (160)
		
		[ContainerField(176), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 MoveToPositionSlopeFactor { get; set; } = new Vec3(); // 0xB0 (176)
		
		[ContainerField(192), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 TargetOffset { get; set; } = new Vec3(); // 0xC0 (192)
		
		[ContainerField(208), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 TargetOffsetSlopeFactor { get; set; } = new Vec3(); // 0xD0 (208)
		
		[ContainerField(224), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 RotationFactor { get; set; } = new Vec3(); // 0xE0 (224)
		
		[ContainerField(240), LayoutImmutable, Blittable]
		public float PositionFactor { get; set; } // 0xF0 (240)
		
		[ContainerField(244), LayoutImmutable, Blittable]
		public float ResetDistance { get; set; } // 0xF4 (244)
		
		[ContainerField(248), LayoutImmutable, Blittable]
		public bool FixedPosition { get; set; } // 0xF8 (248)
		
		[ContainerField(249), LayoutImmutable, Blittable]
		public bool FixedAngleZ { get; set; } // 0xF9 (249)
		
		[ContainerField(250), LayoutImmutable, Blittable]
		public bool UseTerrainAdjustment { get; set; } // 0xFA (250)
		
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
