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
	[ContainerType(4, 20)]
	public class MaterialSoldierSoundSettings : 
		DataContainer
	{
		[ContainerField(8)]
		public CtrRef<SoundAsset> FootStepSound { get; set; } = new();

		[ContainerField(12)]
		public CtrRef<SoundAsset> ProneSound { get; set; } = new();

		[ContainerField(16)]
		public CtrRef<SoundAsset> LandSound { get; set; } = new();

		public static void Deserialize(MaterialSoldierSoundSettings p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.FootStepSound.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.ProneSound.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.LandSound.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
		}

	}
}
