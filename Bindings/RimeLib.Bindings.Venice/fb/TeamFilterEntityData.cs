///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class TeamFilterEntityData : 
		GameEntityData
	{
		[ContainerField(96)]
		public Realm Realm { get; set; } = new Realm(); // 0x60 (96)
		
		[ContainerField(100)]
		public TeamId Team { get; set; } = new TeamId(); // 0x64 (100)
		
		[ContainerField(104), LayoutImmutable, Blittable]
		public bool InvertFilter { get; set; } // 0x68 (104)
		
		[ContainerField(105), LayoutImmutable, Blittable]
		public bool GenerateEventForEveryMatchingTeamMember { get; set; } // 0x69 (105)
		
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
