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
using RimeLib.Frostbite.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 4,  Flags: 53, Size: 28)]
	public class StatsCategoryVehicleData : 
		StatsCategoryGuidData
	{
		protected uint m_FirstVehicleId = new uint();
		[ContainerField(Name: "FirstVehicleId", Offset: 24, NameHash: 4200609226, Flags: 49421), LayoutImmutable, Blittable]
		public uint FirstVehicleId { get { return m_FirstVehicleId; } set { if (OnPropertyChanging("StatsCategoryVehicleData." + nameof(FirstVehicleId), this, m_FirstVehicleId, value)) m_FirstVehicleId = value; } } // 0x18 (24)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 4200609226:
					FirstVehicleId = (uint) p_Value;
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
				case 4200609226:
					return FirstVehicleId;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 4200609226:
					return typeof(StatsCategoryVehicleData).GetProperty(nameof(FirstVehicleId));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
