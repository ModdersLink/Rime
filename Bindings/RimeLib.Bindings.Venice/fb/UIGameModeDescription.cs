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
	public class UIGameModeDescription : 
		UIItemDescription
	{
		[ContainerField(16), LayoutImmutable]
		public string Identifier { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable]
		public string Name { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable]
		public string Abbreviation { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable]
		public string Desc { get; set; } // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public int BattlelogId { get; set; } // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable]
		public string TexturePath { get; set; } // 0x24 (36)
		
		[ContainerField(40)]
		public List<GameModeVariation> Variations { get; set; } = new List<GameModeVariation>(); // 0x28 (40)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3512790342:
					Identifier = (string) p_Value;
					break;

				case 2088949890:
					Name = (string) p_Value;
					break;

				case 1781328241:
					Abbreviation = (string) p_Value;
					break;

				case 2088734996:
					Desc = (string) p_Value;
					break;

				case 281607366:
					BattlelogId = (int) p_Value;
					break;

				case 3058477943:
					TexturePath = (string) p_Value;
					break;

				case 2728063271:
					Variations = (List<GameModeVariation>) p_Value;
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
				case 3512790342:
					return Identifier;

				case 2088949890:
					return Name;

				case 1781328241:
					return Abbreviation;

				case 2088734996:
					return Desc;

				case 281607366:
					return BattlelogId;

				case 3058477943:
					return TexturePath;

				case 2728063271:
					return Variations;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3512790342:
					return typeof(UIGameModeDescription).GetProperty(nameof(Identifier));

				case 2088949890:
					return typeof(UIGameModeDescription).GetProperty(nameof(Name));

				case 1781328241:
					return typeof(UIGameModeDescription).GetProperty(nameof(Abbreviation));

				case 2088734996:
					return typeof(UIGameModeDescription).GetProperty(nameof(Desc));

				case 281607366:
					return typeof(UIGameModeDescription).GetProperty(nameof(BattlelogId));

				case 3058477943:
					return typeof(UIGameModeDescription).GetProperty(nameof(TexturePath));

				case 2728063271:
					return typeof(UIGameModeDescription).GetProperty(nameof(Variations));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
