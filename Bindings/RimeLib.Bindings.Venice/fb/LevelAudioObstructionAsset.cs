///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Collections.Generic;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class LevelAudioObstructionAsset : 
		Asset
	{
		[ContainerField(12)]
		public List<AudioObstructionMaterialInfo> MaterialMap { get; set; } = new List<AudioObstructionMaterialInfo>(); // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float FrequencySlewRate { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float GainSlewRate { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public float MaxRaycastDistanceSquared { get; set; } // 0x18 (24)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2868170514:
					MaterialMap = (List<AudioObstructionMaterialInfo>) p_Value;
					break;

				case 1368142094:
					FrequencySlewRate = (float) p_Value;
					break;

				case 56498091:
					GainSlewRate = (float) p_Value;
					break;

				case 1365527576:
					MaxRaycastDistanceSquared = (float) p_Value;
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
				case 2868170514:
					return MaterialMap;

				case 1368142094:
					return FrequencySlewRate;

				case 56498091:
					return GainSlewRate;

				case 1365527576:
					return MaxRaycastDistanceSquared;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2868170514:
					return typeof(LevelAudioObstructionAsset).GetProperty(nameof(MaterialMap));

				case 1368142094:
					return typeof(LevelAudioObstructionAsset).GetProperty(nameof(FrequencySlewRate));

				case 56498091:
					return typeof(LevelAudioObstructionAsset).GetProperty(nameof(GainSlewRate));

				case 1365527576:
					return typeof(LevelAudioObstructionAsset).GetProperty(nameof(MaxRaycastDistanceSquared));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
