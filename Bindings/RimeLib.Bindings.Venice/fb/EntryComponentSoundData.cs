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
	[ContainerType(4, 16)]
	public class EntryComponentSoundData : 
		DataContainer
	{
		[ContainerField(8)]
		public List<StanceSwitchSoundData> StanceSounds { get; set; } = new();

		[ContainerField(12)]
		public CtrRef<SoundAsset> StanceSwitchSound { get; set; } = new();

		public static void Deserialize(EntryComponentSoundData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.StanceSounds.Clear();
			(RimeReader Reader, uint Count) s_StanceSounds = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_StanceSounds.Count; ++i)
			{
				var s_Value = new StanceSwitchSoundData();
				fb.StanceSwitchSoundData.Deserialize(s_Value, s_StanceSounds.Reader, p_Parser);
				p_Instance.StanceSounds.Add(s_Value);
			}
			
			s_StanceSounds.Reader.Dispose();
			p_Instance.StanceSwitchSound.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
		}

	}
}
