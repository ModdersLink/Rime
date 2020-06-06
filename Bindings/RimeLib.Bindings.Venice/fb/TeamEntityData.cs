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
	public class TeamEntityData : 
		GameEntityData
	{
		[ContainerField(96)]
		public CtrRef<TeamData> Team { get; set; } = new CtrRef<TeamData>(); // 0x60 (96)
		
		[ContainerField(100)]
		public TeamId Id { get; set; } = new TeamId(); // 0x64 (100)
		
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
