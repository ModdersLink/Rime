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
	public class MatchmakingSizeConfiguration
	{
		[ContainerField(0)]
		public MatchmakingPlatform Platform { get; set; } = new();
		
		[ContainerField(4)]
		public List<string> Settings { get; set; } = new();
		
		[ContainerField(8), LayoutImmutable, Blittable]
		public uint DesiredPlayerCount { get; set; }
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public uint MinPlayerCount { get; set; }
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public uint MaxPlayerCapacity { get; set; }
		
		[ContainerField(20), LayoutImmutable]
		public string MinFitThreshold { get; set; } = string.Empty;
		
		public static void Deserialize(MatchmakingSizeConfiguration p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Platform = (MatchmakingPlatform) p_Reader.ReadInt32();
			p_Instance.Settings.Clear();
			(RimeReader Reader, uint Count) s_Settings = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Settings.Count; ++i)
			{
				var s_Value = p_Parser.GetStringAtOffset(s_Settings.Reader.ReadUInt32());
				p_Instance.Settings.Add(s_Value);
			}
			
			s_Settings.Reader.Dispose();
			p_Instance.DesiredPlayerCount = p_Reader.ReadUInt32();
			p_Instance.MinPlayerCount = p_Reader.ReadUInt32();
			p_Instance.MaxPlayerCapacity = p_Reader.ReadUInt32();
			p_Instance.MinFitThreshold = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
		}
	}
}
