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
	public class BFServerConfiguration : 
		DataContainer
	{
		protected List<BFServerConfigurationSchedule> m_Schedules = new List<BFServerConfigurationSchedule>();
		[ContainerField(8), MemberInfoFlag(65), ContainerFieldNameHash(813057715), ContainerArray]
		public List<BFServerConfigurationSchedule> Schedules { get { return m_Schedules; } set { if (OnPropertyChanging("BFServerConfiguration." + nameof(Schedules), this, m_Schedules, value)) m_Schedules = value; } } // 0x8 (8)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 813057715:
					Schedules = (List<BFServerConfigurationSchedule>) p_Value;
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
				case 813057715:
					return Schedules;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 813057715:
					return typeof(BFServerConfiguration).GetProperty(nameof(Schedules));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
