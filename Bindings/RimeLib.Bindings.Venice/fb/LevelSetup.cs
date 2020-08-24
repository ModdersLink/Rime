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
	[ContainerType(4), MemberInfoFlag(41), ContainerStruct]
	public class LevelSetup : FrostbiteContainer
	{
		[ContainerField(0), LayoutImmutable, MemberInfoFlag(16509)]
		public string Name { get; set; } // 0x0 (0)
		
		[ContainerField(4), MemberInfoFlag(65), ContainerArray]
		public List<LevelSetupOption> InclusionOptions { get; set; } = new List<LevelSetupOption>(); // 0x4 (4)
		
		[ContainerField(8), LayoutImmutable, Blittable, MemberInfoFlag(49421)]
		public uint DifficultyIndex { get; set; } // 0x8 (8)
		
		[ContainerField(12), MemberInfoFlag(65), ContainerArray]
		public List<string> SubLevelNames { get; set; } = new List<string>(); // 0xC (12)
		
		[ContainerField(16), MemberInfoFlag(65), ContainerArray]
		public List<int> SubLevelStates { get; set; } = new List<int>(); // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable, MemberInfoFlag(49325)]
		public bool IsSaveGame { get; set; } // 0x14 (20)
		
		[ContainerField(21), LayoutImmutable, Blittable, MemberInfoFlag(49325)]
		public bool ForceReloadResources { get; set; } // 0x15 (21)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2088949890:
					Name = (string) p_Value;
					break;

				case 1857959091:
					InclusionOptions = (List<LevelSetupOption>) p_Value;
					break;

				case 302070728:
					DifficultyIndex = (uint) p_Value;
					break;

				case 2087484675:
					SubLevelNames = (List<string>) p_Value;
					break;

				case 3729589043:
					SubLevelStates = (List<int>) p_Value;
					break;

				case 3625496752:
					IsSaveGame = (bool) p_Value;
					break;

				case 3211157744:
					ForceReloadResources = (bool) p_Value;
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
				case 2088949890:
					return Name;

				case 1857959091:
					return InclusionOptions;

				case 302070728:
					return DifficultyIndex;

				case 2087484675:
					return SubLevelNames;

				case 3729589043:
					return SubLevelStates;

				case 3625496752:
					return IsSaveGame;

				case 3211157744:
					return ForceReloadResources;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2088949890:
					return typeof(LevelSetup).GetProperty(nameof(Name));

				case 1857959091:
					return typeof(LevelSetup).GetProperty(nameof(InclusionOptions));

				case 302070728:
					return typeof(LevelSetup).GetProperty(nameof(DifficultyIndex));

				case 2087484675:
					return typeof(LevelSetup).GetProperty(nameof(SubLevelNames));

				case 3729589043:
					return typeof(LevelSetup).GetProperty(nameof(SubLevelStates));

				case 3625496752:
					return typeof(LevelSetup).GetProperty(nameof(IsSaveGame));

				case 3211157744:
					return typeof(LevelSetup).GetProperty(nameof(ForceReloadResources));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
