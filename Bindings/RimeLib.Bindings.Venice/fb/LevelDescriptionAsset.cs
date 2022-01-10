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
	public class LevelDescriptionAsset : 
		Asset
	{
		[ContainerField(12), LayoutImmutable]
		public string LevelName { get; set; } = string.Empty;

		[ContainerField(16)]
		public List<LevelDescriptionInclusionCategory> Categories { get; set; } = new();

		[ContainerField(20)]
		public LevelDescription Description { get; set; } = new();

		[ContainerField(36)]
		public List<string> StartPoints { get; set; } = new();

		public static void Deserialize(LevelDescriptionAsset p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.LevelName = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.Categories.Clear();
			(RimeReader Reader, uint Count) s_Categories = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Categories.Count; ++i)
			{
				var s_Value = new LevelDescriptionInclusionCategory();
				fb.LevelDescriptionInclusionCategory.Deserialize(s_Value, s_Categories.Reader, p_Parser);
				p_Instance.Categories.Add(s_Value);
			}
			
			s_Categories.Reader.Dispose();
			fb.LevelDescription.Deserialize(p_Instance.Description, p_Reader, p_Parser);
			p_Instance.StartPoints.Clear();
			(RimeReader Reader, uint Count) s_StartPoints = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_StartPoints.Count; ++i)
			{
				var s_Value = p_Parser.GetStringAtOffset(s_StartPoints.Reader.ReadUInt32());
				p_Instance.StartPoints.Add(s_Value);
			}
			
			s_StartPoints.Reader.Dispose();
		}

	}
}
