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
	[ContainerType(4, 40)]
	public class UIWeaponCompData : 
		UIComponentData
	{
		[ContainerField(28), LayoutImmutable, Blittable]
		public float MinHitIndicatorLimit { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable]
		public float MaxHitIndicatorLimit { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable]
		public float NormalHitIndicatorLimit { get; set; }

		public static void Deserialize(UIWeaponCompData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.MinHitIndicatorLimit = p_Reader.ReadSingle();
			p_Instance.MaxHitIndicatorLimit = p_Reader.ReadSingle();
			p_Instance.NormalHitIndicatorLimit = p_Reader.ReadSingle();
		}

	}
}
