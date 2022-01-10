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
	public class GunSwayBaseData
	{
		[ContainerField(0)]
		public GunSwayDispersionData BaseValue { get; set; } = new();
		
		[ContainerField(16)]
		public GunSwayRecoilData Recoil { get; set; } = new();
		
		[ContainerField(40)]
		public GunSwayLagData GunSwayLag { get; set; } = new();
		
		public static void Deserialize(GunSwayBaseData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.GunSwayDispersionData.Deserialize(p_Instance.BaseValue, p_Reader, p_Parser);
			fb.GunSwayRecoilData.Deserialize(p_Instance.Recoil, p_Reader, p_Parser);
			fb.GunSwayLagData.Deserialize(p_Instance.GunSwayLag, p_Reader, p_Parser);
		}
	}
}
