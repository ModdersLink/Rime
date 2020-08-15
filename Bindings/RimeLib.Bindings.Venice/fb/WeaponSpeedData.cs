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
	[ContainerType(4)]
	public class WeaponSpeedData : 
		DataContainer
	{
		protected float m_ZoomOutSpeed = new float();
		[ContainerField(8), LayoutImmutable, Blittable, ContainerFieldNameHash(2275851931)]
		public float ZoomOutSpeed { get { return m_ZoomOutSpeed; } set { if (OnPropertyChanging("WeaponSpeedData." + nameof(ZoomOutSpeed), this, m_ZoomOutSpeed, value)) m_ZoomOutSpeed = value; } } // 0x8 (8)
		
		protected float m_ZoomInSpeed = new float();
		[ContainerField(12), LayoutImmutable, Blittable, ContainerFieldNameHash(638313682)]
		public float ZoomInSpeed { get { return m_ZoomInSpeed; } set { if (OnPropertyChanging("WeaponSpeedData." + nameof(ZoomInSpeed), this, m_ZoomInSpeed, value)) m_ZoomInSpeed = value; } } // 0xC (12)
		
		protected float m_UnDeploySpeed = new float();
		[ContainerField(16), LayoutImmutable, Blittable, ContainerFieldNameHash(3170443666)]
		public float UnDeploySpeed { get { return m_UnDeploySpeed; } set { if (OnPropertyChanging("WeaponSpeedData." + nameof(UnDeploySpeed), this, m_UnDeploySpeed, value)) m_UnDeploySpeed = value; } } // 0x10 (16)
		
		protected float m_DeploySpeed = new float();
		[ContainerField(20), LayoutImmutable, Blittable, ContainerFieldNameHash(2095054953)]
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
