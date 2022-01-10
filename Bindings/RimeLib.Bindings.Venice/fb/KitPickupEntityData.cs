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
	public class KitPickupEntityData : 
		PickupEntityData
	{
		[ContainerField(176), LayoutImmutable, Blittable]
		public bool KeepAdditionalWeapons { get; set; }

		[ContainerField(177), LayoutImmutable, Blittable]
		public bool KeepAmmoState { get; set; }

		public static void Deserialize(KitPickupEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.KeepAdditionalWeapons = p_Reader.ReadBool();
			p_Instance.KeepAmmoState = p_Reader.ReadBool();
			p_Reader.Seek(14, SeekOrigin.Current);
		}

	}
}
