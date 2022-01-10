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
	public class StanceSwitchSoundData
	{
		[ContainerField(0)]
		public CtrRef<SoundAsset> StanceSwitchSound { get; set; } = new();
		
		[ContainerField(4)]
		public List<int> ValidStances { get; set; } = new();
		
		public static void Deserialize(StanceSwitchSoundData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.StanceSwitchSound.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.ValidStances.Clear();
			(RimeReader Reader, uint Count) s_ValidStances = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_ValidStances.Count; ++i)
			{
				var s_Value = s_ValidStances.Reader.ReadInt32();
				p_Instance.ValidStances.Add(s_Value);
			}
			
			s_ValidStances.Reader.Dispose();
		}
	}
}
