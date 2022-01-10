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
	[ContainerType(4, 32)]
	public class UIScoreboardCompData : 
		UIComponentData
	{
		[ContainerField(28), LayoutImmutable, Blittable]
		public float MaxUpdateInterval { get; set; }

		public static void Deserialize(UIScoreboardCompData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.MaxUpdateInterval = p_Reader.ReadSingle();
		}

	}
}
