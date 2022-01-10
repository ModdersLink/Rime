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
	[ContainerType(16, 112)]
	public class MovieEntityData : 
		GameEntityData
	{
		[ContainerField(96)]
		public CtrRef<MovieTextureAsset> Movie { get; set; } = new();

		[ContainerField(100), LayoutImmutable, Blittable]
		public float ExternalTime { get; set; }

		[ContainerField(104), LayoutImmutable, Blittable]
		public bool IsNormalMap { get; set; }

		public static void Deserialize(MovieEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Movie.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.ExternalTime = p_Reader.ReadSingle();
			p_Instance.IsNormalMap = p_Reader.ReadBool();
			p_Reader.Seek(7, SeekOrigin.Current);
		}

	}
}
