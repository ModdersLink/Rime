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
	[ContainerType(Alignment: 4,  Flags: 41, Size: 40)]
	public class GameModeInformation : FrostbiteContainer
	{
		[ContainerField(Name: "Platform", Offset: 0, NameHash: 942751002, Flags: 137)]
		public GamePlatform Platform { get; set; } = new GamePlatform(); // 0x0 (0)
		
		[ContainerField(Name: "Sizes", Offset: 4, NameHash: 231688563, Flags: 65)]
		public List<GameModeSize> Sizes { get; set; } = new List<GameModeSize>(); // 0x4 (4)
		
		[ContainerField(Name: "DefaultSize", Offset: 8, NameHash: 2015239083, Flags: 41)]
		public GameModeSize DefaultSize { get; set; } = new GameModeSize(); // 0x8 (8)
		
		[ContainerField(Name: "AllowFallbackToDefault", Offset: 36, NameHash: 1742608896, Flags: 49325), LayoutImmutable, Blittable]
		public bool AllowFallbackToDefault { get; set; } // 0x24 (36)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 942751002:
						Platform = (GamePlatform) Enum.ToObject(typeof(GamePlatform), p_Value);
					break;

				case 231688563:
					Sizes = (List<GameModeSize>) p_Value;
					break;

				case 2015239083:
					DefaultSize = (GameModeSize) p_Value;
					break;

				case 1742608896:
					AllowFallbackToDefault = (bool) p_Value;
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
				case 942751002:
					return Platform;

				case 231688563:
					return Sizes;

				case 2015239083:
					return DefaultSize;

				case 1742608896:
					return AllowFallbackToDefault;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 942751002:
					return typeof(GameModeInformation).GetProperty(nameof(Platform));

				case 231688563:
					return typeof(GameModeInformation).GetProperty(nameof(Sizes));

				case 2015239083:
					return typeof(GameModeInformation).GetProperty(nameof(DefaultSize));

				case 1742608896:
					return typeof(GameModeInformation).GetProperty(nameof(AllowFallbackToDefault));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
