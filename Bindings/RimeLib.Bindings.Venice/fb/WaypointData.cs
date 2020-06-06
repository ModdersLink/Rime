///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class WaypointData : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public int SchematicsNameHash { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public ushort WaypointId { get; set; } // 0xC (12)
		
		[ContainerField(14), LayoutImmutable, Blittable]
		public bool UseClientsPosition { get; set; } // 0xE (14)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2506236300:
					SchematicsNameHash = (int) p_Value;
					break;

				case 2435520331:
					WaypointId = (ushort) p_Value;
					break;

				case 2175538773:
					UseClientsPosition = (bool) p_Value;
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
				case 2506236300:
					return SchematicsNameHash;

				case 2435520331:
					return WaypointId;

				case 2175538773:
					return UseClientsPosition;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2506236300:
					return typeof(WaypointData).GetProperty(nameof(SchematicsNameHash));

				case 2435520331:
					return typeof(WaypointData).GetProperty(nameof(WaypointId));

				case 2175538773:
					return typeof(WaypointData).GetProperty(nameof(UseClientsPosition));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
