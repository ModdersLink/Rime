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
	[ContainerType(Alignment: 4,  Flags: 41, Size: 8)]
	public class StanceSwitchSoundData : FrostbiteContainer
	{
		[ContainerField(Name: "StanceSwitchSound", Offset: 0, NameHash: 865104730, Flags: 53)]
		public CtrRef<SoundAsset> StanceSwitchSound { get; set; } = new CtrRef<SoundAsset>(); // 0x0 (0)
		
		[ContainerField(Name: "ValidStances", Offset: 4, NameHash: 4192498222, Flags: 65)]
		public List<int> ValidStances { get; set; } = new List<int>(); // 0x4 (4)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 865104730:
					StanceSwitchSound = (CtrRef<SoundAsset>) p_Value;
					break;

				case 4192498222:
					ValidStances = (List<int>) p_Value;
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
				case 865104730:
					return StanceSwitchSound;

				case 4192498222:
					return ValidStances;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 865104730:
					return typeof(StanceSwitchSoundData).GetProperty(nameof(StanceSwitchSound));

				case 4192498222:
					return typeof(StanceSwitchSoundData).GetProperty(nameof(ValidStances));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
