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
	[ContainerType(4, 56)]
	public class MovieTextureAsset : 
		Asset
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public GUID ChunkGuid { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable]
		public uint ChunkSize { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable]
		public GUID SubtitleChunkGuid { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable]
		public uint SubtitleChunkSize { get; set; }

		[ContainerField(52), LayoutImmutable, Blittable]
		public bool HasLocalizedAudioTracks { get; set; }

		[ContainerField(53), LayoutImmutable, Blittable]
		public bool OverrideBackgroundMusic { get; set; }

		public static void Deserialize(MovieTextureAsset p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.ChunkGuid = new GUID(p_Reader);
			p_Instance.ChunkSize = p_Reader.ReadUInt32();
			p_Instance.SubtitleChunkGuid = new GUID(p_Reader);
			p_Instance.SubtitleChunkSize = p_Reader.ReadUInt32();
			p_Instance.HasLocalizedAudioTracks = p_Reader.ReadBool();
			p_Instance.OverrideBackgroundMusic = p_Reader.ReadBool();
			p_Reader.Seek(2, SeekOrigin.Current);
		}

	}
}
