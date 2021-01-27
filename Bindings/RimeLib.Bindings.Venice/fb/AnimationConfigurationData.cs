///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using RimeLib.IO;
using RimeLib.Frostbite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Reflection;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 4,  Flags: 41, Size: 12)]
	public class AnimationConfigurationData : FrostbiteContainer
	{
		[ContainerField(Name: "ShootModuleData", Offset: 0, NameHash: 476923360, Flags: 41)]
		public AnimationConfigurationShootModuleData ShootModuleData { get; set; } = new AnimationConfigurationShootModuleData(); // 0x0 (0)
		
		[ContainerField(Name: "WeaponOffsetModuleData", Offset: 4, NameHash: 4158064960, Flags: 53)]
		public CtrRef<WeaponOffsetData> WeaponOffsetModuleData { get; set; } = new CtrRef<WeaponOffsetData>(); // 0x4 (4)
		
		[ContainerField(Name: "WeaponSpeedModuleData", Offset: 8, NameHash: 3535370986, Flags: 53)]
		public CtrRef<WeaponSpeedData> WeaponSpeedModuleData { get; set; } = new CtrRef<WeaponSpeedData>(); // 0x8 (8)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 476923360:
					ShootModuleData = (AnimationConfigurationShootModuleData) p_Value;
					break;

				case 4158064960:
					WeaponOffsetModuleData = (CtrRef<WeaponOffsetData>) p_Value;
					break;

				case 3535370986:
					WeaponSpeedModuleData = (CtrRef<WeaponSpeedData>) p_Value;
					break;

				default:
					base.Bind(p_Descriptor, p_Value);
					break;
			}
		}

		public override object GetFieldValueByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 476923360:
					return ShootModuleData;

				case 4158064960:
					return WeaponOffsetModuleData;

				case 3535370986:
					return WeaponSpeedModuleData;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 476923360:
					return typeof(AnimationConfigurationData).GetProperty(nameof(ShootModuleData));

				case 4158064960:
					return typeof(AnimationConfigurationData).GetProperty(nameof(WeaponOffsetModuleData));

				case 3535370986:
					return typeof(AnimationConfigurationData).GetProperty(nameof(WeaponSpeedModuleData));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
