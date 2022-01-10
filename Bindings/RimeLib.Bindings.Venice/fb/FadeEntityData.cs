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
	public class FadeEntityData : 
		EntityData
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public float FadeTime { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable]
		public float MaxWaitFadedWhileStreamingTime { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public bool FadeScreen { get; set; }

		[ContainerField(21), LayoutImmutable, Blittable]
		public bool FadeUI { get; set; }

		[ContainerField(22), LayoutImmutable, Blittable]
		public bool FadeRumble { get; set; }

		[ContainerField(23), LayoutImmutable, Blittable]
		public bool FadeAudio { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public bool FadeMovie { get; set; }

		[ContainerField(25), LayoutImmutable, Blittable]
		public bool StartFaded { get; set; }

		public static void Deserialize(FadeEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.FadeTime = p_Reader.ReadSingle();
			p_Instance.MaxWaitFadedWhileStreamingTime = p_Reader.ReadSingle();
			p_Instance.FadeScreen = p_Reader.ReadBool();
			p_Instance.FadeUI = p_Reader.ReadBool();
			p_Instance.FadeRumble = p_Reader.ReadBool();
			p_Instance.FadeAudio = p_Reader.ReadBool();
			p_Instance.FadeMovie = p_Reader.ReadBool();
			p_Instance.StartFaded = p_Reader.ReadBool();
			p_Reader.Seek(2, SeekOrigin.Current);
		}

	}
}
