///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class MatchmakingSizeConfiguration : FrostbiteContainer
	{
		[ContainerField(0)]
		public MatchmakingPlatform Platform { get; set; } = new MatchmakingPlatform(); // 0x0 (0)
		
		[ContainerField(4)]
		public List<string> Settings { get; set; } = new List<string>(); // 0x4 (4)
		
		[ContainerField(8), LayoutImmutable, Blittable]
		public uint DesiredPlayerCount { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public uint MinPlayerCount { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public uint MaxPlayerCapacity { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable]
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
