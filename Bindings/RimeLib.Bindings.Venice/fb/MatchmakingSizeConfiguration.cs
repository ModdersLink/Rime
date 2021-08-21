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
	[ContainerType(Alignment: 4,  Flags: 41, Size: 24)]
	public class MatchmakingSizeConfiguration : FrostbiteContainer
	{
		[ContainerField(Name: "Platform", Offset: 0, NameHash: 942751002, Flags: 137)]
		public MatchmakingPlatform Platform { get; set; } = new MatchmakingPlatform(); // 0x0 (0)
		
		[ContainerField(Name: "Settings", Offset: 4, NameHash: 649772672, Flags: 65)]
		public List<string> Settings { get; set; } = new List<string>(); // 0x4 (4)
		
		[ContainerField(Name: "DesiredPlayerCount", Offset: 8, NameHash: 3876155997, Flags: 49421), LayoutImmutable, Blittable]
		public uint DesiredPlayerCount { get; set; } // 0x8 (8)
		
		[ContainerField(Name: "MinPlayerCount", Offset: 12, NameHash: 891225311, Flags: 49421), LayoutImmutable, Blittable]
		public uint MinPlayerCount { get; set; } // 0xC (12)
		
		[ContainerField(Name: "MaxPlayerCapacity", Offset: 16, NameHash: 4024578774, Flags: 49421), LayoutImmutable, Blittable]
		public uint MaxPlayerCapacity { get; set; } // 0x10 (16)
		
		[ContainerField(Name: "MinFitThreshold", Offset: 20, NameHash: 3350684067, Flags: 16509), LayoutImmutable]
		public string MinFitThreshold { get; set; } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 942751002:
						Platform = (MatchmakingPlatform) Enum.ToObject(typeof(MatchmakingPlatform), p_Value);
					break;

				case 649772672:
					Settings = (List<string>) p_Value;
					break;

				case 3876155997:
					DesiredPlayerCount = (uint) p_Value;
					break;

				case 891225311:
					MinPlayerCount = (uint) p_Value;
					break;

				case 4024578774:
					MaxPlayerCapacity = (uint) p_Value;
					break;

				case 3350684067:
					MinFitThreshold = (string) p_Value;
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
				case 942751002:
					return Platform;

				case 649772672:
					return Settings;

				case 3876155997:
					return DesiredPlayerCount;

				case 891225311:
					return MinPlayerCount;

				case 4024578774:
					return MaxPlayerCapacity;

				case 3350684067:
					return MinFitThreshold;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 942751002:
					return typeof(MatchmakingSizeConfiguration).GetProperty(nameof(Platform));

				case 649772672:
					return typeof(MatchmakingSizeConfiguration).GetProperty(nameof(Settings));

				case 3876155997:
					return typeof(MatchmakingSizeConfiguration).GetProperty(nameof(DesiredPlayerCount));

				case 891225311:
					return typeof(MatchmakingSizeConfiguration).GetProperty(nameof(MinPlayerCount));

				case 4024578774:
					return typeof(MatchmakingSizeConfiguration).GetProperty(nameof(MaxPlayerCapacity));

				case 3350684067:
					return typeof(MatchmakingSizeConfiguration).GetProperty(nameof(MinFitThreshold));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
