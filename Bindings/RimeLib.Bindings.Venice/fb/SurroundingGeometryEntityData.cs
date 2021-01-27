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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 112)]
	public class SurroundingGeometryEntityData : 
		GameEntityData
	{
		protected CtrRef<AllowedVehiclesData> m_AllowedVehicleList = new CtrRef<AllowedVehiclesData>();
		[ContainerField(Name: "AllowedVehicleList", Offset: 96, NameHash: 880039879, Flags: 53)]
		public CtrRef<AllowedVehiclesData> AllowedVehicleList { get { return m_AllowedVehicleList; } set { if (OnPropertyChanging("SurroundingGeometryEntityData." + nameof(AllowedVehicleList), this, m_AllowedVehicleList, value)) m_AllowedVehicleList = value; } } // 0x60 (96)
		
		protected CtrRef<CombatAreaTriggerEntityData> m_CombatArea = new CtrRef<CombatAreaTriggerEntityData>();
		[ContainerField(Name: "CombatArea", Offset: 100, NameHash: 3144394660, Flags: 53)]
		public CtrRef<CombatAreaTriggerEntityData> CombatArea { get { return m_CombatArea; } set { if (OnPropertyChanging("SurroundingGeometryEntityData." + nameof(CombatArea), this, m_CombatArea, value)) m_CombatArea = value; } } // 0x64 (100)
		
		protected uint m_CombatAreaIndex = new uint();
		[ContainerField(Name: "CombatAreaIndex", Offset: 104, NameHash: 2813446234, Flags: 49421), LayoutImmutable, Blittable]
		public uint CombatAreaIndex { get { return m_CombatAreaIndex; } set { if (OnPropertyChanging("SurroundingGeometryEntityData." + nameof(CombatAreaIndex), this, m_CombatAreaIndex, value)) m_CombatAreaIndex = value; } } // 0x68 (104)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 880039879:
					AllowedVehicleList = (CtrRef<AllowedVehiclesData>) p_Value;
					break;

				case 3144394660:
					CombatArea = (CtrRef<CombatAreaTriggerEntityData>) p_Value;
					break;

				case 2813446234:
					CombatAreaIndex = (uint) p_Value;
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
				case 880039879:
					return AllowedVehicleList;

				case 3144394660:
					return CombatArea;

				case 2813446234:
					return CombatAreaIndex;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 880039879:
					return typeof(SurroundingGeometryEntityData).GetProperty(nameof(AllowedVehicleList));

				case 3144394660:
					return typeof(SurroundingGeometryEntityData).GetProperty(nameof(CombatArea));

				case 2813446234:
					return typeof(SurroundingGeometryEntityData).GetProperty(nameof(CombatAreaIndex));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
