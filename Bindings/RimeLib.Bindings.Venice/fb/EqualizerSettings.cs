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
	public class EqualizerSettings : 
		DataContainer
	{
		protected float m_LowShelfFrequency = new float();
		[ContainerField(8), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1164930529)]
		public float LowShelfFrequency { get { return m_LowShelfFrequency; } set { if (OnPropertyChanging("EqualizerSettings." + nameof(LowShelfFrequency), this, m_LowShelfFrequency, value)) m_LowShelfFrequency = value; } } // 0x8 (8)
		
		protected float m_LowShelfGain = new float();
		[ContainerField(12), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(4093417540)]
		public float LowShelfGain { get { return m_LowShelfGain; } set { if (OnPropertyChanging("EqualizerSettings." + nameof(LowShelfGain), this, m_LowShelfGain, value)) m_LowShelfGain = value; } } // 0xC (12)
		
		protected float m_HighShelfFrequency = new float();
		[ContainerField(16), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3252423867)]
		public float HighShelfFrequency { get { return m_HighShelfFrequency; } set { if (OnPropertyChanging("EqualizerSettings." + nameof(HighShelfFrequency), this, m_HighShelfFrequency, value)) m_HighShelfFrequency = value; } } // 0x10 (16)
		
		protected float m_HighShelfGain = new float();
		[ContainerField(20), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(110952414)]
		public float HighShelfGain { get { return m_HighShelfGain; } set { if (OnPropertyChanging("EqualizerSettings." + nameof(HighShelfGain), this, m_HighShelfGain, value)) m_HighShelfGain = value; } } // 0x14 (20)
		
		protected float m_HpCutoffFrequency = new float();
		[ContainerField(24), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3299052820)]
		public float HpCutoffFrequency { get { return m_HpCutoffFrequency; } set { if (OnPropertyChanging("EqualizerSettings." + nameof(HpCutoffFrequency), this, m_HpCutoffFrequency, value)) m_HpCutoffFrequency = value; } } // 0x18 (24)
		
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
