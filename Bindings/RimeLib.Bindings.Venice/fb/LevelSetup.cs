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
	[ContainerType(4, 24)]
	public class LevelSetup
	{
		[ContainerField(0), LayoutImmutable]
		public string Name { get; set; } = string.Empty;
		
		[ContainerField(4)]
		public List<LevelSetupOption> InclusionOptions { get; set; } = new();
		
		[ContainerField(8), LayoutImmutable, Blittable]
		public uint DifficultyIndex { get; set; }
		
		[ContainerField(12)]
		public List<string> SubLevelNames { get; set; } = new();
		
		[ContainerField(16)]
		public List<int> SubLevelStates { get; set; } = new();
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public bool IsSaveGame { get; set; }
		
		[ContainerField(21), LayoutImmutable, Blittable]
		public bool ForceReloadResources { get; set; }
		
		public static void Deserialize(LevelSetup p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Name = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.InclusionOptions.Clear();
			(RimeReader Reader, uint Count) s_InclusionOptions = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_InclusionOptions.Count; ++i)
			{
				var s_Value = new LevelSetupOption();
				fb.LevelSetupOption.Deserialize(s_Value, s_InclusionOptions.Reader, p_Parser);
				p_Instance.InclusionOptions.Add(s_Value);
			}
			
			s_InclusionOptions.Reader.Dispose();
			p_Instance.DifficultyIndex = p_Reader.ReadUInt32();
			p_Instance.SubLevelNames.Clear();
			(RimeReader Reader, uint Count) s_SubLevelNames = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_SubLevelNames.Count; ++i)
			{
				var s_Value = p_Parser.GetStringAtOffset(s_SubLevelNames.Reader.ReadUInt32());
				p_Instance.SubLevelNames.Add(s_Value);
			}
			
			s_SubLevelNames.Reader.Dispose();
			p_Instance.SubLevelStates.Clear();
			(RimeReader Reader, uint Count) s_SubLevelStates = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_SubLevelStates.Count; ++i)
			{
				var s_Value = s_SubLevelStates.Reader.ReadInt32();
				p_Instance.SubLevelStates.Add(s_Value);
			}
			
			s_SubLevelStates.Reader.Dispose();
			p_Instance.IsSaveGame = p_Reader.ReadBool();
			p_Instance.ForceReloadResources = p_Reader.ReadBool();
			p_Reader.Seek(2, SeekOrigin.Current);
		}
	}
}
