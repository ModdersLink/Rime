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
	public class EffectManagerSettings : 
		SystemSettings
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public uint MaxNewEffectsPerFrameCount { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public uint SizeToGrowNewEffectsContainer { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public uint EffectQuality { get; set; } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2561526576:
					MaxNewEffectsPerFrameCount = (uint) p_Value;
					break;

				case 146515561:
					SizeToGrowNewEffectsContainer = (uint) p_Value;
					break;

				case 3929474783:
					EffectQuality = (uint) p_Value;
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
				case 2561526576:
					return MaxNewEffectsPerFrameCount;

				case 146515561:
					return SizeToGrowNewEffectsContainer;

				case 3929474783:
					return EffectQuality;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2561526576:
					return typeof(EffectManagerSettings).GetProperty(nameof(MaxNewEffectsPerFrameCount));

				case 146515561:
					return typeof(EffectManagerSettings).GetProperty(nameof(SizeToGrowNewEffectsContainer));

				case 3929474783:
					return typeof(EffectManagerSettings).GetProperty(nameof(EffectQuality));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
