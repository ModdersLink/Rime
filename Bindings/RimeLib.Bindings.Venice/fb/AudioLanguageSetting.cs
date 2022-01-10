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
	public class AudioLanguageSetting : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable]
		public string Name { get; set; } = string.Empty;

		[ContainerField(12), LayoutImmutable, Blittable]
		public uint NameHash { get; set; }

		[ContainerField(16), LayoutImmutable]
		public string DisplayName { get; set; } = string.Empty;

		[ContainerField(20)]
		public List<AudioLanguageMapping> Mappings { get; set; } = new();

		[ContainerField(24), LayoutImmutable, Blittable]
		public bool IsDefault { get; set; }

		public static void Deserialize(AudioLanguageSetting p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Name = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.NameHash = p_Reader.ReadUInt32();
			p_Instance.DisplayName = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.Mappings.Clear();
			(RimeReader Reader, uint Count) s_Mappings = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Mappings.Count; ++i)
			{
				var s_Value = new AudioLanguageMapping();
				fb.AudioLanguageMapping.Deserialize(s_Value, s_Mappings.Reader, p_Parser);
				p_Instance.Mappings.Add(s_Value);
			}
			
			s_Mappings.Reader.Dispose();
			p_Instance.IsDefault = p_Reader.ReadBool();
			p_Reader.Seek(3, SeekOrigin.Current);
		}

	}
}
