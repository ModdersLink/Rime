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
	[ContainerType(16, 272)]
	public class MedicBagEntityData : 
		ExplosionPackEntityData
	{
		[ContainerField(256)]
		public HealerData Healer { get; set; } = new();

		public static void Deserialize(MedicBagEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.HealerData.Deserialize(p_Instance.Healer, p_Reader, p_Parser);
		}

	}
}
