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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(24), ContainerClass]
	public class StatsCategoryVehicleStateTypeData : 
		StatsCategoryBaseData
	{
		protected List<VehicleStateType> m_States = new List<VehicleStateType>();
		[ContainerField(20), MemberInfoFlag(65), ContainerFieldNameHash(3319729985), ContainerArray]
		public List<VehicleStateType> States { get { return m_States; } set { if (OnPropertyChanging("StatsCategoryVehicleStateTypeData." + nameof(States), this, m_States, value)) m_States = value; } } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3319729985:
					if (p_Value.GetType() == typeof (List<uint>))
						States = ((List<uint>) p_Value).Select(x => (VehicleStateType) Enum.ToObject(typeof(VehicleStateType), x)).ToList();
					else
						States = (List<VehicleStateType>) p_Value;
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
				case 3319729985:
					return States;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3319729985:
					return typeof(StatsCategoryVehicleStateTypeData).GetProperty(nameof(States));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
