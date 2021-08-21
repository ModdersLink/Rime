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
	[ContainerType(Alignment: 4,  Flags: 41, Size: 28)]
	public class GameModeSize : FrostbiteContainer
	{
		[ContainerField(Name: "Name", Offset: 0, NameHash: 2088949890, Flags: 16509), LayoutImmutable]
		public string Name { get; set; } // 0x0 (0)
		
		[ContainerField(Name: "ShortName", Offset: 4, NameHash: 1803010032, Flags: 16509), LayoutImmutable]
		public string ShortName { get; set; } // 0x4 (4)
		
		[ContainerField(Name: "MetaIdentifier", Offset: 8, NameHash: 3002741083, Flags: 16509), LayoutImmutable]
		public string MetaIdentifier { get; set; } // 0x8 (8)
		
		[ContainerField(Name: "PlayerCount", Offset: 12, NameHash: 4110176597, Flags: 49421), LayoutImmutable, Blittable]
		public uint PlayerCount { get; set; } // 0xC (12)
		
		[ContainerField(Name: "Teams", Offset: 16, NameHash: 227737643, Flags: 65)]
		public List<GameModeTeamSize> Teams { get; set; } = new List<GameModeTeamSize>(); // 0x10 (16)
		
		[ContainerField(Name: "RoundsPerMap", Offset: 20, NameHash: 2321647407, Flags: 49421), LayoutImmutable, Blittable]
		public uint RoundsPerMap { get; set; } // 0x14 (20)
		
		[ContainerField(Name: "ForceSquad", Offset: 24, NameHash: 1037585386, Flags: 49325), LayoutImmutable, Blittable]
		public bool ForceSquad { get; set; } // 0x18 (24)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2088949890:
					Name = (string) p_Value;
					break;

				case 1803010032:
					ShortName = (string) p_Value;
					break;

				case 3002741083:
					MetaIdentifier = (string) p_Value;
					break;

				case 4110176597:
					PlayerCount = (uint) p_Value;
					break;

				case 227737643:
					Teams = (List<GameModeTeamSize>) p_Value;
					break;

				case 2321647407:
					RoundsPerMap = (uint) p_Value;
					break;

				case 1037585386:
					ForceSquad = (bool) p_Value;
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
				case 2088949890:
					return Name;

				case 1803010032:
					return ShortName;

				case 3002741083:
					return MetaIdentifier;

				case 4110176597:
					return PlayerCount;

				case 227737643:
					return Teams;

				case 2321647407:
					return RoundsPerMap;

				case 1037585386:
					return ForceSquad;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2088949890:
					return typeof(GameModeSize).GetProperty(nameof(Name));

				case 1803010032:
					return typeof(GameModeSize).GetProperty(nameof(ShortName));

				case 3002741083:
					return typeof(GameModeSize).GetProperty(nameof(MetaIdentifier));

				case 4110176597:
					return typeof(GameModeSize).GetProperty(nameof(PlayerCount));

				case 227737643:
					return typeof(GameModeSize).GetProperty(nameof(Teams));

				case 2321647407:
					return typeof(GameModeSize).GetProperty(nameof(RoundsPerMap));

				case 1037585386:
					return typeof(GameModeSize).GetProperty(nameof(ForceSquad));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
