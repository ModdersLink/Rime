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
	[ContainerType(4, 28)]
	public class GameModeSize
	{
		[ContainerField(0), LayoutImmutable]
		public string Name { get; set; } = string.Empty;
		
		[ContainerField(4), LayoutImmutable]
		public string ShortName { get; set; } = string.Empty;
		
		[ContainerField(8), LayoutImmutable]
		public string MetaIdentifier { get; set; } = string.Empty;
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public uint PlayerCount { get; set; }
		
		[ContainerField(16)]
		public List<GameModeTeamSize> Teams { get; set; } = new();
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public uint RoundsPerMap { get; set; }
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public bool ForceSquad { get; set; }
		
		public static void Deserialize(GameModeSize p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Name = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.ShortName = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.MetaIdentifier = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.PlayerCount = p_Reader.ReadUInt32();
			p_Instance.Teams.Clear();
			(RimeReader Reader, uint Count) s_Teams = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Teams.Count; ++i)
			{
				var s_Value = new GameModeTeamSize();
				fb.GameModeTeamSize.Deserialize(s_Value, s_Teams.Reader, p_Parser);
				p_Instance.Teams.Add(s_Value);
			}
			
			s_Teams.Reader.Dispose();
			p_Instance.RoundsPerMap = p_Reader.ReadUInt32();
			p_Instance.ForceSquad = p_Reader.ReadBool();
			p_Reader.Seek(3, SeekOrigin.Current);
		}
	}
}
