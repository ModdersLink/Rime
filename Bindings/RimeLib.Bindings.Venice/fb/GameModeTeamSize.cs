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
	[ContainerType(Alignment: 4,  Flags: 41, Size: 8)]
	public class GameModeTeamSize : FrostbiteContainer
	{
		[ContainerField(Name: "PlayerCount", Offset: 0, NameHash: 4110176597, Flags: 49421), LayoutImmutable, Blittable]
		public uint PlayerCount { get; set; } // 0x0 (0)
		
		[ContainerField(Name: "SquadSize", Offset: 4, NameHash: 1279632114, Flags: 49421), LayoutImmutable, Blittable]
		public uint SquadSize { get; set; } // 0x4 (4)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 4110176597:
					PlayerCount = (uint) p_Value;
					break;

				case 1279632114:
					SquadSize = (uint) p_Value;
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
				case 4110176597:
					return PlayerCount;

				case 1279632114:
					return SquadSize;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 4110176597:
					return typeof(GameModeTeamSize).GetProperty(nameof(PlayerCount));

				case 1279632114:
					return typeof(GameModeTeamSize).GetProperty(nameof(SquadSize));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
