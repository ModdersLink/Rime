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
	public class UIAwardDescription : 
		UIItemDescription
	{
		[ContainerField(16), LayoutImmutable, Blittable]
		public bool IgnoreBuild { get; set; }

		public static void Deserialize(UIAwardDescription p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.IgnoreBuild = p_Reader.ReadBool();
			p_Reader.Seek(3, SeekOrigin.Current);
		}

	}
}
