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
	[ContainerType(16, 176)]
	public class FenceModelEntityData : 
		StaticModelEntityData
	{
		[ContainerField(160), LayoutImmutable, Blittable]
		public float Width { get; set; }

		[ContainerField(164), LayoutImmutable, Blittable]
		public float Angle { get; set; }

		public static void Deserialize(FenceModelEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Width = p_Reader.ReadSingle();
			p_Instance.Angle = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
		}

	}
}
