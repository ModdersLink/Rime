///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class VehicleDeployWeaponData : 
		WeaponData
	{
		[ContainerField(16), LayoutImmutable, Blittable]
		public float DeployAreaRadius { get; set; } // 0x10 (16)
		
		[ContainerField(20)]
		public CtrRef<ObjectBlueprint> PreviewObject { get; set; } = new CtrRef<ObjectBlueprint>(); // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public float DeployAreaGroundRayLength { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public float DeployAreaGroundFlatness { get; set; } // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public bool UsePreview { get; set; } // 0x20 (32)
		
		[ContainerField(33), LayoutImmutable, Blittable]
		public bool CheckClearSky { get; set; } // 0x21 (33)
		
		[ContainerField(34), LayoutImmutable, Blittable]
		public bool CanRemoteEnterVehicle { get; set; } // 0x22 (34)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2315269409:
					DeployAreaRadius = (float) p_Value;
					break;

				case 3777498618:
					PreviewObject = (CtrRef<ObjectBlueprint>) p_Value;
					break;

				case 2525261002:
					DeployAreaGroundRayLength = (float) p_Value;
					break;

				case 3327549992:
					DeployAreaGroundFlatness = (float) p_Value;
					break;

				case 372592876:
					UsePreview = (bool) p_Value;
					break;

				case 1368247419:
					CheckClearSky = (bool) p_Value;
					break;

				case 553624253:
					CanRemoteEnterVehicle = (bool) p_Value;
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
				case 2315269409:
					return DeployAreaRadius;

				case 3777498618:
					return PreviewObject;

				case 2525261002:
					return DeployAreaGroundRayLength;

				case 3327549992:
					return DeployAreaGroundFlatness;

				case 372592876:
					return UsePreview;

				case 1368247419:
					return CheckClearSky;

				case 553624253:
					return CanRemoteEnterVehicle;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2315269409:
					return typeof(VehicleDeployWeaponData).GetProperty(nameof(DeployAreaRadius));

				case 3777498618:
					return typeof(VehicleDeployWeaponData).GetProperty(nameof(PreviewObject));

				case 2525261002:
					return typeof(VehicleDeployWeaponData).GetProperty(nameof(DeployAreaGroundRayLength));

				case 3327549992:
					return typeof(VehicleDeployWeaponData).GetProperty(nameof(DeployAreaGroundFlatness));

				case 372592876:
					return typeof(VehicleDeployWeaponData).GetProperty(nameof(UsePreview));

				case 1368247419:
					return typeof(VehicleDeployWeaponData).GetProperty(nameof(CheckClearSky));

				case 553624253:
					return typeof(VehicleDeployWeaponData).GetProperty(nameof(CanRemoteEnterVehicle));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
