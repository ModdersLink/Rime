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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 16)]
	public class WaypointData : 
		DataContainer
	{
		protected int m_SchematicsNameHash = new int();
		[ContainerField(Name: "SchematicsNameHash", Offset: 8, NameHash: 2506236300, Flags: 49405), LayoutImmutable, Blittable]
		public int SchematicsNameHash { get { return m_SchematicsNameHash; } set { if (OnPropertyChanging("WaypointData." + nameof(SchematicsNameHash), this, m_SchematicsNameHash, value)) m_SchematicsNameHash = value; } } // 0x8 (8)
		
		protected ushort m_WaypointId = new ushort();
		[ContainerField(Name: "WaypointId", Offset: 12, NameHash: 2435520331, Flags: 49389), LayoutImmutable, Blittable]
		public ushort WaypointId { get { return m_WaypointId; } set { if (OnPropertyChanging("WaypointData." + nameof(WaypointId), this, m_WaypointId, value)) m_WaypointId = value; } } // 0xC (12)
		
		protected bool m_UseClientsPosition = new bool();
		[ContainerField(Name: "UseClientsPosition", Offset: 14, NameHash: 2175538773, Flags: 49325), LayoutImmutable, Blittable]
		public bool UseClientsPosition { get { return m_UseClientsPosition; } set { if (OnPropertyChanging("WaypointData." + nameof(UseClientsPosition), this, m_UseClientsPosition, value)) m_UseClientsPosition = value; } } // 0xE (14)
		
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
