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
using RimeLib.Frostbite.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 4,  Flags: 41, Size: 8)]
	public class GunMasterWeaponsPreset : FrostbiteContainer
	{
		[ContainerField(Name: "GunMasterLevelInfos", Offset: 0, NameHash: 1245436782, Flags: 65)]
		public List<GunMasterLevelInfo> GunMasterLevelInfos { get; set; } = new List<GunMasterLevelInfo>(); // 0x0 (0)
		
		[ContainerField(Name: "LevelOverrides", Offset: 4, NameHash: 2294052628, Flags: 65)]
		public RefArray<CustomizeSoldierData> LevelOverrides { get; set; } = new RefArray<CustomizeSoldierData>(); // 0x4 (4)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1245436782:
					GunMasterLevelInfos = (List<GunMasterLevelInfo>) p_Value;
					break;

				case 2294052628:
					LevelOverrides = (RefArray<CustomizeSoldierData>) p_Value;
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
				case 1245436782:
					return GunMasterLevelInfos;

				case 2294052628:
					return LevelOverrides;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1245436782:
					return typeof(GunMasterWeaponsPreset).GetProperty(nameof(GunMasterLevelInfos));

				case 2294052628:
					return typeof(GunMasterWeaponsPreset).GetProperty(nameof(LevelOverrides));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
