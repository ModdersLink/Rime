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
	[ContainerType(16), MemberInfoFlag(53), ContainerSize(128), ContainerClass]
	public class WheelComponentData : 
		PartComponentData
	{
		protected CtrRef<WheelConfigData> m_Config = new CtrRef<WheelConfigData>();
		[ContainerField(112), MemberInfoFlag(53), ContainerFieldNameHash(2713732399), ContainerCtrRef]
		public CtrRef<WheelConfigData> Config { get { return m_Config; } set { if (OnPropertyChanging("WheelComponentData." + nameof(Config), this, m_Config, value)) m_Config = value; } } // 0x70 (112)
		
		protected WheelPhysicsType m_PhysicsType = new WheelPhysicsType();
		[ContainerField(116), MemberInfoFlag(137), ContainerFieldNameHash(1744391446)]
		public WheelPhysicsType PhysicsType { get { return m_PhysicsType; } set { if (OnPropertyChanging("WheelComponentData." + nameof(PhysicsType), this, m_PhysicsType, value)) m_PhysicsType = value; } } // 0x74 (116)
		
		protected float m_EffectClampVelocity = new float();
		[ContainerField(120), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2869239062)]
		public float EffectClampVelocity { get { return m_EffectClampVelocity; } set { if (OnPropertyChanging("WheelComponentData." + nameof(EffectClampVelocity), this, m_EffectClampVelocity, value)) m_EffectClampVelocity = value; } } // 0x78 (120)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2713732399:
					Config = (CtrRef<WheelConfigData>) p_Value;
					break;

				case 1744391446:
					PhysicsType = (WheelPhysicsType) Enum.ToObject(typeof(WheelPhysicsType), p_Value);
					break;

				case 2869239062:
					EffectClampVelocity = (float) p_Value;
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
				case 2713732399:
					return Config;

				case 1744391446:
					return PhysicsType;

				case 2869239062:
					return EffectClampVelocity;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2713732399:
					return typeof(WheelComponentData).GetProperty(nameof(Config));

				case 1744391446:
					return typeof(WheelComponentData).GetProperty(nameof(PhysicsType));

				case 2869239062:
					return typeof(WheelComponentData).GetProperty(nameof(EffectClampVelocity));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
