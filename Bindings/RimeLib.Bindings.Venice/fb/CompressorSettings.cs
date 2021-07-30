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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 24)]
	public class CompressorSettings : 
		DataContainer
	{
		protected float m_Ratio = new float();
		[ContainerField(Name: "Ratio", Offset: 8, NameHash: 230084836, Flags: 49469), LayoutImmutable, Blittable]
		public float Ratio { get { return m_Ratio; } set { if (OnPropertyChanging("CompressorSettings." + nameof(Ratio), this, m_Ratio, value)) m_Ratio = value; } } // 0x8 (8)
		
		protected float m_Threshold = new float();
		[ContainerField(Name: "Threshold", Offset: 12, NameHash: 3768602130, Flags: 49469), LayoutImmutable, Blittable]
		public float Threshold { get { return m_Threshold; } set { if (OnPropertyChanging("CompressorSettings." + nameof(Threshold), this, m_Threshold, value)) m_Threshold = value; } } // 0xC (12)
		
		protected float m_Attack = new float();
		[ContainerField(Name: "Attack", Offset: 16, NameHash: 2500885101, Flags: 49469), LayoutImmutable, Blittable]
		public float Attack { get { return m_Attack; } set { if (OnPropertyChanging("CompressorSettings." + nameof(Attack), this, m_Attack, value)) m_Attack = value; } } // 0x10 (16)
		
		protected float m_Release = new float();
		[ContainerField(Name: "Release", Offset: 20, NameHash: 1335266828, Flags: 49469), LayoutImmutable, Blittable]
		public float Release { get { return m_Release; } set { if (OnPropertyChanging("CompressorSettings." + nameof(Release), this, m_Release, value)) m_Release = value; } } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 230084836:
					Ratio = (float) p_Value;
					break;

				case 3768602130:
					Threshold = (float) p_Value;
					break;

				case 2500885101:
					Attack = (float) p_Value;
					break;

				case 1335266828:
					Release = (float) p_Value;
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
				case 230084836:
					return Ratio;

				case 3768602130:
					return Threshold;

				case 2500885101:
					return Attack;

				case 1335266828:
					return Release;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 230084836:
					return typeof(CompressorSettings).GetProperty(nameof(Ratio));

				case 3768602130:
					return typeof(CompressorSettings).GetProperty(nameof(Threshold));

				case 2500885101:
					return typeof(CompressorSettings).GetProperty(nameof(Attack));

				case 1335266828:
					return typeof(CompressorSettings).GetProperty(nameof(Release));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
