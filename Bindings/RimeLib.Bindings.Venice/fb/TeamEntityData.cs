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
	[ContainerType(16)]
	public class TeamEntityData : 
		GameEntityData
	{
		protected CtrRef<TeamData> m_Team = new CtrRef<TeamData>();
		[ContainerField(96), ContainerFieldNameHash(2089309528)]
		public CtrRef<TeamData> Team { get { return m_Team; } set { if (OnPropertyChanging("TeamEntityData." + nameof(Team), this, m_Team, value)) m_Team = value; } } // 0x60 (96)
		
		protected TeamId m_Id = new TeamId();
		[ContainerField(100), ContainerFieldNameHash(5862152)]
		public TeamId Id { get { return m_Id; } set { if (OnPropertyChanging("TeamEntityData." + nameof(Id), this, m_Id, value)) m_Id = value; } } // 0x64 (100)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2089309528:
					Team = (CtrRef<TeamData>) p_Value;
					break;

				case 5862152:
					Id = (TeamId) Enum.ToObject(typeof(TeamId), p_Value);
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
				case 2089309528:
					return Team;

				case 5862152:
					return Id;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2089309528:
					return typeof(TeamEntityData).GetProperty(nameof(Team));

				case 5862152:
					return typeof(TeamEntityData).GetProperty(nameof(Id));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
