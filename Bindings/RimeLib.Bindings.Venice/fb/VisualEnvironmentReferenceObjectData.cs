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
	public class VisualEnvironmentReferenceObjectData : 
		ReferenceObjectData
	{
		[ContainerField(96), LayoutImmutable, Blittable]
		public int Priority { get; set; }

		[ContainerField(100), LayoutImmutable, Blittable]
		public bool OverrideVisibility { get; set; }

		public static void Deserialize(VisualEnvironmentReferenceObjectData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Priority = p_Reader.ReadInt32();
			p_Instance.OverrideVisibility = p_Reader.ReadBool();
			p_Reader.Seek(11, SeekOrigin.Current);
		}

	}
}
