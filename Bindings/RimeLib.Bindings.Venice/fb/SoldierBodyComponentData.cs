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
	public class SoldierBodyComponentData : 
		ComponentData
	{
		protected float m_SprintMultiplier = new float();
		[ContainerField(96), LayoutImmutable, Blittable, ContainerFieldNameHash(4088490892)]
		public float SprintMultiplier { get { return m_SprintMultiplier; } set { if (OnPropertyChanging("SoldierBodyComponentData." + nameof(SprintMultiplier), this, m_SprintMultiplier, value)) m_SprintMultiplier = value; } } // 0x60 (96)
		
		protected float m_OverrideGravityValue = new float();
		[ContainerField(100), LayoutImmutable, Blittable, ContainerFieldNameHash(1923054204)]
		public float OverrideGravityValue { get { return m_OverrideGravityValue; } set { if (OnPropertyChanging("SoldierBodyComponentData." + nameof(OverrideGravityValue), this, m_OverrideGravityValue, value)) m_OverrideGravityValue = value; } } // 0x64 (100)
		
		protected float m_OverrideVelocityY = new float();
		[ContainerField(104), LayoutImmutable, Blittable, ContainerFieldNameHash(3664501567)]
		public float OverrideVelocityY { get { return m_OverrideVelocityY; } set { if (OnPropertyChanging("SoldierBodyComponentData." + nameof(OverrideVelocityY), this, m_OverrideVelocityY, value)) m_OverrideVelocityY = value; } } // 0x68 (104)
		
		protected bool m_OverrideVelocity = new bool();
		[ContainerField(108), LayoutImmutable, Blittable, ContainerFieldNameHash(3104507558)]
		public bool OverrideVelocity { get { return m_OverrideVelocity; } set { if (OnPropertyChanging("SoldierBodyComponentData." + nameof(OverrideVelocity), this, m_OverrideVelocity, value)) m_OverrideVelocity = value; } } // 0x6C (108)
		
		protected bool m_OverrideGravity = new bool();
		[ContainerField(109), LayoutImmutable, Blittable, ContainerFieldNameHash(2610853335)]
		public bool OverrideGravity { get { return m_OverrideGravity; } set { if (OnPropertyChanging("SoldierBodyComponentData." + nameof(OverrideGravity), this, m_OverrideGravity, value)) m_OverrideGravity = value; } } // 0x6D (109)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 4088490892:
					SprintMultiplier = (float) p_Value;
					break;

				case 1923054204:
					OverrideGravityValue = (float) p_Value;
					break;

				case 3664501567:
					OverrideVelocityY = (float) p_Value;
					break;

				case 3104507558:
					OverrideVelocity = (bool) p_Value;
					break;

				case 2610853335:
					OverrideGravity = (bool) p_Value;
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
				case 4088490892:
					return SprintMultiplier;

				case 1923054204:
					return OverrideGravityValue;

				case 3664501567:
					return OverrideVelocityY;

				case 3104507558:
					return OverrideVelocity;

				case 2610853335:
					return OverrideGravity;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 4088490892:
					return typeof(SoldierBodyComponentData).GetProperty(nameof(SprintMultiplier));

				case 1923054204:
					return typeof(SoldierBodyComponentData).GetProperty(nameof(OverrideGravityValue));

				case 3664501567:
					return typeof(SoldierBodyComponentData).GetProperty(nameof(OverrideVelocityY));

				case 3104507558:
					return typeof(SoldierBodyComponentData).GetProperty(nameof(OverrideVelocity));

				case 2610853335:
					return typeof(SoldierBodyComponentData).GetProperty(nameof(OverrideGravity));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
