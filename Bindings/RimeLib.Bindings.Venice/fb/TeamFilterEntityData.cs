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
	public class TeamFilterEntityData : 
		GameEntityData
	{
		protected Realm m_Realm = new Realm();
		[ContainerField(96), ContainerFieldNameHash(229961746)]
		public Realm Realm { get { return m_Realm; } set { if (OnPropertyChanging("TeamFilterEntityData." + nameof(Realm), this, m_Realm, value)) m_Realm = value; } } // 0x60 (96)
		
		protected TeamId m_Team = new TeamId();
		[ContainerField(100), ContainerFieldNameHash(2089309528)]
		public TeamId Team { get { return m_Team; } set { if (OnPropertyChanging("TeamFilterEntityData." + nameof(Team), this, m_Team, value)) m_Team = value; } } // 0x64 (100)
		
		protected bool m_InvertFilter = new bool();
		[ContainerField(104), LayoutImmutable, Blittable, ContainerFieldNameHash(2846947863)]
		public bool InvertFilter { get { return m_InvertFilter; } set { if (OnPropertyChanging("TeamFilterEntityData." + nameof(InvertFilter), this, m_InvertFilter, value)) m_InvertFilter = value; } } // 0x68 (104)
		
		protected bool m_GenerateEventForEveryMatchingTeamMember = new bool();
		[ContainerField(105), LayoutImmutable, Blittable, ContainerFieldNameHash(2999321434)]
		public bool GenerateEventForEveryMatchingTeamMember { get { return m_GenerateEventForEveryMatchingTeamMember; } set { if (OnPropertyChanging("TeamFilterEntityData." + nameof(GenerateEventForEveryMatchingTeamMember), this, m_GenerateEventForEveryMatchingTeamMember, value)) m_GenerateEventForEveryMatchingTeamMember = value; } } // 0x69 (105)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 229961746:
					Realm = (Realm) Enum.ToObject(typeof(Realm), p_Value);
					break;

				case 2089309528:
					Team = (TeamId) Enum.ToObject(typeof(TeamId), p_Value);
					break;

				case 2846947863:
					InvertFilter = (bool) p_Value;
					break;

				case 2999321434:
					GenerateEventForEveryMatchingTeamMember = (bool) p_Value;
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
				case 229961746:
					return Realm;

				case 2089309528:
					return Team;

				case 2846947863:
					return InvertFilter;

				case 2999321434:
					return GenerateEventForEveryMatchingTeamMember;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 229961746:
					return typeof(TeamFilterEntityData).GetProperty(nameof(Realm));

				case 2089309528:
					return typeof(TeamFilterEntityData).GetProperty(nameof(Team));

				case 2846947863:
					return typeof(TeamFilterEntityData).GetProperty(nameof(InvertFilter));

				case 2999321434:
					return typeof(TeamFilterEntityData).GetProperty(nameof(GenerateEventForEveryMatchingTeamMember));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
