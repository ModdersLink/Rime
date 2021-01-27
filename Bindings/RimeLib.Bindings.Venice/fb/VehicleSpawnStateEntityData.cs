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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 64)]
	public class VehicleSpawnStateEntityData : 
		EntityData
	{
		protected Vec3 m_InitialVelocity = new Vec3();
		[ContainerField(Name: "InitialVelocity", Offset: 16, NameHash: 3508499596, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 InitialVelocity { get { return m_InitialVelocity; } set { if (OnPropertyChanging("VehicleSpawnStateEntityData." + nameof(InitialVelocity), this, m_InitialVelocity, value)) m_InitialVelocity = value; } } // 0x10 (16)
		
		protected float m_StartupDelayModifier = new float();
		[ContainerField(Name: "StartupDelayModifier", Offset: 32, NameHash: 3073501154, Flags: 49469), LayoutImmutable, Blittable]
		public float StartupDelayModifier { get { return m_StartupDelayModifier; } set { if (OnPropertyChanging("VehicleSpawnStateEntityData." + nameof(StartupDelayModifier), this, m_StartupDelayModifier, value)) m_StartupDelayModifier = value; } } // 0x20 (32)
		
		protected float m_InitialThrottle = new float();
		[ContainerField(Name: "InitialThrottle", Offset: 36, NameHash: 3556007987, Flags: 49469), LayoutImmutable, Blittable]
		public float InitialThrottle { get { return m_InitialThrottle; } set { if (OnPropertyChanging("VehicleSpawnStateEntityData." + nameof(InitialThrottle), this, m_InitialThrottle, value)) m_InitialThrottle = value; } } // 0x24 (36)
		
		protected uint m_EngineIndex = new uint();
		[ContainerField(Name: "EngineIndex", Offset: 40, NameHash: 1485813685, Flags: 49421), LayoutImmutable, Blittable]
		public uint EngineIndex { get { return m_EngineIndex; } set { if (OnPropertyChanging("VehicleSpawnStateEntityData." + nameof(EngineIndex), this, m_EngineIndex, value)) m_EngineIndex = value; } } // 0x28 (40)
		
		protected float m_InitialRpmModifier = new float();
		[ContainerField(Name: "InitialRpmModifier", Offset: 44, NameHash: 304191363, Flags: 49469), LayoutImmutable, Blittable]
		public float InitialRpmModifier { get { return m_InitialRpmModifier; } set { if (OnPropertyChanging("VehicleSpawnStateEntityData." + nameof(InitialRpmModifier), this, m_InitialRpmModifier, value)) m_InitialRpmModifier = value; } } // 0x2C (44)
		
		protected float m_HeightOffset = new float();
		[ContainerField(Name: "HeightOffset", Offset: 48, NameHash: 1929779127, Flags: 49469), LayoutImmutable, Blittable]
		public float HeightOffset { get { return m_HeightOffset; } set { if (OnPropertyChanging("VehicleSpawnStateEntityData." + nameof(HeightOffset), this, m_HeightOffset, value)) m_HeightOffset = value; } } // 0x30 (48)
		
		protected float m_Radius = new float();
		[ContainerField(Name: "Radius", Offset: 52, NameHash: 3298407133, Flags: 49469), LayoutImmutable, Blittable]
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
