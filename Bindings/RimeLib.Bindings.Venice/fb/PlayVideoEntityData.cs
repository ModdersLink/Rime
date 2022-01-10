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
	public class PlayVideoEntityData : 
		EntityData
	{
		[ContainerField(12)]
		public CtrRef<MovieTextureAsset> Movie { get; set; } = new();

		[ContainerField(16), LayoutImmutable, Blittable]
		public bool KeepBlackScreen { get; set; }

		[ContainerField(17), LayoutImmutable, Blittable]
		public bool AllowSkip { get; set; }

		public static void Deserialize(PlayVideoEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Movie.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.KeepBlackScreen = p_Reader.ReadBool();
			p_Instance.AllowSkip = p_Reader.ReadBool();
			p_Reader.Seek(2, SeekOrigin.Current);
		}

	}
}
