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
	public class GunSwayStanceTransition
	{
		[ContainerField(0)]
		public GunSwayDispersionData MaxPenaltyValue { get; set; } = new();
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float CoolDown { get; set; }
		
		public static void Deserialize(GunSwayStanceTransition p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.GunSwayDispersionData.Deserialize(p_Instance.MaxPenaltyValue, p_Reader, p_Parser);
			p_Instance.CoolDown = p_Reader.ReadSingle();
		}
	}
}
