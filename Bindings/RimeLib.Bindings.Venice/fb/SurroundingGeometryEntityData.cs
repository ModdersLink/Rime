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
	public class SurroundingGeometryEntityData : 
		GameEntityData
	{
		[ContainerField(96)]
		public CtrRef<AllowedVehiclesData> AllowedVehicleList { get; set; } = new CtrRef<AllowedVehiclesData>(); // 0x60 (96)
		
		[ContainerField(100)]
		public CtrRef<CombatAreaTriggerEntityData> CombatArea { get; set; } = new CtrRef<CombatAreaTriggerEntityData>(); // 0x64 (100)
		
		[ContainerField(104), LayoutImmutable, Blittable]
		public uint CombatAreaIndex { get; set; } // 0x68 (104)
		
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
