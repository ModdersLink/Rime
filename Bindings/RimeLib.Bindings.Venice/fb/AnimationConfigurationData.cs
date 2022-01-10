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
	[ContainerType(4, 12)]
	public class AnimationConfigurationData
	{
		[ContainerField(0)]
		public AnimationConfigurationShootModuleData ShootModuleData { get; set; } = new();
		
		[ContainerField(4)]
		public CtrRef<WeaponOffsetData> WeaponOffsetModuleData { get; set; } = new();
		
		[ContainerField(8)]
		public CtrRef<WeaponSpeedData> WeaponSpeedModuleData { get; set; } = new();
		
		public static void Deserialize(AnimationConfigurationData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.AnimationConfigurationShootModuleData.Deserialize(p_Instance.ShootModuleData, p_Reader, p_Parser);
			p_Instance.WeaponOffsetModuleData.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.WeaponSpeedModuleData.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
		}
	}
}
