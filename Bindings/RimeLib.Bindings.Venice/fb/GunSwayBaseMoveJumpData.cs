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
	[ContainerType(4, 140)]
	public class GunSwayBaseMoveJumpData
	{
		[ContainerField(0)]
		public GunSwayDispersionData BaseValue { get; set; } = new();
		
		[ContainerField(16)]
		public GunSwayDispersionData Moving { get; set; } = new();
		
		[ContainerField(32)]
		public GunSwayDispersionData Jumping { get; set; } = new();
		
		[ContainerField(48)]
		public GunSwayDispersionData Sprinting { get; set; } = new();
		
		[ContainerField(64)]
		public GunSwayDispersionData VaultingSmallObject { get; set; } = new();
		
		[ContainerField(80)]
		public GunSwayDispersionData VaultingMediumObject { get; set; } = new();
		
		[ContainerField(96)]
		public GunSwayRecoilData Recoil { get; set; } = new();
		
		[ContainerField(120)]
		public GunSwayLagData GunSwayLag { get; set; } = new();
		
		public static void Deserialize(GunSwayBaseMoveJumpData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.GunSwayDispersionData.Deserialize(p_Instance.BaseValue, p_Reader, p_Parser);
			fb.GunSwayDispersionData.Deserialize(p_Instance.Moving, p_Reader, p_Parser);
			fb.GunSwayDispersionData.Deserialize(p_Instance.Jumping, p_Reader, p_Parser);
			fb.GunSwayDispersionData.Deserialize(p_Instance.Sprinting, p_Reader, p_Parser);
			fb.GunSwayDispersionData.Deserialize(p_Instance.VaultingSmallObject, p_Reader, p_Parser);
			fb.GunSwayDispersionData.Deserialize(p_Instance.VaultingMediumObject, p_Reader, p_Parser);
			fb.GunSwayRecoilData.Deserialize(p_Instance.Recoil, p_Reader, p_Parser);
			fb.GunSwayLagData.Deserialize(p_Instance.GunSwayLag, p_Reader, p_Parser);
		}
	}
}
