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
	public class EqualizerSettings : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public float LowShelfFrequency { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public float LowShelfGain { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float HighShelfFrequency { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float HighShelfGain { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public float HpCutoffFrequency { get; set; } // 0x18 (24)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1164930529:
					LowShelfFrequency = (float) p_Value;
					break;

				case 4093417540:
					LowShelfGain = (float) p_Value;
					break;

				case 3252423867:
					HighShelfFrequency = (float) p_Value;
					break;

				case 110952414:
					HighShelfGain = (float) p_Value;
					break;

				case 3299052820:
					HpCutoffFrequency = (float) p_Value;
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
				case 1164930529:
					return LowShelfFrequency;

				case 4093417540:
					return LowShelfGain;

				case 3252423867:
					return HighShelfFrequency;

				case 110952414:
					return HighShelfGain;

				case 3299052820:
					return HpCutoffFrequency;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1164930529:
					return typeof(EqualizerSettings).GetProperty(nameof(LowShelfFrequency));

				case 4093417540:
					return typeof(EqualizerSettings).GetProperty(nameof(LowShelfGain));

				case 3252423867:
					return typeof(EqualizerSettings).GetProperty(nameof(HighShelfFrequency));

				case 110952414:
					return typeof(EqualizerSettings).GetProperty(nameof(HighShelfGain));

				case 3299052820:
					return typeof(EqualizerSettings).GetProperty(nameof(HpCutoffFrequency));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
