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
	public class UIDamageIndicatorCompData : 
		UIComponentData
	{
		[ContainerField(28), LayoutImmutable, Blittable]
		public float MaxUpdateTime { get; set; }

		public static void Deserialize(UIDamageIndicatorCompData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.MaxUpdateTime = p_Reader.ReadSingle();
		}

	}
}
