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
	[ContainerType(4, 24)]
	public class ProfileOptionDataBinary : 
		ProfileOptionData
	{
		[ContainerField(20), LayoutImmutable, Blittable]
		public int MaxLength { get; set; }

		public static void Deserialize(ProfileOptionDataBinary p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.MaxLength = p_Reader.ReadInt32();
		}

	}
}
