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
	public class LevelAudioObstructionAsset : 
		Asset
	{
		[ContainerField(12)]
		public List<AudioObstructionMaterialInfo> MaterialMap { get; set; } = new();

		[ContainerField(16), LayoutImmutable, Blittable]
		public float FrequencySlewRate { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public float GainSlewRate { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public float MaxRaycastDistanceSquared { get; set; }

		public static void Deserialize(LevelAudioObstructionAsset p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.MaterialMap.Clear();
			(RimeReader Reader, uint Count) s_MaterialMap = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_MaterialMap.Count; ++i)
			{
				var s_Value = new AudioObstructionMaterialInfo();
				fb.AudioObstructionMaterialInfo.Deserialize(s_Value, s_MaterialMap.Reader, p_Parser);
				p_Instance.MaterialMap.Add(s_Value);
			}
			
			s_MaterialMap.Reader.Dispose();
			p_Instance.FrequencySlewRate = p_Reader.ReadSingle();
			p_Instance.GainSlewRate = p_Reader.ReadSingle();
			p_Instance.MaxRaycastDistanceSquared = p_Reader.ReadSingle();
		}

	}
}
