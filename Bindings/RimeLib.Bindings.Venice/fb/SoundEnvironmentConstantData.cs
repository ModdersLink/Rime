///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class SoundEnvironmentConstantData : 
		Asset
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public float HumanPlayerSoldierMovementVolumeOverride { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float MemoryTime { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float MinimumLoudness { get; set; } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2922581308:
					HumanPlayerSoldierMovementVolumeOverride = (float) p_Value;
					break;

				case 1308283505:
					MemoryTime = (float) p_Value;
					break;

				case 1173996714:
					MinimumLoudness = (float) p_Value;
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
				case 2922581308:
					return HumanPlayerSoldierMovementVolumeOverride;

				case 1308283505:
					return MemoryTime;

				case 1173996714:
					return MinimumLoudness;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2922581308:
					return typeof(SoundEnvironmentConstantData).GetProperty(nameof(HumanPlayerSoldierMovementVolumeOverride));

				case 1308283505:
					return typeof(SoundEnvironmentConstantData).GetProperty(nameof(MemoryTime));

				case 1173996714:
					return typeof(SoundEnvironmentConstantData).GetProperty(nameof(MinimumLoudness));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
