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
	[ContainerType(4)]
	public class StatsCategoryPlayerRoleData : 
		StatsCategoryBaseData
	{
		protected List<PlayerRole> m_Roles = new List<PlayerRole>();
		[ContainerField(20), ContainerFieldNameHash(230312994)]
		public List<PlayerRole> Roles { get { return m_Roles; } set { if (OnPropertyChanging("StatsCategoryPlayerRoleData." + nameof(Roles), this, m_Roles, value)) m_Roles = value; } } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 230312994:
					if (p_Value.GetType() == typeof (List<uint>))
						Roles = ((List<uint>) p_Value).Select(x => (PlayerRole) Enum.ToObject(typeof(PlayerRole), x)).ToList();
					else
						Roles = (List<PlayerRole>) p_Value;
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
				case 230312994:
					return Roles;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 230312994:
					return typeof(StatsCategoryPlayerRoleData).GetProperty(nameof(Roles));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
