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
	public class VehicleParachuteComponentData : 
		ComponentData
	{
		protected VehicleParachuteBinding m_Binding = new VehicleParachuteBinding();
		[ContainerField(96), ContainerFieldNameHash(2590060228)]
		public VehicleParachuteBinding Binding { get { return m_Binding; } set { if (OnPropertyChanging("VehicleParachuteComponentData." + nameof(Binding), this, m_Binding, value)) m_Binding = value; } } // 0x60 (96)
		
		protected float m_UndeployTime = new float();
		[ContainerField(104), LayoutImmutable, Blittable, ContainerFieldNameHash(1689758176)]
		public float UndeployTime { get { return m_UndeployTime; } set { if (OnPropertyChanging("VehicleParachuteComponentData." + nameof(UndeployTime), this, m_UndeployTime, value)) m_UndeployTime = value; } } // 0x68 (104)
		
		protected float m_TimeInvisibleAfterSpawn = new float();
		[ContainerField(108), LayoutImmutable, Blittable, ContainerFieldNameHash(3698203718)]
		public float TimeInvisibleAfterSpawn { get { return m_TimeInvisibleAfterSpawn; } set { if (OnPropertyChanging("VehicleParachuteComponentData." + nameof(TimeInvisibleAfterSpawn), this, m_TimeInvisibleAfterSpawn, value)) m_TimeInvisibleAfterSpawn = value; } } // 0x6C (108)
		
		protected int m_VehicleType = new int();
		[ContainerField(112), LayoutImmutable, Blittable, ContainerFieldNameHash(925900165)]
		public int VehicleType { get { return m_VehicleType; } set { if (OnPropertyChanging("VehicleParachuteComponentData." + nameof(VehicleType), this, m_VehicleType, value)) m_VehicleType = value; } } // 0x70 (112)
		
		protected bool m_DropParachuteOnUndeploy = new bool();
		[ContainerField(116), LayoutImmutable, Blittable, ContainerFieldNameHash(2075959536)]
		public bool DropParachuteOnUndeploy { get { return m_DropParachuteOnUndeploy; } set { if (OnPropertyChanging("VehicleParachuteComponentData." + nameof(DropParachuteOnUndeploy), this, m_DropParachuteOnUndeploy, value)) m_DropParachuteOnUndeploy = value; } } // 0x74 (116)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2590060228:
					Binding = (VehicleParachuteBinding) p_Value;
					break;

				case 1689758176:
					UndeployTime = (float) p_Value;
					break;

				case 3698203718:
					TimeInvisibleAfterSpawn = (float) p_Value;
					break;

				case 925900165:
					VehicleType = (int) p_Value;
					break;

				case 2075959536:
					DropParachuteOnUndeploy = (bool) p_Value;
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
				case 2590060228:
					return Binding;

				case 1689758176:
					return UndeployTime;

				case 3698203718:
					return TimeInvisibleAfterSpawn;

				case 925900165:
					return VehicleType;

				case 2075959536:
					return DropParachuteOnUndeploy;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2590060228:
					return typeof(VehicleParachuteComponentData).GetProperty(nameof(Binding));

				case 1689758176:
					return typeof(VehicleParachuteComponentData).GetProperty(nameof(UndeployTime));

				case 3698203718:
					return typeof(VehicleParachuteComponentData).GetProperty(nameof(TimeInvisibleAfterSpawn));

				case 925900165:
					return typeof(VehicleParachuteComponentData).GetProperty(nameof(VehicleType));

				case 2075959536:
					return typeof(VehicleParachuteComponentData).GetProperty(nameof(DropParachuteOnUndeploy));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
