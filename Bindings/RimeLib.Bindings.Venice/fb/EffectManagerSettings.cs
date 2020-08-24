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
	[ContainerType(4), MemberInfoFlag(53), ContainerClass]
	public class EffectManagerSettings : 
		SystemSettings
	{
		protected uint m_MaxNewEffectsPerFrameCount = new uint();
		[ContainerField(12), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(2561526576)]
		public uint MaxNewEffectsPerFrameCount { get { return m_MaxNewEffectsPerFrameCount; } set { if (OnPropertyChanging("EffectManagerSettings." + nameof(MaxNewEffectsPerFrameCount), this, m_MaxNewEffectsPerFrameCount, value)) m_MaxNewEffectsPerFrameCount = value; } } // 0xC (12)
		
		protected uint m_SizeToGrowNewEffectsContainer = new uint();
		[ContainerField(16), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(146515561)]
		public uint SizeToGrowNewEffectsContainer { get { return m_SizeToGrowNewEffectsContainer; } set { if (OnPropertyChanging("EffectManagerSettings." + nameof(SizeToGrowNewEffectsContainer), this, m_SizeToGrowNewEffectsContainer, value)) m_SizeToGrowNewEffectsContainer = value; } } // 0x10 (16)
		
		protected uint m_EffectQuality = new uint();
		[ContainerField(20), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(3929474783)]
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
