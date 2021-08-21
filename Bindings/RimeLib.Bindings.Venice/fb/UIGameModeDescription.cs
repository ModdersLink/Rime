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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 44)]
	public class UIGameModeDescription : 
		UIItemDescription
	{
		protected string m_Identifier = string.Empty;
		[ContainerField(Name: "Identifier", Offset: 16, NameHash: 3512790342, Flags: 16509), LayoutImmutable]
		public string Identifier { get { return m_Identifier; } set { if (OnPropertyChanging("UIGameModeDescription." + nameof(Identifier), this, m_Identifier, value)) m_Identifier = value; } } // 0x10 (16)
		
		protected string m_Name = string.Empty;
		[ContainerField(Name: "Name", Offset: 20, NameHash: 2088949890, Flags: 16509), LayoutImmutable]
		public string Name { get { return m_Name; } set { if (OnPropertyChanging("UIGameModeDescription." + nameof(Name), this, m_Name, value)) m_Name = value; } } // 0x14 (20)
		
		protected string m_Abbreviation = string.Empty;
		[ContainerField(Name: "Abbreviation", Offset: 24, NameHash: 1781328241, Flags: 16509), LayoutImmutable]
		public string Abbreviation { get { return m_Abbreviation; } set { if (OnPropertyChanging("UIGameModeDescription." + nameof(Abbreviation), this, m_Abbreviation, value)) m_Abbreviation = value; } } // 0x18 (24)
		
		protected string m_Desc = string.Empty;
		[ContainerField(Name: "Desc", Offset: 28, NameHash: 2088734996, Flags: 16509), LayoutImmutable]
		public string Desc { get { return m_Desc; } set { if (OnPropertyChanging("UIGameModeDescription." + nameof(Desc), this, m_Desc, value)) m_Desc = value; } } // 0x1C (28)
		
		protected int m_BattlelogId = new int();
		[ContainerField(Name: "BattlelogId", Offset: 32, NameHash: 281607366, Flags: 49405), LayoutImmutable, Blittable]
		public int BattlelogId { get { return m_BattlelogId; } set { if (OnPropertyChanging("UIGameModeDescription." + nameof(BattlelogId), this, m_BattlelogId, value)) m_BattlelogId = value; } } // 0x20 (32)
		
		protected string m_TexturePath = string.Empty;
		[ContainerField(Name: "TexturePath", Offset: 36, NameHash: 3058477943, Flags: 16509), LayoutImmutable]
		public string TexturePath { get { return m_TexturePath; } set { if (OnPropertyChanging("UIGameModeDescription." + nameof(TexturePath), this, m_TexturePath, value)) m_TexturePath = value; } } // 0x24 (36)
		
		protected List<GameModeVariation> m_Variations = new List<GameModeVariation>();
		[ContainerField(Name: "Variations", Offset: 40, NameHash: 2728063271, Flags: 65)]
		public List<GameModeVariation> Variations { get { return m_Variations; } set { if (OnPropertyChanging("UIGameModeDescription." + nameof(Variations), this, m_Variations, value)) m_Variations = value; } } // 0x28 (40)
		
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
