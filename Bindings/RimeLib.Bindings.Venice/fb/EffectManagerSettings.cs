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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 24)]
	public class EffectManagerSettings : 
		SystemSettings
	{
		protected uint m_MaxNewEffectsPerFrameCount = new uint();
		[ContainerField(Name: "MaxNewEffectsPerFrameCount", Offset: 12, NameHash: 2561526576, Flags: 49421), LayoutImmutable, Blittable]
		public uint MaxNewEffectsPerFrameCount { get { return m_MaxNewEffectsPerFrameCount; } set { if (OnPropertyChanging("EffectManagerSettings." + nameof(MaxNewEffectsPerFrameCount), this, m_MaxNewEffectsPerFrameCount, value)) m_MaxNewEffectsPerFrameCount = value; } } // 0xC (12)
		
		protected uint m_SizeToGrowNewEffectsContainer = new uint();
		[ContainerField(Name: "SizeToGrowNewEffectsContainer", Offset: 16, NameHash: 146515561, Flags: 49421), LayoutImmutable, Blittable]
		public uint SizeToGrowNewEffectsContainer { get { return m_SizeToGrowNewEffectsContainer; } set { if (OnPropertyChanging("EffectManagerSettings." + nameof(SizeToGrowNewEffectsContainer), this, m_SizeToGrowNewEffectsContainer, value)) m_SizeToGrowNewEffectsContainer = value; } } // 0x10 (16)
		
		protected uint m_EffectQuality = new uint();
		[ContainerField(Name: "EffectQuality", Offset: 20, NameHash: 3929474783, Flags: 49421), LayoutImmutable, Blittable]
		public uint EffectQuality { get { return m_EffectQuality; } set { if (OnPropertyChanging("EffectManagerSettings." + nameof(EffectQuality), this, m_EffectQuality, value)) m_EffectQuality = value; } } // 0x14 (20)
		
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
