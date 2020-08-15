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
	public class VehicleExitPointComponentData : 
		ComponentData
	{
		protected Vec3 m_Impulse = new Vec3();
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable, ContainerFieldNameHash(1723395486)]
		public Vec3 Impulse { get { return m_Impulse; } set { if (OnPropertyChanging("VehicleExitPointComponentData." + nameof(Impulse), this, m_Impulse, value)) m_Impulse = value; } } // 0x60 (96)
		
		protected float m_TerrainHeight = new float();
		[ContainerField(112), LayoutImmutable, Blittable, ContainerFieldNameHash(3163704045)]
		public float TerrainHeight { get { return m_TerrainHeight; } set { if (OnPropertyChanging("VehicleExitPointComponentData." + nameof(TerrainHeight), this, m_TerrainHeight, value)) m_TerrainHeight = value; } } // 0x70 (112)
		
		protected int m_Ordinal = new int();
		[ContainerField(116), LayoutImmutable, Blittable, ContainerFieldNameHash(747685430)]
		public int Ordinal { get { return m_Ordinal; } set { if (OnPropertyChanging("VehicleExitPointComponentData." + nameof(Ordinal), this, m_Ordinal, value)) m_Ordinal = value; } } // 0x74 (116)
		
		protected float m_Velocity = new float();
		[ContainerField(120), LayoutImmutable, Blittable, ContainerFieldNameHash(3860766482)]
		public float Velocity { get { return m_Velocity; } set { if (OnPropertyChanging("VehicleExitPointComponentData." + nameof(Velocity), this, m_Velocity, value)) m_Velocity = value; } } // 0x78 (120)
		
		protected bool m_InheritCameraDirection = new bool();
		[ContainerField(124), LayoutImmutable, Blittable, ContainerFieldNameHash(1304457244)]
		public bool InheritCameraDirection { get { return m_InheritCameraDirection; } set { if (OnPropertyChanging("VehicleExitPointComponentData." + nameof(InheritCameraDirection), this, m_InheritCameraDirection, value)) m_InheritCameraDirection = value; } } // 0x7C (124)
		
		protected bool m_CheckForVehicleOverrun = new bool();
		[ContainerField(125), LayoutImmutable, Blittable, ContainerFieldNameHash(587298343)]
		public bool CheckForVehicleOverrun { get { return m_CheckForVehicleOverrun; } set { if (OnPropertyChanging("VehicleExitPointComponentData." + nameof(CheckForVehicleOverrun), this, m_CheckForVehicleOverrun, value)) m_CheckForVehicleOverrun = value; } } // 0x7D (125)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1723395486:
					Impulse = (Vec3) p_Value;
					break;

				case 3163704045:
					TerrainHeight = (float) p_Value;
					break;

				case 747685430:
					Ordinal = (int) p_Value;
					break;

				case 3860766482:
					Velocity = (float) p_Value;
					break;

				case 1304457244:
					InheritCameraDirection = (bool) p_Value;
					break;

				case 587298343:
					CheckForVehicleOverrun = (bool) p_Value;
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
				case 1723395486:
					return Impulse;

				case 3163704045:
					return TerrainHeight;

				case 747685430:
					return Ordinal;

				case 3860766482:
					return Velocity;

				case 1304457244:
					return InheritCameraDirection;

				case 587298343:
					return CheckForVehicleOverrun;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1723395486:
					return typeof(VehicleExitPointComponentData).GetProperty(nameof(Impulse));

				case 3163704045:
					return typeof(VehicleExitPointComponentData).GetProperty(nameof(TerrainHeight));

				case 747685430:
					return typeof(VehicleExitPointComponentData).GetProperty(nameof(Ordinal));

				case 3860766482:
					return typeof(VehicleExitPointComponentData).GetProperty(nameof(Velocity));

				case 1304457244:
					return typeof(VehicleExitPointComponentData).GetProperty(nameof(InheritCameraDirection));

				case 587298343:
					return typeof(VehicleExitPointComponentData).GetProperty(nameof(CheckForVehicleOverrun));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
