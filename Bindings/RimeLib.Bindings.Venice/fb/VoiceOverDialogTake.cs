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
	[ContainerType(4, 4)]
	public class VoiceOverDialogTake
	{
		[ContainerField(0)]
		public CtrRef<SoundWaveAsset> Wave { get; set; } = new();
		
		public static void Deserialize(VoiceOverDialogTake p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Wave.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
		}
	}
}
