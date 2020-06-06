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
	public class BigWorldSetting : 
		DataContainer
	{
		[ContainerField(8)]
		public CtrRef<SoundAsset> Sound { get; set; } = new CtrRef<SoundAsset>(); // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public int MinDistance { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public int MaxDistance { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float MinDelayTimeInMinutes { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public float MaxDelayTimeInMinutes { get; set; } // 0x18 (24)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 231353798:
					Sound = (CtrRef<SoundAsset>) p_Value;
					break;

				case 1885855628:
					MinDistance = (int) p_Value;
					break;

				case 3520454034:
					MaxDistance = (int) p_Value;
					break;

				case 381594133:
					MinDelayTimeInMinutes = (float) p_Value;
					break;

				case 741272203:
					MaxDelayTimeInMinutes = (float) p_Value;
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
				case 231353798:
					return Sound;

				case 1885855628:
					return MinDistance;

				case 3520454034:
					return MaxDistance;

				case 381594133:
					return MinDelayTimeInMinutes;

				case 741272203:
					return MaxDelayTimeInMinutes;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 231353798:
					return typeof(BigWorldSetting).GetProperty(nameof(Sound));

				case 1885855628:
					return typeof(BigWorldSetting).GetProperty(nameof(MinDistance));

				case 3520454034:
					return typeof(BigWorldSetting).GetProperty(nameof(MaxDistance));

				case 381594133:
					return typeof(BigWorldSetting).GetProperty(nameof(MinDelayTimeInMinutes));

				case 741272203:
					return typeof(BigWorldSetting).GetProperty(nameof(MaxDelayTimeInMinutes));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
