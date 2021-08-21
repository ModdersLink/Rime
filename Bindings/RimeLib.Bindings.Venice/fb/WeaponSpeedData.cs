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
using RimeLib.Frostbite.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 4,  Flags: 53, Size: 24)]
	public class WeaponSpeedData : 
		DataContainer
	{
		protected float m_ZoomOutSpeed = new float();
		[ContainerField(Name: "ZoomOutSpeed", Offset: 8, NameHash: 2275851931, Flags: 49469), LayoutImmutable, Blittable]
		public float ZoomOutSpeed { get { return m_ZoomOutSpeed; } set { if (OnPropertyChanging("WeaponSpeedData." + nameof(ZoomOutSpeed), this, m_ZoomOutSpeed, value)) m_ZoomOutSpeed = value; } } // 0x8 (8)
		
		protected float m_ZoomInSpeed = new float();
		[ContainerField(Name: "ZoomInSpeed", Offset: 12, NameHash: 638313682, Flags: 49469), LayoutImmutable, Blittable]
		public float ZoomInSpeed { get { return m_ZoomInSpeed; } set { if (OnPropertyChanging("WeaponSpeedData." + nameof(ZoomInSpeed), this, m_ZoomInSpeed, value)) m_ZoomInSpeed = value; } } // 0xC (12)
		
		protected float m_UnDeploySpeed = new float();
		[ContainerField(Name: "UnDeploySpeed", Offset: 16, NameHash: 3170443666, Flags: 49469), LayoutImmutable, Blittable]
		public float UnDeploySpeed { get { return m_UnDeploySpeed; } set { if (OnPropertyChanging("WeaponSpeedData." + nameof(UnDeploySpeed), this, m_UnDeploySpeed, value)) m_UnDeploySpeed = value; } } // 0x10 (16)
		
		protected float m_DeploySpeed = new float();
		[ContainerField(Name: "DeploySpeed", Offset: 20, NameHash: 2095054953, Flags: 49469), LayoutImmutable, Blittable]
		public float DeploySpeed { get { return m_DeploySpeed; } set { if (OnPropertyChanging("WeaponSpeedData." + nameof(DeploySpeed), this, m_DeploySpeed, value)) m_DeploySpeed = value; } } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2275851931:
					ZoomOutSpeed = (float) p_Value;
					break;

				case 638313682:
					ZoomInSpeed = (float) p_Value;
					break;

				case 3170443666:
					UnDeploySpeed = (float) p_Value;
					break;

				case 2095054953:
					DeploySpeed = (float) p_Value;
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
				case 2275851931:
					return ZoomOutSpeed;

				case 638313682:
					return ZoomInSpeed;

				case 3170443666:
					return UnDeploySpeed;

				case 2095054953:
					return DeploySpeed;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2275851931:
					return typeof(WeaponSpeedData).GetProperty(nameof(ZoomOutSpeed));

				case 638313682:
					return typeof(WeaponSpeedData).GetProperty(nameof(ZoomInSpeed));

				case 3170443666:
					return typeof(WeaponSpeedData).GetProperty(nameof(UnDeploySpeed));

				case 2095054953:
					return typeof(WeaponSpeedData).GetProperty(nameof(DeploySpeed));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
