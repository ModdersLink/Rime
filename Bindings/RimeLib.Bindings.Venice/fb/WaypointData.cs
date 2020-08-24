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
	[ContainerType(4), MemberInfoFlag(53), ContainerClass]
	public class WaypointData : 
		DataContainer
	{
		protected int m_SchematicsNameHash = new int();
		[ContainerField(8), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(2506236300)]
		public int SchematicsNameHash { get { return m_SchematicsNameHash; } set { if (OnPropertyChanging("WaypointData." + nameof(SchematicsNameHash), this, m_SchematicsNameHash, value)) m_SchematicsNameHash = value; } } // 0x8 (8)
		
		protected ushort m_WaypointId = new ushort();
		[ContainerField(12), LayoutImmutable, Blittable, MemberInfoFlag(49389), ContainerFieldNameHash(2435520331)]
		public ushort WaypointId { get { return m_WaypointId; } set { if (OnPropertyChanging("WaypointData." + nameof(WaypointId), this, m_WaypointId, value)) m_WaypointId = value; } } // 0xC (12)
		
		protected bool m_UseClientsPosition = new bool();
		[ContainerField(14), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2175538773)]
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
