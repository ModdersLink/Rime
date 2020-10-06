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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(36), ContainerClass]
	public class VehicleDeployWeaponData : 
		WeaponData
	{
		protected float m_DeployAreaRadius = new float();
		[ContainerField(16), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2315269409)]
		public float DeployAreaRadius { get { return m_DeployAreaRadius; } set { if (OnPropertyChanging("VehicleDeployWeaponData." + nameof(DeployAreaRadius), this, m_DeployAreaRadius, value)) m_DeployAreaRadius = value; } } // 0x10 (16)
		
		protected CtrRef<ObjectBlueprint> m_PreviewObject = new CtrRef<ObjectBlueprint>();
		[ContainerField(20), MemberInfoFlag(53), ContainerFieldNameHash(3777498618), ContainerCtrRef]
		public CtrRef<ObjectBlueprint> PreviewObject { get { return m_PreviewObject; } set { if (OnPropertyChanging("VehicleDeployWeaponData." + nameof(PreviewObject), this, m_PreviewObject, value)) m_PreviewObject = value; } } // 0x14 (20)
		
		protected float m_DeployAreaGroundRayLength = new float();
		[ContainerField(24), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2525261002)]
		public float DeployAreaGroundRayLength { get { return m_DeployAreaGroundRayLength; } set { if (OnPropertyChanging("VehicleDeployWeaponData." + nameof(DeployAreaGroundRayLength), this, m_DeployAreaGroundRayLength, value)) m_DeployAreaGroundRayLength = value; } } // 0x18 (24)
		
		protected float m_DeployAreaGroundFlatness = new float();
		[ContainerField(28), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3327549992)]
		public float DeployAreaGroundFlatness { get { return m_DeployAreaGroundFlatness; } set { if (OnPropertyChanging("VehicleDeployWeaponData." + nameof(DeployAreaGroundFlatness), this, m_DeployAreaGroundFlatness, value)) m_DeployAreaGroundFlatness = value; } } // 0x1C (28)
		
		protected bool m_UsePreview = new bool();
		[ContainerField(32), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(372592876)]
		public bool UsePreview { get { return m_UsePreview; } set { if (OnPropertyChanging("VehicleDeployWeaponData." + nameof(UsePreview), this, m_UsePreview, value)) m_UsePreview = value; } } // 0x20 (32)
		
		protected bool m_CheckClearSky = new bool();
		[ContainerField(33), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1368247419)]
		public bool CheckClearSky { get { return m_CheckClearSky; } set { if (OnPropertyChanging("VehicleDeployWeaponData." + nameof(CheckClearSky), this, m_CheckClearSky, value)) m_CheckClearSky = value; } } // 0x21 (33)
		
		protected bool m_CanRemoteEnterVehicle = new bool();
		[ContainerField(34), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(553624253)]
		public bool CanRemoteEnterVehicle { get { return m_CanRemoteEnterVehicle; } set { if (OnPropertyChanging("VehicleDeployWeaponData." + nameof(CanRemoteEnterVehicle), this, m_CanRemoteEnterVehicle, value)) m_CanRemoteEnterVehicle = value; } } // 0x22 (34)
		
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
