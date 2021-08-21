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
	[ContainerType(Alignment: 4,  Flags: 41, Size: 8)]
	public class AreaValueTeam : FrostbiteContainer
	{
		[ContainerField(Name: "AreaValue", Offset: 0, NameHash: 4217799545, Flags: 49405), LayoutImmutable, Blittable]
		public int AreaValue { get; set; } // 0x0 (0)
		
		[ContainerField(Name: "Team", Offset: 4, NameHash: 2089309528, Flags: 137)]
		public TeamId Team { get; set; } = new TeamId(); // 0x4 (4)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 4217799545:
					AreaValue = (int) p_Value;
					break;

				case 2089309528:
						Team = (TeamId) Enum.ToObject(typeof(TeamId), p_Value);
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
				case 4217799545:
					return AreaValue;

				case 2089309528:
					return Team;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 4217799545:
					return typeof(AreaValueTeam).GetProperty(nameof(AreaValue));

				case 2089309528:
					return typeof(AreaValueTeam).GetProperty(nameof(Team));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
