///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(4, 12)]
	public class AnimationConfigurationData :
		EbxSerializable
	{
		[ContainerField(0), JsonProperty(Order = 0)]
		public AnimationConfigurationShootModuleData ShootModuleData { get; set; } = new();
		
		[ContainerField(4), JsonProperty(Order = 4)]
		public CtrRef<WeaponOffsetData> WeaponOffsetModuleData { get; set; } = new();
		
		[ContainerField(8), JsonProperty(Order = 8)]
		public CtrRef<WeaponSpeedData> WeaponSpeedModuleData { get; set; } = new();
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			ShootModuleData.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(WeaponOffsetModuleData));
			p_Writer.Write(p_EbxWriter.WriteImport(WeaponSpeedModuleData));
		}
	}
}
