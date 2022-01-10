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
	[ContainerType(4, 60)]
	public class SupplySphereWeaponData : 
		WeaponData
	{
		[ContainerField(16)]
		public SupplyData SupplyData { get; set; } = new();

		public static void Deserialize(SupplySphereWeaponData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.SupplyData.Deserialize(p_Instance.SupplyData, p_Reader, p_Parser);
		}

	}
}
