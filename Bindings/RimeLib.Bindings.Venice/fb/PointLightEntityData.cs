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
	[ContainerType(16, 192)]
	public class PointLightEntityData : 
		LocalLightEntityData
	{
		[ContainerField(160), LayoutImmutable, Blittable]
		public float Width { get; set; }

		[ContainerField(164), LayoutImmutable, Blittable]
		public float TranslucencyAmbient { get; set; }

		[ContainerField(168), LayoutImmutable, Blittable]
		public float TranslucencyScale { get; set; }

		[ContainerField(172), LayoutImmutable, Blittable]
		public uint TranslucencyPower { get; set; }

		[ContainerField(176), LayoutImmutable, Blittable]
		public float TranslucencyDistortion { get; set; }

		public static void Deserialize(PointLightEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Width = p_Reader.ReadSingle();
			p_Instance.TranslucencyAmbient = p_Reader.ReadSingle();
			p_Instance.TranslucencyScale = p_Reader.ReadSingle();
			p_Instance.TranslucencyPower = p_Reader.ReadUInt32();
			p_Instance.TranslucencyDistortion = p_Reader.ReadSingle();
			p_Reader.Seek(12, SeekOrigin.Current);
		}

	}
}
