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
	public class SoundPatchConfigurationAsset : 
		SoundAsset
	{
		[ContainerField(16)]
		public CtrRef<SoundPatchAsset> Sound { get; set; } = new();

		[ContainerField(20)]
		public List<CtrRef<SoundPatchConfigurationEntry>> Entries { get; set; } = new();

		[ContainerField(24), LayoutImmutable, Blittable]
		public float Loudness { get; set; }

		public static void Deserialize(SoundPatchConfigurationAsset p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Sound.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.Entries.Clear();
			(RimeReader Reader, uint Count) s_Entries = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Entries.Count; ++i)
			{
				var s_CtrRef = new CtrRef<SoundPatchConfigurationEntry>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_Entries.Reader.ReadUInt32()));
				p_Instance.Entries.Add(s_CtrRef);
			}
			
			s_Entries.Reader.Dispose();
			p_Instance.Loudness = p_Reader.ReadSingle();
		}

	}
}
