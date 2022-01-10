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
	public class UIEndOfRoundEntityData : 
		GameEntityData
	{
		[ContainerField(96), LayoutImmutable, Blittable]
		public float PreEorTime { get; set; }

		[ContainerField(100), LayoutImmutable, Blittable]
		public float EorTime { get; set; }

		public static void Deserialize(UIEndOfRoundEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.PreEorTime = p_Reader.ReadSingle();
			p_Instance.EorTime = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
		}

	}
}
