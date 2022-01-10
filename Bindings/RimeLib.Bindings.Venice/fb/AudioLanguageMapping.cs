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
	[ContainerType(4, 8)]
	public class AudioLanguageMapping
	{
		[ContainerField(0)]
		public CtrRef<AudioLanguage> Source { get; set; } = new();
		
		[ContainerField(4)]
		public CtrRef<AudioLanguage> Target { get; set; } = new();
		
		public static void Deserialize(AudioLanguageMapping p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Source.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.Target.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
		}
	}
}
