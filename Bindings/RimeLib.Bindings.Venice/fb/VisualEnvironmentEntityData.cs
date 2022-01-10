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
	public class VisualEnvironmentEntityData : 
		GameEntityData
	{
		[ContainerField(96), LayoutImmutable, Blittable]
		public float Visibility { get; set; }

		[ContainerField(100), LayoutImmutable, Blittable]
		public int Priority { get; set; }

		public static void Deserialize(VisualEnvironmentEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Visibility = p_Reader.ReadSingle();
			p_Instance.Priority = p_Reader.ReadInt32();
			p_Reader.Seek(8, SeekOrigin.Current);
		}

	}
}
