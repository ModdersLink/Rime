///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Collections.Generic;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class GameModeSize : FrostbiteContainer
	{
		[ContainerField(0), LayoutImmutable]
		public string Name { get; set; } // 0x0 (0)
		
		[ContainerField(4), LayoutImmutable]
		public string ShortName { get; set; } // 0x4 (4)
		
		[ContainerField(8), LayoutImmutable]
		public string MetaIdentifier { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public uint PlayerCount { get; set; } // 0xC (12)
		
		[ContainerField(16)]
		public List<GameModeTeamSize> Teams { get; set; } = new List<GameModeTeamSize>(); // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public uint RoundsPerMap { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
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
