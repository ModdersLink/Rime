///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4, 44)]
	public class UIGameModeDescription : 
		UIItemDescription
	{
		[ContainerField(16), LayoutImmutable]
		public string Identifier { get; set; } = string.Empty;

		[ContainerField(20), LayoutImmutable]
		public string Name { get; set; } = string.Empty;

		[ContainerField(24), LayoutImmutable]
		public string Abbreviation { get; set; } = string.Empty;

		[ContainerField(28), LayoutImmutable]
		public string Desc { get; set; } = string.Empty;

		[ContainerField(32), LayoutImmutable, Blittable]
		public int BattlelogId { get; set; }

		[ContainerField(36), LayoutImmutable]
		public string TexturePath { get; set; } = string.Empty;

		[ContainerField(40)]
		public List<GameModeVariation> Variations { get; set; } = new();

		public static void Deserialize(UIGameModeDescription p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Identifier = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.Name = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.Abbreviation = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.Desc = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.BattlelogId = p_Reader.ReadInt32();
			p_Instance.TexturePath = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.Variations.Clear();
			(RimeReader Reader, uint Count) s_Variations = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Variations.Count; ++i)
			{
				var s_Value = new GameModeVariation();
				fb.GameModeVariation.Deserialize(s_Value, s_Variations.Reader, p_Parser);
				p_Instance.Variations.Add(s_Value);
			}
			
			s_Variations.Reader.Dispose();
		}

	}
}
