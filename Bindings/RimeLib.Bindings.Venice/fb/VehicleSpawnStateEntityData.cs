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
	[ContainerType(16), MemberInfoFlag(53), ContainerClass]
	public class VehicleSpawnStateEntityData : 
		EntityData
	{
		protected Vec3 m_InitialVelocity = new Vec3();
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(3508499596)]
		public Vec3 InitialVelocity { get { return m_InitialVelocity; } set { if (OnPropertyChanging("VehicleSpawnStateEntityData." + nameof(InitialVelocity), this, m_InitialVelocity, value)) m_InitialVelocity = value; } } // 0x10 (16)
		
		protected float m_StartupDelayModifier = new float();
		[ContainerField(32), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3073501154)]
		public float StartupDelayModifier { get { return m_StartupDelayModifier; } set { if (OnPropertyChanging("VehicleSpawnStateEntityData." + nameof(StartupDelayModifier), this, m_StartupDelayModifier, value)) m_StartupDelayModifier = value; } } // 0x20 (32)
		
		protected float m_InitialThrottle = new float();
		[ContainerField(36), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3556007987)]
		public float InitialThrottle { get { return m_InitialThrottle; } set { if (OnPropertyChanging("VehicleSpawnStateEntityData." + nameof(InitialThrottle), this, m_InitialThrottle, value)) m_InitialThrottle = value; } } // 0x24 (36)
		
		protected uint m_EngineIndex = new uint();
		[ContainerField(40), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(1485813685)]
		public uint EngineIndex { get { return m_EngineIndex; } set { if (OnPropertyChanging("VehicleSpawnStateEntityData." + nameof(EngineIndex), this, m_EngineIndex, value)) m_EngineIndex = value; } } // 0x28 (40)
		
		protected float m_InitialRpmModifier = new float();
		[ContainerField(44), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(304191363)]
		public float InitialRpmModifier { get { return m_InitialRpmModifier; } set { if (OnPropertyChanging("VehicleSpawnStateEntityData." + nameof(InitialRpmModifier), this, m_InitialRpmModifier, value)) m_InitialRpmModifier = value; } } // 0x2C (44)
		
		protected float m_HeightOffset = new float();
		[ContainerField(48), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1929779127)]
		public float HeightOffset { get { return m_HeightOffset; } set { if (OnPropertyChanging("VehicleSpawnStateEntityData." + nameof(HeightOffset), this, m_HeightOffset, value)) m_HeightOffset = value; } } // 0x30 (48)
		
		protected float m_Radius = new float();
		[ContainerField(52), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3298407133)]
		public float Radius { get { return m_Radius; } set { if (OnPropertyChanging("VehicleSpawnStateEntityData." + nameof(Radius), this, m_Radius, value)) m_Radius = value; } } // 0x34 (52)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3508499596:
					InitialVelocity = (Vec3) p_Value;
					break;

				case 3073501154:
					StartupDelayModifier = (float) p_Value;
					break;

				case 3556007987:
					InitialThrottle = (float) p_Value;
					break;

				case 1485813685:
					EngineIndex = (uint) p_Value;
					break;

				case 304191363:
					InitialRpmModifier = (float) p_Value;
					break;

				case 1929779127:
					HeightOffset = (float) p_Value;
					break;

				case 3298407133:
					Radius = (float) p_Value;
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
				case 3508499596:
					return InitialVelocity;

				case 3073501154:
					return StartupDelayModifier;

				case 3556007987:
					return InitialThrottle;

				case 1485813685:
					return EngineIndex;

				case 304191363:
					return InitialRpmModifier;

				case 1929779127:
					return HeightOffset;

				case 3298407133:
					return Radius;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3508499596:
					return typeof(VehicleSpawnStateEntityData).GetProperty(nameof(InitialVelocity));

				case 3073501154:
					return typeof(VehicleSpawnStateEntityData).GetProperty(nameof(StartupDelayModifier));

				case 3556007987:
					return typeof(VehicleSpawnStateEntityData).GetProperty(nameof(InitialThrottle));

				case 1485813685:
					return typeof(VehicleSpawnStateEntityData).GetProperty(nameof(EngineIndex));

				case 304191363:
					return typeof(VehicleSpawnStateEntityData).GetProperty(nameof(InitialRpmModifier));

				case 1929779127:
					return typeof(VehicleSpawnStateEntityData).GetProperty(nameof(HeightOffset));

				case 3298407133:
					return typeof(VehicleSpawnStateEntityData).GetProperty(nameof(Radius));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
