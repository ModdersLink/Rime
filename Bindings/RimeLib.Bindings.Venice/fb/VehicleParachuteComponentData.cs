///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class VehicleParachuteComponentData : 
		ComponentData
	{
		[ContainerField(96)]
		public VehicleParachuteBinding Binding { get; set; } = new VehicleParachuteBinding(); // 0x60 (96)
		
		[ContainerField(104), LayoutImmutable, Blittable]
		public float UndeployTime { get; set; } // 0x68 (104)
		
		[ContainerField(108), LayoutImmutable, Blittable]
		public float TimeInvisibleAfterSpawn { get; set; } // 0x6C (108)
		
		[ContainerField(112), LayoutImmutable, Blittable]
		public int VehicleType { get; set; } // 0x70 (112)
		
		[ContainerField(116), LayoutImmutable, Blittable]
		public bool DropParachuteOnUndeploy { get; set; } // 0x74 (116)
		
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
