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
	public class SoundStateSettingsAsset : 
		Asset
	{
		[ContainerField(12)]
		public List<CtrRef<SoundState>> SoundStates { get; set; } = new();

		[ContainerField(16), LayoutImmutable, Blittable]
		public float ImpairedHearingImpulseThreshold { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public float ScreamThreshold { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public float SupressionThreshold { get; set; }

		public static void Deserialize(SoundStateSettingsAsset p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.SoundStates.Clear();
			(RimeReader Reader, uint Count) s_SoundStates = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_SoundStates.Count; ++i)
			{
				var s_CtrRef = new CtrRef<SoundState>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_SoundStates.Reader.ReadUInt32()));
				p_Instance.SoundStates.Add(s_CtrRef);
			}
			
			s_SoundStates.Reader.Dispose();
			p_Instance.ImpairedHearingImpulseThreshold = p_Reader.ReadSingle();
			p_Instance.ScreamThreshold = p_Reader.ReadSingle();
			p_Instance.SupressionThreshold = p_Reader.ReadSingle();
		}

	}
}
