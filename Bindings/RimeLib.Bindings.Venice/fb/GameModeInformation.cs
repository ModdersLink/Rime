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
	[ContainerType(4, 40)]
	public class GameModeInformation
	{
		[ContainerField(0)]
		public GamePlatform Platform { get; set; } = new();
		
		[ContainerField(4)]
		public List<GameModeSize> Sizes { get; set; } = new();
		
		[ContainerField(8)]
		public GameModeSize DefaultSize { get; set; } = new();
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public bool AllowFallbackToDefault { get; set; }
		
		public static void Deserialize(GameModeInformation p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Platform = (GamePlatform) p_Reader.ReadInt32();
			p_Instance.Sizes.Clear();
			(RimeReader Reader, uint Count) s_Sizes = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Sizes.Count; ++i)
			{
				var s_Value = new GameModeSize();
				fb.GameModeSize.Deserialize(s_Value, s_Sizes.Reader, p_Parser);
				p_Instance.Sizes.Add(s_Value);
			}
			
			s_Sizes.Reader.Dispose();
			fb.GameModeSize.Deserialize(p_Instance.DefaultSize, p_Reader, p_Parser);
			p_Instance.AllowFallbackToDefault = p_Reader.ReadBool();
			p_Reader.Seek(3, SeekOrigin.Current);
		}
	}
}
